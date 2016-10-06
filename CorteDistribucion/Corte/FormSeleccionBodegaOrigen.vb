Public Class FormSeleccionBodegaOrigen
    Public BodegaOrigenId As Integer
    Private _bodegas = New List(Of KeyValueObject(Of Integer, String))

    Public Property Bodegas As List(Of KeyValueObject(Of Integer, String))
        Get
            Return _bodegas
        End Get
        Set(value As List(Of KeyValueObject(Of Integer, String)))
            Me._bodegas = value
        End Set
    End Property
    Private Sub FormBodegaOrigenRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BodegaOrigenId = Nothing
        FillComboBoxWithList(ComboBox1, Me.Bodegas, "Value")
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        aceptar()
    End Sub
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        cancelar()
    End Sub

    Sub aceptar()
        Dim item = DirectCast(ComboBox1.SelectedItem, KeyValueObject(Of Integer, String))
        If item IsNot Nothing Then
            Me.BodegaOrigenId = item.Key
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.None
        End If
    End Sub

    Sub cancelar()
        Me.BodegaOrigenId = Nothing
        Me.Close()
    End Sub
End Class