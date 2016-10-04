Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormRuta
    Private Loading As Boolean = False
    Private FiltroVariable As String = ""

    Public Property RutaId As Integer

    Private Sub FormRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Loading = True
            Me.RutaId = 645
            Me.Cursor = Cursors.WaitCursor

            FillRuta()
            FillOrdenesRuta()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        Finally
            Me.Cursor = Cursors.Default
            Loading = False
        End Try
    End Sub

    Public Sub FillRuta()
        Try
            Dim sql = "tms.ListarRutaPorId"

            Using connection As New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using cmd As New SqlCommand(sql, connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@rutaId", Me.RutaId)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While (reader.Read())
                            Dim fecha As Date?
                            Dim hora As TimeSpan?

                            TextBoxRutaId.Text = reader("id_ruta").ToString()
                            TextBoxNumeroRuta.Text = reader("numero_ruta")
                            TextBoxEstadoRuta.Text = reader("id_estado_ruta")
                            TextBoxMovil.Text = reader("movil").ToString().ToUpper()
                            TextBoxPlaca.Text = reader("placa").ToString().ToUpper()

                            TextBoxConductorIdentificacion.Text = reader("conductor_numero_identificacion").ToString().ToUpper()
                            TextBoxConductorNombres.Text = reader("conductor_apellidos").ToString().ToUpper() + "," + reader("conductor_nombres").ToString().ToUpper()

                            TextBoxEstadoSincronizacion.Text = reader("id_estado_sincronizacion_ruta")
                            fecha = reader("fecha_sincronizacion")
                            TextBoxFechaSincronizacion.Text = IIf(fecha Is Nothing, "", String.Format("{0:dd/MM/yyyy}", fecha))
                            TextBoxIntentosSincronizacion.Text = reader("intentos_sincronizacion").ToString()
                            TextBoxErrorSincronizacion.Text = reader("error_sincronizacion")

                            fecha = reader("fecha_cita_cargue")
                            TextBoxFechaCitaCargue.Text = IIf(fecha Is Nothing, "", String.Format("{0:dd/MM/yyyy}", fecha))
                            hora = reader("hora_cita_cargue")
                            TextBoxHoraCitaCargue.Text = IIf(hora Is Nothing, "", String.Format("{0}", Date.Today().Add(hora).ToString("hh:mm tt", CultureInfo.InvariantCulture)))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub FillOrdenesRuta()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim sql = "tms.ListarOrdenesRutaPorId"

            Using connnection As New SqlConnection(My.Settings.SateliteConnectionString)
                connnection.Open()
                Using cmd As New SqlCommand(sql, connnection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@rutaId", Me.RutaId)


                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    DGV.Fill(dgvOrdenes, ds.Tables(0), "", "", bnOrdenes)
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub ImprimirPlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirPlanillaToolStripMenuItem.Click

    End Sub
End Class