Module FileSystem
    Public Function GetValidFileName(fileName As String) As String
        Return String.Join("-", fileName.Split(IO.Path.GetInvalidFileNameChars))
    End Function

End Module
