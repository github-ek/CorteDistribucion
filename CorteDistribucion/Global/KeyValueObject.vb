Public Class KeyValueObject(Of TKey, TValue)
    Implements IEquatable(Of Object)

    Public Property Key As TKey

    Public Property Value As TValue

    Private Function IEquatable_Equals(other As Object) As Boolean Implements IEquatable(Of Object).Equals
        If other Is Nothing Or Not Me.GetType() Is other.GetType() Then
            Return False
        End If

        Dim b As KeyValueObject(Of TKey, TValue) = DirectCast(other, KeyValueObject(Of TKey, TValue))
        Return Me.Key.Equals(b.Key)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashXObjectCode = If(Me.Key Is Nothing, 0, Me.Key.GetHashCode())
        Dim hashXObjectName = If(Me.Value Is Nothing, 0, Me.Value.GetHashCode())
        Return hashXObjectName Xor hashXObjectCode
    End Function

End Class
