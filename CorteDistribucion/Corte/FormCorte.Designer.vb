<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCorte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TabControlCriterios As System.Windows.Forms.TabControl
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TableLayoutPanelInclusion As System.Windows.Forms.TableLayoutPanel
        Dim TableLayoutPanelExclusion As System.Windows.Forms.TableLayoutPanel
        Dim FlowLayoutPanelComandos As System.Windows.Forms.FlowLayoutPanel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCorte))
        Me.TabPageFiltros = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControlFiltros = New System.Windows.Forms.TabControl()
        Me.TabPageFiltroCeDi = New System.Windows.Forms.TabPage()
        Me.lbxCeDis = New System.Windows.Forms.ListBox()
        Me.TabPageFiltroClientes = New System.Windows.Forms.TabPage()
        Me.lbxClientes = New System.Windows.Forms.ListBox()
        Me.TabPageFiltroServicios = New System.Windows.Forms.TabPage()
        Me.lbxServicios = New System.Windows.Forms.ListBox()
        Me.TabPageFiltroCanales = New System.Windows.Forms.TabPage()
        Me.lbxCanales = New System.Windows.Forms.ListBox()
        Me.TabPageFiltroCiudadesDestino = New System.Windows.Forms.TabPage()
        Me.lbxCiudadesDestino = New System.Windows.Forms.ListBox()
        Me.TabPageFiltroDepartamentosDestino = New System.Windows.Forms.TabPage()
        Me.lbxDepartamentosDestino = New System.Windows.Forms.ListBox()
        Me.dgvFiltros = New System.Windows.Forms.DataGridView()
        Me.Campo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seleccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPageInclusion = New System.Windows.Forms.TabPage()
        Me.cmdLimpiarTodosIncluidos = New System.Windows.Forms.Button()
        Me.cmdLimpiarIncluidos = New System.Windows.Forms.Button()
        Me.txtDocumentosIncluidos = New System.Windows.Forms.TextBox()
        Me.cbxClientesInclusion = New System.Windows.Forms.ComboBox()
        Me.lblClientesIncluidos = New System.Windows.Forms.Label()
        Me.dgvIncluidasTotales = New System.Windows.Forms.DataGridView()
        Me.dgvIncluidas = New System.Windows.Forms.DataGridView()
        Me.cmdIncluir = New System.Windows.Forms.Button()
        Me.lblNumeroLineasTextBoxIncluidos = New System.Windows.Forms.Label()
        Me.TabPageExclusion = New System.Windows.Forms.TabPage()
        Me.cmdLimpiarExcluidos = New System.Windows.Forms.Button()
        Me.txtDocumentosExcluidos = New System.Windows.Forms.TextBox()
        Me.cbxClientesExclusion = New System.Windows.Forms.ComboBox()
        Me.lblClientesExcluidos = New System.Windows.Forms.Label()
        Me.dgvExcluidasTotales = New System.Windows.Forms.DataGridView()
        Me.dgvExcluidas = New System.Windows.Forms.DataGridView()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.lblNumeroLineasTextBoxExcluidos = New System.Windows.Forms.Label()
        Me.cmdLimpiarTodosExcluidos = New System.Windows.Forms.Button()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.dtpFechaSalidaRutas = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaEntrega = New System.Windows.Forms.Label()
        Me.lblTotalCorte = New System.Windows.Forms.Label()
        Me.cbxCiudadOrigen = New System.Windows.Forms.ComboBox()
        Me.lblCiudadOrigen = New System.Windows.Forms.Label()
        Me.TableLayoutPanelMainTop = New System.Windows.Forms.TableLayoutPanel()
        Me.chkSoloIncluidas = New System.Windows.Forms.CheckBox()
        Me.chkPermitirOrdenesSinCeDi = New System.Windows.Forms.CheckBox()
        Me.lblTipoCorte = New System.Windows.Forms.Label()
        Me.cbxTipoCortePlanificacionRuta = New System.Windows.Forms.ComboBox()
        Me.SplitContainerMainFill = New System.Windows.Forms.SplitContainer()
        Me.TabControlResultados = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvHabilitadas = New System.Windows.Forms.DataGridView()
        Me.bnHabilitadas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelFiltrarHabilitadas = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxFiltroHabilitadas = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSeleccionarTodos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonInvertirSeleccion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonAgregarSeleccion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvNoHabilitadas = New System.Windows.Forms.DataGridView()
        Me.bnNoHabilitadas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelFiltrarNoHabilitadas = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxFiltroNoHabilitadas = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bnSeleccionadas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabelFiltrarSeleccionadas = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxFiltroSeleccionadas = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonConfirmar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSeleccionarTodosSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonInvertirSeleccionSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonRemoverSeleccion = New System.Windows.Forms.ToolStripButton()
        Me.dgvSeleccionadas = New System.Windows.Forms.DataGridView()
        TabControlCriterios = New System.Windows.Forms.TabControl()
        TableLayoutPanelInclusion = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanelExclusion = New System.Windows.Forms.TableLayoutPanel()
        FlowLayoutPanelComandos = New System.Windows.Forms.FlowLayoutPanel()
        TabControlCriterios.SuspendLayout()
        Me.TabPageFiltros.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControlFiltros.SuspendLayout()
        Me.TabPageFiltroCeDi.SuspendLayout()
        Me.TabPageFiltroClientes.SuspendLayout()
        Me.TabPageFiltroServicios.SuspendLayout()
        Me.TabPageFiltroCanales.SuspendLayout()
        Me.TabPageFiltroCiudadesDestino.SuspendLayout()
        Me.TabPageFiltroDepartamentosDestino.SuspendLayout()
        CType(Me.dgvFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageInclusion.SuspendLayout()
        TableLayoutPanelInclusion.SuspendLayout()
        CType(Me.dgvIncluidasTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIncluidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageExclusion.SuspendLayout()
        TableLayoutPanelExclusion.SuspendLayout()
        CType(Me.dgvExcluidasTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExcluidas, System.ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanelComandos.SuspendLayout()
        Me.TableLayoutPanelMainTop.SuspendLayout()
        CType(Me.SplitContainerMainFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMainFill.Panel1.SuspendLayout()
        Me.SplitContainerMainFill.Panel2.SuspendLayout()
        Me.SplitContainerMainFill.SuspendLayout()
        Me.TabControlResultados.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvHabilitadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnHabilitadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnHabilitadas.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgvNoHabilitadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnNoHabilitadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnNoHabilitadas.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.bnSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnSeleccionadas.SuspendLayout()
        CType(Me.dgvSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlCriterios
        '
        TabControlCriterios.Controls.Add(Me.TabPageFiltros)
        TabControlCriterios.Controls.Add(Me.TabPageInclusion)
        TabControlCriterios.Controls.Add(Me.TabPageExclusion)
        TabControlCriterios.Dock = System.Windows.Forms.DockStyle.Fill
        TabControlCriterios.Location = New System.Drawing.Point(0, 0)
        TabControlCriterios.Name = "TabControlCriterios"
        TabControlCriterios.SelectedIndex = 0
        TabControlCriterios.ShowToolTips = True
        TabControlCriterios.Size = New System.Drawing.Size(987, 210)
        TabControlCriterios.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        TabControlCriterios.TabIndex = 26
        '
        'TabPageFiltros
        '
        Me.TabPageFiltros.Controls.Add(Me.SplitContainer2)
        Me.TabPageFiltros.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFiltros.Name = "TabPageFiltros"
        Me.TabPageFiltros.Padding = New System.Windows.Forms.Padding(10)
        Me.TabPageFiltros.Size = New System.Drawing.Size(979, 184)
        Me.TabPageFiltros.TabIndex = 0
        Me.TabPageFiltros.Text = "Filtros"
        Me.TabPageFiltros.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(10, 10)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControlFiltros)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvFiltros)
        Me.SplitContainer2.Size = New System.Drawing.Size(959, 164)
        Me.SplitContainer2.SplitterDistance = 318
        Me.SplitContainer2.TabIndex = 20
        '
        'TabControlFiltros
        '
        Me.TabControlFiltros.Controls.Add(Me.TabPageFiltroCeDi)
        Me.TabControlFiltros.Controls.Add(Me.TabPageFiltroClientes)
        Me.TabControlFiltros.Controls.Add(Me.TabPageFiltroServicios)
        Me.TabControlFiltros.Controls.Add(Me.TabPageFiltroCanales)
        Me.TabControlFiltros.Controls.Add(Me.TabPageFiltroCiudadesDestino)
        Me.TabControlFiltros.Controls.Add(Me.TabPageFiltroDepartamentosDestino)
        Me.TabControlFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlFiltros.HotTrack = True
        Me.TabControlFiltros.Location = New System.Drawing.Point(0, 0)
        Me.TabControlFiltros.Name = "TabControlFiltros"
        Me.TabControlFiltros.SelectedIndex = 0
        Me.TabControlFiltros.Size = New System.Drawing.Size(318, 164)
        Me.TabControlFiltros.TabIndex = 19
        '
        'TabPageFiltroCeDi
        '
        Me.TabPageFiltroCeDi.Controls.Add(Me.lbxCeDis)
        Me.TabPageFiltroCeDi.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFiltroCeDi.Name = "TabPageFiltroCeDi"
        Me.TabPageFiltroCeDi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFiltroCeDi.Size = New System.Drawing.Size(310, 138)
        Me.TabPageFiltroCeDi.TabIndex = 0
        Me.TabPageFiltroCeDi.Text = "CeDi"
        Me.TabPageFiltroCeDi.UseVisualStyleBackColor = True
        '
        'lbxCeDis
        '
        Me.lbxCeDis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxCeDis.FormattingEnabled = True
        Me.lbxCeDis.HorizontalScrollbar = True
        Me.lbxCeDis.Location = New System.Drawing.Point(3, 3)
        Me.lbxCeDis.Name = "lbxCeDis"
        Me.lbxCeDis.ScrollAlwaysVisible = True
        Me.lbxCeDis.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxCeDis.Size = New System.Drawing.Size(304, 132)
        Me.lbxCeDis.TabIndex = 3
        '
        'TabPageFiltroClientes
        '
        Me.TabPageFiltroClientes.Controls.Add(Me.lbxClientes)
        Me.TabPageFiltroClientes.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFiltroClientes.Name = "TabPageFiltroClientes"
        Me.TabPageFiltroClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFiltroClientes.Size = New System.Drawing.Size(310, 138)
        Me.TabPageFiltroClientes.TabIndex = 1
        Me.TabPageFiltroClientes.Text = "Clientes"
        Me.TabPageFiltroClientes.UseVisualStyleBackColor = True
        '
        'lbxClientes
        '
        Me.lbxClientes.DisplayMember = "id_cliente"
        Me.lbxClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxClientes.FormattingEnabled = True
        Me.lbxClientes.HorizontalScrollbar = True
        Me.lbxClientes.Location = New System.Drawing.Point(3, 3)
        Me.lbxClientes.Name = "lbxClientes"
        Me.lbxClientes.ScrollAlwaysVisible = True
        Me.lbxClientes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxClientes.Size = New System.Drawing.Size(304, 132)
        Me.lbxClientes.TabIndex = 5
        Me.lbxClientes.ValueMember = "id_cliente"
        '
        'TabPageFiltroServicios
        '
        Me.TabPageFiltroServicios.Controls.Add(Me.lbxServicios)
        Me.TabPageFiltroServicios.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFiltroServicios.Name = "TabPageFiltroServicios"
        Me.TabPageFiltroServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFiltroServicios.Size = New System.Drawing.Size(310, 138)
        Me.TabPageFiltroServicios.TabIndex = 2
        Me.TabPageFiltroServicios.Text = "Servicios"
        Me.TabPageFiltroServicios.UseVisualStyleBackColor = True
        '
        'lbxServicios
        '
        Me.lbxServicios.DisplayMember = "id_tipo_servicio"
        Me.lbxServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxServicios.FormattingEnabled = True
        Me.lbxServicios.HorizontalScrollbar = True
        Me.lbxServicios.Location = New System.Drawing.Point(3, 3)
        Me.lbxServicios.Name = "lbxServicios"
        Me.lbxServicios.ScrollAlwaysVisible = True
        Me.lbxServicios.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxServicios.Size = New System.Drawing.Size(304, 132)
        Me.lbxServicios.TabIndex = 5
        Me.lbxServicios.ValueMember = "id_tipo_servicio"
        '
        'TabPageFiltroCanales
        '
        Me.TabPageFiltroCanales.Controls.Add(Me.lbxCanales)
        Me.TabPageFiltroCanales.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFiltroCanales.Name = "TabPageFiltroCanales"
        Me.TabPageFiltroCanales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFiltroCanales.Size = New System.Drawing.Size(310, 138)
        Me.TabPageFiltroCanales.TabIndex = 3
        Me.TabPageFiltroCanales.Text = "Canales"
        Me.TabPageFiltroCanales.UseVisualStyleBackColor = True
        '
        'lbxCanales
        '
        Me.lbxCanales.DisplayMember = "id_segmento"
        Me.lbxCanales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxCanales.FormattingEnabled = True
        Me.lbxCanales.HorizontalScrollbar = True
        Me.lbxCanales.Location = New System.Drawing.Point(3, 3)
        Me.lbxCanales.Name = "lbxCanales"
        Me.lbxCanales.ScrollAlwaysVisible = True
        Me.lbxCanales.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxCanales.Size = New System.Drawing.Size(304, 132)
        Me.lbxCanales.TabIndex = 6
        Me.lbxCanales.ValueMember = "id_segmento"
        '
        'TabPageFiltroCiudadesDestino
        '
        Me.TabPageFiltroCiudadesDestino.Controls.Add(Me.lbxCiudadesDestino)
        Me.TabPageFiltroCiudadesDestino.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFiltroCiudadesDestino.Name = "TabPageFiltroCiudadesDestino"
        Me.TabPageFiltroCiudadesDestino.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFiltroCiudadesDestino.Size = New System.Drawing.Size(310, 138)
        Me.TabPageFiltroCiudadesDestino.TabIndex = 4
        Me.TabPageFiltroCiudadesDestino.Text = "Ciudades Dest."
        Me.TabPageFiltroCiudadesDestino.UseVisualStyleBackColor = True
        '
        'lbxCiudadesDestino
        '
        Me.lbxCiudadesDestino.DisplayMember = "id_ciudad"
        Me.lbxCiudadesDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxCiudadesDestino.FormattingEnabled = True
        Me.lbxCiudadesDestino.HorizontalScrollbar = True
        Me.lbxCiudadesDestino.Location = New System.Drawing.Point(3, 3)
        Me.lbxCiudadesDestino.Name = "lbxCiudadesDestino"
        Me.lbxCiudadesDestino.ScrollAlwaysVisible = True
        Me.lbxCiudadesDestino.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxCiudadesDestino.Size = New System.Drawing.Size(304, 132)
        Me.lbxCiudadesDestino.TabIndex = 20
        Me.lbxCiudadesDestino.ValueMember = "id_ciudad"
        '
        'TabPageFiltroDepartamentosDestino
        '
        Me.TabPageFiltroDepartamentosDestino.Controls.Add(Me.lbxDepartamentosDestino)
        Me.TabPageFiltroDepartamentosDestino.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFiltroDepartamentosDestino.Name = "TabPageFiltroDepartamentosDestino"
        Me.TabPageFiltroDepartamentosDestino.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFiltroDepartamentosDestino.Size = New System.Drawing.Size(310, 138)
        Me.TabPageFiltroDepartamentosDestino.TabIndex = 5
        Me.TabPageFiltroDepartamentosDestino.Text = "Departamentos Dest."
        Me.TabPageFiltroDepartamentosDestino.UseVisualStyleBackColor = True
        '
        'lbxDepartamentosDestino
        '
        Me.lbxDepartamentosDestino.DisplayMember = "codigo"
        Me.lbxDepartamentosDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxDepartamentosDestino.FormattingEnabled = True
        Me.lbxDepartamentosDestino.HorizontalScrollbar = True
        Me.lbxDepartamentosDestino.Location = New System.Drawing.Point(3, 3)
        Me.lbxDepartamentosDestino.Name = "lbxDepartamentosDestino"
        Me.lbxDepartamentosDestino.ScrollAlwaysVisible = True
        Me.lbxDepartamentosDestino.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbxDepartamentosDestino.Size = New System.Drawing.Size(304, 132)
        Me.lbxDepartamentosDestino.TabIndex = 21
        Me.lbxDepartamentosDestino.ValueMember = "codigo"
        '
        'dgvFiltros
        '
        Me.dgvFiltros.AllowUserToAddRows = False
        Me.dgvFiltros.AllowUserToDeleteRows = False
        Me.dgvFiltros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFiltros.CausesValidation = False
        Me.dgvFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiltros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Campo, Me.Seleccion})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFiltros.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFiltros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvFiltros.Location = New System.Drawing.Point(0, 0)
        Me.dgvFiltros.MultiSelect = False
        Me.dgvFiltros.Name = "dgvFiltros"
        Me.dgvFiltros.ReadOnly = True
        Me.dgvFiltros.ShowEditingIcon = False
        Me.dgvFiltros.Size = New System.Drawing.Size(637, 164)
        Me.dgvFiltros.TabIndex = 10
        '
        'Campo
        '
        Me.Campo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Campo.HeaderText = "Campo"
        Me.Campo.Name = "Campo"
        Me.Campo.ReadOnly = True
        Me.Campo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Campo.Width = 200
        '
        'Seleccion
        '
        Me.Seleccion.HeaderText = "Seleccion"
        Me.Seleccion.Name = "Seleccion"
        Me.Seleccion.ReadOnly = True
        Me.Seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Seleccion.Width = 447
        '
        'TabPageInclusion
        '
        Me.TabPageInclusion.Controls.Add(TableLayoutPanelInclusion)
        Me.TabPageInclusion.Location = New System.Drawing.Point(4, 22)
        Me.TabPageInclusion.Name = "TabPageInclusion"
        Me.TabPageInclusion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInclusion.Size = New System.Drawing.Size(979, 184)
        Me.TabPageInclusion.TabIndex = 1
        Me.TabPageInclusion.Text = "Inclusión"
        Me.TabPageInclusion.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelInclusion
        '
        TableLayoutPanelInclusion.AutoSize = True
        TableLayoutPanelInclusion.ColumnCount = 5
        TableLayoutPanelInclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        TableLayoutPanelInclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        TableLayoutPanelInclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        TableLayoutPanelInclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        TableLayoutPanelInclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        TableLayoutPanelInclusion.Controls.Add(Me.cmdLimpiarTodosIncluidos, 2, 4)
        TableLayoutPanelInclusion.Controls.Add(Me.cmdLimpiarIncluidos, 1, 4)
        TableLayoutPanelInclusion.Controls.Add(Me.txtDocumentosIncluidos, 0, 2)
        TableLayoutPanelInclusion.Controls.Add(Me.cbxClientesInclusion, 0, 1)
        TableLayoutPanelInclusion.Controls.Add(Me.lblClientesIncluidos, 0, 0)
        TableLayoutPanelInclusion.Controls.Add(Me.dgvIncluidasTotales, 4, 0)
        TableLayoutPanelInclusion.Controls.Add(Me.dgvIncluidas, 3, 0)
        TableLayoutPanelInclusion.Controls.Add(Me.cmdIncluir, 0, 4)
        TableLayoutPanelInclusion.Controls.Add(Me.lblNumeroLineasTextBoxIncluidos, 0, 3)
        TableLayoutPanelInclusion.Dock = System.Windows.Forms.DockStyle.Fill
        TableLayoutPanelInclusion.Location = New System.Drawing.Point(3, 3)
        TableLayoutPanelInclusion.Name = "TableLayoutPanelInclusion"
        TableLayoutPanelInclusion.RowCount = 5
        TableLayoutPanelInclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelInclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelInclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanelInclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelInclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelInclusion.Size = New System.Drawing.Size(973, 178)
        TableLayoutPanelInclusion.TabIndex = 0
        '
        'cmdLimpiarTodosIncluidos
        '
        Me.cmdLimpiarTodosIncluidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiarTodosIncluidos.Location = New System.Drawing.Point(215, 152)
        Me.cmdLimpiarTodosIncluidos.Name = "cmdLimpiarTodosIncluidos"
        Me.cmdLimpiarTodosIncluidos.Size = New System.Drawing.Size(79, 23)
        Me.cmdLimpiarTodosIncluidos.TabIndex = 48
        Me.cmdLimpiarTodosIncluidos.Text = "Limpiar T"
        Me.cmdLimpiarTodosIncluidos.UseVisualStyleBackColor = True
        '
        'cmdLimpiarIncluidos
        '
        Me.cmdLimpiarIncluidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiarIncluidos.Location = New System.Drawing.Point(109, 152)
        Me.cmdLimpiarIncluidos.Name = "cmdLimpiarIncluidos"
        Me.cmdLimpiarIncluidos.Size = New System.Drawing.Size(79, 23)
        Me.cmdLimpiarIncluidos.TabIndex = 47
        Me.cmdLimpiarIncluidos.Text = "Limpiar"
        Me.cmdLimpiarIncluidos.UseVisualStyleBackColor = True
        '
        'txtDocumentosIncluidos
        '
        Me.txtDocumentosIncluidos.AcceptsReturn = True
        Me.txtDocumentosIncluidos.AcceptsTab = True
        Me.txtDocumentosIncluidos.AllowDrop = True
        Me.txtDocumentosIncluidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        TableLayoutPanelInclusion.SetColumnSpan(Me.txtDocumentosIncluidos, 3)
        Me.txtDocumentosIncluidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDocumentosIncluidos.Location = New System.Drawing.Point(3, 63)
        Me.txtDocumentosIncluidos.Multiline = True
        Me.txtDocumentosIncluidos.Name = "txtDocumentosIncluidos"
        Me.txtDocumentosIncluidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocumentosIncluidos.Size = New System.Drawing.Size(312, 52)
        Me.txtDocumentosIncluidos.TabIndex = 45
        Me.txtDocumentosIncluidos.WordWrap = False
        '
        'cbxClientesInclusion
        '
        Me.cbxClientesInclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxClientesInclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        TableLayoutPanelInclusion.SetColumnSpan(Me.cbxClientesInclusion, 3)
        Me.cbxClientesInclusion.DisplayMember = "id_cliente"
        Me.cbxClientesInclusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxClientesInclusion.FormattingEnabled = True
        Me.cbxClientesInclusion.IntegralHeight = False
        Me.cbxClientesInclusion.Location = New System.Drawing.Point(3, 33)
        Me.cbxClientesInclusion.MaxDropDownItems = 10
        Me.cbxClientesInclusion.Name = "cbxClientesInclusion"
        Me.cbxClientesInclusion.Size = New System.Drawing.Size(312, 21)
        Me.cbxClientesInclusion.TabIndex = 44
        Me.cbxClientesInclusion.ValueMember = "id_cliente"
        '
        'lblClientesIncluidos
        '
        Me.lblClientesIncluidos.AutoSize = True
        TableLayoutPanelInclusion.SetColumnSpan(Me.lblClientesIncluidos, 3)
        Me.lblClientesIncluidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClientesIncluidos.Location = New System.Drawing.Point(3, 0)
        Me.lblClientesIncluidos.Name = "lblClientesIncluidos"
        Me.lblClientesIncluidos.Size = New System.Drawing.Size(312, 30)
        Me.lblClientesIncluidos.TabIndex = 43
        Me.lblClientesIncluidos.Text = "Clientes"
        '
        'dgvIncluidasTotales
        '
        Me.dgvIncluidasTotales.AllowUserToAddRows = False
        Me.dgvIncluidasTotales.AllowUserToDeleteRows = False
        Me.dgvIncluidasTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncluidasTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIncluidasTotales.Location = New System.Drawing.Point(648, 3)
        Me.dgvIncluidasTotales.Name = "dgvIncluidasTotales"
        Me.dgvIncluidasTotales.ReadOnly = True
        TableLayoutPanelInclusion.SetRowSpan(Me.dgvIncluidasTotales, 5)
        Me.dgvIncluidasTotales.Size = New System.Drawing.Size(322, 172)
        Me.dgvIncluidasTotales.TabIndex = 32
        '
        'dgvIncluidas
        '
        Me.dgvIncluidas.AllowUserToAddRows = False
        Me.dgvIncluidas.AllowUserToDeleteRows = False
        Me.dgvIncluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncluidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIncluidas.Location = New System.Drawing.Point(321, 3)
        Me.dgvIncluidas.Name = "dgvIncluidas"
        Me.dgvIncluidas.ReadOnly = True
        TableLayoutPanelInclusion.SetRowSpan(Me.dgvIncluidas, 5)
        Me.dgvIncluidas.Size = New System.Drawing.Size(321, 172)
        Me.dgvIncluidas.TabIndex = 31
        '
        'cmdIncluir
        '
        Me.cmdIncluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdIncluir.Location = New System.Drawing.Point(3, 152)
        Me.cmdIncluir.Name = "cmdIncluir"
        Me.cmdIncluir.Size = New System.Drawing.Size(79, 23)
        Me.cmdIncluir.TabIndex = 42
        Me.cmdIncluir.Text = "Incluir"
        Me.cmdIncluir.UseVisualStyleBackColor = True
        '
        'lblNumeroLineasTextBoxIncluidos
        '
        Me.lblNumeroLineasTextBoxIncluidos.AutoSize = True
        TableLayoutPanelInclusion.SetColumnSpan(Me.lblNumeroLineasTextBoxIncluidos, 3)
        Me.lblNumeroLineasTextBoxIncluidos.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.lblNumeroLineasTextBoxIncluidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumeroLineasTextBoxIncluidos.Location = New System.Drawing.Point(3, 118)
        Me.lblNumeroLineasTextBoxIncluidos.Name = "lblNumeroLineasTextBoxIncluidos"
        Me.lblNumeroLineasTextBoxIncluidos.Size = New System.Drawing.Size(312, 30)
        Me.lblNumeroLineasTextBoxIncluidos.TabIndex = 46
        Me.lblNumeroLineasTextBoxIncluidos.Text = "..."
        '
        'TabPageExclusion
        '
        Me.TabPageExclusion.Controls.Add(TableLayoutPanelExclusion)
        Me.TabPageExclusion.Location = New System.Drawing.Point(4, 22)
        Me.TabPageExclusion.Name = "TabPageExclusion"
        Me.TabPageExclusion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageExclusion.Size = New System.Drawing.Size(979, 184)
        Me.TabPageExclusion.TabIndex = 2
        Me.TabPageExclusion.Text = "Exclusión"
        Me.TabPageExclusion.UseVisualStyleBackColor = True
        '
        'TableLayoutPanelExclusion
        '
        TableLayoutPanelExclusion.AutoSize = True
        TableLayoutPanelExclusion.ColumnCount = 5
        TableLayoutPanelExclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        TableLayoutPanelExclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        TableLayoutPanelExclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        TableLayoutPanelExclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        TableLayoutPanelExclusion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        TableLayoutPanelExclusion.Controls.Add(Me.cmdLimpiarExcluidos, 1, 4)
        TableLayoutPanelExclusion.Controls.Add(Me.txtDocumentosExcluidos, 0, 2)
        TableLayoutPanelExclusion.Controls.Add(Me.cbxClientesExclusion, 0, 1)
        TableLayoutPanelExclusion.Controls.Add(Me.lblClientesExcluidos, 0, 0)
        TableLayoutPanelExclusion.Controls.Add(Me.dgvExcluidasTotales, 4, 0)
        TableLayoutPanelExclusion.Controls.Add(Me.dgvExcluidas, 3, 0)
        TableLayoutPanelExclusion.Controls.Add(Me.cmdExcluir, 0, 4)
        TableLayoutPanelExclusion.Controls.Add(Me.lblNumeroLineasTextBoxExcluidos, 0, 3)
        TableLayoutPanelExclusion.Controls.Add(Me.cmdLimpiarTodosExcluidos, 2, 4)
        TableLayoutPanelExclusion.Dock = System.Windows.Forms.DockStyle.Fill
        TableLayoutPanelExclusion.Location = New System.Drawing.Point(3, 3)
        TableLayoutPanelExclusion.Name = "TableLayoutPanelExclusion"
        TableLayoutPanelExclusion.RowCount = 5
        TableLayoutPanelExclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelExclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelExclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        TableLayoutPanelExclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelExclusion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        TableLayoutPanelExclusion.Size = New System.Drawing.Size(973, 178)
        TableLayoutPanelExclusion.TabIndex = 1
        '
        'cmdLimpiarExcluidos
        '
        Me.cmdLimpiarExcluidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdLimpiarExcluidos.Location = New System.Drawing.Point(109, 152)
        Me.cmdLimpiarExcluidos.Name = "cmdLimpiarExcluidos"
        Me.cmdLimpiarExcluidos.Size = New System.Drawing.Size(84, 23)
        Me.cmdLimpiarExcluidos.TabIndex = 48
        Me.cmdLimpiarExcluidos.Text = "Limpiar"
        Me.cmdLimpiarExcluidos.UseVisualStyleBackColor = True
        '
        'txtDocumentosExcluidos
        '
        Me.txtDocumentosExcluidos.AcceptsReturn = True
        Me.txtDocumentosExcluidos.AcceptsTab = True
        Me.txtDocumentosExcluidos.AllowDrop = True
        Me.txtDocumentosExcluidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        TableLayoutPanelExclusion.SetColumnSpan(Me.txtDocumentosExcluidos, 3)
        Me.txtDocumentosExcluidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDocumentosExcluidos.Location = New System.Drawing.Point(3, 63)
        Me.txtDocumentosExcluidos.Multiline = True
        Me.txtDocumentosExcluidos.Name = "txtDocumentosExcluidos"
        Me.txtDocumentosExcluidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocumentosExcluidos.Size = New System.Drawing.Size(312, 52)
        Me.txtDocumentosExcluidos.TabIndex = 45
        Me.txtDocumentosExcluidos.WordWrap = False
        '
        'cbxClientesExclusion
        '
        Me.cbxClientesExclusion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbxClientesExclusion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        TableLayoutPanelExclusion.SetColumnSpan(Me.cbxClientesExclusion, 3)
        Me.cbxClientesExclusion.DisplayMember = "id_cliente"
        Me.cbxClientesExclusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbxClientesExclusion.FormattingEnabled = True
        Me.cbxClientesExclusion.IntegralHeight = False
        Me.cbxClientesExclusion.Location = New System.Drawing.Point(3, 33)
        Me.cbxClientesExclusion.MaxDropDownItems = 10
        Me.cbxClientesExclusion.Name = "cbxClientesExclusion"
        Me.cbxClientesExclusion.Size = New System.Drawing.Size(312, 21)
        Me.cbxClientesExclusion.TabIndex = 44
        Me.cbxClientesExclusion.ValueMember = "id_cliente"
        '
        'lblClientesExcluidos
        '
        Me.lblClientesExcluidos.AutoSize = True
        TableLayoutPanelExclusion.SetColumnSpan(Me.lblClientesExcluidos, 3)
        Me.lblClientesExcluidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClientesExcluidos.Location = New System.Drawing.Point(3, 0)
        Me.lblClientesExcluidos.Name = "lblClientesExcluidos"
        Me.lblClientesExcluidos.Size = New System.Drawing.Size(312, 30)
        Me.lblClientesExcluidos.TabIndex = 43
        Me.lblClientesExcluidos.Text = "Clientes"
        '
        'dgvExcluidasTotales
        '
        Me.dgvExcluidasTotales.AllowUserToAddRows = False
        Me.dgvExcluidasTotales.AllowUserToDeleteRows = False
        Me.dgvExcluidasTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcluidasTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExcluidasTotales.Location = New System.Drawing.Point(648, 3)
        Me.dgvExcluidasTotales.Name = "dgvExcluidasTotales"
        Me.dgvExcluidasTotales.ReadOnly = True
        TableLayoutPanelExclusion.SetRowSpan(Me.dgvExcluidasTotales, 5)
        Me.dgvExcluidasTotales.Size = New System.Drawing.Size(322, 172)
        Me.dgvExcluidasTotales.TabIndex = 32
        '
        'dgvExcluidas
        '
        Me.dgvExcluidas.AllowUserToAddRows = False
        Me.dgvExcluidas.AllowUserToDeleteRows = False
        Me.dgvExcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcluidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExcluidas.Location = New System.Drawing.Point(321, 3)
        Me.dgvExcluidas.Name = "dgvExcluidas"
        Me.dgvExcluidas.ReadOnly = True
        TableLayoutPanelExclusion.SetRowSpan(Me.dgvExcluidas, 5)
        Me.dgvExcluidas.Size = New System.Drawing.Size(321, 172)
        Me.dgvExcluidas.TabIndex = 31
        '
        'cmdExcluir
        '
        Me.cmdExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExcluir.BackColor = System.Drawing.Color.Red
        Me.cmdExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.cmdExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExcluir.ForeColor = System.Drawing.Color.White
        Me.cmdExcluir.Location = New System.Drawing.Point(3, 152)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(84, 23)
        Me.cmdExcluir.TabIndex = 42
        Me.cmdExcluir.Text = "Excluir"
        Me.cmdExcluir.UseVisualStyleBackColor = False
        '
        'lblNumeroLineasTextBoxExcluidos
        '
        Me.lblNumeroLineasTextBoxExcluidos.AutoSize = True
        TableLayoutPanelExclusion.SetColumnSpan(Me.lblNumeroLineasTextBoxExcluidos, 3)
        Me.lblNumeroLineasTextBoxExcluidos.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.lblNumeroLineasTextBoxExcluidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumeroLineasTextBoxExcluidos.Location = New System.Drawing.Point(3, 118)
        Me.lblNumeroLineasTextBoxExcluidos.Name = "lblNumeroLineasTextBoxExcluidos"
        Me.lblNumeroLineasTextBoxExcluidos.Size = New System.Drawing.Size(312, 30)
        Me.lblNumeroLineasTextBoxExcluidos.TabIndex = 46
        Me.lblNumeroLineasTextBoxExcluidos.Text = "..."
        '
        'cmdLimpiarTodosExcluidos
        '
        Me.cmdLimpiarTodosExcluidos.Location = New System.Drawing.Point(215, 151)
        Me.cmdLimpiarTodosExcluidos.Name = "cmdLimpiarTodosExcluidos"
        Me.cmdLimpiarTodosExcluidos.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiarTodosExcluidos.TabIndex = 49
        Me.cmdLimpiarTodosExcluidos.Text = "Limpiar T."
        Me.cmdLimpiarTodosExcluidos.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelComandos
        '
        FlowLayoutPanelComandos.AutoSize = True
        FlowLayoutPanelComandos.CausesValidation = False
        FlowLayoutPanelComandos.Controls.Add(Me.cmdExportar)
        FlowLayoutPanelComandos.Controls.Add(Me.cmdConsultar)
        FlowLayoutPanelComandos.Dock = System.Windows.Forms.DockStyle.Fill
        FlowLayoutPanelComandos.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        FlowLayoutPanelComandos.Location = New System.Drawing.Point(747, 5)
        FlowLayoutPanelComandos.Name = "FlowLayoutPanelComandos"
        Me.TableLayoutPanelMainTop.SetRowSpan(FlowLayoutPanelComandos, 2)
        FlowLayoutPanelComandos.Size = New System.Drawing.Size(235, 54)
        FlowLayoutPanelComandos.TabIndex = 30
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(163, 3)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(69, 23)
        Me.cmdExportar.TabIndex = 16
        Me.cmdExportar.Text = "Exportar"
        Me.cmdExportar.UseVisualStyleBackColor = True
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Location = New System.Drawing.Point(88, 3)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(69, 23)
        Me.cmdConsultar.TabIndex = 10
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = True
        '
        'dtpFechaSalidaRutas
        '
        Me.dtpFechaSalidaRutas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpFechaSalidaRutas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalidaRutas.Location = New System.Drawing.Point(5, 37)
        Me.dtpFechaSalidaRutas.Name = "dtpFechaSalidaRutas"
        Me.dtpFechaSalidaRutas.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaSalidaRutas.TabIndex = 1
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFechaEntrega.AutoSize = True
        Me.lblFechaEntrega.Location = New System.Drawing.Point(5, 10)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(100, 13)
        Me.lblFechaEntrega.TabIndex = 21
        Me.lblFechaEntrega.Text = "Fecha Salida Rutas"
        '
        'lblTotalCorte
        '
        Me.lblTotalCorte.AutoSize = True
        Me.lblTotalCorte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotalCorte.Location = New System.Drawing.Point(10, 486)
        Me.lblTotalCorte.Name = "lblTotalCorte"
        Me.lblTotalCorte.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCorte.TabIndex = 26
        '
        'cbxCiudadOrigen
        '
        Me.cbxCiudadOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxCiudadOrigen.FormattingEnabled = True
        Me.cbxCiudadOrigen.Location = New System.Drawing.Point(121, 36)
        Me.cbxCiudadOrigen.Name = "cbxCiudadOrigen"
        Me.cbxCiudadOrigen.Size = New System.Drawing.Size(147, 21)
        Me.cbxCiudadOrigen.TabIndex = 28
        '
        'lblCiudadOrigen
        '
        Me.lblCiudadOrigen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCiudadOrigen.AutoSize = True
        Me.lblCiudadOrigen.Location = New System.Drawing.Point(121, 10)
        Me.lblCiudadOrigen.Name = "lblCiudadOrigen"
        Me.lblCiudadOrigen.Size = New System.Drawing.Size(74, 13)
        Me.lblCiudadOrigen.TabIndex = 29
        Me.lblCiudadOrigen.Text = "Ciudad Origen"
        '
        'TableLayoutPanelMainTop
        '
        Me.TableLayoutPanelMainTop.AutoSize = True
        Me.TableLayoutPanelMainTop.ColumnCount = 6
        Me.TableLayoutPanelMainTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanelMainTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.TableLayoutPanelMainTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TableLayoutPanelMainTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.TableLayoutPanelMainTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanelMainTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241.0!))
        Me.TableLayoutPanelMainTop.Controls.Add(Me.chkSoloIncluidas, 3, 0)
        Me.TableLayoutPanelMainTop.Controls.Add(Me.chkPermitirOrdenesSinCeDi, 4, 0)
        Me.TableLayoutPanelMainTop.Controls.Add(FlowLayoutPanelComandos, 5, 0)
        Me.TableLayoutPanelMainTop.Controls.Add(Me.lblFechaEntrega, 0, 0)
        Me.TableLayoutPanelMainTop.Controls.Add(Me.dtpFechaSalidaRutas, 0, 1)
        Me.TableLayoutPanelMainTop.Controls.Add(Me.lblCiudadOrigen, 1, 0)
        Me.TableLayoutPanelMainTop.Controls.Add(Me.cbxCiudadOrigen, 1, 1)
        Me.TableLayoutPanelMainTop.Controls.Add(Me.lblTipoCorte, 2, 0)
        Me.TableLayoutPanelMainTop.Controls.Add(Me.cbxTipoCortePlanificacionRuta, 2, 1)
        Me.TableLayoutPanelMainTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanelMainTop.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanelMainTop.Margin = New System.Windows.Forms.Padding(30, 3, 30, 3)
        Me.TableLayoutPanelMainTop.Name = "TableLayoutPanelMainTop"
        Me.TableLayoutPanelMainTop.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanelMainTop.RowCount = 2
        Me.TableLayoutPanelMainTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelMainTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelMainTop.Size = New System.Drawing.Size(987, 64)
        Me.TableLayoutPanelMainTop.TabIndex = 30
        '
        'chkSoloIncluidas
        '
        Me.chkSoloIncluidas.AutoSize = True
        Me.chkSoloIncluidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkSoloIncluidas.Location = New System.Drawing.Point(425, 5)
        Me.chkSoloIncluidas.Name = "chkSoloIncluidas"
        Me.TableLayoutPanelMainTop.SetRowSpan(Me.chkSoloIncluidas, 2)
        Me.chkSoloIncluidas.Size = New System.Drawing.Size(166, 54)
        Me.chkSoloIncluidas.TabIndex = 34
        Me.chkSoloIncluidas.Text = "Solo ver ordenes habilitadas por la opción Inclusión"
        Me.chkSoloIncluidas.UseVisualStyleBackColor = True
        '
        'chkPermitirOrdenesSinCeDi
        '
        Me.chkPermitirOrdenesSinCeDi.AutoSize = True
        Me.chkPermitirOrdenesSinCeDi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkPermitirOrdenesSinCeDi.Location = New System.Drawing.Point(597, 5)
        Me.chkPermitirOrdenesSinCeDi.Name = "chkPermitirOrdenesSinCeDi"
        Me.TableLayoutPanelMainTop.SetRowSpan(Me.chkPermitirOrdenesSinCeDi, 2)
        Me.chkPermitirOrdenesSinCeDi.Size = New System.Drawing.Size(144, 54)
        Me.chkPermitirOrdenesSinCeDi.TabIndex = 33
        Me.chkPermitirOrdenesSinCeDi.Text = "Permitir Ordenes Sin CeDi"
        Me.chkPermitirOrdenesSinCeDi.UseVisualStyleBackColor = True
        '
        'lblTipoCorte
        '
        Me.lblTipoCorte.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoCorte.AutoSize = True
        Me.lblTipoCorte.Location = New System.Drawing.Point(274, 10)
        Me.lblTipoCorte.Name = "lblTipoCorte"
        Me.lblTipoCorte.Size = New System.Drawing.Size(56, 13)
        Me.lblTipoCorte.TabIndex = 32
        Me.lblTipoCorte.Text = "Tipo Corte"
        '
        'cbxTipoCortePlanificacionRuta
        '
        Me.cbxTipoCortePlanificacionRuta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxTipoCortePlanificacionRuta.FormattingEnabled = True
        Me.cbxTipoCortePlanificacionRuta.Location = New System.Drawing.Point(274, 36)
        Me.cbxTipoCortePlanificacionRuta.Name = "cbxTipoCortePlanificacionRuta"
        Me.cbxTipoCortePlanificacionRuta.Size = New System.Drawing.Size(141, 21)
        Me.cbxTipoCortePlanificacionRuta.TabIndex = 31
        '
        'SplitContainerMainFill
        '
        Me.SplitContainerMainFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMainFill.Location = New System.Drawing.Point(10, 74)
        Me.SplitContainerMainFill.Name = "SplitContainerMainFill"
        Me.SplitContainerMainFill.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerMainFill.Panel1
        '
        Me.SplitContainerMainFill.Panel1.Controls.Add(TabControlCriterios)
        '
        'SplitContainerMainFill.Panel2
        '
        Me.SplitContainerMainFill.Panel2.Controls.Add(Me.TabControlResultados)
        Me.SplitContainerMainFill.Size = New System.Drawing.Size(987, 412)
        Me.SplitContainerMainFill.SplitterDistance = 210
        Me.SplitContainerMainFill.TabIndex = 31
        '
        'TabControlResultados
        '
        Me.TabControlResultados.Controls.Add(Me.TabPage1)
        Me.TabControlResultados.Controls.Add(Me.TabPage2)
        Me.TabControlResultados.Controls.Add(Me.TabPage3)
        Me.TabControlResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlResultados.Location = New System.Drawing.Point(0, 0)
        Me.TabControlResultados.Name = "TabControlResultados"
        Me.TabControlResultados.SelectedIndex = 0
        Me.TabControlResultados.Size = New System.Drawing.Size(987, 198)
        Me.TabControlResultados.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(979, 172)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Habilitadas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.dgvHabilitadas, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.bnHabilitadas, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(973, 166)
        Me.TableLayoutPanel2.TabIndex = 27
        '
        'dgvHabilitadas
        '
        Me.dgvHabilitadas.AllowUserToAddRows = False
        Me.dgvHabilitadas.AllowUserToDeleteRows = False
        Me.dgvHabilitadas.AllowUserToOrderColumns = True
        Me.dgvHabilitadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvHabilitadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvHabilitadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvHabilitadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvHabilitadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHabilitadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHabilitadas.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgvHabilitadas.Location = New System.Drawing.Point(3, 33)
        Me.dgvHabilitadas.Name = "dgvHabilitadas"
        Me.dgvHabilitadas.ReadOnly = True
        Me.dgvHabilitadas.ShowEditingIcon = False
        Me.dgvHabilitadas.Size = New System.Drawing.Size(967, 141)
        Me.dgvHabilitadas.TabIndex = 28
        '
        'bnHabilitadas
        '
        Me.bnHabilitadas.AddNewItem = Nothing
        Me.bnHabilitadas.CountItem = Me.BindingNavigatorCountItem1
        Me.bnHabilitadas.DeleteItem = Nothing
        Me.bnHabilitadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnHabilitadas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelFiltrarHabilitadas, Me.ToolStripTextBoxFiltroHabilitadas, Me.BindingNavigatorSeparator5, Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.ToolStripSeparator11, Me.ToolStripButtonSeleccionarTodos, Me.ToolStripSeparator5, Me.ToolStripButtonInvertirSeleccion, Me.ToolStripSeparator6, Me.ToolStripButtonAgregarSeleccion, Me.ToolStripSeparator7})
        Me.bnHabilitadas.Location = New System.Drawing.Point(0, 0)
        Me.bnHabilitadas.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.bnHabilitadas.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.bnHabilitadas.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.bnHabilitadas.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.bnHabilitadas.Name = "bnHabilitadas"
        Me.bnHabilitadas.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bnHabilitadas.Size = New System.Drawing.Size(973, 30)
        Me.bnHabilitadas.TabIndex = 27
        Me.bnHabilitadas.Text = "BindingNavigatorHabilitadas"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 27)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'ToolStripLabelFiltrarHabilitadas
        '
        Me.ToolStripLabelFiltrarHabilitadas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabelFiltrarHabilitadas.Image = CType(resources.GetObject("ToolStripLabelFiltrarHabilitadas.Image"), System.Drawing.Image)
        Me.ToolStripLabelFiltrarHabilitadas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripLabelFiltrarHabilitadas.Name = "ToolStripLabelFiltrarHabilitadas"
        Me.ToolStripLabelFiltrarHabilitadas.Size = New System.Drawing.Size(37, 27)
        Me.ToolStripLabelFiltrarHabilitadas.Text = "Filtrar"
        '
        'ToolStripTextBoxFiltroHabilitadas
        '
        Me.ToolStripTextBoxFiltroHabilitadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBoxFiltroHabilitadas.Name = "ToolStripTextBoxFiltroHabilitadas"
        Me.ToolStripTextBoxFiltroHabilitadas.Size = New System.Drawing.Size(250, 30)
        Me.ToolStripTextBoxFiltroHabilitadas.ToolTipText = "Para buscar registros que contengan la palabra XXX, puede hacer uso de las siguie" &
    "ntes opciones: Que comience *XXX. Que termine XXX* y que contenga *XXX*."
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonSeleccionarTodos
        '
        Me.ToolStripButtonSeleccionarTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonSeleccionarTodos.Image = CType(resources.GetObject("ToolStripButtonSeleccionarTodos.Image"), System.Drawing.Image)
        Me.ToolStripButtonSeleccionarTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSeleccionarTodos.Name = "ToolStripButtonSeleccionarTodos"
        Me.ToolStripButtonSeleccionarTodos.Size = New System.Drawing.Size(64, 27)
        Me.ToolStripButtonSeleccionarTodos.Text = "Sel. Todos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonInvertirSeleccion
        '
        Me.ToolStripButtonInvertirSeleccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonInvertirSeleccion.Image = CType(resources.GetObject("ToolStripButtonInvertirSeleccion.Image"), System.Drawing.Image)
        Me.ToolStripButtonInvertirSeleccion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonInvertirSeleccion.Name = "ToolStripButtonInvertirSeleccion"
        Me.ToolStripButtonInvertirSeleccion.Size = New System.Drawing.Size(83, 27)
        Me.ToolStripButtonInvertirSeleccion.Text = "Inv. Selección"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonAgregarSeleccion
        '
        Me.ToolStripButtonAgregarSeleccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonAgregarSeleccion.Image = CType(resources.GetObject("ToolStripButtonAgregarSeleccion.Image"), System.Drawing.Image)
        Me.ToolStripButtonAgregarSeleccion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAgregarSeleccion.Name = "ToolStripButtonAgregarSeleccion"
        Me.ToolStripButtonAgregarSeleccion.Size = New System.Drawing.Size(115, 27)
        Me.ToolStripButtonAgregarSeleccion.Text = "Agregar a Selección"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 30)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(979, 172)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "No Habilitadas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.dgvNoHabilitadas, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.bnNoHabilitadas, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(973, 166)
        Me.TableLayoutPanel3.TabIndex = 28
        '
        'dgvNoHabilitadas
        '
        Me.dgvNoHabilitadas.AllowUserToAddRows = False
        Me.dgvNoHabilitadas.AllowUserToDeleteRows = False
        Me.dgvNoHabilitadas.AllowUserToOrderColumns = True
        Me.dgvNoHabilitadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvNoHabilitadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvNoHabilitadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvNoHabilitadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNoHabilitadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNoHabilitadas.Location = New System.Drawing.Point(3, 33)
        Me.dgvNoHabilitadas.Name = "dgvNoHabilitadas"
        Me.dgvNoHabilitadas.ReadOnly = True
        Me.dgvNoHabilitadas.ShowEditingIcon = False
        Me.dgvNoHabilitadas.Size = New System.Drawing.Size(967, 141)
        Me.dgvNoHabilitadas.TabIndex = 29
        '
        'bnNoHabilitadas
        '
        Me.bnNoHabilitadas.AddNewItem = Nothing
        Me.bnNoHabilitadas.CountItem = Me.BindingNavigatorCountItem
        Me.bnNoHabilitadas.DeleteItem = Nothing
        Me.bnNoHabilitadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnNoHabilitadas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelFiltrarNoHabilitadas, Me.ToolStripTextBoxFiltroNoHabilitadas, Me.BindingNavigatorSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.bnNoHabilitadas.Location = New System.Drawing.Point(0, 0)
        Me.bnNoHabilitadas.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnNoHabilitadas.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnNoHabilitadas.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnNoHabilitadas.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnNoHabilitadas.Name = "bnNoHabilitadas"
        Me.bnNoHabilitadas.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnNoHabilitadas.Size = New System.Drawing.Size(973, 30)
        Me.bnNoHabilitadas.TabIndex = 28
        Me.bnNoHabilitadas.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 27)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'ToolStripLabelFiltrarNoHabilitadas
        '
        Me.ToolStripLabelFiltrarNoHabilitadas.Name = "ToolStripLabelFiltrarNoHabilitadas"
        Me.ToolStripLabelFiltrarNoHabilitadas.Size = New System.Drawing.Size(37, 27)
        Me.ToolStripLabelFiltrarNoHabilitadas.Text = "Filtrar"
        '
        'ToolStripTextBoxFiltroNoHabilitadas
        '
        Me.ToolStripTextBoxFiltroNoHabilitadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBoxFiltroNoHabilitadas.Name = "ToolStripTextBoxFiltroNoHabilitadas"
        Me.ToolStripTextBoxFiltroNoHabilitadas.Size = New System.Drawing.Size(250, 30)
        Me.ToolStripTextBoxFiltroNoHabilitadas.ToolTipText = "Para buscar registros que contengan la palabra XXX, puede hacer uso de las siguie" &
    "ntes opciones: Que comience *XXX. Que termine XXX* y que contenga *XXX*."
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(979, 172)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Seleccionadas"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.bnSeleccionadas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvSeleccionadas, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(973, 166)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'bnSeleccionadas
        '
        Me.bnSeleccionadas.AddNewItem = Nothing
        Me.bnSeleccionadas.CountItem = Me.ToolStripLabel1
        Me.bnSeleccionadas.DeleteItem = Nothing
        Me.bnSeleccionadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnSeleccionadas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelFiltrarSeleccionadas, Me.ToolStripTextBoxFiltroSeleccionadas, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripTextBox2, Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator10, Me.ToolStripButtonConfirmar, Me.ToolStripSeparator4, Me.ToolStripButtonSeleccionarTodosSeleccionados, Me.ToolStripSeparator8, Me.ToolStripButtonInvertirSeleccionSeleccionados, Me.ToolStripSeparator9, Me.ToolStripButtonRemoverSeleccion})
        Me.bnSeleccionadas.Location = New System.Drawing.Point(0, 0)
        Me.bnSeleccionadas.MoveFirstItem = Me.ToolStripButton1
        Me.bnSeleccionadas.MoveLastItem = Me.ToolStripButton4
        Me.bnSeleccionadas.MoveNextItem = Me.ToolStripButton3
        Me.bnSeleccionadas.MovePreviousItem = Me.ToolStripButton2
        Me.bnSeleccionadas.Name = "bnSeleccionadas"
        Me.bnSeleccionadas.PositionItem = Me.ToolStripTextBox2
        Me.bnSeleccionadas.Size = New System.Drawing.Size(973, 30)
        Me.bnSeleccionadas.TabIndex = 31
        Me.bnSeleccionadas.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 27)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripLabelFiltrarSeleccionadas
        '
        Me.ToolStripLabelFiltrarSeleccionadas.Name = "ToolStripLabelFiltrarSeleccionadas"
        Me.ToolStripLabelFiltrarSeleccionadas.Size = New System.Drawing.Size(37, 27)
        Me.ToolStripLabelFiltrarSeleccionadas.Text = "Filtrar"
        '
        'ToolStripTextBoxFiltroSeleccionadas
        '
        Me.ToolStripTextBoxFiltroSeleccionadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBoxFiltroSeleccionadas.Name = "ToolStripTextBoxFiltroSeleccionadas"
        Me.ToolStripTextBoxFiltroSeleccionadas.Size = New System.Drawing.Size(250, 30)
        Me.ToolStripTextBoxFiltroSeleccionadas.ToolTipText = "Para buscar registros que contengan la palabra XXX, puede hacer uso de las siguie" &
    "ntes opciones: Que comience *XXX. Que termine XXX* y que contenga *XXX*."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton2.Text = "Mover anterior"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Posición"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton3.Text = "Mover siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton4.Text = "Mover último"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonConfirmar
        '
        Me.ToolStripButtonConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonConfirmar.Image = CType(resources.GetObject("ToolStripButtonConfirmar.Image"), System.Drawing.Image)
        Me.ToolStripButtonConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonConfirmar.Name = "ToolStripButtonConfirmar"
        Me.ToolStripButtonConfirmar.Size = New System.Drawing.Size(65, 27)
        Me.ToolStripButtonConfirmar.Text = "Confirmar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonSeleccionarTodosSeleccionados
        '
        Me.ToolStripButtonSeleccionarTodosSeleccionados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonSeleccionarTodosSeleccionados.Image = CType(resources.GetObject("ToolStripButtonSeleccionarTodosSeleccionados.Image"), System.Drawing.Image)
        Me.ToolStripButtonSeleccionarTodosSeleccionados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSeleccionarTodosSeleccionados.Name = "ToolStripButtonSeleccionarTodosSeleccionados"
        Me.ToolStripButtonSeleccionarTodosSeleccionados.Size = New System.Drawing.Size(64, 27)
        Me.ToolStripButtonSeleccionarTodosSeleccionados.Text = "Sel. Todos"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonInvertirSeleccionSeleccionados
        '
        Me.ToolStripButtonInvertirSeleccionSeleccionados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonInvertirSeleccionSeleccionados.Image = CType(resources.GetObject("ToolStripButtonInvertirSeleccionSeleccionados.Image"), System.Drawing.Image)
        Me.ToolStripButtonInvertirSeleccionSeleccionados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonInvertirSeleccionSeleccionados.Name = "ToolStripButtonInvertirSeleccionSeleccionados"
        Me.ToolStripButtonInvertirSeleccionSeleccionados.Size = New System.Drawing.Size(83, 27)
        Me.ToolStripButtonInvertirSeleccionSeleccionados.Text = "Inv. Selección"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButtonRemoverSeleccion
        '
        Me.ToolStripButtonRemoverSeleccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonRemoverSeleccion.Image = CType(resources.GetObject("ToolStripButtonRemoverSeleccion.Image"), System.Drawing.Image)
        Me.ToolStripButtonRemoverSeleccion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRemoverSeleccion.Name = "ToolStripButtonRemoverSeleccion"
        Me.ToolStripButtonRemoverSeleccion.Size = New System.Drawing.Size(127, 27)
        Me.ToolStripButtonRemoverSeleccion.Text = "Remover de Selección"
        '
        'dgvSeleccionadas
        '
        Me.dgvSeleccionadas.AllowUserToAddRows = False
        Me.dgvSeleccionadas.AllowUserToDeleteRows = False
        Me.dgvSeleccionadas.AllowUserToOrderColumns = True
        Me.dgvSeleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvSeleccionadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvSeleccionadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeleccionadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSeleccionadas.Location = New System.Drawing.Point(3, 33)
        Me.dgvSeleccionadas.Name = "dgvSeleccionadas"
        Me.dgvSeleccionadas.ReadOnly = True
        Me.dgvSeleccionadas.ShowEditingIcon = False
        Me.dgvSeleccionadas.Size = New System.Drawing.Size(967, 141)
        Me.dgvSeleccionadas.TabIndex = 30
        '
        'FormCorteRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1007, 509)
        Me.Controls.Add(Me.SplitContainerMainFill)
        Me.Controls.Add(Me.TableLayoutPanelMainTop)
        Me.Controls.Add(Me.lblTotalCorte)
        Me.Name = "FormCorteRutas"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.ShowInTaskbar = False
        Me.Text = "Planificación de Rutas"
        TabControlCriterios.ResumeLayout(False)
        Me.TabPageFiltros.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControlFiltros.ResumeLayout(False)
        Me.TabPageFiltroCeDi.ResumeLayout(False)
        Me.TabPageFiltroClientes.ResumeLayout(False)
        Me.TabPageFiltroServicios.ResumeLayout(False)
        Me.TabPageFiltroCanales.ResumeLayout(False)
        Me.TabPageFiltroCiudadesDestino.ResumeLayout(False)
        Me.TabPageFiltroDepartamentosDestino.ResumeLayout(False)
        CType(Me.dgvFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageInclusion.ResumeLayout(False)
        Me.TabPageInclusion.PerformLayout()
        TableLayoutPanelInclusion.ResumeLayout(False)
        TableLayoutPanelInclusion.PerformLayout()
        CType(Me.dgvIncluidasTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIncluidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageExclusion.ResumeLayout(False)
        Me.TabPageExclusion.PerformLayout()
        TableLayoutPanelExclusion.ResumeLayout(False)
        TableLayoutPanelExclusion.PerformLayout()
        CType(Me.dgvExcluidasTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExcluidas, System.ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanelComandos.ResumeLayout(False)
        Me.TableLayoutPanelMainTop.ResumeLayout(False)
        Me.TableLayoutPanelMainTop.PerformLayout()
        Me.SplitContainerMainFill.Panel1.ResumeLayout(False)
        Me.SplitContainerMainFill.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMainFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMainFill.ResumeLayout(False)
        Me.TabControlResultados.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvHabilitadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnHabilitadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnHabilitadas.ResumeLayout(False)
        Me.bnHabilitadas.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.dgvNoHabilitadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnNoHabilitadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnNoHabilitadas.ResumeLayout(False)
        Me.bnNoHabilitadas.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.bnSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnSeleccionadas.ResumeLayout(False)
        Me.bnSeleccionadas.PerformLayout()
        CType(Me.dgvSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Campo_Disposed(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents dtpFechaSalidaRutas As DateTimePicker
    '   Friend WithEvents Vista_ordenesBindingSource As BindingSource
    '    Friend WithEvents SateliteDataSet1 As SateliteDataSet1
    '   Friend WithEvents VistaordenesBindingSource As BindingSource
    '   Friend WithEvents SateliteDataSet2 As SateliteDataSet2
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents lblFechaEntrega As Label
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalCorte As Label
    Friend WithEvents cbxCiudadOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lblCiudadOrigen As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanelMainTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainerMainFill As System.Windows.Forms.SplitContainer
    Friend WithEvents TabPageFiltros As System.Windows.Forms.TabPage
    Friend WithEvents TabControlFiltros As System.Windows.Forms.TabControl
    Friend WithEvents TabPageFiltroCeDi As System.Windows.Forms.TabPage
    Friend WithEvents TabPageFiltroClientes As System.Windows.Forms.TabPage
    Friend WithEvents lbxClientes As System.Windows.Forms.ListBox
    Friend WithEvents TabPageFiltroServicios As System.Windows.Forms.TabPage
    Friend WithEvents lbxServicios As System.Windows.Forms.ListBox
    Friend WithEvents TabPageFiltroCanales As System.Windows.Forms.TabPage
    Friend WithEvents lbxCanales As System.Windows.Forms.ListBox
    Friend WithEvents TabPageFiltroCiudadesDestino As System.Windows.Forms.TabPage
    Friend WithEvents lbxCiudadesDestino As System.Windows.Forms.ListBox
    Friend WithEvents TabPageFiltroDepartamentosDestino As System.Windows.Forms.TabPage
    Friend WithEvents lbxDepartamentosDestino As System.Windows.Forms.ListBox
    Friend WithEvents dgvFiltros As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageInclusion As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Campo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seleccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents dgvIncluidas As System.Windows.Forms.DataGridView
    Friend WithEvents txtDocumentosIncluidos As System.Windows.Forms.TextBox
    Friend WithEvents cbxClientesInclusion As System.Windows.Forms.ComboBox
    Friend WithEvents lblClientesIncluidos As System.Windows.Forms.Label
    Friend WithEvents cmdIncluir As System.Windows.Forms.Button
    Friend WithEvents lblNumeroLineasTextBoxIncluidos As System.Windows.Forms.Label
    Friend WithEvents TabPageExclusion As System.Windows.Forms.TabPage
    Friend WithEvents txtDocumentosExcluidos As System.Windows.Forms.TextBox
    Friend WithEvents cbxClientesExclusion As System.Windows.Forms.ComboBox
    Friend WithEvents lblClientesExcluidos As System.Windows.Forms.Label
    Friend WithEvents dgvExcluidasTotales As System.Windows.Forms.DataGridView
    Friend WithEvents dgvExcluidas As System.Windows.Forms.DataGridView
    Friend WithEvents cmdExcluir As System.Windows.Forms.Button
    Friend WithEvents lblNumeroLineasTextBoxExcluidos As System.Windows.Forms.Label
    Friend WithEvents cbxTipoCortePlanificacionRuta As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCorte As System.Windows.Forms.Label
    Friend WithEvents TabControlResultados As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvHabilitadas As System.Windows.Forms.DataGridView
    Friend WithEvents bnHabilitadas As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvNoHabilitadas As System.Windows.Forms.DataGridView
    Friend WithEvents bnNoHabilitadas As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents chkSoloIncluidas As System.Windows.Forms.CheckBox
    Friend WithEvents chkPermitirOrdenesSinCeDi As System.Windows.Forms.CheckBox
    Friend WithEvents lbxCeDis As System.Windows.Forms.ListBox
    Friend WithEvents dgvIncluidasTotales As System.Windows.Forms.DataGridView
    Friend WithEvents cmdLimpiarIncluidos As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiarExcluidos As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiarTodosIncluidos As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiarTodosExcluidos As Button
    Friend WithEvents ToolStripLabelFiltrarNoHabilitadas As ToolStripLabel
    Friend WithEvents ToolStripTextBoxFiltroHabilitadas As ToolStripTextBox
    Friend WithEvents ToolStripLabelFiltrarHabilitadas As ToolStripLabel
    Friend WithEvents ToolStripTextBoxFiltroNoHabilitadas As ToolStripTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents bnSeleccionadas As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabelFiltrarSeleccionadas As ToolStripLabel
    Friend WithEvents ToolStripTextBoxFiltroSeleccionadas As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents dgvSeleccionadas As DataGridView
    Friend WithEvents ToolStripButtonSeleccionarTodos As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButtonInvertirSeleccion As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButtonAgregarSeleccion As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripButtonSeleccionarTodosSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButtonInvertirSeleccionSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripButtonRemoverSeleccion As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripButtonConfirmar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
