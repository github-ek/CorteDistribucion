Public Class DocumentoOrdenClienteComparer
    Implements IEqualityComparer(Of DocumentoOrdenIncluida)

    Public Overloads Function Equals(x As DocumentoOrdenIncluida, y As DocumentoOrdenIncluida) As Boolean Implements IEqualityComparer(Of DocumentoOrdenIncluida).Equals
        Return (Integer.Equals(x.ClienteId, y.ClienteId) And String.Equals(x.NumeroDocumento, y.NumeroDocumento))
    End Function

    Public Overloads Function GetHashCode(obj As DocumentoOrdenIncluida) As Integer Implements IEqualityComparer(Of DocumentoOrdenIncluida).GetHashCode
        If obj Is Nothing Then Return 0

        ' Get hash code for the Code field.
        Dim hashClienteId = obj.ClienteId.GetHashCode()

        ' Get hash code for the Name field if it is not null.
        Dim hashNumeroDocumento =
            If(obj.NumeroDocumento Is Nothing, 0, obj.NumeroDocumento.GetHashCode())

        ' Calculate the hash code for the product.
        Return hashClienteId Xor hashNumeroDocumento ' 
    End Function
End Class
