Imports System.Data.SqlClient
Module Time
    Public Function DiaPredeterminado() As Date
        Dim dia As Date = DateTime.Today

        If (DateTime.Now.Hour >= 12) Then
            dia = dia.AddDays(1)
        End If

        If (dia.DayOfWeek = DayOfWeek.Sunday) Then
            dia = dia.AddDays(1)
        End If

        Return dia
    End Function

    Public Sub SetDateTimePickerDateTimeValue(DTP As DateTimePicker, reader As SqlDataReader, col As String)
        If (IsDBNull(reader(col))) Then
            DTP.Tag = DTP.CustomFormat
            DTP.Format = Windows.Forms.DateTimePickerFormat.Custom
            DTP.CustomFormat = " "
            DTP.Value = DateTime.Today().AddDays(1)
        Else
            RestoreCustomFormat(DTP)
            Dim dt As DateTime = reader(col)
            DTP.Value = dt
        End If
    End Sub
    Public Sub SetDateTimePickerDateValue(DTP As DateTimePicker, reader As SqlDataReader, col As String)
        If (IsDBNull(reader(col))) Then
            DTP.Tag = DTP.CustomFormat
            DTP.Format = Windows.Forms.DateTimePickerFormat.Custom
            DTP.CustomFormat = " "
            DTP.Value = DateTime.Today().AddDays(1).Date
        Else
            RestoreCustomFormat(DTP)
            Dim dt As DateTime = reader(col)
            DTP.Value = dt.Date
        End If
    End Sub
    Public Sub SetDateTimePickerTimeValue(DTP As DateTimePicker, reader As SqlDataReader, col As String)
        If (IsDBNull(reader(col))) Then
            DTP.Value = DateTime.Today().AddDays(1)
        Else
            RestoreCustomFormat(DTP)
            Dim dt As DateTime = reader(col)
            DTP.Value = dt
        End If
    End Sub

    Public Sub SetDateTimePickerDateTimeValue(DTP As DateTimePicker, dt As Date?)
        If (dt Is Nothing) Then
            DTP.Tag = DTP.CustomFormat
            DTP.Format = Windows.Forms.DateTimePickerFormat.Custom
            DTP.CustomFormat = " "
            DTP.Value = DateTime.Today().AddDays(1)
        Else
            RestoreCustomFormat(DTP)
            DTP.Value = dt.Value
        End If
    End Sub

    Public Sub RestoreCustomFormat(DTP As DateTimePicker)
        If (DTP.CustomFormat = " ") Then
            If (DTP.Tag <> "") Then
                DTP.Format = Windows.Forms.DateTimePickerFormat.Custom
                DTP.CustomFormat = DTP.Tag
            End If
        End If
    End Sub

    Public Function GetDateFomDateTimePicker(DTP As DateTimePicker) As Date?
        If (DTP.CustomFormat = " ") Then
            Return Nothing
        Else
            Return DTP.Value
        End If
    End Function
    Public Function GetTimeSpanFomDateTimePicker(DTP As DateTimePicker) As TimeSpan?
        With DTP.Value
            If (.Hour = 0 And .Minute = 0 And .Second = 0) Then
                Return Nothing
            End If
            Return .TimeOfDay()
        End With
    End Function

End Module
