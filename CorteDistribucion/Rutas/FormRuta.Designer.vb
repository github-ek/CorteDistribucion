<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRuta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRuta))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelRutaId = New System.Windows.Forms.Label()
        Me.TextBoxRutaId = New System.Windows.Forms.TextBox()
        Me.LabelNumeroRuta = New System.Windows.Forms.Label()
        Me.TextBoxNumeroRuta = New System.Windows.Forms.TextBox()
        Me.LabelEstadoRuta = New System.Windows.Forms.Label()
        Me.TextBoxEstadoRuta = New System.Windows.Forms.TextBox()
        Me.LabelMovil = New System.Windows.Forms.Label()
        Me.TextBoxMovil = New System.Windows.Forms.TextBox()
        Me.LabelPlaca = New System.Windows.Forms.Label()
        Me.TextBoxPlaca = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageTransportador = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelConductorIdentificacion = New System.Windows.Forms.Label()
        Me.TextBoxConductorIdentificacion = New System.Windows.Forms.TextBox()
        Me.LabelConductorNombres = New System.Windows.Forms.Label()
        Me.TextBoxConductorNombres = New System.Windows.Forms.TextBox()
        Me.TabPageSincronizacion = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelEstadoSincronizacion = New System.Windows.Forms.Label()
        Me.TextBoxEstadoSincronizacion = New System.Windows.Forms.TextBox()
        Me.LabelFechaSincronizacion = New System.Windows.Forms.Label()
        Me.TextBoxFechaSincronizacion = New System.Windows.Forms.TextBox()
        Me.LabelIntentosSincronizacion = New System.Windows.Forms.Label()
        Me.TextBoxIntentosSincronizacion = New System.Windows.Forms.TextBox()
        Me.LabelErrorSincronizacion = New System.Windows.Forms.Label()
        Me.TextBoxErrorSincronizacion = New System.Windows.Forms.TextBox()
        Me.TabPageTiempos = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCitaCargue = New System.Windows.Forms.Label()
        Me.LabelFechaCitaCargue = New System.Windows.Forms.Label()
        Me.TextBoxFechaCitaCargue = New System.Windows.Forms.TextBox()
        Me.LabelHoraCitaCargue = New System.Windows.Forms.Label()
        Me.TextBoxHoraCitaCargue = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.bnOrdenes = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripButtonAcciones = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirPlanillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSeleccionarTodosSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonInvertirSeleccionSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvOrdenes = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageTransportador.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPageSincronizacion.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TabPageTiempos.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.bnOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnOrdenes.SuspendLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 10)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1064, 414)
        Me.SplitContainer1.SplitterDistance = 227
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.LabelRutaId, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxRutaId, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelNumeroRuta, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxNumeroRuta, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelEstadoRuta, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxEstadoRuta, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelMovil, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxMovil, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelPlaca, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPlaca, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1060, 223)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelRutaId
        '
        Me.LabelRutaId.AutoSize = True
        Me.LabelRutaId.Location = New System.Drawing.Point(3, 3)
        Me.LabelRutaId.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelRutaId.Name = "LabelRutaId"
        Me.LabelRutaId.Size = New System.Drawing.Size(18, 13)
        Me.LabelRutaId.TabIndex = 0
        Me.LabelRutaId.Text = "ID"
        '
        'TextBoxRutaId
        '
        Me.TextBoxRutaId.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxRutaId.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxRutaId.Location = New System.Drawing.Point(103, 3)
        Me.TextBoxRutaId.Name = "TextBoxRutaId"
        Me.TextBoxRutaId.ReadOnly = True
        Me.TextBoxRutaId.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxRutaId.TabIndex = 55
        '
        'LabelNumeroRuta
        '
        Me.LabelNumeroRuta.AutoSize = True
        Me.LabelNumeroRuta.Location = New System.Drawing.Point(253, 3)
        Me.LabelNumeroRuta.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNumeroRuta.Name = "LabelNumeroRuta"
        Me.LabelNumeroRuta.Size = New System.Drawing.Size(40, 13)
        Me.LabelNumeroRuta.TabIndex = 1
        Me.LabelNumeroRuta.Text = "# Ruta"
        '
        'TextBoxNumeroRuta
        '
        Me.TextBoxNumeroRuta.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxNumeroRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNumeroRuta.Location = New System.Drawing.Point(353, 3)
        Me.TextBoxNumeroRuta.Name = "TextBoxNumeroRuta"
        Me.TextBoxNumeroRuta.ReadOnly = True
        Me.TextBoxNumeroRuta.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxNumeroRuta.TabIndex = 56
        '
        'LabelEstadoRuta
        '
        Me.LabelEstadoRuta.AutoSize = True
        Me.LabelEstadoRuta.Location = New System.Drawing.Point(503, 3)
        Me.LabelEstadoRuta.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelEstadoRuta.Name = "LabelEstadoRuta"
        Me.LabelEstadoRuta.Size = New System.Drawing.Size(66, 13)
        Me.LabelEstadoRuta.TabIndex = 7
        Me.LabelEstadoRuta.Text = "Estado Ruta"
        '
        'TextBoxEstadoRuta
        '
        Me.TextBoxEstadoRuta.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEstadoRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxEstadoRuta.Location = New System.Drawing.Point(603, 3)
        Me.TextBoxEstadoRuta.Name = "TextBoxEstadoRuta"
        Me.TextBoxEstadoRuta.ReadOnly = True
        Me.TextBoxEstadoRuta.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxEstadoRuta.TabIndex = 57
        '
        'LabelMovil
        '
        Me.LabelMovil.AutoSize = True
        Me.LabelMovil.Location = New System.Drawing.Point(3, 28)
        Me.LabelMovil.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelMovil.Name = "LabelMovil"
        Me.LabelMovil.Size = New System.Drawing.Size(32, 13)
        Me.LabelMovil.TabIndex = 2
        Me.LabelMovil.Text = "Móvil"
        '
        'TextBoxMovil
        '
        Me.TextBoxMovil.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMovil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxMovil.Location = New System.Drawing.Point(103, 28)
        Me.TextBoxMovil.Name = "TextBoxMovil"
        Me.TextBoxMovil.ReadOnly = True
        Me.TextBoxMovil.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxMovil.TabIndex = 58
        '
        'LabelPlaca
        '
        Me.LabelPlaca.AutoSize = True
        Me.LabelPlaca.Location = New System.Drawing.Point(253, 28)
        Me.LabelPlaca.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelPlaca.Name = "LabelPlaca"
        Me.LabelPlaca.Size = New System.Drawing.Size(34, 13)
        Me.LabelPlaca.TabIndex = 3
        Me.LabelPlaca.Text = "Placa"
        '
        'TextBoxPlaca
        '
        Me.TextBoxPlaca.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxPlaca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPlaca.Location = New System.Drawing.Point(353, 28)
        Me.TextBoxPlaca.Name = "TextBoxPlaca"
        Me.TextBoxPlaca.ReadOnly = True
        Me.TextBoxPlaca.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxPlaca.TabIndex = 59
        '
        'TabControl
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl, 7)
        Me.TabControl.Controls.Add(Me.TabPageTransportador)
        Me.TabControl.Controls.Add(Me.TabPageSincronizacion)
        Me.TabControl.Controls.Add(Me.TabPageTiempos)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(3, 78)
        Me.TabControl.Name = "TabControl"
        Me.TableLayoutPanel1.SetRowSpan(Me.TabControl, 3)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1058, 146)
        Me.TabControl.TabIndex = 60
        '
        'TabPageTransportador
        '
        Me.TabPageTransportador.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageTransportador.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageTransportador.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTransportador.Name = "TabPageTransportador"
        Me.TabPageTransportador.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTransportador.Size = New System.Drawing.Size(1050, 120)
        Me.TabPageTransportador.TabIndex = 0
        Me.TabPageTransportador.Text = "Transportador"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.LabelConductorIdentificacion, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxConductorIdentificacion, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelConductorNombres, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxConductorNombres, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1044, 114)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'LabelConductorIdentificacion
        '
        Me.LabelConductorIdentificacion.AutoSize = True
        Me.LabelConductorIdentificacion.Location = New System.Drawing.Point(3, 3)
        Me.LabelConductorIdentificacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelConductorIdentificacion.Name = "LabelConductorIdentificacion"
        Me.LabelConductorIdentificacion.Size = New System.Drawing.Size(21, 13)
        Me.LabelConductorIdentificacion.TabIndex = 4
        Me.LabelConductorIdentificacion.Text = "CC"
        '
        'TextBoxConductorIdentificacion
        '
        Me.TextBoxConductorIdentificacion.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxConductorIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxConductorIdentificacion.Location = New System.Drawing.Point(98, 3)
        Me.TextBoxConductorIdentificacion.Name = "TextBoxConductorIdentificacion"
        Me.TextBoxConductorIdentificacion.ReadOnly = True
        Me.TextBoxConductorIdentificacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxConductorIdentificacion.TabIndex = 59
        '
        'LabelConductorNombres
        '
        Me.LabelConductorNombres.AutoSize = True
        Me.LabelConductorNombres.Location = New System.Drawing.Point(248, 3)
        Me.LabelConductorNombres.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelConductorNombres.Name = "LabelConductorNombres"
        Me.LabelConductorNombres.Size = New System.Drawing.Size(49, 13)
        Me.LabelConductorNombres.TabIndex = 30
        Me.LabelConductorNombres.Text = "Nombres"
        '
        'TextBoxConductorNombres
        '
        Me.TextBoxConductorNombres.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxConductorNombres, 3)
        Me.TextBoxConductorNombres.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxConductorNombres.Location = New System.Drawing.Point(343, 3)
        Me.TextBoxConductorNombres.Name = "TextBoxConductorNombres"
        Me.TextBoxConductorNombres.ReadOnly = True
        Me.TextBoxConductorNombres.Size = New System.Drawing.Size(389, 20)
        Me.TextBoxConductorNombres.TabIndex = 60
        '
        'TabPageSincronizacion
        '
        Me.TabPageSincronizacion.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageSincronizacion.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPageSincronizacion.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSincronizacion.Name = "TabPageSincronizacion"
        Me.TabPageSincronizacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSincronizacion.Size = New System.Drawing.Size(1050, 120)
        Me.TabPageSincronizacion.TabIndex = 1
        Me.TabPageSincronizacion.Text = "Sincronización"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 7
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.LabelEstadoSincronizacion, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxEstadoSincronizacion, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelFechaSincronizacion, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxFechaSincronizacion, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelIntentosSincronizacion, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxIntentosSincronizacion, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelErrorSincronizacion, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxErrorSincronizacion, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1044, 114)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'LabelEstadoSincronizacion
        '
        Me.LabelEstadoSincronizacion.AutoSize = True
        Me.LabelEstadoSincronizacion.Location = New System.Drawing.Point(3, 3)
        Me.LabelEstadoSincronizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelEstadoSincronizacion.Name = "LabelEstadoSincronizacion"
        Me.LabelEstadoSincronizacion.Size = New System.Drawing.Size(40, 13)
        Me.LabelEstadoSincronizacion.TabIndex = 10
        Me.LabelEstadoSincronizacion.Text = "Estado"
        '
        'TextBoxEstadoSincronizacion
        '
        Me.TextBoxEstadoSincronizacion.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxEstadoSincronizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxEstadoSincronizacion.Location = New System.Drawing.Point(98, 3)
        Me.TextBoxEstadoSincronizacion.Name = "TextBoxEstadoSincronizacion"
        Me.TextBoxEstadoSincronizacion.ReadOnly = True
        Me.TextBoxEstadoSincronizacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxEstadoSincronizacion.TabIndex = 61
        '
        'LabelFechaSincronizacion
        '
        Me.LabelFechaSincronizacion.AutoSize = True
        Me.LabelFechaSincronizacion.Location = New System.Drawing.Point(248, 3)
        Me.LabelFechaSincronizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaSincronizacion.Name = "LabelFechaSincronizacion"
        Me.LabelFechaSincronizacion.Size = New System.Drawing.Size(37, 13)
        Me.LabelFechaSincronizacion.TabIndex = 39
        Me.LabelFechaSincronizacion.Text = "Fecha"
        '
        'TextBoxFechaSincronizacion
        '
        Me.TextBoxFechaSincronizacion.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxFechaSincronizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxFechaSincronizacion.Location = New System.Drawing.Point(343, 3)
        Me.TextBoxFechaSincronizacion.Name = "TextBoxFechaSincronizacion"
        Me.TextBoxFechaSincronizacion.ReadOnly = True
        Me.TextBoxFechaSincronizacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxFechaSincronizacion.TabIndex = 62
        '
        'LabelIntentosSincronizacion
        '
        Me.LabelIntentosSincronizacion.AutoSize = True
        Me.LabelIntentosSincronizacion.BackColor = System.Drawing.SystemColors.Control
        Me.LabelIntentosSincronizacion.Location = New System.Drawing.Point(493, 3)
        Me.LabelIntentosSincronizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelIntentosSincronizacion.Name = "LabelIntentosSincronizacion"
        Me.LabelIntentosSincronizacion.Size = New System.Drawing.Size(45, 13)
        Me.LabelIntentosSincronizacion.TabIndex = 41
        Me.LabelIntentosSincronizacion.Text = "Intentos"
        '
        'TextBoxIntentosSincronizacion
        '
        Me.TextBoxIntentosSincronizacion.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxIntentosSincronizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxIntentosSincronizacion.Location = New System.Drawing.Point(588, 3)
        Me.TextBoxIntentosSincronizacion.Name = "TextBoxIntentosSincronizacion"
        Me.TextBoxIntentosSincronizacion.ReadOnly = True
        Me.TextBoxIntentosSincronizacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxIntentosSincronizacion.TabIndex = 63
        '
        'LabelErrorSincronizacion
        '
        Me.LabelErrorSincronizacion.AutoSize = True
        Me.LabelErrorSincronizacion.Location = New System.Drawing.Point(3, 28)
        Me.LabelErrorSincronizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelErrorSincronizacion.Name = "LabelErrorSincronizacion"
        Me.LabelErrorSincronizacion.Size = New System.Drawing.Size(29, 13)
        Me.LabelErrorSincronizacion.TabIndex = 42
        Me.LabelErrorSincronizacion.Text = "Error"
        '
        'TextBoxErrorSincronizacion
        '
        Me.TextBoxErrorSincronizacion.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel4.SetColumnSpan(Me.TextBoxErrorSincronizacion, 6)
        Me.TextBoxErrorSincronizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxErrorSincronizacion.Location = New System.Drawing.Point(3, 53)
        Me.TextBoxErrorSincronizacion.Multiline = True
        Me.TextBoxErrorSincronizacion.Name = "TextBoxErrorSincronizacion"
        Me.TextBoxErrorSincronizacion.ReadOnly = True
        Me.TableLayoutPanel4.SetRowSpan(Me.TextBoxErrorSincronizacion, 2)
        Me.TextBoxErrorSincronizacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxErrorSincronizacion.Size = New System.Drawing.Size(729, 58)
        Me.TextBoxErrorSincronizacion.TabIndex = 64
        '
        'TabPageTiempos
        '
        Me.TabPageTiempos.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageTiempos.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPageTiempos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageTiempos.Name = "TabPageTiempos"
        Me.TabPageTiempos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageTiempos.Size = New System.Drawing.Size(1050, 120)
        Me.TabPageTiempos.TabIndex = 2
        Me.TabPageTiempos.Text = "Tiempos"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 8
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.LabelCitaCargue, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelFechaCitaCargue, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxFechaCitaCargue, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelHoraCitaCargue, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxHoraCitaCargue, 4, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1044, 114)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'LabelCitaCargue
        '
        Me.LabelCitaCargue.AutoSize = True
        Me.LabelCitaCargue.Location = New System.Drawing.Point(3, 3)
        Me.LabelCitaCargue.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCitaCargue.Name = "LabelCitaCargue"
        Me.LabelCitaCargue.Size = New System.Drawing.Size(59, 13)
        Me.LabelCitaCargue.TabIndex = 53
        Me.LabelCitaCargue.Text = "Inicio prog."
        '
        'LabelFechaCitaCargue
        '
        Me.LabelFechaCitaCargue.AutoSize = True
        Me.LabelFechaCitaCargue.Location = New System.Drawing.Point(98, 3)
        Me.LabelFechaCitaCargue.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaCitaCargue.Name = "LabelFechaCitaCargue"
        Me.LabelFechaCitaCargue.Size = New System.Drawing.Size(37, 13)
        Me.LabelFechaCitaCargue.TabIndex = 15
        Me.LabelFechaCitaCargue.Text = "Fecha"
        '
        'TextBoxFechaCitaCargue
        '
        Me.TextBoxFechaCitaCargue.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxFechaCitaCargue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxFechaCitaCargue.Location = New System.Drawing.Point(193, 3)
        Me.TextBoxFechaCitaCargue.Name = "TextBoxFechaCitaCargue"
        Me.TextBoxFechaCitaCargue.ReadOnly = True
        Me.TextBoxFechaCitaCargue.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxFechaCitaCargue.TabIndex = 59
        '
        'LabelHoraCitaCargue
        '
        Me.LabelHoraCitaCargue.AutoSize = True
        Me.LabelHoraCitaCargue.Location = New System.Drawing.Point(343, 3)
        Me.LabelHoraCitaCargue.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelHoraCitaCargue.Name = "LabelHoraCitaCargue"
        Me.LabelHoraCitaCargue.Size = New System.Drawing.Size(30, 13)
        Me.LabelHoraCitaCargue.TabIndex = 52
        Me.LabelHoraCitaCargue.Text = "Hora"
        '
        'TextBoxHoraCitaCargue
        '
        Me.TextBoxHoraCitaCargue.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxHoraCitaCargue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxHoraCitaCargue.Location = New System.Drawing.Point(438, 3)
        Me.TextBoxHoraCitaCargue.Name = "TextBoxHoraCitaCargue"
        Me.TextBoxHoraCitaCargue.ReadOnly = True
        Me.TextBoxHoraCitaCargue.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxHoraCitaCargue.TabIndex = 60
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.bnOrdenes, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvOrdenes, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1060, 179)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'bnOrdenes
        '
        Me.bnOrdenes.AddNewItem = Nothing
        Me.bnOrdenes.CountItem = Me.ToolStripLabel1
        Me.bnOrdenes.DeleteItem = Nothing
        Me.bnOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnOrdenes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelFiltrarSeleccionadas, Me.ToolStripTextBoxFiltroSeleccionadas, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripTextBox2, Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator10, Me.ToolStripButtonAcciones, Me.ToolStripSeparator4, Me.ToolStripButtonSeleccionarTodosSeleccionados, Me.ToolStripSeparator8, Me.ToolStripButtonInvertirSeleccionSeleccionados, Me.ToolStripSeparator9})
        Me.bnOrdenes.Location = New System.Drawing.Point(0, 0)
        Me.bnOrdenes.MoveFirstItem = Me.ToolStripButton1
        Me.bnOrdenes.MoveLastItem = Me.ToolStripButton4
        Me.bnOrdenes.MoveNextItem = Me.ToolStripButton3
        Me.bnOrdenes.MovePreviousItem = Me.ToolStripButton2
        Me.bnOrdenes.Name = "bnOrdenes"
        Me.bnOrdenes.PositionItem = Me.ToolStripTextBox2
        Me.bnOrdenes.Size = New System.Drawing.Size(1064, 30)
        Me.bnOrdenes.TabIndex = 61
        Me.bnOrdenes.Text = "BindingNavigator1"
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
        'ToolStripButtonAcciones
        '
        Me.ToolStripButtonAcciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonAcciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.ImprimirPlanillaToolStripMenuItem})
        Me.ToolStripButtonAcciones.Image = CType(resources.GetObject("ToolStripButtonAcciones.Image"), System.Drawing.Image)
        Me.ToolStripButtonAcciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAcciones.Name = "ToolStripButtonAcciones"
        Me.ToolStripButtonAcciones.Size = New System.Drawing.Size(68, 27)
        Me.ToolStripButtonAcciones.Text = "Acciones"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Enabled = False
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EditarToolStripMenuItem.Text = "Registrar Cajas"
        '
        'ImprimirPlanillaToolStripMenuItem
        '
        Me.ImprimirPlanillaToolStripMenuItem.Name = "ImprimirPlanillaToolStripMenuItem"
        Me.ImprimirPlanillaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ImprimirPlanillaToolStripMenuItem.Text = "Cambiar Estado"
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
        'dgvOrdenes
        '
        Me.dgvOrdenes.AllowUserToAddRows = False
        Me.dgvOrdenes.AllowUserToDeleteRows = False
        Me.dgvOrdenes.AllowUserToOrderColumns = True
        Me.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrdenes.Location = New System.Drawing.Point(3, 33)
        Me.dgvOrdenes.Name = "dgvOrdenes"
        Me.dgvOrdenes.ReadOnly = True
        Me.dgvOrdenes.ShowEditingIcon = False
        Me.dgvOrdenes.Size = New System.Drawing.Size(1058, 147)
        Me.dgvOrdenes.TabIndex = 62
        '
        'FormRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1084, 434)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormRuta"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Ruta"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageTransportador.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPageSincronizacion.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TabPageTiempos.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.bnOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnOrdenes.ResumeLayout(False)
        Me.bnOrdenes.PerformLayout()
        CType(Me.dgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelRutaId As Label
    Friend WithEvents LabelNumeroRuta As Label
    Friend WithEvents LabelMovil As Label
    Friend WithEvents LabelPlaca As Label
    Friend WithEvents LabelConductorIdentificacion As Label
    Friend WithEvents LabelEstadoRuta As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents bnOrdenes As BindingNavigator
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
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripButtonAcciones As ToolStripDropDownButton
    Friend WithEvents ImprimirPlanillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButtonSeleccionarTodosSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButtonInvertirSeleccionSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents dgvOrdenes As DataGridView
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageTransportador As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TabPageSincronizacion As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents LabelErrorSincronizacion As Label
    Friend WithEvents LabelIntentosSincronizacion As Label
    Friend WithEvents LabelFechaSincronizacion As Label
    Friend WithEvents LabelEstadoSincronizacion As Label
    Friend WithEvents TabPageTiempos As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents LabelHoraCitaCargue As Label
    Friend WithEvents LabelFechaCitaCargue As Label
    Friend WithEvents LabelConductorNombres As Label
    Friend WithEvents TextBoxEstadoRuta As TextBox
    Friend WithEvents TextBoxNumeroRuta As TextBox
    Friend WithEvents TextBoxConductorNombres As TextBox
    Friend WithEvents TextBoxConductorIdentificacion As TextBox
    Friend WithEvents TextBoxRutaId As TextBox
    Friend WithEvents TextBoxMovil As TextBox
    Friend WithEvents TextBoxPlaca As TextBox
    Friend WithEvents TextBoxErrorSincronizacion As TextBox
    Friend WithEvents TextBoxEstadoSincronizacion As TextBox
    Friend WithEvents TextBoxFechaSincronizacion As TextBox
    Friend WithEvents TextBoxIntentosSincronizacion As TextBox
    Friend WithEvents TextBoxHoraCitaCargue As TextBox
    Friend WithEvents TextBoxFechaCitaCargue As TextBox
    Friend WithEvents LabelCitaCargue As Label
End Class
