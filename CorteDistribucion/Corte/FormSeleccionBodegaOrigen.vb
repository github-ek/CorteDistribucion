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

        ComboBox1.DataSource = Me.Bodegas
        ComboBox1.DisplayMember = "Name"
        ComboBox1.ValueMember = "Code"
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        aceptar()
    End Sub
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        cancelar()
    End Sub

    Sub aceptar()
        Me.BodegaOrigenId = CInt(ComboBox1.SelectedValue)
        Me.Close()
    End Sub

    Sub cancelar()
        Me.BodegaOrigenId = Nothing
        Me.Close()
    End Sub
End Class