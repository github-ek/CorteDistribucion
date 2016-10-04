Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormCita
    Public data As DataGridView
    Private _horas As List(Of TimeSpan) = New List(Of TimeSpan)

    Private Loading As Boolean = False
    Private FiltroVariable As String = ""

#Region "Propiedades"
    Public ReadOnly Property Usuario() As String
        Get
            Return Environment.UserName
        End Get
    End Property

    Public ReadOnly Property Horas As List(Of TimeSpan)
        Get
            Return _horas
        End Get
    End Property
    Public ReadOnly Property FechaCitaEntrega As Date
        Get
            Return mcFechaCita.SelectionStart
        End Get
    End Property

    Public ReadOnly Property HoMi As TimeSpan
        Get
            Dim t = HoMa.Subtract(New TimeSpan(nudVentanaHoraria.Value, 0, 0))
            If (t.CompareTo(HoMa) > 0) Then
                Return New TimeSpan(0, 0, 0)
            End If
            Return t
        End Get
    End Property
    Public ReadOnly Property HoMa As TimeSpan
        Get
            Return cbxHoraMax.SelectedValue
        End Get
    End Property

#End Region

#Region "Metodos Load/Unload Formulario"
    Private Sub FormAsignarCita_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Loading = True
            mcFechaCita.MinDate = Date.Today

            cbxAMPM.Text = My.Settings.CitaAMPM

            Me._horas = Listas.GetHoras()
            FillHoras(cbxHoraMax, Me.Horas, cbxAMPM.Text)

            AgregarASeleccion(Me.data, dgvSeleccionadas)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        Finally
            Loading = False
            ActualizarResumen()
        End Try
    End Sub
#End Region

#Region "Metodos Seleccion"
    Private Sub AgregarASeleccion(source As DataGridView, dest As DataGridView)
        Me.Cursor = Cursors.WaitCursor
        Dim bindingSource As BindingSource = source.DataSource
        Dim table As DataTable = bindingSource.DataSource

        dest.DataSource = Nothing
        DGV.Fill(dest, table, "", "", bnSeleccionadas)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RemoverDeSeleccion(source As DataGridView)
        If (source.SelectedRows.Count = 0) Then
            MsgBox("No hay registros seleccionados ")
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim list = source.SelectedRows.Cast(Of DataGridViewRow).Select(Function(row) row.Cells("id_orden").Value).ToList()

        Dim bindingSource As BindingSource = source.DataSource
        Dim table As DataTable = bindingSource.DataSource

        source.DataSource = Nothing
        For Each id In list
            Dim row = table.Rows.Cast(Of DataRow).Where(Function(r) r("id_orden").Equals(id)).First()

            table.Rows.Remove(row)
        Next

        Fill(source, table, "", "", bnSeleccionadas)
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "Seccion Comandos"
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs)
        AsignarCita()
    End Sub

    Private Sub AsignarCita()
        Me.Cursor = Cursors.WaitCursor
        Try
            Using connection = New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using transaction = connection.BeginTransaction()
                    Dim sql As String = "tms.AsignarCitaEntrega"
                    Using cmd = New SqlCommand(sql, connection, transaction)
                        cmd.CommandType = CommandType.StoredProcedure

                        For Each row As DataGridViewRow In dgvSeleccionadas.Rows
                            DB.SQL_tms_AsignarCitaEntrega(row.Cells("id_orden").Value, Me.FechaCitaEntrega, Me.HoMi, Me.HoMa, Me.Usuario, cmd)
                        Next
                    End Using
                    transaction.Commit()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            Me.Close()
        End Try
    End Sub

    Private Sub ToolStripButtonSeleccionarTodosSeleccionados_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSeleccionarTodosSeleccionados.Click
        dgvSeleccionadas.SelectAll()
    End Sub

    Private Sub ToolStripButtonInvertirSeleccionSeleccionados_Click(sender As Object, e As EventArgs) Handles ToolStripButtonInvertirSeleccionSeleccionados.Click
        For Each row As DataGridViewRow In dgvSeleccionadas.Rows
            If row.Selected Then
                row.Selected = False
            Else
                row.Selected = True
            End If
        Next
    End Sub

    Private Sub ToolStripButtonRemoverSeleccion_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRemoverSeleccion.Click
        RemoverDeSeleccion(dgvSeleccionadas)
    End Sub

    Private Sub ToolStripTextBoxFiltroSeleccionadas_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBoxFiltroSeleccionadas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            DGV.Filtrar(dgvSeleccionadas, "", Me.FiltroVariable, ToolStripTextBoxFiltroSeleccionadas.Text)
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "Seccion Selección de Cita"
    Private Sub mcFechaCita_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mcFechaCita.DateChanged
        If (Loading) Then
            Exit Sub
        End If

        ActualizarResumen()
    End Sub
    Private Sub cbxAMPM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAMPM.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        Listas.FillHoras(cbxHoraMax, Me.Horas, cbxAMPM.Text)
        My.Settings.CitaAMPM = cbxAMPM.Text

        ActualizarResumen()
    End Sub

    Private Sub cbxHoraMax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxHoraMax.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        ActualizarResumen()
    End Sub

    Private Sub nudVentanaHoraria_ValueChanged(sender As Object, e As EventArgs) Handles nudVentanaHoraria.ValueChanged
        If (Loading) Then
            Exit Sub
        End If

        ActualizarResumen()
    End Sub

    Private Sub ActualizarResumen()
        If (Loading) Then
            Exit Sub
        End If
        lblResumen.Text = String.Format("Cita programada para el día {0:dddd dd/MM/yyyy}, desde las {1} hasta las {2}", FechaCitaEntrega, FechaCitaEntrega.Add(HoMi).ToString("hh:mm tt", CultureInfo.InvariantCulture), FechaCitaEntrega.Add(HoMa).ToString("hh:mm tt", CultureInfo.InvariantCulture))
    End Sub


#End Region
End Class