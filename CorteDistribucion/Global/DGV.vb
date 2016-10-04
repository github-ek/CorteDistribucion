Imports System.Text

Module DGV
    Friend Sub Fill(dgv As DataGridView, table As DataTable, filter As String, sort As String, Optional bindingNavigator As BindingNavigator = Nothing)
        Dim bindingSource As New BindingSource()
        Dim dataView = New DataView(table, filter, sort, DataViewRowState.CurrentRows)
        bindingSource.DataSource = dataView.ToTable()

        If (Not bindingNavigator Is Nothing) Then
            bindingNavigator.BindingSource = bindingSource
        End If

        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            .ReadOnly = True
            .DataSource = bindingSource

            For i = 0 To .Columns.Count - 1
                .Columns(i).HeaderText = UppercaseFirstLetter(.Columns(i).HeaderText.Replace("_", " ").Replace("codigo", "").Replace("nombre", ""))
            Next
        End With
    End Sub

    Friend Sub CopyDefinition(source As DataGridView, dest As DataGridView, Optional bindingNavigator As BindingNavigator = Nothing)
        Dim table As DataTable = DirectCast(DirectCast(source.DataSource, BindingSource).DataSource, DataTable).Clone()
        Fill(dest, table, "", "", bindingNavigator)
    End Sub
    Friend Sub Filtrar(dataGV As DataGridView, filtroFijo As String, ByRef filtroVariable As String, criterio As String)
        With dataGV
            If (Not .DataSource Is Nothing) Then
                Dim bindingSource As BindingSource = .DataSource
                Dim table As DataTable = bindingSource.DataSource
                DGV.Filtrar(table, filtroFijo, filtroVariable, criterio)
            End If
        End With
    End Sub

    Friend Sub Filtrar(table As DataTable, filtroFijo As String, ByRef filtroVariable As String, criterio As String)
        Dim sb As New StringBuilder()
        If (filtroFijo <> "") Then
            sb.Append("(").Append(filtroFijo).Append(")")
        End If

        criterio = EscapeLikeValue(criterio)
        If (filtroVariable = "") Then
            filtroVariable = GetFiltroVariable(table)
        End If
        If (criterio <> "") Then
            If (sb.Length > 0) Then
                sb.Append(" AND ")
            End If
            sb.Append("(").Append(String.Format(filtroVariable, criterio)).Append(")")
        End If

        Dim filtro As String = sb.ToString()
        If (table.DefaultView.RowFilter <> filtro) Then
            table.DefaultView.RowFilter = filtro
        End If
    End Sub

    Private Function GetFiltroVariable(table As DataTable) As String
        Dim sb As New StringBuilder()
        For Each e As DataColumn In table.Columns()
            Select Case e.DataType
                Case GetType(Integer)
                    sb.Append("CONVERT(").Append(e.ColumnName).Append(", 'System.String')")
                Case GetType(Long)
                    sb.Append("CONVERT(").Append(e.ColumnName).Append(", 'System.String')")
                Case GetType(String)
                    sb.Append(e.ColumnName)
                Case GetType(DateTime)
                    sb.Append("SUBSTRING(")
                    sb.Append("CONVERT(").Append(e.ColumnName).Append(", 'System.String')")
                    sb.Append(",1,10)")
                Case Else
                    Continue For
            End Select

            sb.Append(" LIKE '{0}' OR ")
        Next

        sb.Append(" 0 = 1 ")

        Return sb.ToString()
    End Function

    Private Function EscapeLikeValue(valueWithoutWildcards As String) As String
        Dim sb As New StringBuilder()
        For i As Integer = 0 To valueWithoutWildcards.Length - 1
            Dim c As Char = valueWithoutWildcards(i)
            If (c = "[" Or c = "]") Then
                sb.Append("[").Append(c).Append("]")
            ElseIf (c = "\'") Then
                sb.Append("''")
            Else
                sb.Append(c)
            End If
        Next i

        Return sb.ToString()
    End Function

End Module
