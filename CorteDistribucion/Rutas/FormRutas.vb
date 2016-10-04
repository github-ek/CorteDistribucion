Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration
Imports CorteDistribucion
Imports System.Windows.Forms.ListBox
Imports DgvFilterPopup
Imports System.Net
Imports System.IO

Public Class FormRutas
    Private Loading As Boolean = False
    Private FiltroVariableHabilitadas As String = ""
    Private FiltroVariableSeleccionadas As String = ""

#Region "Propiedades"
    Public ReadOnly Property Usuario() As String
        Get
            Return Environment.UserName
        End Get
    End Property
#End Region

#Region "Metodos Load/Unload Formulario"
    Private Sub FormGestionRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Loading = True

            Me.ConstruirDGVFiltrosCorte()

            Listas.FillCiudades(Me.Usuario, cbxCiudadOrigen)

            Listas.FillCeDis(Me.cbxCiudadOrigen.SelectedValue, lbxCeDis)
            Listas.FillClientes(lbxClientes)
            Listas.FillServicios(lbxClientes, lbxServicios)
            Listas.FillCanales(lbxCanales)
            Listas.FillCiudades(lbxCiudadesDestino)
            Listas.FillDepartamentos(lbxDepartamentosDestino)

            Me.dtpFechaDesde.Value = Time.DiaPredeterminado
            Me.dtpFechaHasta.Value = Me.dtpFechaDesde.Value.AddDays(7)
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

        ToolStripButtonSeleccionarTodos.Enabled = Not lock
        ToolStripButtonInvertirSeleccion.Enabled = Not lock
        ToolStripButtonAgregarSeleccion.Enabled = Not lock

        ToolStripButtonSeleccionarTodosSeleccionados.Enabled = Not lock
        ToolStripButtonInvertirSeleccionSeleccionados.Enabled = Not lock
        ToolStripButtonRemoverSeleccion.Enabled = Not lock

        ToolStripButtonAcciones.Enabled = Not lock
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

    'Private Sub ToolStripButtonConfirmar_Click(sender As Object, e As EventArgs) Handles ToolStripButtonConfirmar.Click
    '    Me.Cursor = Cursors.WaitCursor
    '    Confirmar()
    '    Me.Cursor = Cursors.Default
    'End Sub

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

    Private Sub ToolStripTextBoxFiltroSeleccionadas_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBoxFiltroSeleccionadas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            DGV.Filtrar(dgvSeleccionadas, "", Me.FiltroVariableSeleccionadas, ToolStripTextBoxFiltroSeleccionadas.Text)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ImprimirPlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirPlanillaToolStripMenuItem.Click
        ImprimirPlanillaRuta()
    End Sub

    Private Sub CambiarAPlanilladaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarAPlanilladaToolStripMenuItem.Click
        CambiarAPLANILLADA()
    End Sub

#End Region

#Region "Seccion Filtros"

    Private Sub dtpFechaDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesde.ValueChanged
        Me.Limpiar()
    End Sub

    Private Sub dtpFechaHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaHasta.ValueChanged
        Me.Limpiar()
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
            Dim FechaDesde As Date = dtpFechaDesde.Value
            Dim FechaHasta As Date = dtpFechaHasta.Value


            Using connnection As New SqlConnection(My.Settings.SateliteConnectionString)
                connnection.Open()
                Using cmd As New SqlCommand(sql, connnection)
                    cmd.Parameters.AddWithValue("@ciudadId", ciudadOrigenId)
                    cmd.Parameters.AddWithValue("@fechaDesde", FechaDesde)
                    cmd.Parameters.AddWithValue("@fechaHasta", FechaHasta)

                    Dim da = New SqlDataAdapter(cmd)
                    Dim ds = New DataSet()
                    da.Fill(ds)
                    DGV.Fill(dgvHabilitadas, ds.Tables(0), GetFiltroFijoHabilitadas(), sort, bnHabilitadas)
                    If (dgvSeleccionadas.ColumnCount = 0) Then
                        DGV.CopyDefinition(dgvHabilitadas, dgvSeleccionadas, bnSeleccionadas)
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
        Return String.Format("{0}", GetCondiciones())
    End Function

    Private Shared Function GetCondiciones() As String
        Return "(1 = 1)"
    End Function

    Private Shared Function GetSort() As String
        Return "bodega_origen_codigo, numero_ruta"
    End Function

    Private Function GetSQLConsultaPrincipal() As String
        Dim sqlListaCeDiOrigen As String = GetSQLListaCeDiOrigen()
        Dim sqlListaClientes As String = GetSQLListaClientes()
        Dim sqlListaTiposServicio As String = GetSQLListaTiposServicio()
        Dim sqlListaCanales As String = GetSQLListaCanales()
        Dim sqlListaDepartamentos As String = GetSQLListaDepartamentos()
        Dim sqlListaCiudades As String = GetSQLListaCiudades()

        Dim FiltrarPorCeDi As Boolean = Not String.IsNullOrEmpty(sqlListaCeDiOrigen)
        Dim FiltrarPorCliente As Boolean = Not String.IsNullOrEmpty(sqlListaClientes)
        Dim FiltrarPorTipoServicio As Boolean = Not String.IsNullOrEmpty(sqlListaTiposServicio)
        Dim FiltrarPorCanal As Boolean = Not String.IsNullOrEmpty(sqlListaCanales)
        Dim FiltrarPorCiudadDestino As Boolean = (Not String.IsNullOrEmpty(sqlListaDepartamentos)) Or (Not String.IsNullOrEmpty(sqlListaCiudades))

        Dim sql = My.Settings.RutasSQLConsulta _
        .Replace("--@ListaCeDiOrigen", sqlListaCeDiOrigen) _
        .Replace("--@ListaClientes", sqlListaClientes) _
        .Replace("--@ListaTiposServicio", sqlListaTiposServicio) _
        .Replace("--@ListaCanales", sqlListaCanales) _
        .Replace("--@ListaDepartamentos", sqlListaDepartamentos) _
        .Replace("--@ListaCiudades", sqlListaCiudades)

        sql = sql.Replace(IIf(FiltrarPorCeDi, "--@FiltrarPorCeDi", "--@NoFiltrarPorCeDi"), "") _
        .Replace(IIf(FiltrarPorCliente, "--@FiltrarPorCliente", "--@NoFiltrarPorCliente"), "") _
        .Replace(IIf(FiltrarPorTipoServicio, "--@FiltrarPorTipoServicio", "--@NoFiltrarPorTipoServicio"), "") _
        .Replace(IIf(FiltrarPorCanal, "--@FiltrarPorCanal", "--@NoFiltrarPorCanal"), "") _
        .Replace(IIf(FiltrarPorCiudadDestino, "--@FiltrarPorCiudadDestino", "--@NoFiltrarPorCiudadDestino"), "")

        Debug.WriteLine(sql)

        Return sql
    End Function

    Private Function CheckParametrosConsultar(Optional alertar As Boolean = False) As Boolean
        Dim FechaDesde As Date = dtpFechaDesde.Value
        Dim FechaHasta As Date = dtpFechaHasta.Value

        If (alertar) Then
            If (FechaDesde > FechaHasta) Then
                MsgBox(String.Format("El intervalo de fechas dado no es consistente. La fecha desde debe ser menor o igual que la fecha hasta"), MsgBoxStyle.Exclamation)
                Return False
            End If

            If (FechaDesde.CompareTo(Date.Today.AddDays(-30)) < 0 Or FechaHasta.CompareTo(Date.Today.AddDays(30)) > 0) Then
                If (MsgBox(String.Format("El intervalo es muy amplio. ¿Esta seguro de realizar la consulta?", FechaHasta), vbYesNo) = MsgBoxResult.No) Then
                    Return False
                End If
            End If
        End If

        If (lbxCeDis.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar uno o mas Centros de Distribución Origen.", MsgBoxStyle.Exclamation)
            Return False
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
            Dim found As Boolean = table.Rows.Cast(Of DataRow).Any(Function(r) r("id_ruta").Equals(Row.Cells("id_ruta").Value))

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
        Dim list = source.SelectedRows.Cast(Of DataGridViewRow).Select(Function(row) row.Cells("id_ruta").Value).ToList()

        Dim bindingSource As BindingSource = source.DataSource
        Dim table As DataTable = bindingSource.DataSource

        source.DataSource = Nothing
        For Each id In list
            Dim row = table.Rows.Cast(Of DataRow).Where(Function(r) r("id_ruta").Equals(id)).First()

            table.Rows.Remove(row)
        Next

        Fill(source, table, "", "", bnSeleccionadas)
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Metodos Asignar"
    'Private Sub Confirmar()
    '    If dgvSeleccionadas.RowCount = 0 Then
    '        MsgBox("No hay registros seleccionados")
    '        Return
    '    End If

    '    Dim form As New FormAsignarCita()
    '    form.data = dgvSeleccionadas
    '    If (form.ShowDialog() = DialogResult.OK) Then
    '        dgvSeleccionadas.SelectAll()
    '        RemoverDeSeleccion(dgvSeleccionadas)
    '        Me.Consultar()
    '    End If
    'End Sub

    Private Function GenerarNombreCorte(usuarioCorte As String) As String
        Dim fileName = FileSystem.GetValidFileName(usuarioCorte)
        Dim corteNombre = String.Format("{0:yyyy-MM-dd-HHmmss}-{1}", Date.Now(), usuarioCorte)

        If (corteNombre.Length > 200) Then
            corteNombre = corteNombre.Substring(0, 200)
        End If

        Return corteNombre
    End Function

    Private Sub ImprimirPlanillaRuta()
        Dim WC As New System.Net.WebClient

        For Each row As DataGridViewRow In dgvSeleccionadas.Rows
            Dim url As String = My.Settings.URLReportePlanillaRuta + row.Cells("numero_ruta").Value
            System.Diagnostics.Process.Start("Firefox.exe", url)
            'Dim fileName = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData + "\\" + FileSystem.GetValidFileName(row.Cells("numero_ruta").Value) + ".pdf"
            'WC.DownloadFile(url, fileName)
            'WC.DownloadData(url)
            'GetFileStream(url)
        Next
    End Sub
    Private Sub CambiarAPLANILLADA()
        Me.Cursor = Cursors.WaitCursor
        Try
            Using connection = New SqlConnection(My.Settings.SateliteConnectionString)
                connection.Open()
                Using transaction = connection.BeginTransaction()
                    Dim sql As String = "tms.PlanillarRuta"
                    Using cmd = New SqlCommand(sql, connection, transaction)
                        cmd.CommandType = CommandType.StoredProcedure

                        For Each row As DataGridViewRow In dgvSeleccionadas.Rows
                            If row.Cells("id_estado_ruta").Value = "PLANIFICADA" Or row.Cells("id_estado_ruta").Value = "PLANILLADA" Then
                                DB.SQL_tms_PlanillarRuta(row.Cells("id_ruta").Value, Me.Usuario, cmd)
                                row.DefaultCellStyle.BackColor = Color.LightGreen
                            Else
                                row.DefaultCellStyle.BackColor = Color.LightPink
                            End If
                        Next
                    End Using
                    transaction.Commit()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

End Class
