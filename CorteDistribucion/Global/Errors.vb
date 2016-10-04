Imports System.Text

Module Errors
    Public Sub AddError(errores As Dictionary(Of Control, List(Of String)), c As Control, err As String)
        If Not String.IsNullOrEmpty(err) Then
            Dim list As New List(Of String)
            If Not errores.TryGetValue(c, list) Then
                list = New List(Of String)
                errores.Add(c, list)
            End If
            list.Add(err)
        End If
    End Sub

    Public Function SetErrors(ep As ErrorProvider, errores As Dictionary(Of Control, List(Of String))) As String
        Dim sb As New StringBuilder

        ep.Clear()
        ep.BlinkRate = 0
        ep.BlinkStyle = ErrorBlinkStyle.NeverBlink

        Dim pair As KeyValuePair(Of Control, List(Of String))

        For Each pair In errores
            Dim err = String.Join(vbLf, pair.Value)
            sb.Append(err).Append(vbLf)

            ep.SetError(pair.Key, err)
        Next

        Return sb.ToString()
    End Function

End Module
