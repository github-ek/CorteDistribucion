Imports System.Data.SqlClient

Public Class FormCreacionNovedad
    Private Loading As Boolean = False


#Region "Propiedades"
    Public Property LineaOrdenId As Integer

    Public Property CausalesDeNovedades As List(Of CausalDeNovedadDeDistribucion)
    Public Property TiposDeNovedad As List(Of TipoDeNovedadDeDistribucion)
    Public Property Responsables As List(Of KeyValueObject(Of Integer, String))
    Public Property ResponsablesInternos As List(Of KeyValueObject(Of Integer?, String))

#End Region

    Private Property CantidadPlanificada As Integer
    Private Property CantidadOtrasNovedades As Integer

    Private Sub FormEdicionNovedad_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Loading = True
            Me.Cursor = Cursors.WaitCursor

            CargarLineaOrden()
            InitNovedad()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        Finally
            Me.Cursor = Cursors.Default
            Loading = False
        End Try

    End Sub

    Private Sub CargarLineaOrden()
        Try
            Dim sql = "tms.ListarLineaOrdenPorIdParaCierreDeOrden"

            Using connection As New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using cmd As New SqlCommand(sql, connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@lineaOrdenId", Me.LineaOrdenId)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While (reader.Read())
                            TextBoxNumeroItem.Text = reader("numero_item")
                            TextBoxProductoCodigo.Text = reader("codigo_producto")
                            TextBoxDescripcion.Text = reader("descripcion")

                            TextBoxCantidadSolicitada.Text = reader("cantidad_solicitada")
                            TextBoxCantidadPlanificada.Text = reader("cantidad_planificada")
                            TextBoxCantidadOtrasNovedades.Text = reader("cantidad_novedades")

                            CantidadPlanificada = reader("cantidad_planificada")
                            CantidadOtrasNovedades = reader("cantidad_novedades")
                            NUDCantidad.Maximum = (CantidadPlanificada - CantidadOtrasNovedades)
                            TextBoxSaldo.Text = (NUDCantidad.Maximum)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub InitNovedad()
        Reset()

        ComboBoxTipoNovedad.Enabled = False
        ComboBoxCausalNovedadResponsableInterno.Enabled = False

        FillComboBoxWithList(ComboBoxCausalNovedad, CausalesDeNovedades, "Nombre")
        FillComboBoxWithList(ComboBoxTipoNovedad, TiposDeNovedad, "Nombre")
        FillComboBoxWithList(ComboBoxCausalNovedadResponsable, Responsables, "Value")
        FillComboBoxWithList(ComboBoxCausalNovedadResponsableInterno, ResponsablesInternos, "Value")

    End Sub

    Private Sub Reset()
        TextBoxCausalNoEntregaDescripcion.Text = ""
        TextBoxIndicadorOTIF.Text = ""

        ComboBoxCausalNovedad.SelectedIndex = -1
        ComboBoxTipoNovedad.SelectedIndex = -1
        ComboBoxTipoNovedad.Enabled = False
        ComboBoxCausalNovedadResponsable.SelectedIndex = -1
        ComboBoxCausalNovedadResponsableInterno.Enabled = False
        ComboBoxCausalNovedadResponsableInterno.SelectedIndex = -1
        TextBoxCausalNovedadNotas.Text = ""
        TextBoxCausalNoEntregaUsuarioActualizacion.Text = ""
        SetDateTimePickerDateTimeValue(DTPCausalNoEntregaFechaActualizacion, Nothing)
    End Sub

    Private Sub ComboBoxCausalNovedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCausalNovedad.SelectedIndexChanged
        Dim Causal As CausalDeNovedadDeDistribucion
        Dim control = DirectCast(sender, ComboBox)
        Causal = DirectCast(control.SelectedItem, CausalDeNovedadDeDistribucion)

        If (Causal IsNot Nothing) Then
            TextBoxCausalNoEntregaDescripcion.Text = Causal.Descripcion
            TextBoxIndicadorOTIF.Text = Causal.IndicadorOtifId

            With ComboBoxTipoNovedad
                If (Not Causal.TipoNovedadDeDistribucionId Is Nothing) Then
                    Dim tn = TiposDeNovedad.FirstOrDefault(Function(a) a.Id.Equals(Causal.TipoNovedadDeDistribucionId))
                    .SelectedIndex = .Items.IndexOf(tn)
                Else
                    .SelectedIndex = -1
                End If
            End With

            With ComboBoxCausalNovedadResponsable
                If (Not Causal.ResponsableId Is Nothing) Then
                    Dim r = Responsables.FirstOrDefault(Function(a) a.Key.Equals(Causal.ResponsableId))
                    .SelectedIndex = .Items.IndexOf(r)
                Else
                    .SelectedIndex = -1
                End If
            End With

            With ComboBoxCausalNovedadResponsableInterno
                If (ComboBoxCausalNovedadResponsable.Text = "TACTIC") Then
                    .Enabled = True
                Else
                    .Enabled = False
                End If

                If (Not Causal.ResponsableInternoId Is Nothing) Then
                    Dim ri = ResponsablesInternos.FirstOrDefault(Function(a) a.Key.Equals(Causal.ResponsableInternoId))
                    .SelectedValue = Causal.ResponsableInternoId
                    .SelectedIndex = .Items.IndexOf(ri)
                Else
                    .SelectedIndex = -1
                End If
            End With
        Else
            Reset()
        End If
    End Sub

    Private Sub ComboBoxCausalNovedadResponsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCausalNovedadResponsable.SelectedIndexChanged
        With ComboBoxCausalNovedadResponsableInterno
            If (ComboBoxCausalNovedadResponsable.Text = "TACTIC") Then
                .Enabled = True
            Else
                .Enabled = False
            End If

            .SelectedIndex = -1
        End With
    End Sub

    Private Sub NUDCantidad_ValueChanged(sender As Object, e As EventArgs) Handles NUDCantidad.ValueChanged
        TextBoxSaldo.Text = (CantidadPlanificada - CantidadOtrasNovedades - Int(NUDCantidad.Value))
    End Sub
End Class