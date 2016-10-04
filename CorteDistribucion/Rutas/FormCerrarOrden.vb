Imports System.Data.SqlClient
Imports CorteDistribucion

Public Class FormCerrarOrden
    Private Const EJECUCION As String = "EJECUCION"
    Private Const ENTREGADA As String = "ENTREGADA"
    Private Const NO_ENTREGADA As String = "NO_ENTREGADA"
    Private Const NOVEDADES As String = "NOVEDADES"
    Private Const REPROGRAMADA As String = "REPROGRAMADA"
    Private Const NO_REPROGRAMADA As String = "NO_REPROGRAMADA"

    Private EstadosOrden As List(Of KeyValueObject(Of String, String))
    Private CausalesDeNoEntrega As List(Of CausalDeNovedadDeDistribucion)
    Private CausalesDeNovedades As List(Of CausalDeNovedadDeDistribucion)
    Private TiposDeNovedad As List(Of TipoDeNovedadDeDistribucion)
    Private Responsables As List(Of KeyValueObject(Of Integer, String))
    Private ResponsablesInternos As List(Of KeyValueObject(Of Integer?, String))

    Private Loading As Boolean = False
    Private FiltroVariableLineas As String = ""
    Private FiltroVariableNovedades As String = ""

    Private NovedadDeNoEntregaId As Integer? = Nothing
    Private CausalDeReprogramacion As Integer? = Nothing

    Private hiddenPages As New List(Of TabPage)

#Region "Propiedades"

    Public Property OrdenId As Integer
    Private Property ActualEstadoOrden As String
    Private Property EstadoOrden As String
    Private Property EstadoOrdenIndex As Integer

    Public ReadOnly Property Usuario() As String
        Get
            Return Environment.UserName
        End Get
    End Property
#End Region

#Region "Eventos Formulario"
    Private Sub FormReportarResultadoEntregaDeOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Loading = True
            Me.Cursor = Cursors.WaitCursor

            CargarListas()
            CargarOrden()
            InicializarPorEstadoOrden()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        Finally
            Me.Cursor = Cursors.Default
            Loading = False
        End Try
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        For Each t In hiddenPages
            t.Dispose()
        Next

        MyBase.OnFormClosed(e)
    End Sub

#End Region

#Region "Eventos Cambio de Estado"
    Private Sub ComboBoxEstadoOrdenNuevo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstadoOrdenNuevo.SelectedIndexChanged
        If Not Loading Then
            Try
                Dim control = DirectCast(sender, ComboBox)
                Dim item = DirectCast(control.SelectedItem, KeyValueObject(Of String, String))

                If (item Is Nothing) Then
                    Return
                End If

                Dim nuevoEstadoOrden As String = item.Key
                If (Not ConfirmarCambioEstadoOrden(IIf(Me.EstadoOrden IsNot Nothing, Me.EstadoOrden, Me.ActualEstadoOrden), nuevoEstadoOrden)) Then
                    If (control.SelectedIndex <> Me.EstadoOrdenIndex) Then
                        control.SelectedIndex = Me.EstadoOrdenIndex
                    End If
                    Return
                Else
                    Me.EstadoOrdenIndex = control.SelectedIndex
                    Me.EstadoOrden = nuevoEstadoOrden
                End If

                Try
                    Loading = True
                    Me.Cursor = Cursors.WaitCursor

                    Select Case Me.EstadoOrden
                        Case ENTREGADA
                            InitEntregada(True)
                        Case NO_ENTREGADA
                            InitNoEntregada(True)
                        Case NOVEDADES
                            InitNovedades(True)
                        Case REPROGRAMADA, NO_REPROGRAMADA
                            InitReprogramacion(True)
                        Case Else
                            Throw New Exception("Cambio de estado no permitido")
                    End Select
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Me.Cursor = Cursors.Default
                    Loading = False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Function ConfirmarCambioEstadoOrden(actualEstadoOrden As String, nuevoEstadoOrden As String) As Boolean
        If (actualEstadoOrden <> nuevoEstadoOrden) Then
            Select Case actualEstadoOrden
                Case NO_ENTREGADA, NOVEDADES, NO_REPROGRAMADA
                    If (MsgBox("Este cambio causará que se pierdan los datos del ultimo resultado, ¿Esta seguro de continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No) Then
                        Return False
                    End If
            End Select
        End If

        Return True
    End Function

#End Region

#Region "Eventos Fechas de Entrega"
    Private Sub DTPFechaInicioEntrega_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaInicioEntrega.ValueChanged
        If Not Loading Then
            RestoreCustomFormat(DirectCast(sender, DateTimePicker))
            DTPFechaFinEntrega.Value = DTPFechaInicioEntrega.Value
        End If
    End Sub

    Private Sub DTPHoraInicioEntrega_ValueChanged(sender As Object, e As EventArgs) Handles DTPHoraInicioEntrega.ValueChanged
        If Not Loading Then
            If (DTPHoraFinEntrega.Value.TimeOfDay.CompareTo(New TimeSpan(0, 0, 0)) = 0) Then
                DTPHoraFinEntrega.Value = DTPHoraInicioEntrega.Value
            End If
        End If
    End Sub

    Private Sub DTPFechaFinEntrega_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaFinEntrega.ValueChanged
        If Not Loading Then
            RestoreCustomFormat(DirectCast(sender, DateTimePicker))
        End If
    End Sub
#End Region

#Region "Eventos NO ENTREGA"

    Private Sub ComboBoxCausalNoEntrega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCausalNoEntrega.SelectedIndexChanged
        If Not Loading Then

            Dim Causal As CausalDeNovedadDeDistribucion
            Dim control = DirectCast(sender, ComboBox)
            Causal = DirectCast(control.SelectedItem, CausalDeNovedadDeDistribucion)

            If (Causal IsNot Nothing) Then
                TextBoxCausalNoEntregaDescripcion.Text = Causal.Descripcion
                TextBoxIndicadorOTIF.Text = Causal.IndicadorOtifId
                SetResponsableNovedad(ComboBoxCausalNoEntregaResponsable, Causal.ResponsableId)

                With ComboBoxCausalNoEntregaResponsableInterno
                    If (ComboBoxCausalNoEntregaResponsable.Text = "TACTIC") Then
                        .Enabled = True
                    Else
                        .Enabled = False
                    End If

                    SetResponsableInternoNovedad(ComboBoxCausalNoEntregaResponsableInterno, Causal.ResponsableInternoId)
                End With
            Else
                ResetNoEntregado()
            End If
        End If
    End Sub

    Private Sub ComboBoxCausalNoEntregaResponsable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCausalNoEntregaResponsable.SelectedIndexChanged
        If Not Loading Then
            With ComboBoxCausalNoEntregaResponsableInterno
                If (ComboBoxCausalNoEntregaResponsable.Text = "TACTIC") Then
                    .Enabled = True
                Else
                    .Enabled = False
                End If

                .SelectedIndex = -1
            End With
        End If
    End Sub

#End Region

#Region "Eventos NOVEDADES"
    Private Sub NuevaNovedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaNovedadToolStripMenuItem.Click
        NuevaNovedad()
    End Sub

    Private Sub NuevaNovedad()
        If (dgvLineas.SelectedRows.Count = 0 Or dgvLineas.SelectedRows.Count > 1) Then
            MsgBox("Debe seleccionar un registro")
            Return
        End If

        Dim LineOrdenId As Integer = dgvLineas.SelectedRows(0).Cells("id_linea_orden").Value

        Dim form As New FormEdicionNovedad
        With form
            .LineaOrdenId = LineOrdenId
            .CausalesDeNovedades = Me.CausalesDeNovedades
            .TiposDeNovedad = Me.TiposDeNovedad
            .Responsables = Me.Responsables
            .ResponsablesInternos = Me.ResponsablesInternos
            .ShowDialog(Me)
        End With
    End Sub

    'TODO EDIT
    'TODO DELETE

#End Region

#Region "REPROGRAMACIONES"

#End Region

#Region "Inicializacion"
    Private Sub CargarListas()
        Me.EstadosOrden = GetEstadosOrdenCierreOrden()

        Me.CausalesDeNoEntrega = GetCausalesDeNoEntrega()
        Me.CausalesDeNovedades = GetCausalesDeNovedades()
        Me.TiposDeNovedad = GetTiposDeNovedad()

        Me.Responsables = GetResponsablesDeNovedades()
        Me.ResponsablesInternos = GetResponsablesInternosDeNovedades()
    End Sub

    Private Sub CargarOrden()
        Try
            Dim sql = "tms.ListarOrdenPorIdParaCierreDeOrden"

            Using connection As New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using cmd As New SqlCommand(sql, connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ordenId", Me.OrdenId)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While (reader.Read())
                            TextBoxClienteCodigo.Text = reader("cliente_codigo")
                            TextBoxServicioNombre.Text = reader("servicio_nombre")
                            TextBoxOrdenId.Text = reader("id_orden").ToString()
                            TextBoxOrdenNumero.Text = reader("numero_orden")

                            Me.ActualEstadoOrden = reader("id_estado_orden")
                            TextBoxEstadoOrden.Text = reader("id_estado_orden")

                            Me.EstadoOrden = Nothing
                            Me.EstadoOrdenIndex = -1
                            FillComboBoxWithList(ComboBoxEstadoOrdenNuevo, GetEstadosOrdenHabilitados(Me.ActualEstadoOrden, Me.EstadosOrden), "Value")

                            TextBoxEstadoDistribucionActual.Text = reader("id_estado_distribucion")
                            '-------------------------------------------------------------------------------------------------------------------
                            SetDateTimePickerDateValue(DTPFechaCita, reader, "fecha_cita_entrega")
                            SetDateTimePickerDateTimeValue(DTPFechaEstimadaEntrega, reader, "fecha_entrega_estimada")

                            SetDateTimePickerDateValue(DTPFechaInicioEntrega, reader, "fecha_entrega_inicio")
                            SetDateTimePickerTimeValue(DTPHoraInicioEntrega, reader, "fecha_entrega_inicio")

                            SetDateTimePickerDateValue(DTPFechaFinEntrega, reader, "fecha_entrega_fin")
                            SetDateTimePickerTimeValue(DTPHoraFinEntrega, reader, "fecha_entrega_fin")

                            '-------------------------------------------------------------------------------------------------------------------
                            TextBoxDestinatarioIdentificacion.Text = reader("destinatario_numero_identificacion")
                            TextBoxDestinatarioNombre.Text = reader("destinatario_nombre")
                            TextBoxDestinatarioEmail.Text = reader("destinatario_contacto_email")
                            TextBoxDestinatarioContacto.Text = reader("destinatario_contacto_nombres")
                            TextBoxDestinatarioTelefono.Text = reader("destinatario_contacto_telefonos")

                            '-------------------------------------------------------------------------------------------------------------------
                            TextBoxDestinoCiudad.Text = reader("destino_ciudad_nombre_alterno")
                            TextBoxDestinoDireccion.Text = reader("destino_direccion")
                            TextBoxDestinoCodigo.Text = reader("destino_codigo")
                            TextBoxDestinoNombre.Text = reader("destino_nombre")
                            TextBoxDestinoEmail.Text = reader("destino_contacto_email")
                            TextBoxDestinoContacto.Text = reader("destino_contacto_nombres")
                            TextBoxDestinoTelefono.Text = reader("destino_contacto_telefonos")

                            '-------------------------------------------------------------------------------------------------------------------
                            TextBoxValorRecaudo.Text = reader("valor_recaudo").ToString()
                            TextBoxUsuarioConfirmacion.Text = reader("usuario_confirmacion")
                            TextBoxNotasConfirmacion.Text = reader("notas_confirmacion")
                            DTPFechaConfirmacion.Value = reader("fecha_confirmacion")
                            TextBoxUsuarioAceptacion.Text = reader("usuario_aceptacion")
                            TextBoxNotasAceptacion.Text = reader("notas_aceptacion")
                            DTPFechaAceptacion.Value = reader("fecha_aceptacion")

                            '-------------------------------------------------------------------------------------------------------------------
                            CausalDeReprogramacion = IIf(IsDBNull(reader("id_causal_reprogramacion")), Nothing, reader("id_causal_reprogramacion"))
                            TextBoxCausalReprogramacionDescripcion.Text = reader("causal_reprogramacion_descripcion")
                            TextBoxCausalReprogramacionNotas.Text = reader("notas_reprogramacion")
                            SetDateTimePickerDateTimeValue(DTPCausalReprogramacionFechaActualizacion, reader, "fecha_reprogramacion")
                            TextBoxCausalReprogramacionUsuarioActualizacion.Text = reader("usuario_reprogramacion")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub InicializarPorEstadoOrden()
        Select Case Me.ActualEstadoOrden
            Case ENTREGADA
                InitEntregada(False)
            Case NO_ENTREGADA
                InitNoEntregada(False)
            Case NOVEDADES
                InitNovedades(False)
            Case REPROGRAMADA
                InitReprogramacion(False)
            Case NO_REPROGRAMADA
                InitReprogramacion(False)
            Case Else
                Init(False)
        End Select
    End Sub

    Private Sub Init(Lock As Boolean)
        DTPFechaInicioEntrega.Enabled = Lock
        DTPHoraInicioEntrega.Enabled = Lock
        DTPFechaFinEntrega.Enabled = Lock
        DTPHoraFinEntrega.Enabled = Lock

        EnablePage(TabPageNoEntregada, False)
        EnablePage(TabPageLineas, False)
        EnablePage(TabPageNovedades, False)
        EnablePage(TabPageReprogramacion, False)

        Tab.Visible = False
    End Sub

#End Region

#Region "GUARDADO"
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Dim OK As Boolean = False
        Try
            Select Case Me.EstadoOrden
                Case ENTREGADA
                    OK = ValidarENTREGADA()
                Case NO_ENTREGADA
                    OK = ValidarNO_ENTREGADA()
                Case NOVEDADES
                Case REPROGRAMADA
                Case NO_REPROGRAMADA
                Case Else
                    MsgBox("No ha seleccionado un nuevo estado")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
            Debug.WriteLine(ex)
            OK = False
        End Try

        If Not OK Then
            Me.DialogResult = DialogResult.None
        End If
    End Sub
#End Region

#Region "ENTREGADA"
    Private Sub InitEntregada(Lock As Boolean)
        Init(Lock)
    End Sub

    Private Function ValidarENTREGADA() As Boolean
        Dim OK As Boolean = True
        Dim errores = New Dictionary(Of Control, List(Of String))

        Dim fechaInicioEntrega As Date?
        Dim fechaFinEntrega As Date?

        OK = OK And ValidarFechasDeEntrega(errores, fechaInicioEntrega, fechaFinEntrega)

        Dim err = SetErrors(ErrorProvider, errores)

        If OK Then
            GuardarENTREGADA(fechaInicioEntrega.Value, fechaFinEntrega.Value)
        Else
            MsgBox("Se detectaron los siguientes errores: " + vbLf + err)
        End If

        Return OK
    End Function

    Private Sub GuardarENTREGADA(fechaInicioEntrega As Date, fechaFinEntrega As Date)
        Me.Cursor = Cursors.WaitCursor
        Try
            Using connection = New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using transaction = connection.BeginTransaction()
                    Dim sql As String = "tms.CambiarEstadoENTREGADA"
                    Using cmd = New SqlCommand(sql, connection, transaction)
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.AddWithValue("@ordenId", Me.OrdenId)
                        cmd.Parameters.AddWithValue("@fechaEntrega", fechaInicioEntrega)
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicioEntrega)
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFinEntrega)
                        cmd.Parameters.AddWithValue("@usuario", Me.Usuario)

                        cmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "NO ENTREGADA"
    Private Sub InitNoEntregada(Lock As Boolean)
        Init(Lock)
        ResetNoEntregado()

        ComboBoxCausalNoEntrega.Enabled = Lock
        ComboBoxCausalNoEntregaResponsable.Enabled = Lock
        ComboBoxCausalNoEntregaResponsableInterno.Enabled = False
        TextBoxCausalNoEntregaNotas.Enabled = Lock

        FillComboBoxWithList(ComboBoxCausalNoEntrega, CausalesDeNoEntrega, "Nombre")
        FillComboBoxWithList(ComboBoxCausalNoEntregaResponsable, Responsables, "Value")
        FillComboBoxWithList(ComboBoxCausalNoEntregaResponsableInterno, ResponsablesInternos, "Value")

        If (Me.ActualEstadoOrden = NO_ENTREGADA) Then
            CargarNovedadNoEntrega()
        End If

        EnablePage(TabPageNoEntregada, True)

        Tab.Visible = True
    End Sub

    Private Sub ResetNoEntregado()
        ComboBoxCausalNoEntrega.SelectedIndex = -1
        TextBoxCausalNoEntregaDescripcion.Text = ""
        TextBoxIndicadorOTIF.Text = ""

        ComboBoxCausalNoEntregaResponsable.SelectedIndex = -1

        ComboBoxCausalNoEntregaResponsableInterno.Enabled = False
        ComboBoxCausalNoEntregaResponsableInterno.SelectedIndex = -1

        TextBoxCausalNoEntregaNotas.Text = ""
        TextBoxCausalNoEntregaUsuarioActualizacion.Text = ""
        SetDateTimePickerDateTimeValue(DTPCausalNoEntregaFechaActualizacion, Nothing)
    End Sub

    Private Sub CargarNovedadNoEntrega()
        Try
            Dim sql = "tms.ListarNovedadDeNoEntregaPorOrdenIdParaCierreDeOrden"

            Using connection As New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using cmd As New SqlCommand(sql, connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ordenId", Me.OrdenId)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While (reader.Read())
                            Dim causalId As Integer? = IIf(IsDBNull(reader("id_causal_novedad_distribucion")), Nothing, reader("id_causal_novedad_distribucion"))
                            Dim responsablelId As Integer? = IIf(IsDBNull(reader("id_responsable_novedad")), Nothing, reader("id_responsable_novedad"))
                            Dim responsableInternolId As Integer? = IIf(IsDBNull(reader("id_responsable_interno_novedad")), Nothing, reader("id_responsable_interno_novedad"))

                            NovedadDeNoEntregaId = reader("id_orden_novedad")

                            SetCausalNovedad(ComboBoxCausalNoEntrega, causalId)
                            TextBoxCausalNoEntregaDescripcion.Text = reader("causal_novedad_descripcion")
                            TextBoxIndicadorOTIF.Text = reader("id_indicador_otif")

                            SetResponsableNovedad(ComboBoxCausalNoEntregaResponsable, responsablelId)
                            SetResponsableInternoNovedad(ComboBoxCausalNoEntregaResponsableInterno, responsableInternolId)

                            TextBoxCausalNoEntregaNotas.Text = reader("notas")
                            TextBoxCausalNoEntregaUsuarioActualizacion.Text = reader("usuario_actualizacion")
                            SetDateTimePickerDateTimeValue(DTPCausalNoEntregaFechaActualizacion, reader, "fecha_actualizacion")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function ValidarNO_ENTREGADA() As Boolean
        Dim OK As Boolean = True
        Dim errores = New Dictionary(Of Control, List(Of String))

        Dim fechaInicioEntrega As Date?
        Dim fechaFinEntrega As Date?
        Dim Causal = DirectCast(ComboBoxCausalNoEntrega.SelectedItem, CausalDeNovedadDeDistribucion)
        Dim Responsable = DirectCast(ComboBoxCausalNoEntregaResponsable.SelectedItem, KeyValueObject(Of Integer, String))
        Dim ResponsableInterno = DirectCast(ComboBoxCausalNoEntregaResponsableInterno.SelectedItem, KeyValueObject(Of Integer?, String))

        OK = OK And ValidarFechasDeEntrega(errores, fechaInicioEntrega, fechaFinEntrega)
        OK = OK And ValidarCausalDeNoEntrega(Causal, errores)
        OK = OK And ValidarResponsableNovedad(Responsable, errores)

        Dim err = SetErrors(ErrorProvider, errores)

        If OK Then
            Dim ResponsableInternoId As Integer? = Nothing

            If ResponsableInterno IsNot Nothing Then
                ResponsableInternoId = ResponsableInterno.Key
            End If
            GuardarNO_ENTREGADA(fechaInicioEntrega, fechaFinEntrega, Causal.Id, Responsable.Key, ResponsableInternoId, TextBoxCausalNoEntregaNotas.Text)
        Else
            MsgBox("Se detectaron los siguientes errores: " + vbLf + err)
        End If

        Return OK
    End Function

    Private Sub GuardarNO_ENTREGADA(fechaInicioEntrega As Date, fechaFinEntrega As Date, causalNovedadId As Integer, responsableNovedadId As Integer, responsableInternoNovedadId As Integer?, notas As String)
        Me.Cursor = Cursors.WaitCursor
        Try
            Using connection = New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using transaction = connection.BeginTransaction()
                    Dim sql As String = "tms.CambiarEstadoNO_ENTREGADA"
                    Using cmd = New SqlCommand(sql, connection, transaction)
                        cmd.CommandType = CommandType.StoredProcedure

                        cmd.Parameters.AddWithValue("@ordenId", Me.OrdenId)
                        cmd.Parameters.AddWithValue("@fechaEntrega", fechaInicioEntrega)
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicioEntrega)
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFinEntrega)

                        cmd.Parameters.AddWithValue("@causalNovedadId", causalNovedadId)
                        cmd.Parameters.AddWithValue("@responsableNovedadId", responsableNovedadId)
                        cmd.Parameters.AddWithValue("@responsableInternoNovedadId", IIf(responsableInternoNovedadId IsNot Nothing, responsableInternoNovedadId, DBNull.Value))
                        cmd.Parameters.AddWithValue("@notas", notas)

                        cmd.Parameters.AddWithValue("@usuario", Me.Usuario)

                        cmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "NOVEDADES"
    Private Sub InitNovedades(Lock As Boolean)
        Init(Lock)

        NuevaNovedadToolStripMenuItem.Enabled = Lock
        ModificarNovedadToolStripMenuItem.Enabled = Lock
        EliminarNovedadToolStripMenuItem.Enabled = Lock

        EnablePage(TabPageLineas, True)
        EnablePage(TabPageNovedades, True)

        Tab.Visible = True

        CargarLineasOrden()
        CargarNovedasdesOrden()
    End Sub

    Private Sub CargarLineasOrden()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim sql = "tms.ListarLineasOrdenPorOrdenIdParaCierreDeOrden"

            Using connnection As New SqlConnection(My.Settings.SateliteConnectionString)
                connnection.Open()
                Using cmd As New SqlCommand(sql, connnection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ordenId", Me.OrdenId)

                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    DGV.Fill(dgvLineas, ds.Tables(0), "", "", bnLineas)
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub CargarNovedasdesOrden()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim sql = "tms.ListarNovedadesPorOrdenIdParaCierreDeOrden"

            Using connnection As New SqlConnection(My.Settings.SateliteConnectionString)
                connnection.Open()
                Using cmd As New SqlCommand(sql, connnection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@ordenId", Me.OrdenId)

                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    DGV.Fill(dgvNovedades, ds.Tables(0), "", "", bnNovedades)
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region "REPROGRAMACION"
    Private Sub InitReprogramacion(Lock As Boolean)
        Init(Lock)

        ComboBoxCausalReprogramacion.Enabled = Lock
        TextBoxCausalReprogramacionNotas.Enabled = Lock

        CheckBoxRequiereServicioDistribucion.Enabled = Lock
        CheckBoxRequiereConfirmarCita.Enabled = Lock

        DTPReprogramacionFechaDesde.Enabled = Lock
        DTPReprogramacionFechaHasta.Enabled = Lock
        ComboBoxAMPM.Enabled = Lock
        ComboBoxHoraMaxima.Enabled = Lock
        NUDHoras.Enabled = Lock
        LabelResumen.Text = ""

        EnablePage(TabPageReprogramacion, True)

        Tab.Visible = True
    End Sub

#End Region

#Region "Validaciones"
    Private Function ValidarFechasDeEntrega(errores As Dictionary(Of Control, List(Of String)), ByRef fechaInicioEntrega As Date?, ByRef fechaFinEntrega As Date?) As Boolean
        Dim OK As Boolean = True

        fechaInicioEntrega = GetDateFomDateTimePicker(DTPFechaInicioEntrega)
        fechaFinEntrega = GetDateFomDateTimePicker(DTPFechaFinEntrega)
        Dim horaInicioEntrega As TimeSpan? = GetTimeSpanFomDateTimePicker(DTPHoraInicioEntrega)
        Dim horaFinEntrega As TimeSpan? = GetTimeSpanFomDateTimePicker(DTPHoraFinEntrega)

        OK = OK And ValidarFechaInicioEntrega(fechaInicioEntrega, errores)
        OK = OK And ValidarFechaFinEntrega(fechaFinEntrega, errores)
        OK = OK And ValidarHoraInicioEntrega(horaInicioEntrega, errores)
        OK = OK And ValidarHoraFinEntrega(horaFinEntrega, errores)

        If (OK) Then
            fechaInicioEntrega = fechaInicioEntrega.Value.Add(horaInicioEntrega)
            fechaFinEntrega = fechaFinEntrega.Value.Add(horaFinEntrega)

            OK = OK And ValidarFechas(fechaInicioEntrega.Value, fechaFinEntrega.Value, errores)
        End If

        Return OK
    End Function

    Private Function ValidarFechaInicioEntrega(fecha As Date?, errores As Dictionary(Of Control, List(Of String))) As Boolean
        Dim err As String = ""
        If (fecha Is Nothing) Then
            err = "No ha suministrado la fecha de inicio de la entrega"
        ElseIf fecha.Value.CompareTo(Date.Today) > 0 Then
            err = "La fecha de inicio de la entrega debe ser menor o igual al dia de hoy"
        End If

        AddError(errores, DTPHoraInicioEntrega, err)

        Return String.IsNullOrEmpty(err)
    End Function

    Private Function ValidarFechaFinEntrega(fecha As Date?, errores As Dictionary(Of Control, List(Of String))) As Boolean
        Dim err As String = ""
        If (fecha Is Nothing) Then
            err = "No ha suministrado la fecha de finalización de la entrega"
        ElseIf fecha.Value.CompareTo(Date.Today) > 0 Then
            err = "La fecha de finalización de la entrega debe ser menor o igual al dia de hoy"
        End If

        AddError(errores, DTPHoraFinEntrega, err)

        Return String.IsNullOrEmpty(err)
    End Function

    Private Function ValidarHoraInicioEntrega(hora As TimeSpan?, errores As Dictionary(Of Control, List(Of String))) As Boolean
        Dim err As String = ""
        If (hora Is Nothing) Then
            err = "No ha suministrado la hora de inicio de la entrega"
        End If

        AddError(errores, DTPHoraInicioEntrega, err)

        Return String.IsNullOrEmpty(err)
    End Function

    Private Function ValidarHoraFinEntrega(hora As TimeSpan?, errores As Dictionary(Of Control, List(Of String))) As Boolean
        Dim err As String = ""
        If (hora Is Nothing) Then
            err = "No ha suministrado la hora de finalización de de la entrega"
        End If

        AddError(errores, DTPHoraFinEntrega, err)

        Return String.IsNullOrEmpty(err)
    End Function

    Private Function ValidarFechas(fechaInicio As Date, fechaFin As Date, errores As Dictionary(Of Control, List(Of String))) As Boolean
        Dim err As String = ""
        If fechaInicio.CompareTo(fechaFin) > 0 Then
            err = "La fecha de inicio de la entrega debe ser menor o igual que la fecha de finaliación"
        End If

        AddError(errores, DTPHoraFinEntrega, err)

        Return String.IsNullOrEmpty(err)
    End Function
    Private Function ValidarCausalDeNoEntrega(Causal As CausalDeNovedadDeDistribucion, errores As Dictionary(Of Control, List(Of String))) As Boolean
        Dim err As String = ""
        If Causal Is Nothing Then
            err = "No ha suministrado la causal de la no entrega"
        End If

        AddError(errores, ComboBoxCausalNoEntrega, err)

        Return String.IsNullOrEmpty(err)
    End Function
    Private Function ValidarResponsableNovedad(Responsable As KeyValueObject(Of Integer, String), errores As Dictionary(Of Control, List(Of String))) As Boolean
        Dim err As String = ""
        If Responsable Is Nothing Then
            err = "No ha suministrado un responsable de la no entrega"
        End If

        AddError(errores, ComboBoxCausalNoEntregaResponsable, err)

        Return String.IsNullOrEmpty(err)
    End Function

#End Region

#Region "Utilidades"
    Private Sub SetCausalNovedad(control As ComboBox, CausalId As Integer?)
        With control
            If (CausalId.HasValue) Then
                Dim c = CausalesDeNoEntrega.FirstOrDefault(Function(a) a.Id.Equals(CausalId.Value))
                .SelectedIndex = .Items.IndexOf(c)
            Else
                .SelectedIndex = -1
            End If
        End With
    End Sub

    Private Sub SetResponsableNovedad(control As ComboBox, ResponsableId As Integer?)
        With control
            If (ResponsableId.HasValue) Then
                Dim r = Responsables.FirstOrDefault(Function(a) a.Key.Equals(ResponsableId.Value))
                .SelectedIndex = .Items.IndexOf(r)
            Else
                .SelectedIndex = -1
            End If
        End With
    End Sub

    Private Sub SetResponsableInternoNovedad(control As ComboBox, ResponsableInternoId As Integer?)
        With control
            If (ResponsableInternoId.HasValue) Then
                Dim r = ResponsablesInternos.FirstOrDefault(Function(a) a.Key.Equals(ResponsableInternoId.Value))
                .SelectedIndex = .Items.IndexOf(r)
            Else
                .SelectedIndex = -1
            End If
        End With
    End Sub

    Private Function GetEstadosOrdenHabilitados(ActualEstadoOrden As String, estados As List(Of KeyValueObject(Of String, String))) As List(Of KeyValueObject(Of String, String))
        Dim estadosHabilitados = New List(Of KeyValueObject(Of String, String))

        Select Case ActualEstadoOrden
            Case EJECUCION, ENTREGADA, NOVEDADES, "ACEPTADA"
                estadosHabilitados.AddRange(estados.Where(Function(a)
                                                              Return a.Key.Equals(ENTREGADA) Or a.Key.Equals(NO_ENTREGADA) Or a.Key.Equals(NOVEDADES)
                                                          End Function).ToList())
            Case NO_ENTREGADA
                estadosHabilitados.AddRange(estados.Where(Function(a)
                                                              Return a.Key.Equals(ENTREGADA) Or a.Key.Equals(NO_ENTREGADA) Or a.Key.Equals(NOVEDADES) Or a.Key.Equals(REPROGRAMADA) Or a.Key.Equals(NO_REPROGRAMADA)
                                                          End Function).ToList())
            Case NO_REPROGRAMADA
                estadosHabilitados.AddRange(estados.Where(Function(a)
                                                              Return a.Key.Equals(NO_ENTREGADA) Or a.Key.Equals(REPROGRAMADA) Or a.Key.Equals(NO_REPROGRAMADA)
                                                          End Function).ToList())
            Case REPROGRAMADA

            Case Else
        End Select

        Return estadosHabilitados
    End Function

    Private Sub EnablePage(page As TabPage, enable As Boolean)
        If (enable) Then
            Tab.TabPages.Add(page)
            hiddenPages.Remove(page)
        Else
            Tab.TabPages.Remove(page)
            If (Not hiddenPages.Contains(page)) Then
                hiddenPages.Add(page)
            End If
        End If

    End Sub



#End Region

End Class