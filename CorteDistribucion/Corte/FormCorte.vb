Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration
Imports CorteDistribucion
Imports System.Windows.Forms.ListBox
Imports DgvFilterPopup
Imports System.Reflection

Public Class FormCorte
    Private _Incluidas As List(Of DocumentoOrdenIncluida) = New List(Of DocumentoOrdenIncluida)
    Private _Excluidas As List(Of DocumentoOrdenExcluida) = New List(Of DocumentoOrdenExcluida)
    Private _bodegas As List(Of XObject) = New List(Of XObject)

    Private Loading As Boolean = False
    Private FiltroVariableHabilitadas As String = ""
    Private FiltroVariableNoHabilitadas As String = ""
    Private FiltroVariableSeleccionadas As String = ""

#Region "Propiedades"
    Public ReadOnly Property Usuario() As String
        Get
            Return Environment.UserName
        End Get
    End Property

    Public Property Incluidas As List(Of DocumentoOrdenIncluida)
        Get
            Return _Incluidas
        End Get
        Set(value As List(Of DocumentoOrdenIncluida))
            _Incluidas = value
        End Set
    End Property

    Public Property Excluidas As List(Of DocumentoOrdenExcluida)
        Get
            Return _Excluidas
        End Get
        Set(value As List(Of DocumentoOrdenExcluida))
            _Excluidas = value
        End Set
    End Property

    Public ReadOnly Property Bodegas As List(Of KeyValueObject(Of Integer, String))
        Get
            Dim list = New List(Of KeyValueObject(Of Integer, String))

            If (dgvSeleccionadas.Rows.Count > 0) Then
                For Each e As DataGridViewRow In dgvSeleccionadas.Rows
                    Dim item As New KeyValueObject(Of Integer, String)
                    item.Key = e.Cells("id_bodega").Value
                    item.Value = e.Cells("bodega_codigo").Value
                    list.Add(item)
                Next
                list = list.Where(Function(a) a.Key <> 0).Distinct().ToList()

                If (list.Count = 0) Then
                    Dim rows As DataRowCollection = lbxCeDis.DataSource.Rows
                    For Each e In rows
                        Dim item As New KeyValueObject(Of Integer, String)
                        item.Key = e("id_bodega")
                        item.Value = e("codigo")
                        list.Add(item)
                    Next
                    list = list.Where(Function(a) a.Key <> 0).Distinct().ToList()
                End If
            End If

            Return list
        End Get
    End Property
#End Region

#Region "Metodos Load/Unload Formulario"
    Private Sub FormCorteRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Loading = True

            Me.ConstruirDGVFiltrosCorte()

            Listas.FillCiudades(Me.Usuario, cbxCiudadOrigen)
            Listas.FillTiposCortePlanificacionRuta(cbxTipoCortePlanificacionRuta)
            Listas.FillCeDis(Me.cbxCiudadOrigen.SelectedValue, lbxCeDis)
            Listas.FillClientes(lbxClientes)
            Listas.FillServicios(lbxClientes, lbxServicios)
            Listas.FillCanales(lbxCanales)
            Listas.FillCiudades(lbxCiudadesDestino)
            Listas.FillDepartamentos(lbxDepartamentosDestino)
            Listas.FillClientes(cbxClientesInclusion)
            Listas.FillClientes(cbxClientesExclusion)

            Me.dtpFechaSalidaRutas.Value = Time.DiaPredeterminado
            Me.dtpFechaSalidaRutas.MinDate = Date.Today

            GetType(DataGridView).InvokeMember("DoubleBuffered",
                (BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetProperty),
                Nothing,
                dgvHabilitadas, {True})

            GetType(DataGridView).InvokeMember("DoubleBuffered",
                (BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.SetProperty),
                Nothing,
                dgvNoHabilitadas, {True})

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        Finally
            Loading = False
        End Try
    End Sub

    Private Sub ConstruirDGVFiltrosCorte()
        dgvFiltros.Rows.Insert(0, New String() {"Departamentos", ""})
        dgvFiltros.Rows.Insert(0, New String() {"Ciudades", ""})
        dgvFiltros.Rows.Insert(0, New String() {"Canales", ""})
        dgvFiltros.Rows.Insert(0, New String() {"Servicios", ""})
        dgvFiltros.Rows.Insert(0, New String() {"Clientes", ""})
        dgvFiltros.Rows.Insert(0, New String() {"CeDis", ""})
    End Sub

    Private Sub FormPlanificacionRutas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub Lock(lock As Boolean)
        cmdConsultar.Enabled = Not lock
        cmdExportar.Enabled = Not lock

        cmdIncluir.Enabled = Not lock
        cmdLimpiarIncluidos.Enabled = Not lock
        cmdLimpiarTodosIncluidos.Enabled = Not lock

        cmdExcluir.Enabled = Not lock
        cmdLimpiarExcluidos.Enabled = Not lock
        cmdLimpiarTodosExcluidos.Enabled = Not lock

        ToolStripButtonSeleccionarTodos.Enabled = Not lock
        ToolStripButtonInvertirSeleccion.Enabled = Not lock
        ToolStripButtonAgregarSeleccion.Enabled = Not lock

        ToolStripButtonSeleccionarTodosSeleccionados.Enabled = Not lock
        ToolStripButtonInvertirSeleccionSeleccionados.Enabled = Not lock
        ToolStripButtonRemoverSeleccion.Enabled = Not lock

        ToolStripButtonConfirmar.Enabled = Not lock
    End Sub
#End Region

#Region "Seccion Comandos"
    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Consultar(True)
    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        Me.Cursor = Cursors.WaitCursor
        Exportar("", False)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripButtonConfirmar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonConfirmar.Click
        Me.Cursor = Cursors.WaitCursor
        Confirmar()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripButtonSeleccionarTodos_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSeleccionarTodos.Click
        dgvHabilitadas.SelectAll()
    End Sub

    Private Sub ToolStripButtonInvertirSeleccion_Click(sender As Object, e As EventArgs) Handles ToolStripButtonInvertirSeleccion.Click
        For Each row As DataGridViewRow In dgvHabilitadas.Rows
            If row.Selected Then
                row.Selected = False
            Else
                row.Selected = True
            End If
        Next
    End Sub

    Private Sub ToolStripButtonAgregarSeleccion_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAgregarSeleccion.Click
        AgregarASeleccion(dgvHabilitadas, dgvSeleccionadas)
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

    Private Sub ToolStripTextBoxFiltroHabilitadas_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBoxFiltroHabilitadas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            DGV.Filtrar(dgvHabilitadas, GetFiltroFijoHabilitadas(), Me.FiltroVariableHabilitadas, ToolStripTextBoxFiltroHabilitadas.Text)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ToolStripTextBoxFiltroNoHabilitadas_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBoxFiltroNoHabilitadas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            DGV.Filtrar(dgvNoHabilitadas, GetFiltroFijoNoHabilitadas(), Me.FiltroVariableNoHabilitadas, ToolStripTextBoxFiltroNoHabilitadas.Text)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ToolStripTextBoxFiltroSeleccionadas_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBoxFiltroSeleccionadas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            DGV.Filtrar(dgvSeleccionadas, "", Me.FiltroVariableSeleccionadas, ToolStripTextBoxFiltroSeleccionadas.Text)
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "Seccion Filtros"
    Private Sub dtpFechaCorteRutas_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaSalidaRutas.ValueChanged
        'Me.Limpiar()
    End Sub
    Private Sub cbxCiudadOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCiudadOrigen.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        Dim ciudadId As Integer = cbxCiudadOrigen.SelectedValue
        Listas.FillCeDis(ciudadId, lbxCeDis)

        My.Settings.CiudadOrigenId = ciudadId
        Me.Limpiar()
    End Sub
    Private Sub cbxTipoCortePlanificacionRuta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoCortePlanificacionRuta.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        Dim TipoCortePlanificacionRutaId As Integer = cbxTipoCortePlanificacionRuta.SelectedValue

        My.Settings.TipoCorteRutaId = TipoCortePlanificacionRutaId
        Me.Limpiar()
    End Sub
    Private Sub chkPermitirOrdenesSinCeDi_CheckedChanged(sender As Object, e As EventArgs) Handles chkPermitirOrdenesSinCeDi.CheckedChanged
        If chkPermitirOrdenesSinCeDi.Checked Then
            Dim sb As New StringBuilder()
            sb.AppendLine("Esta funcionalidad permite incluir en el corte, órdenes a las cuales aún no se les ha especificado un CeDi origen.")
            sb.AppendLine()
            sb.AppendLine("TENGA EN CUENTA QUE ESTA FUNCIONALIDAD PERMITIRÁ INCLUIR EN LOS RESULTADOS, ÓRDENES QUE POTENCIALMENTE PODRÍAN SALIR DE CUALQUIER CEDI EN EL PAÍS.")
            sb.AppendLine()
            sb.AppendLine("Adicionalmente la consulta podria tomar un poco más de tiempo.")
            sb.AppendLine()
            sb.AppendLine("ESTA FUNCIONALIDAD SOLO ESTARÁ ACTIVA DURANTE LA ESTABILIZACIÓN DEL SISTEMA.")
            sb.AppendLine()
            sb.AppendLine("¿ESTA SEGURO DE ACTIVAR ESTE FILTRO?")
            If (MsgBox(sb.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.No) Then
                chkPermitirOrdenesSinCeDi.Checked = False
            End If
        End If
        Me.Consultar()
    End Sub
    Private Sub chkSoloIncluidas_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoloIncluidas.CheckedChanged
        Me.Consultar()
    End Sub
    Private Sub lbxCeDis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCeDis.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        UpdateDGVFiltros(lbxCeDis, "codigo", 0, 1)
    End Sub
    Private Sub lbxClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxClientes.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        FillServicios(lbxClientes, lbxServicios)
        UpdateDGVFiltros(lbxClientes, "codigo", 1, 1)
    End Sub
    Private Sub lbxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxServicios.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        UpdateDGVFiltros(lbxServicios, "nombre", 2, 1)
    End Sub
    Private Sub lbxCanales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCanales.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        UpdateDGVFiltros(lbxCanales, "nombre", 3, 1)
    End Sub
    Private Sub lbxCiudadesDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCiudadesDestino.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        UpdateDGVFiltros(lbxCiudadesDestino, "nombre_alterno", 4, 1)
    End Sub
    Private Sub lbxDepartamentosDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxDepartamentosDestino.SelectedIndexChanged
        If (Loading) Then
            Exit Sub
        End If

        UpdateDGVFiltros(lbxDepartamentosDestino, "nombre", 5, 1)
    End Sub
    Private Sub UpdateDGVFiltros(lbx As ListBox, displayColum As String, Row As Integer, Col As Integer)
        If (Loading) Then
            Exit Sub
        End If

        Dim sb As New StringBuilder()
        With lbx
            For Each drv As DataRowView In .SelectedItems
                sb.Append(drv.Row(displayColum)).Append(", ")
            Next
            If (sb.Length > 0) Then
                sb.Append(",")
                sb.Replace(", ,", "")
            End If
        End With

        dgvFiltros.Rows(Row).Cells(Col).Value = sb.ToString()
        Me.Limpiar()
    End Sub
#End Region

#Region "Sección Inclusión"
    Private Function GetLineasTextBoxDocumentosIncluidos() As String()
        Return txtDocumentosIncluidos.Lines.Where(Function(w) w.Trim() <> "").ToArray()
    End Function
    Private Sub cbxClientesInclusion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClientesInclusion.SelectedIndexChanged
        Dim Id As Integer = cbxClientesInclusion.SelectedValue
        txtDocumentosIncluidos.Lines = Me.Incluidas.Where(Function(w) w.ClienteId = Id).Select(Function(s) s.NumeroDocumento).ToArray()
    End Sub
    Private Sub txtDocumentosIncluidos_TextChanged(sender As Object, e As EventArgs) Handles txtDocumentosIncluidos.TextChanged
        Dim sb As New StringBuilder()

        Dim result = GetLineasTextBoxDocumentosIncluidos()
        sb.Append(CStr(result.Count) + " Documento(s)")

        Dim rc = result.Distinct.Count()

        If (result.Count <> rc) Then
            sb.Append(", ").Append(rc).Append(" Distinto(s)")
        End If

        lblNumeroLineasTextBoxIncluidos.Text = sb.ToString()
    End Sub
    Private Sub cmdIncluir_Click(sender As Object, e As EventArgs) Handles cmdIncluir.Click
        Incluir()
    End Sub
    Private Sub cmdLimpiarIncluidos_Click(sender As Object, e As EventArgs) Handles cmdLimpiarIncluidos.Click
        LimpiarIncluidas()
    End Sub
    Private Sub cmdLimpiarTodosIncluidos_Click(sender As Object, e As EventArgs) Handles cmdLimpiarTodosIncluidos.Click
        LimpiarIncluidasTodas()
    End Sub
#End Region

#Region "Sección Exclusión"
    Private Function GetLineasTextBoxDocumentosExcluidos() As String()
        Return txtDocumentosExcluidos.Lines.Where(Function(w) w.Trim() <> "").ToArray()
    End Function
    Private Sub cbxClientesExclusion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClientesExclusion.SelectedIndexChanged
        Dim Id As Integer = cbxClientesExclusion.SelectedValue
        txtDocumentosExcluidos.Lines = Me.Excluidas.Where(Function(w) w.ClienteId = Id).Select(Function(s) s.NumeroDocumento).ToArray()
    End Sub
    Private Sub txtDocumentosExcluidos_TextChanged(sender As Object, e As EventArgs) Handles txtDocumentosExcluidos.TextChanged
        Dim sb As New StringBuilder()

        Dim result = GetLineasTextBoxDocumentosExcluidos()
        sb.Append(CStr(result.Count) + " Documento(s)")

        Dim rc = result.Distinct.Count()

        If (result.Count <> rc) Then
            sb.Append(", ").Append(rc).Append(" Distinto(s)")
        End If

        lblNumeroLineasTextBoxExcluidos.Text = sb.ToString()
    End Sub
    Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
        Excluir()
    End Sub
    Private Sub cmdLimpiarExcluidos_Click(sender As Object, e As EventArgs) Handles cmdLimpiarExcluidos.Click
        LimpiarExcluidas()
    End Sub
    Private Sub cmdLimpiarTodosExcluidos_Click(sender As Object, e As EventArgs) Handles cmdLimpiarTodosExcluidos.Click
        LimpiarExcluidasTodas()
    End Sub
#End Region

#Region "Metodos Consultar"
    Private Sub Limpiar(Optional full As Boolean = False)
        With dgvHabilitadas
            If (Not .DataSource Is Nothing) Then
                .DataSource = Nothing
            Else
                .Rows.Clear()
            End If
            If (Not bnHabilitadas.BindingSource Is Nothing) Then
                bnHabilitadas.BindingSource.DataSource = Nothing
            End If
        End With

        With dgvNoHabilitadas
            If (Not .DataSource Is Nothing) Then
                .DataSource = Nothing
            Else
                .Rows.Clear()
            End If
            If (Not bnNoHabilitadas.BindingSource Is Nothing) Then
                bnNoHabilitadas.BindingSource.DataSource = Nothing
            End If
        End With

        If (full) Then
            With dgvSeleccionadas
                If (Not .DataSource Is Nothing) Then
                    .DataSource = Nothing
                Else
                    .Rows.Clear()
                End If
                If (Not bnSeleccionadas.BindingSource Is Nothing) Then
                    bnSeleccionadas.BindingSource.DataSource = Nothing
                End If
            End With
        End If
    End Sub

    Private Sub Consultar(Optional alertar As Boolean = False)
        If (Not CheckParametrosConsultar(alertar)) Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Me.Lock(True)
        Me.Limpiar()
        Try
            Dim sql As String = GetSQLConsultaPrincipal()
            Dim sort As String = GetSort()

            Dim ciudadOrigenId As Integer = CInt(cbxCiudadOrigen.SelectedValue)

            Using connnection As New SqlConnection(My.Settings.SateliteConnectionString)
                connnection.Open()
                Using cmd As New SqlCommand(sql, connnection)
                    cmd.Parameters.AddWithValue("@ciudadId", ciudadOrigenId)

                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    DGV.Fill(dgvHabilitadas, ds.Tables(0), GetFiltroFijoHabilitadas(), sort, bnHabilitadas)
                    DGV.Fill(dgvNoHabilitadas, ds.Tables(0), GetFiltroFijoNoHabilitadas(), sort, bnNoHabilitadas)

                    If (dgvSeleccionadas.ColumnCount = 0) Then
                        DGV.CopyDefinition(dgvNoHabilitadas, dgvSeleccionadas, bnSeleccionadas)
                    End If

                End Using
            End Using

            Me.TabControlResultados.SelectedIndex = 0
            Me.TabControlResultados.SelectedIndex = 1
            Me.TabControlResultados.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Limpiar()
        Finally
            Me.Lock(False)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Shared Function GetFiltroFijoHabilitadas() As String
        Return String.Format("tipo_habilitacion NOT IN (2) And {0}", GetCondiciones())
    End Function

    Private Shared Function GetFiltroFijoNoHabilitadas() As String
        Return String.Format("tipo_habilitacion IN (2) Or Not {0}", GetCondiciones())
    End Function

    Private Shared Function GetCondiciones() As String
        Return "(condicion_estado_orden And condicion_estado_distribucion And condicion_requiere_servicio_distribucion And condicion_georeferenciacion And condicion_cita)"
    End Function

    Private Shared Function GetSort() As String
        Return "tipo_habilitacion, ciudad_ordinal, bodega_codigo, cliente_codigo, numero_orden"
    End Function

    Private Function GetSQLConsultaPrincipal() As String
        Dim sqlListaCeDiOrigen As String = GetSQLListaCeDiOrigen()
        Dim sqlListaClientes As String = GetSQLListaClientes()
        Dim sqlListaTiposServicio As String = GetSQLListaTiposServicio()
        Dim sqlListaCanales As String = GetSQLListaCanales()
        Dim sqlListaDepartamentos As String = GetSQLListaDepartamentos()
        Dim sqlListaCiudades As String = GetSQLListaCiudades()
        Dim sqlListaExcluidas As String = GetSQLListaExcluidas()
        Dim sqlListaIncluidas As String = GetSQLListaIncluidas()

        Dim FiltrarPorCeDi As Boolean = Not String.IsNullOrEmpty(sqlListaCeDiOrigen)
        Dim FiltrarPorCliente As Boolean = Not String.IsNullOrEmpty(sqlListaClientes)
        Dim FiltrarPorTipoServicio As Boolean = Not String.IsNullOrEmpty(sqlListaTiposServicio)
        Dim FiltrarPorCanal As Boolean = Not String.IsNullOrEmpty(sqlListaCanales)
        Dim FiltrarPorCiudadDestino As Boolean = (Not String.IsNullOrEmpty(sqlListaDepartamentos)) Or (Not String.IsNullOrEmpty(sqlListaCiudades))

        Dim NoPermitirOrdenesSinCeDiOrigen As Boolean = Not chkPermitirOrdenesSinCeDi.Checked
        Dim FiltrarSoloIncluirIncluidas As Boolean = chkSoloIncluidas.Checked

        Dim sql = My.Settings.CorteDistribucionSQLConsulta _
        .Replace("--@ListaCeDiOrigen", sqlListaCeDiOrigen) _
        .Replace("--@ListaClientes", sqlListaClientes) _
        .Replace("--@ListaTiposServicio", sqlListaTiposServicio) _
        .Replace("--@ListaCanales", sqlListaCanales) _
        .Replace("--@ListaDepartamentos", sqlListaDepartamentos) _
        .Replace("--@ListaCiudades", sqlListaCiudades) _
        .Replace("--@ListaExcluidas", sqlListaExcluidas) _
        .Replace("--@ListaIncluidas", sqlListaIncluidas)

        sql = sql.Replace(IIf(FiltrarPorCeDi, "--@FiltrarPorCeDi", "--@NoFiltrarPorCeDi"), "") _
        .Replace(IIf(FiltrarPorCliente, "--@FiltrarPorCliente", "--@NoFiltrarPorCliente"), "") _
        .Replace(IIf(FiltrarPorTipoServicio, "--@FiltrarPorTipoServicio", "--@NoFiltrarPorTipoServicio"), "") _
        .Replace(IIf(FiltrarPorCanal, "--@FiltrarPorCanal", "--@NoFiltrarPorCanal"), "") _
        .Replace(IIf(FiltrarPorCiudadDestino, "--@FiltrarPorCiudadDestino", "--@NoFiltrarPorCiudadDestino"), "") _
        .Replace(IIf(NoPermitirOrdenesSinCeDiOrigen, "--@NoPermitirOrdenesSinCeDiOrigen", "--@PermitirOrdenesSinCeDiOrigen"), "") _
        .Replace(IIf(FiltrarSoloIncluirIncluidas, "--@FiltrarSoloIncluirIncluidas", "--@NoFiltrarSoloIncluirIncluidas"), "")

        Debug.WriteLine(sql)

        Return sql
    End Function

    Private Function CheckParametrosConsultar(Optional alertar As Boolean = False) As Boolean
        Dim FechaEntrega As Date = dtpFechaSalidaRutas.Value
        Dim PermitirOrdenesSinCeDi As Boolean = chkPermitirOrdenesSinCeDi.Checked

        If (alertar) Then
            If (FechaEntrega.CompareTo(Date.Today.AddDays(30)) > 0) Then
                If (MsgBox(String.Format("La fecha de salida de las rutas {0: yyyy/MM/dd}, es muy distante de la fecha actual. ¿Esta seguro de realizar la programación para esta fecha?", FechaEntrega), vbYesNo) = MsgBoxResult.No) Then
                    Return False
                End If
            End If

            If (PermitirOrdenesSinCeDi) Then
                If (MsgBox("¿Esta seguro de incluir en el corte, órdenes sin Centro de Distribución Origen?", vbYesNo) = MsgBoxResult.No) Then
                    Return False
                End If
            End If

            If (lbxCeDis.SelectedItems.Count = 0) Then
                If (Not PermitirOrdenesSinCeDi) Then
                    If (Me.Incluidas.Count = 0) Then
                        MsgBox("Debe seleccionar uno o mas Centros de Distribución Origen.", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                End If
            End If
        End If

        Return True
    End Function
#End Region

#Region "Metodos Listas de valores para SQL Dinamico"
    Private Function GetSQLListaCeDiOrigen() As String
        Return GetSQLVALUESInt(lbxCeDis.SelectedItems, "id_bodega")
    End Function
    Private Function GetSQLListaClientes() As String
        Return GetSQLVALUESInt(lbxClientes.SelectedItems, "id_cliente")
    End Function
    Private Function GetSQLListaTiposServicio() As String
        Return GetSQLVALUESInt(lbxServicios.SelectedItems, "id_tipo_servicio")
    End Function
    Private Function GetSQLListaCanales() As String
        Return GetSQLVALUESInt(lbxCanales.SelectedItems, "id_canal")
    End Function
    Private Function GetSQLListaDepartamentos() As String
        Return GetSQLVALUESInt(lbxDepartamentosDestino.SelectedItems, "id_departamento")
    End Function
    Private Function GetSQLListaCiudades() As String
        Return GetSQLVALUESInt(lbxCiudadesDestino.SelectedItems, "id_ciudad")
    End Function
    Private Function GetSQLListaExcluidas() As String
        Dim builder As New StringBuilder
        For Each Row In Me.Excluidas.Where(Function(a) a.Existe And Not a.Incluida)
            builder.Append("(").Append(Row.OrdenId).Append("),").AppendLine()
        Next
        Return builder.ToString()
    End Function
    Private Function GetSQLListaIncluidas() As String
        Dim builder As New StringBuilder
        For Each Row In Me.Incluidas.Where(Function(a) a.Existe)
            builder.Append("(").Append(Row.OrdenId).Append("),").AppendLine()
        Next
        Return builder.ToString()
    End Function

#End Region

#Region "Metodos Sección Incluir"
    Private Sub LimpiarIncluidasTodas()
        Me.Incluidas = New List(Of DocumentoOrdenIncluida)
        FillIncluidas()
        FillIncluidasTotales()
        Me.Consultar()
    End Sub
    Private Sub LimpiarIncluidas()
        Dim clienteId As Integer = cbxClientesInclusion.SelectedValue

        ActualizarIncluidas(clienteId, New String() {})
        FillIncluidas()
        FillIncluidasTotales()
        Me.Consultar()
    End Sub
    Private Sub Incluir()
        Dim clienteId As Integer = cbxClientesInclusion.SelectedValue

        ActualizarIncluidas(clienteId, GetLineasTextBoxDocumentosIncluidos().Distinct.ToArray())
        FillIncluidas()
        FillIncluidasTotales()
        Me.Consultar()
    End Sub
    Private Sub ActualizarIncluidas(clienteId As Integer, NumerosDeOrden As String())
        Dim list = Me.Incluidas _
                    .Where(Function(s) s.ClienteId <> clienteId) _
                    .Union(NumerosDeOrden.Select(Function(s) New DocumentoOrdenIncluida(clienteId, s))) _
                    .ToList()

        Dim sql = DB.GetSQLActualizarIncluidasExcluidas(list)

        Debug.WriteLine(sql)

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                Dim incluidas As New List(Of DocumentoOrdenIncluida)
                For Each Row In ds.Tables(0).Rows
                    incluidas.Add(New DocumentoOrdenIncluida(Row("id_cliente"), Row("numero_orden"), Row("codigo"), Row("id_orden"), Row("existe")))
                Next

                Me.Incluidas = incluidas.OrderBy(Function(s) s.ClienteCodigo).ThenByDescending(Function(s) s.Existe).ThenBy(Function(s) s.NumeroDocumento).ToList()
            End Using
        End Using
    End Sub

    Private Sub FillIncluidas()
        With dgvIncluidas
            .DataSource = Me.Incluidas
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "Cliente"
            .Columns(3).HeaderText = "# Documento"
            .Columns(4).HeaderText = "Existe"
        End With
    End Sub

    Private Sub FillIncluidasTotales()
        Dim query = Me.Incluidas.
        GroupBy(Function(g) New With {Key g.ClienteCodigo}).
        Select(Function(group) New With
                    {
                        .ClienteCodigo = group.Key.ClienteCodigo,
                        .Existe = group.Sum(Function(s) IIf(s.Existe, 1, 0)),
                        .NoExiste = group.Sum(Function(s) IIf(s.Existe, 0, 1)),
                        .TotalCount = group.Count()
                    }) _
        .OrderBy(Function(s) s.ClienteCodigo) _
        .ToList()

        Dim queryRollup = query.Union(query.
        GroupBy(Function(g) New With {Key .ClienteCodigo = "TOTAL"}).
        Select(Function(group) New With
                    {
                        .ClienteCodigo = group.Key.ClienteCodigo,
                        .Existe = group.Sum(Function(s) s.Existe),
                        .NoExiste = group.Sum(Function(s) s.NoExiste),
                        .TotalCount = group.Sum(Function(s) s.TotalCount)
                    })).
        ToList()

        With dgvIncluidasTotales
            .DataSource = queryRollup
            .Columns(0).HeaderText = "Cliente"
            .Columns(1).HeaderText = "Existen"
            .Columns(2).HeaderText = "No Existen"
            .Columns(3).HeaderText = "Total"
            For i As Integer = 1 To 3
                .Columns(i).DefaultCellStyle.Format = "N0"
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next i
        End With
    End Sub
#End Region

#Region "Metodos Sección Excluir"
    Private Sub LimpiarExcluidasTodas()
        Me.Excluidas = New List(Of DocumentoOrdenExcluida)
        FillExcluidas()
        FillExcluidasTotales()
        Me.Consultar()
    End Sub

    Private Sub LimpiarExcluidas()
        Dim ClienteId As Integer = cbxClientesExclusion.SelectedValue

        ActualizarExcluidas(ClienteId, New String() {})
        FillExcluidas()
        FillExcluidasTotales()
        Me.Consultar()
    End Sub

    Private Sub Excluir()
        Dim ClienteId As Integer = cbxClientesExclusion.SelectedValue

        ActualizarExcluidas(ClienteId, GetLineasTextBoxDocumentosExcluidos().Distinct.ToArray())
        FillExcluidas()
        FillExcluidasTotales()
        Me.Consultar()
    End Sub

    Private Sub ActualizarExcluidas(ClienteId As Integer, NumerosDeOrden As String())
        Dim list = Me.Excluidas _
                    .Where(Function(s) s.ClienteId <> ClienteId) _
                    .Select(Function(s) New DocumentoOrdenIncluida(s.ClienteId, s.NumeroDocumento)) _
                    .Union(NumerosDeOrden.Select(Function(s) New DocumentoOrdenIncluida(ClienteId, s))) _
                    .ToList()

        Dim sql = GetSQLActualizarIncluidasExcluidas(list)

        Debug.WriteLine(sql)

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                Dim excluidas As New List(Of DocumentoOrdenIncluida)
                For Each Row In ds.Tables(0).Rows
                    excluidas.Add(New DocumentoOrdenIncluida(Row("id_cliente"), Row("numero_orden"), Row("codigo"), Row("id_orden"), Row("existe")))
                Next

                Dim comparer = New DocumentoOrdenClienteComparer()

                Dim result = excluidas.GroupJoin(Me.Incluidas.Where(Function(a) a.Existe),
                    Function(exc) exc,
                    Function(inc) inc,
                    Function(exc, inc) New DocumentoOrdenExcluida(exc.ClienteId, exc.NumeroDocumento, exc.ClienteCodigo, exc.OrdenId, exc.Existe, Not (inc.FirstOrDefault() Is Nothing)),
                    comparer) _
                    .OrderBy(Function(s) s.ClienteCodigo) _
                .ThenByDescending(Function(s) s.Existe) _
                .ThenByDescending(Function(s) s.Incluida) _
                .ThenBy(Function(s) s.NumeroDocumento) _
                .ToList()

                Me.Excluidas = result
            End Using
        End Using
    End Sub

    Private Sub FillExcluidas()
        With dgvExcluidas
            .DataSource = Me.Excluidas
            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(2).HeaderText = "Cliente"
            .Columns(3).HeaderText = "# Documento"
            .Columns(4).HeaderText = "Existe"
            .Columns(5).HeaderText = "Incluida"
        End With
    End Sub

    Private Sub FillExcluidasTotales()
        Dim query = Me.Excluidas.
        GroupBy(Function(g) New With {Key g.ClienteCodigo}).
        Select(Function(group) New With
                    {
                        .ClienteCodigo = group.Key.ClienteCodigo,
                        .Existe = group.Sum(Function(s) IIf(s.Existe, 1, 0)),
                        .NoExiste = group.Sum(Function(s) IIf(s.Existe, 0, 1)),
                        .Incluidas = group.Sum(Function(s) IIf(s.Incluida, 1, 0)),
                        .TotalCount = group.Count()
                    }) _
        .OrderBy(Function(s) s.ClienteCodigo) _
        .ToList()

        Dim queryRollup = query.Union(query.
        GroupBy(Function(g) New With {Key .ClienteCodigo = "TOTAL"}).
        Select(Function(group) New With
                    {
                        .ClienteCodigo = group.Key.ClienteCodigo,
                        .Existe = group.Sum(Function(s) s.Existe),
                        .NoExiste = group.Sum(Function(s) s.NoExiste),
                        .Incluidas = group.Sum(Function(s) s.Incluidas),
                        .TotalCount = group.Sum(Function(s) s.TotalCount)
                    })).
        ToList()

        With dgvExcluidasTotales
            .DataSource = queryRollup
            .Columns(0).HeaderText = "Cliente"
            .Columns(1).HeaderText = "Existen"
            .Columns(2).HeaderText = "No Existen"
            .Columns(3).HeaderText = "Incluidas"
            .Columns(4).HeaderText = "Total"
            For i As Integer = 2 To .Columns.Count - 1
                .Columns(i).DefaultCellStyle.Format = "N0"
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next i
        End With
    End Sub
#End Region

#Region "Metodos Exportar"
    Private Sub Exportar(nombreArchivo As String, guardar As Boolean)
        Dim export As Boolean = False

        Me.Lock(True)
        Try
            If (String.IsNullOrEmpty(nombreArchivo)) Then
                nombreArchivo = GenerarNombreCorte(Me.Usuario)
            End If

            Dim excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim wSheetPrimera As Microsoft.Office.Interop.Excel.Worksheet

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()
            wSheetPrimera = wSheet
            'Seleccionadas
            export = export Or ExportDGVToExcel(dgvSeleccionadas, wSheet, "SELECCIONADAS")
            'Habilitadas
            wSheet = wBook.Worksheets().Add(, wSheet)
            export = export Or ExportDGVToExcel(dgvHabilitadas, wSheet, "HABILITADAS")
            'No Habilitadas
            wSheet = wBook.Worksheets().Add(, wSheet)
            export = export Or ExportDGVToExcel(dgvNoHabilitadas, wSheet, "NO HABILITADAS")
            'Incluidas
            wSheet = wBook.Worksheets().Add(, wSheet)
            export = export Or ExportDGVToExcel(dgvIncluidas, wSheet, "INCLUIDAS")
            'Excluidas
            wSheet = wBook.Worksheets().Add(, wSheet)
            export = export Or ExportDGVToExcel(dgvExcluidas, wSheet, "EXCLUIDAS")

            wSheetPrimera.Select()

            If (export) Then
                If (guardar) Then
                    Dim dialog As New SaveFileDialog()

                    With dialog
                        .CheckPathExists = True
                        .DefaultExt = ".xlsx"
                        .FileName = nombreArchivo
                        .OverwritePrompt = True
                        If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                            wBook.SaveAs(.FileName)
                        End If
                    End With
                End If
                excel.Visible = True
            Else
                wBook.Saved = True
                wBook.Close()
                excel.Quit()
                MsgBox("No se encotraron datos para exportar.")
            End If

            wSheet = Nothing
            wBook = Nothing
            excel = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Lock(False)
        End Try
    End Sub
#End Region

#Region "Metodos Seleccion"
    Private Sub AgregarASeleccion(source As DataGridView, dest As DataGridView)
        If (source.SelectedRows.Count = 0) Then
            MsgBox("No hay registros seleccionados ")
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Dim bindingSource As BindingSource = dest.DataSource
        Dim table As DataTable = bindingSource.DataSource

        If (ToolStripTextBoxFiltroSeleccionadas.Text <> "") Then
            ToolStripTextBoxFiltroSeleccionadas.Text = ""
            'DGV.Filtrar(table, "", Me.FiltroVariableSeleccionadas, ToolStripTextBoxFiltroSeleccionadas.Text)
        End If

        dest.DataSource = Nothing
        For i As Integer = 0 To source.SelectedRows.Count - 1
            Dim Row As DataGridViewRow = source.SelectedRows(i)
            Dim found As Boolean = table.Rows.Cast(Of DataRow).Any(Function(r) r("id_orden").Equals(Row.Cells("id_orden").Value))

            If (Not found) Then
                Dim newRow As DataRow = table.NewRow()
                For j As Integer = 0 To source.Columns.Count - 1
                    Dim obj As Object = source.SelectedRows(i).Cells(j).Value
                    newRow(j) = obj
                Next
                table.Rows.Add(newRow)
            End If
        Next

        Fill(dest, table, "", "", bnSeleccionadas)
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

#Region "Metodos Confirmar"
    Private Sub Confirmar()
        Dim bodegaOrigenId As Integer? = GetBodegaOrigenRuta()

        If Not bodegaOrigenId.HasValue Then
            Return
        End If

        Using connection = New SqlConnection(My.Settings.SateliteConnectionString)
            connection.Open()

            Using transaction As SqlTransaction = connection.BeginTransaction()
                Try
                    Dim usuarioCorte As String = FileSystem.GetValidFileName(Me.Usuario)
                    Dim tipoCorteId As Integer = cbxTipoCortePlanificacionRuta.SelectedValue
                    Dim fechaSalidaRutas As Date = dtpFechaSalidaRutas.Value
                    Dim ciudadOrigenId As Integer = cbxCiudadOrigen.SelectedValue
                    Dim corteNombre As String = GenerarNombreCorte(usuarioCorte)
                    Dim corteId As Integer

                    corteId = CrearCorte(connection, transaction, corteNombre, tipoCorteId, fechaSalidaRutas, bodegaOrigenId, usuarioCorte)
                    AgregarAlCorte(connection, transaction, corteId)
                    GenerarSolicitudes(connection, transaction, corteId)
                    transaction.Commit()

                    Me.Exportar(corteNombre, False)
                    Me.Limpiar(True)
                Catch ex As Exception
                    Try
                        Debug.WriteLine("Rollback Exception Type: {0}", ex.GetType())
                        Debug.WriteLine("Message: {0}", ex.Message)
                        transaction.Rollback()
                    Catch e As Exception
                        ' This catch block will handle any errors that may have occurred
                        ' on the server that would cause the rollback to fail, such as
                        ' a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", e.GetType())
                        Console.WriteLine("  Message: {0}", e.Message)
                    Finally
                        MsgBox(String.Format("  Message: {0}", ex.Message))
                    End Try
                End Try
            End Using
        End Using
    End Sub

    Private Function GetBodegaOrigenRuta() As Integer?
        Dim bodegas = Me.Bodegas

        Dim bodegaId? As Integer = Nothing
        Select Case bodegas.Count
            Case 0
                MsgBox("No hay registros seleccionados")
            Case 1
                bodegaId = bodegas(0).Key
            Case Else
                If (SeleccionarBodegaOrigenRuta(bodegas)) Then
                    bodegaId = FormSeleccionBodegaOrigen.BodegaOrigenId
                End If
        End Select

        Return bodegaId
    End Function

    Private Function SeleccionarBodegaOrigenRuta(bodegas As List(Of KeyValueObject(Of Integer, String))) As Boolean
        FormSeleccionBodegaOrigen.Bodegas = bodegas
        Return (FormSeleccionBodegaOrigen.ShowDialog() = DialogResult.OK)
    End Function

    Private Function CrearCorte(connection As SqlConnection, transaction As SqlTransaction, corteNombre As String, tipoCorteId As Integer, fechaRuta As Date, BodegaOrigenRutaId As Integer, usuarioCorte As String) As Integer

        Dim sql As String = "tms.PlanificacionRutasCrearCorte"

        Using cmd = New SqlCommand(sql, connection, transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@corteNombre", corteNombre)
            cmd.Parameters.AddWithValue("@tipoCorteRutaId", tipoCorteId)
            cmd.Parameters.AddWithValue("@fechaRutas", fechaRuta)
            cmd.Parameters.AddWithValue("@bodegaOrigenId", BodegaOrigenRutaId)
            cmd.Parameters.AddWithValue("@usuarioCorte", usuarioCorte)

            Dim p As SqlParameter = cmd.Parameters.Add("@corteRutaId", SqlDbType.Int)
            p.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()

            Return p.Value
        End Using
    End Function

    Private Sub AgregarAlCorte(connection As SqlConnection, transaction As SqlTransaction, corteId As Integer)
        Dim sqlListaSeleccionadas As String = GetSQLListaSeleccionadas()

        Dim sql = My.Settings.CorteDistribucionSQLAgregarOrdenACorte _
        .Replace("--@ListaSeleccionadas", sqlListaSeleccionadas)

        Debug.WriteLine(sql)

        Using cmd = New SqlCommand(sql, connection, transaction)
            cmd.Parameters.AddWithValue("@corteId", corteId)

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Shared Sub GenerarSolicitudes(connection As SqlConnection, transaction As SqlTransaction, corteId As Integer)
        Dim sql As String = "tms.PlanificacionRutasGenerarSolicitudes"

        Using cmd = New SqlCommand(sql, connection, transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@corteId", corteId)

            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function GenerarNombreCorte(usuarioCorte As String) As String
        Dim fileName = FileSystem.GetValidFileName(usuarioCorte)
        Dim corteNombre = String.Format("{0:yyyy-MM-dd-HHmmss}-{1}-({2})", Date.Now(), usuarioCorte, GetListaClientesSeleccionados())

        If (corteNombre.Length > 200) Then
            corteNombre = corteNombre.Substring(0, 200)
        End If

        Return corteNombre
    End Function

    Private Function GetSQLListaSeleccionadas() As String
        Dim builder As New StringBuilder

        For Each row As DataGridViewRow In dgvSeleccionadas.Rows
            builder.Append("(").Append(row.Cells("id_orden").Value).Append("),").AppendLine()
        Next
        Return builder.ToString()
    End Function

    Private Function GetListaClientesSeleccionados() As String
        Dim lista As New List(Of String)

        For Each row As DataGridViewRow In dgvSeleccionadas.Rows
            lista.Add(row.Cells("cliente_codigo").Value)
        Next

        Return String.Join("-", lista.Distinct().OrderBy(Function(a) a).ToArray())
    End Function

#End Region

End Class
