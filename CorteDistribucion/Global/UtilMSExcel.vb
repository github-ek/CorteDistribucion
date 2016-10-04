Module UtilMSExcel
    Public Function ExportDGVToExcel(DGV As DataGridView, wSheet As Microsoft.Office.Interop.Excel.Worksheet, nombre As String) As Boolean
        Dim counter As Integer = 0

        wSheet.Name = nombre

        If ((DGV.Columns.Count = 0) Or (DGV.Rows.Count = 0)) Then
            Return False
        End If

        Dim ds As DataSet = ExportDGVToDataSet(DGV)

        Dim dt As System.Data.DataTable = ds.Tables(0)
        Dim arr(dt.Rows.Count + 1, dt.Columns.Count) As Object

        Dim colIndex As Integer = 0
        For Each dc In dt.Columns
            arr(0, colIndex) = UppercaseFirstLetter(dc.ColumnName.Replace("_", " "))
            colIndex = colIndex + 1
        Next

        For r As Integer = 0 To dt.Rows.Count() - 1
            Dim dr As DataRow = dt.Rows(r)
            For c As Integer = 0 To dt.Columns.Count - 1
                arr(r + 1, c) = dr(c)
            Next
        Next r

        Dim topRow As Integer = 1
        Dim c1 As Microsoft.Office.Interop.Excel.Range = CType(wSheet.Cells(1, 1), Microsoft.Office.Interop.Excel.Range)
        Dim c2 As Microsoft.Office.Interop.Excel.Range = CType(wSheet.Cells(1 + dt.Rows.Count, dt.Columns.Count), Microsoft.Office.Interop.Excel.Range)
        Dim range As Microsoft.Office.Interop.Excel.Range = wSheet.Range(c1, c2)

        range.Value = arr

        Dim Table As Microsoft.Office.Interop.Excel.ListObject =
        wSheet.ListObjects.AddEx(Microsoft.Office.Interop.Excel.XlListObjectSourceType.xlSrcRange, range, Nothing, Microsoft.Office.Interop.Excel.XlYesNoGuess.xlYes)
        Table.Name = "Tabla_" + nombre
        Table.TableStyle = "TableStyleLight8"
        wSheet.Columns.AutoFit()

        With range
            .Font.Size = 10
        End With

        Dim Header As Microsoft.Office.Interop.Excel.Range = wSheet.Cells(1, 1).EntireRow
        With Header
            .Font.Bold = True
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter
        End With
        Return True
    End Function
    Public Function ExportDGVToDataSet(DGV As DataGridView) As DataSet
        Dim ds As New DataSet

        ds.Tables.Add()
        For i As Integer = 0 To DGV.ColumnCount - 1
            Dim col As String = DGV.Columns(i).HeaderText

            If (ds.Tables(0).Columns.Contains(col)) Then
                col &= CStr(i)
            End If
            ds.Tables(0).Columns.Add(col)
        Next

        Dim row As DataRow

        For i As Integer = 0 To DGV.RowCount - 1
            row = ds.Tables(0).NewRow
            For j As Integer = 0 To DGV.Columns.Count - 1
                row(j) = DGV.Rows(i).Cells(j).Value
            Next
            ds.Tables(0).Rows.Add(row)
        Next

        Return ds
    End Function

    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        val = val.Trim()
        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

    Public Sub ExportToExcel(dataGridView As DataGridView, workSheetName As String)
        ' Creating a Excel object.
        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing

        Try
            worksheet = workbook.ActiveSheet

            worksheet.Name = workSheetName

            Dim cellRowIndex As Integer = 1
            Dim cellColumnIndex As Integer = 1
            Try
                'Loop through each row and read value from each column.
                For i As Integer = 0 To dataGridView.Rows.Count - 2
                    For j As Integer = 0 To dataGridView.Columns.Count - 1
                        ' Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        If cellRowIndex = 1 Then
                            worksheet.Cells(cellRowIndex, cellColumnIndex) = dataGridView.Columns(j).HeaderText
                        Else
                            worksheet.Cells(cellRowIndex, cellColumnIndex) = dataGridView.Rows(i).Cells(j).Value.ToString()
                        End If
                        cellColumnIndex += 1
                    Next
                    cellColumnIndex = 1
                    cellRowIndex += 1
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            excel.Visible = True
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        Finally
            'excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try
    End Sub

End Module
