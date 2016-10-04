<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCerrarOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCerrarOrden))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControlOrden = New System.Windows.Forms.TabControl()
        Me.TabPageOrden = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelOrden = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBoxEstadoOrden = New System.Windows.Forms.TextBox()
        Me.TextBoxClienteCodigo = New System.Windows.Forms.TextBox()
        Me.LabelServicioNombre = New System.Windows.Forms.Label()
        Me.TextBoxServicioNombre = New System.Windows.Forms.TextBox()
        Me.LabelOrdenId = New System.Windows.Forms.Label()
        Me.TextBoxOrdenId = New System.Windows.Forms.TextBox()
        Me.LabelOrdenNumero = New System.Windows.Forms.Label()
        Me.TextBoxOrdenNumero = New System.Windows.Forms.TextBox()
        Me.LabelEstadoDistribucionActual = New System.Windows.Forms.Label()
        Me.TextBoxEstadoDistribucionActual = New System.Windows.Forms.TextBox()
        Me.ComboBoxEstadoOrdenNuevo = New System.Windows.Forms.ComboBox()
        Me.LabelFechaCita = New System.Windows.Forms.Label()
        Me.DTPFechaCita = New System.Windows.Forms.DateTimePicker()
        Me.LabelFechaEstimadaEntrega = New System.Windows.Forms.Label()
        Me.DTPFechaEstimadaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.LabelFechaInicioEntrega = New System.Windows.Forms.Label()
        Me.LabelFechaFinEntrega = New System.Windows.Forms.Label()
        Me.LabelClienteCodigo = New System.Windows.Forms.Label()
        Me.LabelEstadoOrdenNuevo = New System.Windows.Forms.Label()
        Me.LabelEstadoOrden = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DTPFechaInicioEntrega = New System.Windows.Forms.DateTimePicker()
        Me.DTPHoraInicioEntrega = New System.Windows.Forms.DateTimePicker()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DTPFechaFinEntrega = New System.Windows.Forms.DateTimePicker()
        Me.DTPHoraFinEntrega = New System.Windows.Forms.DateTimePicker()
        Me.TabPageDestinatario = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelDestinatarioIdentificacion = New System.Windows.Forms.Label()
        Me.TextBoxDestinatarioIdentificacion = New System.Windows.Forms.TextBox()
        Me.LabelDestinatarioNombre = New System.Windows.Forms.Label()
        Me.TextBoxDestinatarioNombre = New System.Windows.Forms.TextBox()
        Me.LabelDestinatarioEmail = New System.Windows.Forms.Label()
        Me.TextBoxDestinatarioEmail = New System.Windows.Forms.TextBox()
        Me.LabelDestinatarioContacto = New System.Windows.Forms.Label()
        Me.TextBoxDestinatarioContacto = New System.Windows.Forms.TextBox()
        Me.LabelDestinatarioTelefono = New System.Windows.Forms.Label()
        Me.TextBoxDestinatarioTelefono = New System.Windows.Forms.TextBox()
        Me.TabPageDestino = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelDestinoCiudad = New System.Windows.Forms.Label()
        Me.TextBoxDestinoCiudad = New System.Windows.Forms.TextBox()
        Me.LabelDestinoDireccion = New System.Windows.Forms.Label()
        Me.TextBoxDestinoDireccion = New System.Windows.Forms.TextBox()
        Me.LabelDestinoCodigo = New System.Windows.Forms.Label()
        Me.TextBoxDestinoCodigo = New System.Windows.Forms.TextBox()
        Me.LabelDestinoNombre = New System.Windows.Forms.Label()
        Me.TextBoxDestinoNombre = New System.Windows.Forms.TextBox()
        Me.LabelDestinoEmail = New System.Windows.Forms.Label()
        Me.TextBoxDestinoEmail = New System.Windows.Forms.TextBox()
        Me.LabelDestinoContacto = New System.Windows.Forms.Label()
        Me.TextBoxDestinoContacto = New System.Windows.Forms.TextBox()
        Me.LabelDestinoTelefono = New System.Windows.Forms.Label()
        Me.TextBoxDestinoTelefono = New System.Windows.Forms.TextBox()
        Me.TabPageOtros = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelValorRecaudo = New System.Windows.Forms.Label()
        Me.TextBoxValorRecaudo = New System.Windows.Forms.TextBox()
        Me.LabelUsuarioConfirmacion = New System.Windows.Forms.Label()
        Me.TextBoxUsuarioConfirmacion = New System.Windows.Forms.TextBox()
        Me.LabelNotasConfirmacion = New System.Windows.Forms.Label()
        Me.TextBoxNotasConfirmacion = New System.Windows.Forms.TextBox()
        Me.LabelFechaConfirmacion = New System.Windows.Forms.Label()
        Me.DTPFechaConfirmacion = New System.Windows.Forms.DateTimePicker()
        Me.LabelUsuarioAceptacion = New System.Windows.Forms.Label()
        Me.TextBoxUsuarioAceptacion = New System.Windows.Forms.TextBox()
        Me.LabelNotasAceptacion = New System.Windows.Forms.Label()
        Me.TextBoxNotasAceptacion = New System.Windows.Forms.TextBox()
        Me.LabelFechaAceptacion = New System.Windows.Forms.Label()
        Me.DTPFechaAceptacion = New System.Windows.Forms.DateTimePicker()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.TabPageNoEntregada = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCausalNoEntrega = New System.Windows.Forms.Label()
        Me.ComboBoxCausalNoEntrega = New System.Windows.Forms.ComboBox()
        Me.LabelCausalNoEntregaDescripcion = New System.Windows.Forms.Label()
        Me.TextBoxCausalNoEntregaDescripcion = New System.Windows.Forms.TextBox()
        Me.LabelIndicadorOTIF = New System.Windows.Forms.Label()
        Me.TextBoxIndicadorOTIF = New System.Windows.Forms.TextBox()
        Me.LabelCausalNoEntregaResponsable = New System.Windows.Forms.Label()
        Me.ComboBoxCausalNoEntregaResponsable = New System.Windows.Forms.ComboBox()
        Me.LabelCausalNoEntregaResponsableInterno = New System.Windows.Forms.Label()
        Me.ComboBoxCausalNoEntregaResponsableInterno = New System.Windows.Forms.ComboBox()
        Me.LabelCausalNoEntregaNotas = New System.Windows.Forms.Label()
        Me.TextBoxCausalNoEntregaNotas = New System.Windows.Forms.TextBox()
        Me.LabelNovedadUsuarioActualizacion = New System.Windows.Forms.Label()
        Me.TextBoxCausalNoEntregaUsuarioActualizacion = New System.Windows.Forms.TextBox()
        Me.LabelNovedadFechaActualizacion = New System.Windows.Forms.Label()
        Me.DTPCausalNoEntregaFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.TabPageLineas = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.bnLineas = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NuevaNovedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonSeleccionarTodosSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonInvertirSeleccionSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvLineas = New System.Windows.Forms.DataGridView()
        Me.TabPageNovedades = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.bnNovedades = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ModificarNovedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarNovedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.dgvNovedades = New System.Windows.Forms.DataGridView()
        Me.TabPageReprogramacion = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelCausalReprogramacion = New System.Windows.Forms.Label()
        Me.ComboBoxCausalReprogramacion = New System.Windows.Forms.ComboBox()
        Me.LabelCausalReprogramacionDescripcion = New System.Windows.Forms.Label()
        Me.TextBoxCausalReprogramacionDescripcion = New System.Windows.Forms.TextBox()
        Me.LabelCausalReprogramacionNotas = New System.Windows.Forms.Label()
        Me.TextBoxCausalReprogramacionNotas = New System.Windows.Forms.TextBox()
        Me.LabelCausalReprogramacionUsuarioActualizacion = New System.Windows.Forms.Label()
        Me.TextBoxCausalReprogramacionUsuarioActualizacion = New System.Windows.Forms.TextBox()
        Me.LabelCausalReprogramacionFechaActualizacion = New System.Windows.Forms.Label()
        Me.DTPCausalReprogramacionFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.LabelLine01 = New System.Windows.Forms.Label()
        Me.LabelReprogramacionFechaDesde = New System.Windows.Forms.Label()
        Me.DTPReprogramacionFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.DTPReprogramacionFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.LabelReprogramacionFechaHasta = New System.Windows.Forms.Label()
        Me.LabelAMPM = New System.Windows.Forms.Label()
        Me.ComboBoxAMPM = New System.Windows.Forms.ComboBox()
        Me.ComboBoxHoraMaxima = New System.Windows.Forms.ComboBox()
        Me.LabelHoraMaxima = New System.Windows.Forms.Label()
        Me.CheckBoxRequiereConfirmarCita = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRequiereServicioDistribucion = New System.Windows.Forms.CheckBox()
        Me.LabelHoras = New System.Windows.Forms.Label()
        Me.NUDHoras = New System.Windows.Forms.NumericUpDown()
        Me.LabelResumen = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControlOrden.SuspendLayout()
        Me.TabPageOrden.SuspendLayout()
        Me.TableLayoutPanelOrden.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabPageDestinatario.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPageDestino.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TabPageOtros.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.TabPageNoEntregada.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TabPageLineas.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.bnLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnLineas.SuspendLayout()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNovedades.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.bnNovedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnNovedades.SuspendLayout()
        CType(Me.dgvNovedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageReprogramacion.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.NUDHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 525.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(766, 572)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControlOrden)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Tab)
        Me.SplitContainer1.Size = New System.Drawing.Size(760, 519)
        Me.SplitContainer1.SplitterDistance = 213
        Me.SplitContainer1.TabIndex = 4
        '
        'TabControlOrden
        '
        Me.TabControlOrden.Controls.Add(Me.TabPageOrden)
        Me.TabControlOrden.Controls.Add(Me.TabPageDestinatario)
        Me.TabControlOrden.Controls.Add(Me.TabPageDestino)
        Me.TabControlOrden.Controls.Add(Me.TabPageOtros)
        Me.TabControlOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlOrden.Location = New System.Drawing.Point(0, 0)
        Me.TabControlOrden.Name = "TabControlOrden"
        Me.TabControlOrden.SelectedIndex = 0
        Me.TabControlOrden.Size = New System.Drawing.Size(756, 209)
        Me.TabControlOrden.TabIndex = 1
        '
        'TabPageOrden
        '
        Me.TabPageOrden.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageOrden.Controls.Add(Me.TableLayoutPanelOrden)
        Me.TabPageOrden.Location = New System.Drawing.Point(4, 22)
        Me.TabPageOrden.Name = "TabPageOrden"
        Me.TabPageOrden.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOrden.Size = New System.Drawing.Size(748, 183)
        Me.TabPageOrden.TabIndex = 3
        Me.TabPageOrden.Text = "Orden"
        '
        'TableLayoutPanelOrden
        '
        Me.TableLayoutPanelOrden.ColumnCount = 6
        Me.TableLayoutPanelOrden.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanelOrden.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanelOrden.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanelOrden.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanelOrden.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanelOrden.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelOrden.Controls.Add(Me.TextBoxEstadoOrden, 1, 2)
        Me.TableLayoutPanelOrden.Controls.Add(Me.TextBoxClienteCodigo, 1, 0)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelServicioNombre, 2, 0)
        Me.TableLayoutPanelOrden.Controls.Add(Me.TextBoxServicioNombre, 3, 0)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelOrdenId, 0, 1)
        Me.TableLayoutPanelOrden.Controls.Add(Me.TextBoxOrdenId, 1, 1)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelOrdenNumero, 2, 1)
        Me.TableLayoutPanelOrden.Controls.Add(Me.TextBoxOrdenNumero, 3, 1)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelEstadoDistribucionActual, 0, 3)
        Me.TableLayoutPanelOrden.Controls.Add(Me.TextBoxEstadoDistribucionActual, 1, 3)
        Me.TableLayoutPanelOrden.Controls.Add(Me.ComboBoxEstadoOrdenNuevo, 3, 2)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelFechaCita, 0, 4)
        Me.TableLayoutPanelOrden.Controls.Add(Me.DTPFechaCita, 1, 4)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelFechaEstimadaEntrega, 2, 4)
        Me.TableLayoutPanelOrden.Controls.Add(Me.DTPFechaEstimadaEntrega, 3, 4)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelFechaInicioEntrega, 0, 5)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelFechaFinEntrega, 2, 5)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelClienteCodigo, 0, 0)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelEstadoOrdenNuevo, 2, 2)
        Me.TableLayoutPanelOrden.Controls.Add(Me.LabelEstadoOrden, 0, 2)
        Me.TableLayoutPanelOrden.Controls.Add(Me.FlowLayoutPanel1, 1, 5)
        Me.TableLayoutPanelOrden.Controls.Add(Me.FlowLayoutPanel2, 3, 5)
        Me.TableLayoutPanelOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelOrden.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelOrden.Name = "TableLayoutPanelOrden"
        Me.TableLayoutPanelOrden.RowCount = 8
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelOrden.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelOrden.Size = New System.Drawing.Size(742, 177)
        Me.TableLayoutPanelOrden.TabIndex = 0
        '
        'TextBoxEstadoOrden
        '
        Me.TextBoxEstadoOrden.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxEstadoOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxEstadoOrden.Location = New System.Drawing.Point(98, 53)
        Me.TextBoxEstadoOrden.Name = "TextBoxEstadoOrden"
        Me.TextBoxEstadoOrden.ReadOnly = True
        Me.TextBoxEstadoOrden.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxEstadoOrden.TabIndex = 14
        '
        'TextBoxClienteCodigo
        '
        Me.TextBoxClienteCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxClienteCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxClienteCodigo.Location = New System.Drawing.Point(98, 3)
        Me.TextBoxClienteCodigo.Name = "TextBoxClienteCodigo"
        Me.TextBoxClienteCodigo.ReadOnly = True
        Me.TextBoxClienteCodigo.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxClienteCodigo.TabIndex = 10
        '
        'LabelServicioNombre
        '
        Me.LabelServicioNombre.AutoSize = True
        Me.LabelServicioNombre.Location = New System.Drawing.Point(298, 3)
        Me.LabelServicioNombre.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelServicioNombre.Name = "LabelServicioNombre"
        Me.LabelServicioNombre.Size = New System.Drawing.Size(45, 13)
        Me.LabelServicioNombre.TabIndex = 1
        Me.LabelServicioNombre.Text = "Servicio"
        '
        'TextBoxServicioNombre
        '
        Me.TextBoxServicioNombre.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxServicioNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxServicioNombre.Location = New System.Drawing.Point(393, 3)
        Me.TextBoxServicioNombre.Name = "TextBoxServicioNombre"
        Me.TextBoxServicioNombre.ReadOnly = True
        Me.TextBoxServicioNombre.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxServicioNombre.TabIndex = 11
        '
        'LabelOrdenId
        '
        Me.LabelOrdenId.AutoSize = True
        Me.LabelOrdenId.Location = New System.Drawing.Point(3, 28)
        Me.LabelOrdenId.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelOrdenId.Name = "LabelOrdenId"
        Me.LabelOrdenId.Size = New System.Drawing.Size(18, 13)
        Me.LabelOrdenId.TabIndex = 2
        Me.LabelOrdenId.Text = "ID"
        '
        'TextBoxOrdenId
        '
        Me.TextBoxOrdenId.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxOrdenId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOrdenId.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxOrdenId.Name = "TextBoxOrdenId"
        Me.TextBoxOrdenId.ReadOnly = True
        Me.TextBoxOrdenId.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxOrdenId.TabIndex = 12
        '
        'LabelOrdenNumero
        '
        Me.LabelOrdenNumero.AutoSize = True
        Me.LabelOrdenNumero.Location = New System.Drawing.Point(298, 28)
        Me.LabelOrdenNumero.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelOrdenNumero.Name = "LabelOrdenNumero"
        Me.LabelOrdenNumero.Size = New System.Drawing.Size(76, 13)
        Me.LabelOrdenNumero.TabIndex = 3
        Me.LabelOrdenNumero.Text = "Número Orden"
        '
        'TextBoxOrdenNumero
        '
        Me.TextBoxOrdenNumero.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxOrdenNumero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOrdenNumero.Location = New System.Drawing.Point(393, 28)
        Me.TextBoxOrdenNumero.Name = "TextBoxOrdenNumero"
        Me.TextBoxOrdenNumero.ReadOnly = True
        Me.TextBoxOrdenNumero.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxOrdenNumero.TabIndex = 13
        '
        'LabelEstadoDistribucionActual
        '
        Me.LabelEstadoDistribucionActual.AutoSize = True
        Me.LabelEstadoDistribucionActual.Location = New System.Drawing.Point(3, 78)
        Me.LabelEstadoDistribucionActual.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelEstadoDistribucionActual.Name = "LabelEstadoDistribucionActual"
        Me.LabelEstadoDistribucionActual.Size = New System.Drawing.Size(64, 13)
        Me.LabelEstadoDistribucionActual.TabIndex = 4
        Me.LabelEstadoDistribucionActual.Text = "Estado Dist."
        '
        'TextBoxEstadoDistribucionActual
        '
        Me.TextBoxEstadoDistribucionActual.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxEstadoDistribucionActual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxEstadoDistribucionActual.Location = New System.Drawing.Point(98, 78)
        Me.TextBoxEstadoDistribucionActual.Name = "TextBoxEstadoDistribucionActual"
        Me.TextBoxEstadoDistribucionActual.ReadOnly = True
        Me.TextBoxEstadoDistribucionActual.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxEstadoDistribucionActual.TabIndex = 16
        '
        'ComboBoxEstadoOrdenNuevo
        '
        Me.TableLayoutPanelOrden.SetColumnSpan(Me.ComboBoxEstadoOrdenNuevo, 2)
        Me.ComboBoxEstadoOrdenNuevo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxEstadoOrdenNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstadoOrdenNuevo.FormattingEnabled = True
        Me.ComboBoxEstadoOrdenNuevo.Location = New System.Drawing.Point(393, 53)
        Me.ComboBoxEstadoOrdenNuevo.Name = "ComboBoxEstadoOrdenNuevo"
        Me.ComboBoxEstadoOrdenNuevo.Size = New System.Drawing.Size(289, 21)
        Me.ComboBoxEstadoOrdenNuevo.TabIndex = 15
        '
        'LabelFechaCita
        '
        Me.LabelFechaCita.AutoSize = True
        Me.LabelFechaCita.Location = New System.Drawing.Point(3, 103)
        Me.LabelFechaCita.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaCita.Name = "LabelFechaCita"
        Me.LabelFechaCita.Size = New System.Drawing.Size(37, 13)
        Me.LabelFechaCita.TabIndex = 5
        Me.LabelFechaCita.Text = "F. Cita"
        '
        'DTPFechaCita
        '
        Me.DTPFechaCita.CustomFormat = "dd/MM/yyyy"
        Me.DTPFechaCita.Enabled = False
        Me.DTPFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaCita.Location = New System.Drawing.Point(98, 103)
        Me.DTPFechaCita.Name = "DTPFechaCita"
        Me.DTPFechaCita.Size = New System.Drawing.Size(144, 20)
        Me.DTPFechaCita.TabIndex = 1617
        '
        'LabelFechaEstimadaEntrega
        '
        Me.LabelFechaEstimadaEntrega.AutoSize = True
        Me.LabelFechaEstimadaEntrega.Location = New System.Drawing.Point(298, 103)
        Me.LabelFechaEstimadaEntrega.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaEstimadaEntrega.Name = "LabelFechaEstimadaEntrega"
        Me.LabelFechaEstimadaEntrega.Size = New System.Drawing.Size(62, 13)
        Me.LabelFechaEstimadaEntrega.TabIndex = 6
        Me.LabelFechaEstimadaEntrega.Text = "F. Estimada"
        '
        'DTPFechaEstimadaEntrega
        '
        Me.DTPFechaEstimadaEntrega.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTPFechaEstimadaEntrega.Enabled = False
        Me.DTPFechaEstimadaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaEstimadaEntrega.Location = New System.Drawing.Point(393, 103)
        Me.DTPFechaEstimadaEntrega.Name = "DTPFechaEstimadaEntrega"
        Me.DTPFechaEstimadaEntrega.Size = New System.Drawing.Size(144, 20)
        Me.DTPFechaEstimadaEntrega.TabIndex = 18
        '
        'LabelFechaInicioEntrega
        '
        Me.LabelFechaInicioEntrega.AutoSize = True
        Me.LabelFechaInicioEntrega.Location = New System.Drawing.Point(3, 128)
        Me.LabelFechaInicioEntrega.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaInicioEntrega.Name = "LabelFechaInicioEntrega"
        Me.LabelFechaInicioEntrega.Size = New System.Drawing.Size(84, 13)
        Me.LabelFechaInicioEntrega.TabIndex = 7
        Me.LabelFechaInicioEntrega.Text = "F. Inicio Entrega"
        '
        'LabelFechaFinEntrega
        '
        Me.LabelFechaFinEntrega.AutoSize = True
        Me.LabelFechaFinEntrega.Location = New System.Drawing.Point(298, 128)
        Me.LabelFechaFinEntrega.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaFinEntrega.Name = "LabelFechaFinEntrega"
        Me.LabelFechaFinEntrega.Size = New System.Drawing.Size(73, 13)
        Me.LabelFechaFinEntrega.TabIndex = 8
        Me.LabelFechaFinEntrega.Text = "F. Fin Entrega"
        '
        'LabelClienteCodigo
        '
        Me.LabelClienteCodigo.AutoSize = True
        Me.LabelClienteCodigo.Location = New System.Drawing.Point(3, 3)
        Me.LabelClienteCodigo.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelClienteCodigo.Name = "LabelClienteCodigo"
        Me.LabelClienteCodigo.Size = New System.Drawing.Size(39, 13)
        Me.LabelClienteCodigo.TabIndex = 23
        Me.LabelClienteCodigo.Text = "Cliente"
        '
        'LabelEstadoOrdenNuevo
        '
        Me.LabelEstadoOrdenNuevo.AutoSize = True
        Me.LabelEstadoOrdenNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoOrdenNuevo.ForeColor = System.Drawing.Color.Red
        Me.LabelEstadoOrdenNuevo.Location = New System.Drawing.Point(298, 53)
        Me.LabelEstadoOrdenNuevo.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelEstadoOrdenNuevo.Name = "LabelEstadoOrdenNuevo"
        Me.LabelEstadoOrdenNuevo.Size = New System.Drawing.Size(87, 13)
        Me.LabelEstadoOrdenNuevo.TabIndex = 0
        Me.LabelEstadoOrdenNuevo.Text = "Nuevo Estado"
        '
        'LabelEstadoOrden
        '
        Me.LabelEstadoOrden.AutoSize = True
        Me.LabelEstadoOrden.Location = New System.Drawing.Point(3, 53)
        Me.LabelEstadoOrden.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelEstadoOrden.Name = "LabelEstadoOrden"
        Me.LabelEstadoOrden.Size = New System.Drawing.Size(72, 13)
        Me.LabelEstadoOrden.TabIndex = 1618
        Me.LabelEstadoOrden.Text = "Estado Orden"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.DTPFechaInicioEntrega)
        Me.FlowLayoutPanel1.Controls.Add(Me.DTPHoraInicioEntrega)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(95, 125)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 25)
        Me.FlowLayoutPanel1.TabIndex = 1619
        '
        'DTPFechaInicioEntrega
        '
        Me.DTPFechaInicioEntrega.CustomFormat = "dd/MM/yyyy"
        Me.DTPFechaInicioEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaInicioEntrega.Location = New System.Drawing.Point(3, 3)
        Me.DTPFechaInicioEntrega.Name = "DTPFechaInicioEntrega"
        Me.DTPFechaInicioEntrega.Size = New System.Drawing.Size(82, 20)
        Me.DTPFechaInicioEntrega.TabIndex = 19
        '
        'DTPHoraInicioEntrega
        '
        Me.DTPHoraInicioEntrega.CustomFormat = "HH:mm"
        Me.DTPHoraInicioEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPHoraInicioEntrega.Location = New System.Drawing.Point(91, 3)
        Me.DTPHoraInicioEntrega.Name = "DTPHoraInicioEntrega"
        Me.DTPHoraInicioEntrega.ShowUpDown = True
        Me.DTPHoraInicioEntrega.Size = New System.Drawing.Size(56, 20)
        Me.DTPHoraInicioEntrega.TabIndex = 21
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.DTPFechaFinEntrega)
        Me.FlowLayoutPanel2.Controls.Add(Me.DTPHoraFinEntrega)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(390, 125)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 25)
        Me.FlowLayoutPanel2.TabIndex = 1620
        '
        'DTPFechaFinEntrega
        '
        Me.DTPFechaFinEntrega.CustomFormat = "dd/MM/yyyy"
        Me.DTPFechaFinEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaFinEntrega.Location = New System.Drawing.Point(3, 3)
        Me.DTPFechaFinEntrega.Name = "DTPFechaFinEntrega"
        Me.DTPFechaFinEntrega.Size = New System.Drawing.Size(82, 20)
        Me.DTPFechaFinEntrega.TabIndex = 20
        '
        'DTPHoraFinEntrega
        '
        Me.DTPHoraFinEntrega.CustomFormat = "HH:mm"
        Me.DTPHoraFinEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPHoraFinEntrega.Location = New System.Drawing.Point(91, 3)
        Me.DTPHoraFinEntrega.Name = "DTPHoraFinEntrega"
        Me.DTPHoraFinEntrega.ShowUpDown = True
        Me.DTPHoraFinEntrega.Size = New System.Drawing.Size(56, 20)
        Me.DTPHoraFinEntrega.TabIndex = 22
        '
        'TabPageDestinatario
        '
        Me.TabPageDestinatario.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageDestinatario.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPageDestinatario.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDestinatario.Name = "TabPageDestinatario"
        Me.TabPageDestinatario.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDestinatario.Size = New System.Drawing.Size(748, 183)
        Me.TabPageDestinatario.TabIndex = 0
        Me.TabPageDestinatario.Text = "Destinatario"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LabelDestinatarioIdentificacion, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxDestinatarioIdentificacion, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelDestinatarioNombre, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxDestinatarioNombre, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelDestinatarioEmail, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxDestinatarioEmail, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelDestinatarioContacto, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxDestinatarioContacto, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelDestinatarioTelefono, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBoxDestinatarioTelefono, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(742, 177)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'LabelDestinatarioIdentificacion
        '
        Me.LabelDestinatarioIdentificacion.AutoSize = True
        Me.LabelDestinatarioIdentificacion.Location = New System.Drawing.Point(3, 3)
        Me.LabelDestinatarioIdentificacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinatarioIdentificacion.Name = "LabelDestinatarioIdentificacion"
        Me.LabelDestinatarioIdentificacion.Size = New System.Drawing.Size(25, 13)
        Me.LabelDestinatarioIdentificacion.TabIndex = 0
        Me.LabelDestinatarioIdentificacion.Text = "NIT"
        '
        'TextBoxDestinatarioIdentificacion
        '
        Me.TextBoxDestinatarioIdentificacion.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinatarioIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinatarioIdentificacion.Location = New System.Drawing.Point(98, 3)
        Me.TextBoxDestinatarioIdentificacion.Name = "TextBoxDestinatarioIdentificacion"
        Me.TextBoxDestinatarioIdentificacion.ReadOnly = True
        Me.TextBoxDestinatarioIdentificacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDestinatarioIdentificacion.TabIndex = 200
        '
        'LabelDestinatarioNombre
        '
        Me.LabelDestinatarioNombre.AutoSize = True
        Me.LabelDestinatarioNombre.Location = New System.Drawing.Point(248, 3)
        Me.LabelDestinatarioNombre.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinatarioNombre.Name = "LabelDestinatarioNombre"
        Me.LabelDestinatarioNombre.Size = New System.Drawing.Size(44, 13)
        Me.LabelDestinatarioNombre.TabIndex = 1
        Me.LabelDestinatarioNombre.Text = "Nombre"
        '
        'TextBoxDestinatarioNombre
        '
        Me.TextBoxDestinatarioNombre.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxDestinatarioNombre, 2)
        Me.TextBoxDestinatarioNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinatarioNombre.Location = New System.Drawing.Point(343, 3)
        Me.TextBoxDestinatarioNombre.Name = "TextBoxDestinatarioNombre"
        Me.TextBoxDestinatarioNombre.ReadOnly = True
        Me.TextBoxDestinatarioNombre.Size = New System.Drawing.Size(396, 20)
        Me.TextBoxDestinatarioNombre.TabIndex = 201
        '
        'LabelDestinatarioEmail
        '
        Me.LabelDestinatarioEmail.AutoSize = True
        Me.LabelDestinatarioEmail.Location = New System.Drawing.Point(3, 28)
        Me.LabelDestinatarioEmail.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinatarioEmail.Name = "LabelDestinatarioEmail"
        Me.LabelDestinatarioEmail.Size = New System.Drawing.Size(35, 13)
        Me.LabelDestinatarioEmail.TabIndex = 2
        Me.LabelDestinatarioEmail.Text = "E-mail"
        '
        'TextBoxDestinatarioEmail
        '
        Me.TextBoxDestinatarioEmail.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinatarioEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinatarioEmail.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxDestinatarioEmail.Name = "TextBoxDestinatarioEmail"
        Me.TextBoxDestinatarioEmail.ReadOnly = True
        Me.TextBoxDestinatarioEmail.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDestinatarioEmail.TabIndex = 202
        '
        'LabelDestinatarioContacto
        '
        Me.LabelDestinatarioContacto.AutoSize = True
        Me.LabelDestinatarioContacto.Location = New System.Drawing.Point(248, 28)
        Me.LabelDestinatarioContacto.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinatarioContacto.Name = "LabelDestinatarioContacto"
        Me.LabelDestinatarioContacto.Size = New System.Drawing.Size(50, 13)
        Me.LabelDestinatarioContacto.TabIndex = 3
        Me.LabelDestinatarioContacto.Text = "Contacto"
        '
        'TextBoxDestinatarioContacto
        '
        Me.TextBoxDestinatarioContacto.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel3.SetColumnSpan(Me.TextBoxDestinatarioContacto, 2)
        Me.TextBoxDestinatarioContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinatarioContacto.Location = New System.Drawing.Point(343, 28)
        Me.TextBoxDestinatarioContacto.Name = "TextBoxDestinatarioContacto"
        Me.TextBoxDestinatarioContacto.ReadOnly = True
        Me.TextBoxDestinatarioContacto.Size = New System.Drawing.Size(396, 20)
        Me.TextBoxDestinatarioContacto.TabIndex = 203
        '
        'LabelDestinatarioTelefono
        '
        Me.LabelDestinatarioTelefono.AutoSize = True
        Me.LabelDestinatarioTelefono.Location = New System.Drawing.Point(3, 53)
        Me.LabelDestinatarioTelefono.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinatarioTelefono.Name = "LabelDestinatarioTelefono"
        Me.LabelDestinatarioTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LabelDestinatarioTelefono.TabIndex = 4
        Me.LabelDestinatarioTelefono.Text = "Teléfono"
        '
        'TextBoxDestinatarioTelefono
        '
        Me.TextBoxDestinatarioTelefono.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinatarioTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinatarioTelefono.Location = New System.Drawing.Point(98, 53)
        Me.TextBoxDestinatarioTelefono.Name = "TextBoxDestinatarioTelefono"
        Me.TextBoxDestinatarioTelefono.ReadOnly = True
        Me.TextBoxDestinatarioTelefono.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDestinatarioTelefono.TabIndex = 204
        '
        'TabPageDestino
        '
        Me.TabPageDestino.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageDestino.Controls.Add(Me.TableLayoutPanel4)
        Me.TabPageDestino.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDestino.Name = "TabPageDestino"
        Me.TabPageDestino.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDestino.Size = New System.Drawing.Size(748, 183)
        Me.TabPageDestino.TabIndex = 1
        Me.TabPageDestino.Text = "Punto"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDestinoCiudad, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDestinoCiudad, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDestinoDireccion, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDestinoDireccion, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDestinoCodigo, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDestinoCodigo, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDestinoNombre, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDestinoNombre, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDestinoEmail, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDestinoEmail, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDestinoContacto, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDestinoContacto, 3, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDestinoTelefono, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TextBoxDestinoTelefono, 1, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(742, 177)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'LabelDestinoCiudad
        '
        Me.LabelDestinoCiudad.AutoSize = True
        Me.LabelDestinoCiudad.Location = New System.Drawing.Point(3, 3)
        Me.LabelDestinoCiudad.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinoCiudad.Name = "LabelDestinoCiudad"
        Me.LabelDestinoCiudad.Size = New System.Drawing.Size(40, 13)
        Me.LabelDestinoCiudad.TabIndex = 0
        Me.LabelDestinoCiudad.Text = "Ciudad"
        '
        'TextBoxDestinoCiudad
        '
        Me.TextBoxDestinoCiudad.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinoCiudad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinoCiudad.Location = New System.Drawing.Point(98, 3)
        Me.TextBoxDestinoCiudad.Name = "TextBoxDestinoCiudad"
        Me.TextBoxDestinoCiudad.ReadOnly = True
        Me.TextBoxDestinoCiudad.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDestinoCiudad.TabIndex = 251
        '
        'LabelDestinoDireccion
        '
        Me.LabelDestinoDireccion.AutoSize = True
        Me.LabelDestinoDireccion.Location = New System.Drawing.Point(248, 3)
        Me.LabelDestinoDireccion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinoDireccion.Name = "LabelDestinoDireccion"
        Me.LabelDestinoDireccion.Size = New System.Drawing.Size(52, 13)
        Me.LabelDestinoDireccion.TabIndex = 1
        Me.LabelDestinoDireccion.Text = "Dirección"
        '
        'TextBoxDestinoDireccion
        '
        Me.TextBoxDestinoDireccion.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel4.SetColumnSpan(Me.TextBoxDestinoDireccion, 2)
        Me.TextBoxDestinoDireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinoDireccion.Location = New System.Drawing.Point(343, 3)
        Me.TextBoxDestinoDireccion.Name = "TextBoxDestinoDireccion"
        Me.TextBoxDestinoDireccion.ReadOnly = True
        Me.TextBoxDestinoDireccion.Size = New System.Drawing.Size(396, 20)
        Me.TextBoxDestinoDireccion.TabIndex = 252
        '
        'LabelDestinoCodigo
        '
        Me.LabelDestinoCodigo.AutoSize = True
        Me.LabelDestinoCodigo.Location = New System.Drawing.Point(3, 28)
        Me.LabelDestinoCodigo.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinoCodigo.Name = "LabelDestinoCodigo"
        Me.LabelDestinoCodigo.Size = New System.Drawing.Size(40, 13)
        Me.LabelDestinoCodigo.TabIndex = 14
        Me.LabelDestinoCodigo.Text = "Código"
        '
        'TextBoxDestinoCodigo
        '
        Me.TextBoxDestinoCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinoCodigo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxDestinoCodigo.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxDestinoCodigo.Name = "TextBoxDestinoCodigo"
        Me.TextBoxDestinoCodigo.ReadOnly = True
        Me.TextBoxDestinoCodigo.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDestinoCodigo.TabIndex = 253
        '
        'LabelDestinoNombre
        '
        Me.LabelDestinoNombre.AutoSize = True
        Me.LabelDestinoNombre.Location = New System.Drawing.Point(248, 28)
        Me.LabelDestinoNombre.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinoNombre.Name = "LabelDestinoNombre"
        Me.LabelDestinoNombre.Size = New System.Drawing.Size(44, 13)
        Me.LabelDestinoNombre.TabIndex = 16
        Me.LabelDestinoNombre.Text = "Nombre"
        '
        'TextBoxDestinoNombre
        '
        Me.TextBoxDestinoNombre.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel4.SetColumnSpan(Me.TextBoxDestinoNombre, 2)
        Me.TextBoxDestinoNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinoNombre.Location = New System.Drawing.Point(343, 28)
        Me.TextBoxDestinoNombre.Name = "TextBoxDestinoNombre"
        Me.TextBoxDestinoNombre.ReadOnly = True
        Me.TextBoxDestinoNombre.Size = New System.Drawing.Size(396, 20)
        Me.TextBoxDestinoNombre.TabIndex = 254
        '
        'LabelDestinoEmail
        '
        Me.LabelDestinoEmail.AutoSize = True
        Me.LabelDestinoEmail.Location = New System.Drawing.Point(3, 53)
        Me.LabelDestinoEmail.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinoEmail.Name = "LabelDestinoEmail"
        Me.LabelDestinoEmail.Size = New System.Drawing.Size(35, 13)
        Me.LabelDestinoEmail.TabIndex = 2
        Me.LabelDestinoEmail.Text = "E-mail"
        '
        'TextBoxDestinoEmail
        '
        Me.TextBoxDestinoEmail.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinoEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinoEmail.Location = New System.Drawing.Point(98, 53)
        Me.TextBoxDestinoEmail.Name = "TextBoxDestinoEmail"
        Me.TextBoxDestinoEmail.ReadOnly = True
        Me.TextBoxDestinoEmail.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDestinoEmail.TabIndex = 255
        '
        'LabelDestinoContacto
        '
        Me.LabelDestinoContacto.AutoSize = True
        Me.LabelDestinoContacto.Location = New System.Drawing.Point(248, 53)
        Me.LabelDestinoContacto.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinoContacto.Name = "LabelDestinoContacto"
        Me.LabelDestinoContacto.Size = New System.Drawing.Size(50, 13)
        Me.LabelDestinoContacto.TabIndex = 3
        Me.LabelDestinoContacto.Text = "Contacto"
        '
        'TextBoxDestinoContacto
        '
        Me.TextBoxDestinoContacto.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel4.SetColumnSpan(Me.TextBoxDestinoContacto, 2)
        Me.TextBoxDestinoContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinoContacto.Location = New System.Drawing.Point(343, 53)
        Me.TextBoxDestinoContacto.Name = "TextBoxDestinoContacto"
        Me.TextBoxDestinoContacto.ReadOnly = True
        Me.TextBoxDestinoContacto.Size = New System.Drawing.Size(396, 20)
        Me.TextBoxDestinoContacto.TabIndex = 256
        '
        'LabelDestinoTelefono
        '
        Me.LabelDestinoTelefono.AutoSize = True
        Me.LabelDestinoTelefono.Location = New System.Drawing.Point(3, 78)
        Me.LabelDestinoTelefono.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDestinoTelefono.Name = "LabelDestinoTelefono"
        Me.LabelDestinoTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LabelDestinoTelefono.TabIndex = 4
        Me.LabelDestinoTelefono.Text = "Teléfono"
        '
        'TextBoxDestinoTelefono
        '
        Me.TextBoxDestinoTelefono.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxDestinoTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDestinoTelefono.Location = New System.Drawing.Point(98, 78)
        Me.TextBoxDestinoTelefono.Name = "TextBoxDestinoTelefono"
        Me.TextBoxDestinoTelefono.ReadOnly = True
        Me.TextBoxDestinoTelefono.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDestinoTelefono.TabIndex = 257
        '
        'TabPageOtros
        '
        Me.TabPageOtros.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageOtros.Controls.Add(Me.TableLayoutPanel5)
        Me.TabPageOtros.Location = New System.Drawing.Point(4, 22)
        Me.TabPageOtros.Name = "TabPageOtros"
        Me.TabPageOtros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOtros.Size = New System.Drawing.Size(748, 183)
        Me.TabPageOtros.TabIndex = 2
        Me.TabPageOtros.Text = "Otros datos"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.LabelValorRecaudo, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxValorRecaudo, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelUsuarioConfirmacion, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxUsuarioConfirmacion, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelNotasConfirmacion, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxNotasConfirmacion, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelFechaConfirmacion, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.DTPFechaConfirmacion, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelUsuarioAceptacion, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxUsuarioAceptacion, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelNotasAceptacion, 2, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBoxNotasAceptacion, 3, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.LabelFechaAceptacion, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.DTPFechaAceptacion, 1, 4)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(742, 177)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'LabelValorRecaudo
        '
        Me.LabelValorRecaudo.AutoSize = True
        Me.LabelValorRecaudo.Location = New System.Drawing.Point(3, 3)
        Me.LabelValorRecaudo.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelValorRecaudo.Name = "LabelValorRecaudo"
        Me.LabelValorRecaudo.Size = New System.Drawing.Size(78, 13)
        Me.LabelValorRecaudo.TabIndex = 0
        Me.LabelValorRecaudo.Text = "Valor Recaudo"
        '
        'TextBoxValorRecaudo
        '
        Me.TextBoxValorRecaudo.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxValorRecaudo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxValorRecaudo.Location = New System.Drawing.Point(98, 3)
        Me.TextBoxValorRecaudo.Name = "TextBoxValorRecaudo"
        Me.TextBoxValorRecaudo.ReadOnly = True
        Me.TextBoxValorRecaudo.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxValorRecaudo.TabIndex = 300
        '
        'LabelUsuarioConfirmacion
        '
        Me.LabelUsuarioConfirmacion.AutoSize = True
        Me.LabelUsuarioConfirmacion.Location = New System.Drawing.Point(3, 28)
        Me.LabelUsuarioConfirmacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelUsuarioConfirmacion.Name = "LabelUsuarioConfirmacion"
        Me.LabelUsuarioConfirmacion.Size = New System.Drawing.Size(82, 13)
        Me.LabelUsuarioConfirmacion.TabIndex = 2
        Me.LabelUsuarioConfirmacion.Text = "U. Confirmación"
        '
        'TextBoxUsuarioConfirmacion
        '
        Me.TextBoxUsuarioConfirmacion.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxUsuarioConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxUsuarioConfirmacion.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxUsuarioConfirmacion.Name = "TextBoxUsuarioConfirmacion"
        Me.TextBoxUsuarioConfirmacion.ReadOnly = True
        Me.TextBoxUsuarioConfirmacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxUsuarioConfirmacion.TabIndex = 301
        '
        'LabelNotasConfirmacion
        '
        Me.LabelNotasConfirmacion.AutoSize = True
        Me.LabelNotasConfirmacion.Location = New System.Drawing.Point(248, 28)
        Me.LabelNotasConfirmacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNotasConfirmacion.Name = "LabelNotasConfirmacion"
        Me.LabelNotasConfirmacion.Size = New System.Drawing.Size(63, 13)
        Me.LabelNotasConfirmacion.TabIndex = 3
        Me.LabelNotasConfirmacion.Text = "Notas Conf."
        '
        'TextBoxNotasConfirmacion
        '
        Me.TextBoxNotasConfirmacion.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel5.SetColumnSpan(Me.TextBoxNotasConfirmacion, 2)
        Me.TextBoxNotasConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNotasConfirmacion.Location = New System.Drawing.Point(343, 28)
        Me.TextBoxNotasConfirmacion.Multiline = True
        Me.TextBoxNotasConfirmacion.Name = "TextBoxNotasConfirmacion"
        Me.TextBoxNotasConfirmacion.ReadOnly = True
        Me.TableLayoutPanel5.SetRowSpan(Me.TextBoxNotasConfirmacion, 2)
        Me.TextBoxNotasConfirmacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxNotasConfirmacion.Size = New System.Drawing.Size(396, 44)
        Me.TextBoxNotasConfirmacion.TabIndex = 303
        '
        'LabelFechaConfirmacion
        '
        Me.LabelFechaConfirmacion.AutoSize = True
        Me.LabelFechaConfirmacion.Location = New System.Drawing.Point(3, 53)
        Me.LabelFechaConfirmacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaConfirmacion.Name = "LabelFechaConfirmacion"
        Me.LabelFechaConfirmacion.Size = New System.Drawing.Size(80, 13)
        Me.LabelFechaConfirmacion.TabIndex = 16
        Me.LabelFechaConfirmacion.Text = "F. Confirmación"
        '
        'DTPFechaConfirmacion
        '
        Me.DTPFechaConfirmacion.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTPFechaConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPFechaConfirmacion.Enabled = False
        Me.DTPFechaConfirmacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaConfirmacion.Location = New System.Drawing.Point(98, 53)
        Me.DTPFechaConfirmacion.Name = "DTPFechaConfirmacion"
        Me.DTPFechaConfirmacion.Size = New System.Drawing.Size(144, 20)
        Me.DTPFechaConfirmacion.TabIndex = 302
        '
        'LabelUsuarioAceptacion
        '
        Me.LabelUsuarioAceptacion.AutoSize = True
        Me.LabelUsuarioAceptacion.Location = New System.Drawing.Point(3, 78)
        Me.LabelUsuarioAceptacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelUsuarioAceptacion.Name = "LabelUsuarioAceptacion"
        Me.LabelUsuarioAceptacion.Size = New System.Drawing.Size(75, 13)
        Me.LabelUsuarioAceptacion.TabIndex = 4
        Me.LabelUsuarioAceptacion.Text = "U. Aceptación"
        '
        'TextBoxUsuarioAceptacion
        '
        Me.TextBoxUsuarioAceptacion.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxUsuarioAceptacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxUsuarioAceptacion.Location = New System.Drawing.Point(98, 78)
        Me.TextBoxUsuarioAceptacion.Name = "TextBoxUsuarioAceptacion"
        Me.TextBoxUsuarioAceptacion.ReadOnly = True
        Me.TextBoxUsuarioAceptacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxUsuarioAceptacion.TabIndex = 304
        '
        'LabelNotasAceptacion
        '
        Me.LabelNotasAceptacion.AutoSize = True
        Me.LabelNotasAceptacion.Location = New System.Drawing.Point(248, 78)
        Me.LabelNotasAceptacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNotasAceptacion.Name = "LabelNotasAceptacion"
        Me.LabelNotasAceptacion.Size = New System.Drawing.Size(69, 13)
        Me.LabelNotasAceptacion.TabIndex = 14
        Me.LabelNotasAceptacion.Text = "Notas Acept."
        '
        'TextBoxNotasAceptacion
        '
        Me.TextBoxNotasAceptacion.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel5.SetColumnSpan(Me.TextBoxNotasAceptacion, 2)
        Me.TextBoxNotasAceptacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNotasAceptacion.Location = New System.Drawing.Point(343, 78)
        Me.TextBoxNotasAceptacion.Multiline = True
        Me.TextBoxNotasAceptacion.Name = "TextBoxNotasAceptacion"
        Me.TextBoxNotasAceptacion.ReadOnly = True
        Me.TableLayoutPanel5.SetRowSpan(Me.TextBoxNotasAceptacion, 2)
        Me.TextBoxNotasAceptacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxNotasAceptacion.Size = New System.Drawing.Size(396, 44)
        Me.TextBoxNotasAceptacion.TabIndex = 306
        '
        'LabelFechaAceptacion
        '
        Me.LabelFechaAceptacion.AutoSize = True
        Me.LabelFechaAceptacion.Location = New System.Drawing.Point(3, 103)
        Me.LabelFechaAceptacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelFechaAceptacion.Name = "LabelFechaAceptacion"
        Me.LabelFechaAceptacion.Size = New System.Drawing.Size(73, 13)
        Me.LabelFechaAceptacion.TabIndex = 18
        Me.LabelFechaAceptacion.Text = "F. Aceptación"
        '
        'DTPFechaAceptacion
        '
        Me.DTPFechaAceptacion.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTPFechaAceptacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPFechaAceptacion.Enabled = False
        Me.DTPFechaAceptacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaAceptacion.Location = New System.Drawing.Point(98, 103)
        Me.DTPFechaAceptacion.Name = "DTPFechaAceptacion"
        Me.DTPFechaAceptacion.Size = New System.Drawing.Size(144, 20)
        Me.DTPFechaAceptacion.TabIndex = 305
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabPageNoEntregada)
        Me.Tab.Controls.Add(Me.TabPageLineas)
        Me.Tab.Controls.Add(Me.TabPageNovedades)
        Me.Tab.Controls.Add(Me.TabPageReprogramacion)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(756, 298)
        Me.Tab.TabIndex = 3
        '
        'TabPageNoEntregada
        '
        Me.TabPageNoEntregada.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageNoEntregada.Controls.Add(Me.TableLayoutPanel6)
        Me.TabPageNoEntregada.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNoEntregada.Name = "TabPageNoEntregada"
        Me.TabPageNoEntregada.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNoEntregada.Size = New System.Drawing.Size(748, 272)
        Me.TabPageNoEntregada.TabIndex = 0
        Me.TabPageNoEntregada.Text = "NO ENTREGADA"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntrega, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxCausalNoEntrega, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaDescripcion, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCausalNoEntregaDescripcion, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelIndicadorOTIF, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxIndicadorOTIF, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaResponsable, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxCausalNoEntregaResponsable, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaResponsableInterno, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxCausalNoEntregaResponsableInterno, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaNotas, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCausalNoEntregaNotas, 1, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelNovedadUsuarioActualizacion, 0, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCausalNoEntregaUsuarioActualizacion, 1, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelNovedadFechaActualizacion, 2, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.DTPCausalNoEntregaFechaActualizacion, 3, 8)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 10
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(742, 266)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'LabelCausalNoEntrega
        '
        Me.LabelCausalNoEntrega.AutoSize = True
        Me.LabelCausalNoEntrega.Location = New System.Drawing.Point(3, 3)
        Me.LabelCausalNoEntrega.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntrega.Name = "LabelCausalNoEntrega"
        Me.LabelCausalNoEntrega.Size = New System.Drawing.Size(39, 13)
        Me.LabelCausalNoEntrega.TabIndex = 0
        Me.LabelCausalNoEntrega.Text = "Causal"
        '
        'ComboBoxCausalNoEntrega
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.ComboBoxCausalNoEntrega, 3)
        Me.ComboBoxCausalNoEntrega.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCausalNoEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCausalNoEntrega.FormattingEnabled = True
        Me.ComboBoxCausalNoEntrega.Location = New System.Drawing.Point(98, 3)
        Me.ComboBoxCausalNoEntrega.Name = "ComboBoxCausalNoEntrega"
        Me.ComboBoxCausalNoEntrega.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxCausalNoEntrega.TabIndex = 50
        '
        'LabelCausalNoEntregaDescripcion
        '
        Me.LabelCausalNoEntregaDescripcion.AutoSize = True
        Me.LabelCausalNoEntregaDescripcion.Location = New System.Drawing.Point(3, 28)
        Me.LabelCausalNoEntregaDescripcion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaDescripcion.Name = "LabelCausalNoEntregaDescripcion"
        Me.LabelCausalNoEntregaDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LabelCausalNoEntregaDescripcion.TabIndex = 23
        Me.LabelCausalNoEntregaDescripcion.Text = "Descripción"
        '
        'TextBoxCausalNoEntregaDescripcion
        '
        Me.TextBoxCausalNoEntregaDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBoxCausalNoEntregaDescripcion, 3)
        Me.TextBoxCausalNoEntregaDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalNoEntregaDescripcion.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxCausalNoEntregaDescripcion.Multiline = True
        Me.TextBoxCausalNoEntregaDescripcion.Name = "TextBoxCausalNoEntregaDescripcion"
        Me.TextBoxCausalNoEntregaDescripcion.ReadOnly = True
        Me.TableLayoutPanel6.SetRowSpan(Me.TextBoxCausalNoEntregaDescripcion, 2)
        Me.TextBoxCausalNoEntregaDescripcion.Size = New System.Drawing.Size(389, 44)
        Me.TextBoxCausalNoEntregaDescripcion.TabIndex = 51
        '
        'LabelIndicadorOTIF
        '
        Me.LabelIndicadorOTIF.AutoSize = True
        Me.LabelIndicadorOTIF.Location = New System.Drawing.Point(3, 78)
        Me.LabelIndicadorOTIF.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelIndicadorOTIF.Name = "LabelIndicadorOTIF"
        Me.LabelIndicadorOTIF.Size = New System.Drawing.Size(51, 13)
        Me.LabelIndicadorOTIF.TabIndex = 2
        Me.LabelIndicadorOTIF.Text = "Indicador"
        '
        'TextBoxIndicadorOTIF
        '
        Me.TextBoxIndicadorOTIF.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBoxIndicadorOTIF, 3)
        Me.TextBoxIndicadorOTIF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxIndicadorOTIF.Location = New System.Drawing.Point(98, 78)
        Me.TextBoxIndicadorOTIF.Name = "TextBoxIndicadorOTIF"
        Me.TextBoxIndicadorOTIF.ReadOnly = True
        Me.TextBoxIndicadorOTIF.Size = New System.Drawing.Size(389, 20)
        Me.TextBoxIndicadorOTIF.TabIndex = 52
        '
        'LabelCausalNoEntregaResponsable
        '
        Me.LabelCausalNoEntregaResponsable.AutoSize = True
        Me.LabelCausalNoEntregaResponsable.Location = New System.Drawing.Point(3, 103)
        Me.LabelCausalNoEntregaResponsable.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaResponsable.Name = "LabelCausalNoEntregaResponsable"
        Me.LabelCausalNoEntregaResponsable.Size = New System.Drawing.Size(69, 13)
        Me.LabelCausalNoEntregaResponsable.TabIndex = 4
        Me.LabelCausalNoEntregaResponsable.Text = "Responsable"
        '
        'ComboBoxCausalNoEntregaResponsable
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.ComboBoxCausalNoEntregaResponsable, 3)
        Me.ComboBoxCausalNoEntregaResponsable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCausalNoEntregaResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCausalNoEntregaResponsable.FormattingEnabled = True
        Me.ComboBoxCausalNoEntregaResponsable.Location = New System.Drawing.Point(98, 103)
        Me.ComboBoxCausalNoEntregaResponsable.Name = "ComboBoxCausalNoEntregaResponsable"
        Me.ComboBoxCausalNoEntregaResponsable.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxCausalNoEntregaResponsable.TabIndex = 53
        '
        'LabelCausalNoEntregaResponsableInterno
        '
        Me.LabelCausalNoEntregaResponsableInterno.AutoSize = True
        Me.LabelCausalNoEntregaResponsableInterno.Location = New System.Drawing.Point(3, 128)
        Me.LabelCausalNoEntregaResponsableInterno.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaResponsableInterno.Name = "LabelCausalNoEntregaResponsableInterno"
        Me.LabelCausalNoEntregaResponsableInterno.Size = New System.Drawing.Size(40, 13)
        Me.LabelCausalNoEntregaResponsableInterno.TabIndex = 26
        Me.LabelCausalNoEntregaResponsableInterno.Text = "Interno"
        '
        'ComboBoxCausalNoEntregaResponsableInterno
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.ComboBoxCausalNoEntregaResponsableInterno, 3)
        Me.ComboBoxCausalNoEntregaResponsableInterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCausalNoEntregaResponsableInterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCausalNoEntregaResponsableInterno.FormattingEnabled = True
        Me.ComboBoxCausalNoEntregaResponsableInterno.Location = New System.Drawing.Point(98, 128)
        Me.ComboBoxCausalNoEntregaResponsableInterno.Name = "ComboBoxCausalNoEntregaResponsableInterno"
        Me.ComboBoxCausalNoEntregaResponsableInterno.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxCausalNoEntregaResponsableInterno.TabIndex = 54
        '
        'LabelCausalNoEntregaNotas
        '
        Me.LabelCausalNoEntregaNotas.AutoSize = True
        Me.LabelCausalNoEntregaNotas.Location = New System.Drawing.Point(3, 153)
        Me.LabelCausalNoEntregaNotas.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaNotas.Name = "LabelCausalNoEntregaNotas"
        Me.LabelCausalNoEntregaNotas.Size = New System.Drawing.Size(35, 13)
        Me.LabelCausalNoEntregaNotas.TabIndex = 28
        Me.LabelCausalNoEntregaNotas.Text = "Notas"
        '
        'TextBoxCausalNoEntregaNotas
        '
        Me.TextBoxCausalNoEntregaNotas.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBoxCausalNoEntregaNotas, 3)
        Me.TextBoxCausalNoEntregaNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalNoEntregaNotas.Location = New System.Drawing.Point(98, 153)
        Me.TextBoxCausalNoEntregaNotas.Multiline = True
        Me.TextBoxCausalNoEntregaNotas.Name = "TextBoxCausalNoEntregaNotas"
        Me.TableLayoutPanel6.SetRowSpan(Me.TextBoxCausalNoEntregaNotas, 2)
        Me.TextBoxCausalNoEntregaNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxCausalNoEntregaNotas.Size = New System.Drawing.Size(389, 44)
        Me.TextBoxCausalNoEntregaNotas.TabIndex = 55
        '
        'LabelNovedadUsuarioActualizacion
        '
        Me.LabelNovedadUsuarioActualizacion.AutoSize = True
        Me.LabelNovedadUsuarioActualizacion.Location = New System.Drawing.Point(3, 203)
        Me.LabelNovedadUsuarioActualizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNovedadUsuarioActualizacion.Name = "LabelNovedadUsuarioActualizacion"
        Me.LabelNovedadUsuarioActualizacion.Size = New System.Drawing.Size(43, 13)
        Me.LabelNovedadUsuarioActualizacion.TabIndex = 30
        Me.LabelNovedadUsuarioActualizacion.Text = "Usuario"
        '
        'TextBoxCausalNoEntregaUsuarioActualizacion
        '
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Location = New System.Drawing.Point(98, 203)
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Name = "TextBoxCausalNoEntregaUsuarioActualizacion"
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.ReadOnly = True
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.TabIndex = 56
        '
        'LabelNovedadFechaActualizacion
        '
        Me.LabelNovedadFechaActualizacion.AutoSize = True
        Me.LabelNovedadFechaActualizacion.Location = New System.Drawing.Point(248, 203)
        Me.LabelNovedadFechaActualizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNovedadFechaActualizacion.Name = "LabelNovedadFechaActualizacion"
        Me.LabelNovedadFechaActualizacion.Size = New System.Drawing.Size(37, 13)
        Me.LabelNovedadFechaActualizacion.TabIndex = 31
        Me.LabelNovedadFechaActualizacion.Text = "Fecha"
        '
        'DTPCausalNoEntregaFechaActualizacion
        '
        Me.DTPCausalNoEntregaFechaActualizacion.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTPCausalNoEntregaFechaActualizacion.Enabled = False
        Me.DTPCausalNoEntregaFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPCausalNoEntregaFechaActualizacion.Location = New System.Drawing.Point(343, 203)
        Me.DTPCausalNoEntregaFechaActualizacion.Name = "DTPCausalNoEntregaFechaActualizacion"
        Me.DTPCausalNoEntregaFechaActualizacion.Size = New System.Drawing.Size(144, 20)
        Me.DTPCausalNoEntregaFechaActualizacion.TabIndex = 57
        '
        'TabPageLineas
        '
        Me.TabPageLineas.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageLineas.Controls.Add(Me.TableLayoutPanel7)
        Me.TabPageLineas.Location = New System.Drawing.Point(4, 22)
        Me.TabPageLineas.Name = "TabPageLineas"
        Me.TabPageLineas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLineas.Size = New System.Drawing.Size(748, 272)
        Me.TabPageLineas.TabIndex = 1
        Me.TabPageLineas.Text = "LINEAS"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.bnLineas, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.dgvLineas, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(742, 266)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'bnLineas
        '
        Me.bnLineas.AddNewItem = Nothing
        Me.bnLineas.CountItem = Me.ToolStripLabel1
        Me.bnLineas.DeleteItem = Nothing
        Me.bnLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnLineas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelFiltrarSeleccionadas, Me.ToolStripTextBoxFiltroSeleccionadas, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripTextBox2, Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator10, Me.ToolStripButtonAcciones, Me.ToolStripSeparator4, Me.ToolStripButtonSeleccionarTodosSeleccionados, Me.ToolStripSeparator8, Me.ToolStripButtonInvertirSeleccionSeleccionados, Me.ToolStripSeparator9})
        Me.bnLineas.Location = New System.Drawing.Point(0, 0)
        Me.bnLineas.MoveFirstItem = Me.ToolStripButton1
        Me.bnLineas.MoveLastItem = Me.ToolStripButton4
        Me.bnLineas.MoveNextItem = Me.ToolStripButton3
        Me.bnLineas.MovePreviousItem = Me.ToolStripButton2
        Me.bnLineas.Name = "bnLineas"
        Me.bnLineas.PositionItem = Me.ToolStripTextBox2
        Me.bnLineas.Size = New System.Drawing.Size(768, 30)
        Me.bnLineas.TabIndex = 61
        Me.bnLineas.Text = "BindingNavigator1"
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
        Me.ToolStripButtonAcciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaNovedadToolStripMenuItem})
        Me.ToolStripButtonAcciones.Image = CType(resources.GetObject("ToolStripButtonAcciones.Image"), System.Drawing.Image)
        Me.ToolStripButtonAcciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAcciones.Name = "ToolStripButtonAcciones"
        Me.ToolStripButtonAcciones.Size = New System.Drawing.Size(68, 27)
        Me.ToolStripButtonAcciones.Text = "Acciones"
        '
        'NuevaNovedadToolStripMenuItem
        '
        Me.NuevaNovedadToolStripMenuItem.Name = "NuevaNovedadToolStripMenuItem"
        Me.NuevaNovedadToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NuevaNovedadToolStripMenuItem.Text = "Nueva Novedad"
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
        'dgvLineas
        '
        Me.dgvLineas.AllowUserToAddRows = False
        Me.dgvLineas.AllowUserToDeleteRows = False
        Me.dgvLineas.AllowUserToOrderColumns = True
        Me.dgvLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvLineas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvLineas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLineas.Location = New System.Drawing.Point(3, 33)
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.ReadOnly = True
        Me.dgvLineas.ShowEditingIcon = False
        Me.dgvLineas.Size = New System.Drawing.Size(762, 230)
        Me.dgvLineas.TabIndex = 62
        '
        'TabPageNovedades
        '
        Me.TabPageNovedades.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageNovedades.Controls.Add(Me.TableLayoutPanel8)
        Me.TabPageNovedades.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNovedades.Name = "TabPageNovedades"
        Me.TabPageNovedades.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNovedades.Size = New System.Drawing.Size(748, 272)
        Me.TabPageNovedades.TabIndex = 2
        Me.TabPageNovedades.Text = "NOVEDADES"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.bnNovedades, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.dgvNovedades, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(742, 266)
        Me.TableLayoutPanel8.TabIndex = 2
        '
        'bnNovedades
        '
        Me.bnNovedades.AddNewItem = Nothing
        Me.bnNovedades.CountItem = Me.ToolStripLabel2
        Me.bnNovedades.DeleteItem = Nothing
        Me.bnNovedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnNovedades.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripTextBox1, Me.ToolStripSeparator5, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator6, Me.ToolStripTextBox3, Me.ToolStripLabel2, Me.ToolStripSeparator7, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator11, Me.ToolStripDropDownButton1, Me.ToolStripSeparator12, Me.ToolStripButton9, Me.ToolStripSeparator13, Me.ToolStripButton10, Me.ToolStripSeparator14})
        Me.bnNovedades.Location = New System.Drawing.Point(0, 0)
        Me.bnNovedades.MoveFirstItem = Me.ToolStripButton5
        Me.bnNovedades.MoveLastItem = Me.ToolStripButton8
        Me.bnNovedades.MoveNextItem = Me.ToolStripButton7
        Me.bnNovedades.MovePreviousItem = Me.ToolStripButton6
        Me.bnNovedades.Name = "bnNovedades"
        Me.bnNovedades.PositionItem = Me.ToolStripTextBox3
        Me.bnNovedades.Size = New System.Drawing.Size(742, 30)
        Me.bnNovedades.TabIndex = 61
        Me.bnNovedades.Text = "BindingNavigator1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 27)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Número total de elementos"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(37, 27)
        Me.ToolStripLabel3.Text = "Filtrar"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(250, 30)
        Me.ToolStripTextBox1.ToolTipText = "Para buscar registros que contengan la palabra XXX, puede hacer uso de las siguie" &
    "ntes opciones: Que comience *XXX. Que termine XXX* y que contenga *XXX*."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton5.Text = "Mover primero"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton6.Text = "Mover anterior"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Posición"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton7.Text = "Mover siguiente"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton8.Text = "Mover último"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarNovedadToolStripMenuItem, Me.EliminarNovedadToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(68, 27)
        Me.ToolStripDropDownButton1.Text = "Acciones"
        '
        'ModificarNovedadToolStripMenuItem
        '
        Me.ModificarNovedadToolStripMenuItem.Name = "ModificarNovedadToolStripMenuItem"
        Me.ModificarNovedadToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarNovedadToolStripMenuItem.Text = "Modificar"
        '
        'EliminarNovedadToolStripMenuItem
        '
        Me.EliminarNovedadToolStripMenuItem.Name = "EliminarNovedadToolStripMenuItem"
        Me.EliminarNovedadToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarNovedadToolStripMenuItem.Text = "Eliminar"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(64, 27)
        Me.ToolStripButton9.Text = "Sel. Todos"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(83, 27)
        Me.ToolStripButton10.Text = "Inv. Selección"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 30)
        '
        'dgvNovedades
        '
        Me.dgvNovedades.AllowUserToAddRows = False
        Me.dgvNovedades.AllowUserToDeleteRows = False
        Me.dgvNovedades.AllowUserToOrderColumns = True
        Me.dgvNovedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvNovedades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvNovedades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvNovedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNovedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNovedades.Location = New System.Drawing.Point(3, 33)
        Me.dgvNovedades.Name = "dgvNovedades"
        Me.dgvNovedades.ReadOnly = True
        Me.dgvNovedades.ShowEditingIcon = False
        Me.dgvNovedades.Size = New System.Drawing.Size(736, 230)
        Me.dgvNovedades.TabIndex = 62
        '
        'TabPageReprogramacion
        '
        Me.TabPageReprogramacion.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageReprogramacion.Controls.Add(Me.TableLayoutPanel9)
        Me.TabPageReprogramacion.Location = New System.Drawing.Point(4, 22)
        Me.TabPageReprogramacion.Name = "TabPageReprogramacion"
        Me.TabPageReprogramacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageReprogramacion.Size = New System.Drawing.Size(748, 272)
        Me.TabPageReprogramacion.TabIndex = 3
        Me.TabPageReprogramacion.Text = "REPROGRAMACION"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 7
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel9.Controls.Add(Me.LabelCausalReprogramacion, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.ComboBoxCausalReprogramacion, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelCausalReprogramacionDescripcion, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBoxCausalReprogramacionDescripcion, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelCausalReprogramacionNotas, 0, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBoxCausalReprogramacionNotas, 1, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelCausalReprogramacionUsuarioActualizacion, 0, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.TextBoxCausalReprogramacionUsuarioActualizacion, 1, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelCausalReprogramacionFechaActualizacion, 2, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.DTPCausalReprogramacionFechaActualizacion, 3, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelLine01, 0, 7)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelReprogramacionFechaDesde, 0, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.DTPReprogramacionFechaDesde, 1, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.DTPReprogramacionFechaHasta, 3, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelReprogramacionFechaHasta, 2, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelAMPM, 0, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.ComboBoxAMPM, 1, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.ComboBoxHoraMaxima, 3, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelHoraMaxima, 2, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.CheckBoxRequiereConfirmarCita, 2, 8)
        Me.TableLayoutPanel9.Controls.Add(Me.CheckBoxRequiereServicioDistribucion, 0, 8)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelHoras, 4, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.NUDHoras, 5, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.LabelResumen, 0, 11)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 13
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(742, 266)
        Me.TableLayoutPanel9.TabIndex = 2
        '
        'LabelCausalReprogramacion
        '
        Me.LabelCausalReprogramacion.AutoSize = True
        Me.LabelCausalReprogramacion.Location = New System.Drawing.Point(3, 3)
        Me.LabelCausalReprogramacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalReprogramacion.Name = "LabelCausalReprogramacion"
        Me.LabelCausalReprogramacion.Size = New System.Drawing.Size(65, 13)
        Me.LabelCausalReprogramacion.TabIndex = 0
        Me.LabelCausalReprogramacion.Text = "Causal Rep."
        '
        'ComboBoxCausalReprogramacion
        '
        Me.TableLayoutPanel9.SetColumnSpan(Me.ComboBoxCausalReprogramacion, 3)
        Me.ComboBoxCausalReprogramacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCausalReprogramacion.FormattingEnabled = True
        Me.ComboBoxCausalReprogramacion.Location = New System.Drawing.Point(98, 3)
        Me.ComboBoxCausalReprogramacion.Name = "ComboBoxCausalReprogramacion"
        Me.ComboBoxCausalReprogramacion.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxCausalReprogramacion.TabIndex = 22
        '
        'LabelCausalReprogramacionDescripcion
        '
        Me.LabelCausalReprogramacionDescripcion.AutoSize = True
        Me.LabelCausalReprogramacionDescripcion.Location = New System.Drawing.Point(3, 28)
        Me.LabelCausalReprogramacionDescripcion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalReprogramacionDescripcion.Name = "LabelCausalReprogramacionDescripcion"
        Me.LabelCausalReprogramacionDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LabelCausalReprogramacionDescripcion.TabIndex = 23
        Me.LabelCausalReprogramacionDescripcion.Text = "Descripción"
        '
        'TextBoxCausalReprogramacionDescripcion
        '
        Me.TextBoxCausalReprogramacionDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel9.SetColumnSpan(Me.TextBoxCausalReprogramacionDescripcion, 3)
        Me.TextBoxCausalReprogramacionDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalReprogramacionDescripcion.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxCausalReprogramacionDescripcion.Multiline = True
        Me.TextBoxCausalReprogramacionDescripcion.Name = "TextBoxCausalReprogramacionDescripcion"
        Me.TextBoxCausalReprogramacionDescripcion.ReadOnly = True
        Me.TableLayoutPanel9.SetRowSpan(Me.TextBoxCausalReprogramacionDescripcion, 2)
        Me.TextBoxCausalReprogramacionDescripcion.Size = New System.Drawing.Size(389, 39)
        Me.TextBoxCausalReprogramacionDescripcion.TabIndex = 24
        '
        'LabelCausalReprogramacionNotas
        '
        Me.LabelCausalReprogramacionNotas.AutoSize = True
        Me.LabelCausalReprogramacionNotas.Location = New System.Drawing.Point(3, 73)
        Me.LabelCausalReprogramacionNotas.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalReprogramacionNotas.Name = "LabelCausalReprogramacionNotas"
        Me.LabelCausalReprogramacionNotas.Size = New System.Drawing.Size(35, 13)
        Me.LabelCausalReprogramacionNotas.TabIndex = 28
        Me.LabelCausalReprogramacionNotas.Text = "Notas"
        '
        'TextBoxCausalReprogramacionNotas
        '
        Me.TextBoxCausalReprogramacionNotas.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel9.SetColumnSpan(Me.TextBoxCausalReprogramacionNotas, 3)
        Me.TextBoxCausalReprogramacionNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalReprogramacionNotas.Location = New System.Drawing.Point(98, 73)
        Me.TextBoxCausalReprogramacionNotas.Multiline = True
        Me.TextBoxCausalReprogramacionNotas.Name = "TextBoxCausalReprogramacionNotas"
        Me.TableLayoutPanel9.SetRowSpan(Me.TextBoxCausalReprogramacionNotas, 2)
        Me.TextBoxCausalReprogramacionNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxCausalReprogramacionNotas.Size = New System.Drawing.Size(389, 44)
        Me.TextBoxCausalReprogramacionNotas.TabIndex = 29
        '
        'LabelCausalReprogramacionUsuarioActualizacion
        '
        Me.LabelCausalReprogramacionUsuarioActualizacion.AutoSize = True
        Me.LabelCausalReprogramacionUsuarioActualizacion.Location = New System.Drawing.Point(3, 123)
        Me.LabelCausalReprogramacionUsuarioActualizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalReprogramacionUsuarioActualizacion.Name = "LabelCausalReprogramacionUsuarioActualizacion"
        Me.LabelCausalReprogramacionUsuarioActualizacion.Size = New System.Drawing.Size(43, 13)
        Me.LabelCausalReprogramacionUsuarioActualizacion.TabIndex = 30
        Me.LabelCausalReprogramacionUsuarioActualizacion.Text = "Usuario"
        '
        'TextBoxCausalReprogramacionUsuarioActualizacion
        '
        Me.TextBoxCausalReprogramacionUsuarioActualizacion.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCausalReprogramacionUsuarioActualizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalReprogramacionUsuarioActualizacion.Location = New System.Drawing.Point(98, 123)
        Me.TextBoxCausalReprogramacionUsuarioActualizacion.Name = "TextBoxCausalReprogramacionUsuarioActualizacion"
        Me.TextBoxCausalReprogramacionUsuarioActualizacion.ReadOnly = True
        Me.TextBoxCausalReprogramacionUsuarioActualizacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCausalReprogramacionUsuarioActualizacion.TabIndex = 33
        '
        'LabelCausalReprogramacionFechaActualizacion
        '
        Me.LabelCausalReprogramacionFechaActualizacion.AutoSize = True
        Me.LabelCausalReprogramacionFechaActualizacion.Location = New System.Drawing.Point(248, 123)
        Me.LabelCausalReprogramacionFechaActualizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalReprogramacionFechaActualizacion.Name = "LabelCausalReprogramacionFechaActualizacion"
        Me.LabelCausalReprogramacionFechaActualizacion.Size = New System.Drawing.Size(37, 13)
        Me.LabelCausalReprogramacionFechaActualizacion.TabIndex = 31
        Me.LabelCausalReprogramacionFechaActualizacion.Text = "Fecha"
        '
        'DTPCausalReprogramacionFechaActualizacion
        '
        Me.DTPCausalReprogramacionFechaActualizacion.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTPCausalReprogramacionFechaActualizacion.Enabled = False
        Me.DTPCausalReprogramacionFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPCausalReprogramacionFechaActualizacion.Location = New System.Drawing.Point(343, 123)
        Me.DTPCausalReprogramacionFechaActualizacion.Name = "DTPCausalReprogramacionFechaActualizacion"
        Me.DTPCausalReprogramacionFechaActualizacion.Size = New System.Drawing.Size(144, 20)
        Me.DTPCausalReprogramacionFechaActualizacion.TabIndex = 32
        '
        'LabelLine01
        '
        Me.LabelLine01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel9.SetColumnSpan(Me.LabelLine01, 5)
        Me.LabelLine01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelLine01.Location = New System.Drawing.Point(3, 168)
        Me.LabelLine01.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelLine01.Name = "LabelLine01"
        Me.LabelLine01.Size = New System.Drawing.Size(579, 1)
        Me.LabelLine01.TabIndex = 36
        '
        'LabelReprogramacionFechaDesde
        '
        Me.LabelReprogramacionFechaDesde.AutoSize = True
        Me.LabelReprogramacionFechaDesde.Location = New System.Drawing.Point(3, 195)
        Me.LabelReprogramacionFechaDesde.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelReprogramacionFechaDesde.Name = "LabelReprogramacionFechaDesde"
        Me.LabelReprogramacionFechaDesde.Size = New System.Drawing.Size(38, 13)
        Me.LabelReprogramacionFechaDesde.TabIndex = 37
        Me.LabelReprogramacionFechaDesde.Text = "Desde"
        '
        'DTPReprogramacionFechaDesde
        '
        Me.DTPReprogramacionFechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.DTPReprogramacionFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPReprogramacionFechaDesde.Location = New System.Drawing.Point(98, 195)
        Me.DTPReprogramacionFechaDesde.Name = "DTPReprogramacionFechaDesde"
        Me.DTPReprogramacionFechaDesde.Size = New System.Drawing.Size(144, 20)
        Me.DTPReprogramacionFechaDesde.TabIndex = 39
        '
        'DTPReprogramacionFechaHasta
        '
        Me.DTPReprogramacionFechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.DTPReprogramacionFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPReprogramacionFechaHasta.Location = New System.Drawing.Point(343, 195)
        Me.DTPReprogramacionFechaHasta.Name = "DTPReprogramacionFechaHasta"
        Me.DTPReprogramacionFechaHasta.Size = New System.Drawing.Size(144, 20)
        Me.DTPReprogramacionFechaHasta.TabIndex = 40
        '
        'LabelReprogramacionFechaHasta
        '
        Me.LabelReprogramacionFechaHasta.AutoSize = True
        Me.LabelReprogramacionFechaHasta.Location = New System.Drawing.Point(248, 195)
        Me.LabelReprogramacionFechaHasta.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelReprogramacionFechaHasta.Name = "LabelReprogramacionFechaHasta"
        Me.LabelReprogramacionFechaHasta.Size = New System.Drawing.Size(35, 13)
        Me.LabelReprogramacionFechaHasta.TabIndex = 38
        Me.LabelReprogramacionFechaHasta.Text = "Hasta"
        '
        'LabelAMPM
        '
        Me.LabelAMPM.AutoSize = True
        Me.LabelAMPM.Location = New System.Drawing.Point(3, 220)
        Me.LabelAMPM.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelAMPM.Name = "LabelAMPM"
        Me.LabelAMPM.Size = New System.Drawing.Size(44, 13)
        Me.LabelAMPM.TabIndex = 41
        Me.LabelAMPM.Text = "AM/PM"
        '
        'ComboBoxAMPM
        '
        Me.ComboBoxAMPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAMPM.FormattingEnabled = True
        Me.ComboBoxAMPM.Items.AddRange(New Object() {"AM", "PM", "AM/PM"})
        Me.ComboBoxAMPM.Location = New System.Drawing.Point(98, 220)
        Me.ComboBoxAMPM.Name = "ComboBoxAMPM"
        Me.ComboBoxAMPM.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxAMPM.TabIndex = 42
        '
        'ComboBoxHoraMaxima
        '
        Me.ComboBoxHoraMaxima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxHoraMaxima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxHoraMaxima.FormattingEnabled = True
        Me.ComboBoxHoraMaxima.Location = New System.Drawing.Point(343, 220)
        Me.ComboBoxHoraMaxima.Name = "ComboBoxHoraMaxima"
        Me.ComboBoxHoraMaxima.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxHoraMaxima.TabIndex = 43
        '
        'LabelHoraMaxima
        '
        Me.LabelHoraMaxima.AutoSize = True
        Me.LabelHoraMaxima.Location = New System.Drawing.Point(248, 220)
        Me.LabelHoraMaxima.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelHoraMaxima.Name = "LabelHoraMaxima"
        Me.LabelHoraMaxima.Size = New System.Drawing.Size(70, 13)
        Me.LabelHoraMaxima.TabIndex = 44
        Me.LabelHoraMaxima.Text = "Hora maxíma"
        '
        'CheckBoxRequiereConfirmarCita
        '
        Me.CheckBoxRequiereConfirmarCita.AutoSize = True
        Me.TableLayoutPanel9.SetColumnSpan(Me.CheckBoxRequiereConfirmarCita, 2)
        Me.CheckBoxRequiereConfirmarCita.Location = New System.Drawing.Point(248, 170)
        Me.CheckBoxRequiereConfirmarCita.Name = "CheckBoxRequiereConfirmarCita"
        Me.CheckBoxRequiereConfirmarCita.Size = New System.Drawing.Size(137, 17)
        Me.CheckBoxRequiereConfirmarCita.TabIndex = 35
        Me.CheckBoxRequiereConfirmarCita.Text = "Requiere Confirmar Cita"
        Me.CheckBoxRequiereConfirmarCita.UseVisualStyleBackColor = True
        '
        'CheckBoxRequiereServicioDistribucion
        '
        Me.CheckBoxRequiereServicioDistribucion.AutoSize = True
        Me.TableLayoutPanel9.SetColumnSpan(Me.CheckBoxRequiereServicioDistribucion, 2)
        Me.CheckBoxRequiereServicioDistribucion.Location = New System.Drawing.Point(3, 170)
        Me.CheckBoxRequiereServicioDistribucion.Name = "CheckBoxRequiereServicioDistribucion"
        Me.CheckBoxRequiereServicioDistribucion.Size = New System.Drawing.Size(168, 17)
        Me.CheckBoxRequiereServicioDistribucion.TabIndex = 34
        Me.CheckBoxRequiereServicioDistribucion.Text = "Requiere Servicio Distribución"
        Me.CheckBoxRequiereServicioDistribucion.UseVisualStyleBackColor = True
        '
        'LabelHoras
        '
        Me.LabelHoras.AutoSize = True
        Me.LabelHoras.Location = New System.Drawing.Point(493, 220)
        Me.LabelHoras.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelHoras.Name = "LabelHoras"
        Me.LabelHoras.Size = New System.Drawing.Size(82, 13)
        Me.LabelHoras.TabIndex = 45
        Me.LabelHoras.Text = "Ventana horaria"
        '
        'NUDHoras
        '
        Me.NUDHoras.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CorteDistribucion.My.MySettings.Default, "CitaVentanaHoraria", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.NUDHoras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NUDHoras.Location = New System.Drawing.Point(588, 220)
        Me.NUDHoras.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NUDHoras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDHoras.Name = "NUDHoras"
        Me.NUDHoras.Size = New System.Drawing.Size(39, 20)
        Me.NUDHoras.TabIndex = 46
        Me.NUDHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NUDHoras.Value = Global.CorteDistribucion.My.MySettings.Default.CitaVentanaHoraria
        '
        'LabelResumen
        '
        Me.LabelResumen.AutoSize = True
        Me.LabelResumen.BackColor = System.Drawing.SystemColors.Control
        Me.LabelResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel9.SetColumnSpan(Me.LabelResumen, 6)
        Me.LabelResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResumen.Location = New System.Drawing.Point(3, 245)
        Me.LabelResumen.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelResumen.Name = "LabelResumen"
        Me.LabelResumen.Size = New System.Drawing.Size(624, 19)
        Me.LabelResumen.TabIndex = 47
        Me.LabelResumen.Text = "   "
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Controls.Add(Me.ButtonAceptar)
        Me.FlowLayoutPanel3.Controls.Add(Me.ButtonCancelar)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(577, 528)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(186, 41)
        Me.FlowLayoutPanel3.TabIndex = 5
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonAceptar.Location = New System.Drawing.Point(98, 8)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 1
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(10, 8)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 0
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FormCerrarOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(766, 572)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCerrarOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambio de Estado De Entrega"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControlOrden.ResumeLayout(False)
        Me.TabPageOrden.ResumeLayout(False)
        Me.TableLayoutPanelOrden.ResumeLayout(False)
        Me.TableLayoutPanelOrden.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TabPageDestinatario.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPageDestino.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TabPageOtros.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Tab.ResumeLayout(False)
        Me.TabPageNoEntregada.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TabPageLineas.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.bnLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnLineas.ResumeLayout(False)
        Me.bnLineas.PerformLayout()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNovedades.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.bnNovedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnNovedades.ResumeLayout(False)
        Me.bnNovedades.PerformLayout()
        CType(Me.dgvNovedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageReprogramacion.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.NUDHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControlOrden As TabControl
    Friend WithEvents TabPageDestinatario As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TextBoxDestinatarioTelefono As TextBox
    Friend WithEvents TextBoxDestinatarioContacto As TextBox
    Friend WithEvents TextBoxDestinatarioEmail As TextBox
    Friend WithEvents TextBoxDestinatarioNombre As TextBox
    Friend WithEvents LabelDestinatarioIdentificacion As Label
    Friend WithEvents LabelDestinatarioNombre As Label
    Friend WithEvents LabelDestinatarioEmail As Label
    Friend WithEvents LabelDestinatarioContacto As Label
    Friend WithEvents LabelDestinatarioTelefono As Label
    Friend WithEvents TextBoxDestinatarioIdentificacion As TextBox
    Friend WithEvents TabPageDestino As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TextBoxDestinoNombre As TextBox
    Friend WithEvents TextBoxDestinoCodigo As TextBox
    Friend WithEvents TextBoxDestinoTelefono As TextBox
    Friend WithEvents TextBoxDestinoContacto As TextBox
    Friend WithEvents TextBoxDestinoEmail As TextBox
    Friend WithEvents TextBoxDestinoDireccion As TextBox
    Friend WithEvents LabelDestinoCiudad As Label
    Friend WithEvents LabelDestinoDireccion As Label
    Friend WithEvents LabelDestinoEmail As Label
    Friend WithEvents LabelDestinoContacto As Label
    Friend WithEvents LabelDestinoTelefono As Label
    Friend WithEvents TextBoxDestinoCiudad As TextBox
    Friend WithEvents LabelDestinoCodigo As Label
    Friend WithEvents LabelDestinoNombre As Label
    Friend WithEvents TabPageOtros As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DTPFechaAceptacion As DateTimePicker
    Friend WithEvents TextBoxNotasAceptacion As TextBox
    Friend WithEvents TextBoxUsuarioAceptacion As TextBox
    Friend WithEvents TextBoxNotasConfirmacion As TextBox
    Friend WithEvents TextBoxUsuarioConfirmacion As TextBox
    Friend WithEvents LabelValorRecaudo As Label
    Friend WithEvents LabelUsuarioConfirmacion As Label
    Friend WithEvents LabelNotasConfirmacion As Label
    Friend WithEvents LabelUsuarioAceptacion As Label
    Friend WithEvents TextBoxValorRecaudo As TextBox
    Friend WithEvents LabelNotasAceptacion As Label
    Friend WithEvents LabelFechaConfirmacion As Label
    Friend WithEvents DTPFechaConfirmacion As DateTimePicker
    Friend WithEvents LabelFechaAceptacion As Label
    Friend WithEvents Tab As TabControl
    Friend WithEvents TabPageNoEntregada As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TextBoxIndicadorOTIF As TextBox
    Friend WithEvents LabelCausalNoEntrega As Label
    Friend WithEvents LabelIndicadorOTIF As Label
    Friend WithEvents LabelCausalNoEntregaResponsable As Label
    Friend WithEvents TabPageLineas As TabPage
    Friend WithEvents TabPageNovedades As TabPage
    Friend WithEvents TabPageReprogramacion As TabPage
    Friend WithEvents TextBoxCausalNoEntregaUsuarioActualizacion As TextBox
    Friend WithEvents TextBoxCausalNoEntregaNotas As TextBox
    Friend WithEvents ComboBoxCausalNoEntregaResponsableInterno As ComboBox
    Friend WithEvents ComboBoxCausalNoEntregaResponsable As ComboBox
    Friend WithEvents TextBoxCausalNoEntregaDescripcion As TextBox
    Friend WithEvents ComboBoxCausalNoEntrega As ComboBox
    Friend WithEvents LabelCausalNoEntregaDescripcion As Label
    Friend WithEvents LabelCausalNoEntregaResponsableInterno As Label
    Friend WithEvents LabelCausalNoEntregaNotas As Label
    Friend WithEvents LabelNovedadUsuarioActualizacion As Label
    Friend WithEvents LabelNovedadFechaActualizacion As Label
    Friend WithEvents DTPCausalNoEntregaFechaActualizacion As DateTimePicker
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents bnLineas As BindingNavigator
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
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButtonSeleccionarTodosSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButtonInvertirSeleccionSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents dgvLineas As DataGridView
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents bnNovedades As BindingNavigator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents dgvNovedades As DataGridView
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TextBoxCausalReprogramacionUsuarioActualizacion As TextBox
    Friend WithEvents TextBoxCausalReprogramacionNotas As TextBox
    Friend WithEvents TextBoxCausalReprogramacionDescripcion As TextBox
    Friend WithEvents ComboBoxCausalReprogramacion As ComboBox
    Friend WithEvents LabelCausalReprogramacion As Label
    Friend WithEvents LabelCausalReprogramacionDescripcion As Label
    Friend WithEvents LabelCausalReprogramacionNotas As Label
    Friend WithEvents LabelCausalReprogramacionUsuarioActualizacion As Label
    Friend WithEvents LabelCausalReprogramacionFechaActualizacion As Label
    Friend WithEvents DTPCausalReprogramacionFechaActualizacion As DateTimePicker
    Friend WithEvents TableLayoutPanelOrden As TableLayoutPanel
    Friend WithEvents LabelServicioNombre As Label
    Friend WithEvents TextBoxServicioNombre As TextBox
    Friend WithEvents LabelOrdenId As Label
    Friend WithEvents TextBoxOrdenId As TextBox
    Friend WithEvents LabelOrdenNumero As Label
    Friend WithEvents TextBoxOrdenNumero As TextBox
    Friend WithEvents LabelEstadoDistribucionActual As Label
    Friend WithEvents TextBoxEstadoDistribucionActual As TextBox
    Friend WithEvents LabelEstadoOrdenNuevo As Label
    Friend WithEvents ComboBoxEstadoOrdenNuevo As ComboBox
    Friend WithEvents LabelFechaCita As Label
    Friend WithEvents DTPFechaCita As DateTimePicker
    Friend WithEvents LabelFechaEstimadaEntrega As Label
    Friend WithEvents DTPFechaEstimadaEntrega As DateTimePicker
    Friend WithEvents LabelFechaInicioEntrega As Label
    Friend WithEvents LabelFechaFinEntrega As Label
    Friend WithEvents DTPFechaInicioEntrega As DateTimePicker
    Friend WithEvents DTPFechaFinEntrega As DateTimePicker
    Friend WithEvents DTPHoraInicioEntrega As DateTimePicker
    Friend WithEvents TextBoxClienteCodigo As TextBox
    Friend WithEvents LabelClienteCodigo As Label
    Friend WithEvents DTPHoraFinEntrega As DateTimePicker
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TextBoxEstadoOrden As TextBox
    Friend WithEvents LabelEstadoOrden As Label
    Friend WithEvents NuevaNovedadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarNovedadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarNovedadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBoxRequiereServicioDistribucion As CheckBox
    Friend WithEvents CheckBoxRequiereConfirmarCita As CheckBox
    Friend WithEvents LabelLine01 As Label
    Friend WithEvents LabelReprogramacionFechaDesde As Label
    Friend WithEvents DTPReprogramacionFechaDesde As DateTimePicker
    Friend WithEvents DTPReprogramacionFechaHasta As DateTimePicker
    Friend WithEvents LabelReprogramacionFechaHasta As Label
    Friend WithEvents LabelAMPM As Label
    Friend WithEvents ComboBoxAMPM As ComboBox
    Friend WithEvents ComboBoxHoraMaxima As ComboBox
    Friend WithEvents LabelHoraMaxima As Label
    Friend WithEvents LabelHoras As Label
    Friend WithEvents NUDHoras As NumericUpDown
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents LabelResumen As Label
    Friend WithEvents TabPageOrden As TabPage
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
