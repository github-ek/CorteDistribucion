<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdicionNovedad
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
        Me.LabelSaldo = New System.Windows.Forms.Label()
        Me.LabelCantidadOtrasNovedades = New System.Windows.Forms.Label()
        Me.LabelCantidadPlanificada = New System.Windows.Forms.Label()
        Me.LabelCantidadSolicitada = New System.Windows.Forms.Label()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.LabelProductoCodigo = New System.Windows.Forms.Label()
        Me.LabelNumeroItem = New System.Windows.Forms.Label()
        Me.DTPCausalNoEntregaFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.LabelNovedadFechaActualizacion = New System.Windows.Forms.Label()
        Me.TextBoxCausalNoEntregaUsuarioActualizacion = New System.Windows.Forms.TextBox()
        Me.LabelNovedadUsuarioActualizacion = New System.Windows.Forms.Label()
        Me.TextBoxCausalNovedadNotas = New System.Windows.Forms.TextBox()
        Me.LabelCausalNoEntregaNotas = New System.Windows.Forms.Label()
        Me.ComboBoxCausalNovedadResponsableInterno = New System.Windows.Forms.ComboBox()
        Me.LabelCausalNoEntregaResponsableInterno = New System.Windows.Forms.Label()
        Me.ComboBoxCausalNovedadResponsable = New System.Windows.Forms.ComboBox()
        Me.LabelCausalNoEntregaResponsable = New System.Windows.Forms.Label()
        Me.TextBoxIndicadorOTIF = New System.Windows.Forms.TextBox()
        Me.LabelIndicadorOTIF = New System.Windows.Forms.Label()
        Me.TextBoxCausalNoEntregaDescripcion = New System.Windows.Forms.TextBox()
        Me.LabelCausalNoEntregaDescripcion = New System.Windows.Forms.Label()
        Me.ComboBoxCausalNovedad = New System.Windows.Forms.ComboBox()
        Me.LabelCausalNoEntrega = New System.Windows.Forms.Label()
        Me.TextBoxNumeroItem = New System.Windows.Forms.TextBox()
        Me.TextBoxProductoCodigo = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidadPlanificada = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidadSolicitada = New System.Windows.Forms.TextBox()
        Me.TextBoxSaldo = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidadOtrasNovedades = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTipoNovedad = New System.Windows.Forms.Label()
        Me.ComboBoxTipoNovedad = New System.Windows.Forms.ComboBox()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.NUDCantidad = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.NUDCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSaldo
        '
        Me.LabelSaldo.AutoSize = True
        Me.LabelSaldo.Location = New System.Drawing.Point(3, 303)
        Me.LabelSaldo.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelSaldo.Name = "LabelSaldo"
        Me.LabelSaldo.Size = New System.Drawing.Size(34, 13)
        Me.LabelSaldo.TabIndex = 68
        Me.LabelSaldo.Text = "Saldo"
        '
        'LabelCantidadOtrasNovedades
        '
        Me.LabelCantidadOtrasNovedades.AutoSize = True
        Me.LabelCantidadOtrasNovedades.Location = New System.Drawing.Point(3, 253)
        Me.LabelCantidadOtrasNovedades.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCantidadOtrasNovedades.Name = "LabelCantidadOtrasNovedades"
        Me.LabelCantidadOtrasNovedades.Size = New System.Drawing.Size(88, 13)
        Me.LabelCantidadOtrasNovedades.TabIndex = 70
        Me.LabelCantidadOtrasNovedades.Text = "Otras novedades"
        '
        'LabelCantidadPlanificada
        '
        Me.LabelCantidadPlanificada.AutoSize = True
        Me.LabelCantidadPlanificada.Location = New System.Drawing.Point(248, 228)
        Me.LabelCantidadPlanificada.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCantidadPlanificada.Name = "LabelCantidadPlanificada"
        Me.LabelCantidadPlanificada.Size = New System.Drawing.Size(59, 13)
        Me.LabelCantidadPlanificada.TabIndex = 66
        Me.LabelCantidadPlanificada.Text = "Planificado"
        '
        'LabelCantidadSolicitada
        '
        Me.LabelCantidadSolicitada.AutoSize = True
        Me.LabelCantidadSolicitada.Location = New System.Drawing.Point(3, 228)
        Me.LabelCantidadSolicitada.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCantidadSolicitada.Name = "LabelCantidadSolicitada"
        Me.LabelCantidadSolicitada.Size = New System.Drawing.Size(53, 13)
        Me.LabelCantidadSolicitada.TabIndex = 64
        Me.LabelCantidadSolicitada.Text = "Solicitado"
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.AutoSize = True
        Me.LabelDescripcion.Location = New System.Drawing.Point(3, 28)
        Me.LabelDescripcion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LabelDescripcion.TabIndex = 62
        Me.LabelDescripcion.Text = "Descripción"
        '
        'LabelProductoCodigo
        '
        Me.LabelProductoCodigo.AutoSize = True
        Me.LabelProductoCodigo.Location = New System.Drawing.Point(248, 3)
        Me.LabelProductoCodigo.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelProductoCodigo.Name = "LabelProductoCodigo"
        Me.LabelProductoCodigo.Size = New System.Drawing.Size(50, 13)
        Me.LabelProductoCodigo.TabIndex = 60
        Me.LabelProductoCodigo.Text = "Producto"
        '
        'LabelNumeroItem
        '
        Me.LabelNumeroItem.AutoSize = True
        Me.LabelNumeroItem.Location = New System.Drawing.Point(3, 3)
        Me.LabelNumeroItem.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNumeroItem.Name = "LabelNumeroItem"
        Me.LabelNumeroItem.Size = New System.Drawing.Size(27, 13)
        Me.LabelNumeroItem.TabIndex = 58
        Me.LabelNumeroItem.Text = "Item"
        '
        'DTPCausalNoEntregaFechaActualizacion
        '
        Me.DTPCausalNoEntregaFechaActualizacion.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DTPCausalNoEntregaFechaActualizacion.Enabled = False
        Me.DTPCausalNoEntregaFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPCausalNoEntregaFechaActualizacion.Location = New System.Drawing.Point(343, 478)
        Me.DTPCausalNoEntregaFechaActualizacion.Name = "DTPCausalNoEntregaFechaActualizacion"
        Me.DTPCausalNoEntregaFechaActualizacion.Size = New System.Drawing.Size(144, 20)
        Me.DTPCausalNoEntregaFechaActualizacion.TabIndex = 17
        '
        'LabelNovedadFechaActualizacion
        '
        Me.LabelNovedadFechaActualizacion.AutoSize = True
        Me.LabelNovedadFechaActualizacion.Location = New System.Drawing.Point(248, 478)
        Me.LabelNovedadFechaActualizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNovedadFechaActualizacion.Name = "LabelNovedadFechaActualizacion"
        Me.LabelNovedadFechaActualizacion.Size = New System.Drawing.Size(37, 13)
        Me.LabelNovedadFechaActualizacion.TabIndex = 31
        Me.LabelNovedadFechaActualizacion.Text = "Fecha"
        '
        'TextBoxCausalNoEntregaUsuarioActualizacion
        '
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Location = New System.Drawing.Point(98, 478)
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Name = "TextBoxCausalNoEntregaUsuarioActualizacion"
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.ReadOnly = True
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCausalNoEntregaUsuarioActualizacion.TabIndex = 16
        '
        'LabelNovedadUsuarioActualizacion
        '
        Me.LabelNovedadUsuarioActualizacion.AutoSize = True
        Me.LabelNovedadUsuarioActualizacion.Location = New System.Drawing.Point(3, 478)
        Me.LabelNovedadUsuarioActualizacion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelNovedadUsuarioActualizacion.Name = "LabelNovedadUsuarioActualizacion"
        Me.LabelNovedadUsuarioActualizacion.Size = New System.Drawing.Size(43, 13)
        Me.LabelNovedadUsuarioActualizacion.TabIndex = 30
        Me.LabelNovedadUsuarioActualizacion.Text = "Usuario"
        '
        'TextBoxCausalNovedadNotas
        '
        Me.TextBoxCausalNovedadNotas.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBoxCausalNovedadNotas, 3)
        Me.TextBoxCausalNovedadNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalNovedadNotas.Location = New System.Drawing.Point(98, 428)
        Me.TextBoxCausalNovedadNotas.Multiline = True
        Me.TextBoxCausalNovedadNotas.Name = "TextBoxCausalNovedadNotas"
        Me.TableLayoutPanel6.SetRowSpan(Me.TextBoxCausalNovedadNotas, 2)
        Me.TextBoxCausalNovedadNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxCausalNovedadNotas.Size = New System.Drawing.Size(389, 44)
        Me.TextBoxCausalNovedadNotas.TabIndex = 15
        '
        'LabelCausalNoEntregaNotas
        '
        Me.LabelCausalNoEntregaNotas.AutoSize = True
        Me.LabelCausalNoEntregaNotas.Location = New System.Drawing.Point(3, 428)
        Me.LabelCausalNoEntregaNotas.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaNotas.Name = "LabelCausalNoEntregaNotas"
        Me.LabelCausalNoEntregaNotas.Size = New System.Drawing.Size(35, 13)
        Me.LabelCausalNoEntregaNotas.TabIndex = 28
        Me.LabelCausalNoEntregaNotas.Text = "Notas"
        '
        'ComboBoxCausalNovedadResponsableInterno
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.ComboBoxCausalNovedadResponsableInterno, 3)
        Me.ComboBoxCausalNovedadResponsableInterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCausalNovedadResponsableInterno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCausalNovedadResponsableInterno.FormattingEnabled = True
        Me.ComboBoxCausalNovedadResponsableInterno.Location = New System.Drawing.Point(98, 378)
        Me.ComboBoxCausalNovedadResponsableInterno.Name = "ComboBoxCausalNovedadResponsableInterno"
        Me.ComboBoxCausalNovedadResponsableInterno.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxCausalNovedadResponsableInterno.TabIndex = 14
        '
        'LabelCausalNoEntregaResponsableInterno
        '
        Me.LabelCausalNoEntregaResponsableInterno.AutoSize = True
        Me.LabelCausalNoEntregaResponsableInterno.Location = New System.Drawing.Point(3, 378)
        Me.LabelCausalNoEntregaResponsableInterno.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaResponsableInterno.Name = "LabelCausalNoEntregaResponsableInterno"
        Me.LabelCausalNoEntregaResponsableInterno.Size = New System.Drawing.Size(40, 13)
        Me.LabelCausalNoEntregaResponsableInterno.TabIndex = 26
        Me.LabelCausalNoEntregaResponsableInterno.Text = "Interno"
        '
        'ComboBoxCausalNovedadResponsable
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.ComboBoxCausalNovedadResponsable, 3)
        Me.ComboBoxCausalNovedadResponsable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCausalNovedadResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCausalNovedadResponsable.FormattingEnabled = True
        Me.ComboBoxCausalNovedadResponsable.Location = New System.Drawing.Point(98, 353)
        Me.ComboBoxCausalNovedadResponsable.Name = "ComboBoxCausalNovedadResponsable"
        Me.ComboBoxCausalNovedadResponsable.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxCausalNovedadResponsable.TabIndex = 13
        '
        'LabelCausalNoEntregaResponsable
        '
        Me.LabelCausalNoEntregaResponsable.AutoSize = True
        Me.LabelCausalNoEntregaResponsable.Location = New System.Drawing.Point(3, 353)
        Me.LabelCausalNoEntregaResponsable.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaResponsable.Name = "LabelCausalNoEntregaResponsable"
        Me.LabelCausalNoEntregaResponsable.Size = New System.Drawing.Size(69, 13)
        Me.LabelCausalNoEntregaResponsable.TabIndex = 4
        Me.LabelCausalNoEntregaResponsable.Text = "Responsable"
        '
        'TextBoxIndicadorOTIF
        '
        Me.TextBoxIndicadorOTIF.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBoxIndicadorOTIF, 3)
        Me.TextBoxIndicadorOTIF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxIndicadorOTIF.Location = New System.Drawing.Point(98, 153)
        Me.TextBoxIndicadorOTIF.Name = "TextBoxIndicadorOTIF"
        Me.TextBoxIndicadorOTIF.ReadOnly = True
        Me.TextBoxIndicadorOTIF.Size = New System.Drawing.Size(389, 20)
        Me.TextBoxIndicadorOTIF.TabIndex = 8
        '
        'LabelIndicadorOTIF
        '
        Me.LabelIndicadorOTIF.AutoSize = True
        Me.LabelIndicadorOTIF.Location = New System.Drawing.Point(3, 153)
        Me.LabelIndicadorOTIF.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelIndicadorOTIF.Name = "LabelIndicadorOTIF"
        Me.LabelIndicadorOTIF.Size = New System.Drawing.Size(51, 13)
        Me.LabelIndicadorOTIF.TabIndex = 2
        Me.LabelIndicadorOTIF.Text = "Indicador"
        '
        'TextBoxCausalNoEntregaDescripcion
        '
        Me.TextBoxCausalNoEntregaDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBoxCausalNoEntregaDescripcion, 3)
        Me.TextBoxCausalNoEntregaDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCausalNoEntregaDescripcion.Location = New System.Drawing.Point(98, 103)
        Me.TextBoxCausalNoEntregaDescripcion.Multiline = True
        Me.TextBoxCausalNoEntregaDescripcion.Name = "TextBoxCausalNoEntregaDescripcion"
        Me.TextBoxCausalNoEntregaDescripcion.ReadOnly = True
        Me.TableLayoutPanel6.SetRowSpan(Me.TextBoxCausalNoEntregaDescripcion, 2)
        Me.TextBoxCausalNoEntregaDescripcion.Size = New System.Drawing.Size(389, 44)
        Me.TextBoxCausalNoEntregaDescripcion.TabIndex = 7
        '
        'LabelCausalNoEntregaDescripcion
        '
        Me.LabelCausalNoEntregaDescripcion.AutoSize = True
        Me.LabelCausalNoEntregaDescripcion.Location = New System.Drawing.Point(3, 103)
        Me.LabelCausalNoEntregaDescripcion.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntregaDescripcion.Name = "LabelCausalNoEntregaDescripcion"
        Me.LabelCausalNoEntregaDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LabelCausalNoEntregaDescripcion.TabIndex = 23
        Me.LabelCausalNoEntregaDescripcion.Text = "Descripción"
        '
        'ComboBoxCausalNovedad
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.ComboBoxCausalNovedad, 3)
        Me.ComboBoxCausalNovedad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxCausalNovedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCausalNovedad.FormattingEnabled = True
        Me.ComboBoxCausalNovedad.Location = New System.Drawing.Point(98, 78)
        Me.ComboBoxCausalNovedad.Name = "ComboBoxCausalNovedad"
        Me.ComboBoxCausalNovedad.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxCausalNovedad.TabIndex = 6
        '
        'LabelCausalNoEntrega
        '
        Me.LabelCausalNoEntrega.AutoSize = True
        Me.LabelCausalNoEntrega.Location = New System.Drawing.Point(3, 78)
        Me.LabelCausalNoEntrega.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCausalNoEntrega.Name = "LabelCausalNoEntrega"
        Me.LabelCausalNoEntrega.Size = New System.Drawing.Size(39, 13)
        Me.LabelCausalNoEntrega.TabIndex = 0
        Me.LabelCausalNoEntrega.Text = "Causal"
        '
        'TextBoxNumeroItem
        '
        Me.TextBoxNumeroItem.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxNumeroItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNumeroItem.Location = New System.Drawing.Point(98, 3)
        Me.TextBoxNumeroItem.Name = "TextBoxNumeroItem"
        Me.TextBoxNumeroItem.ReadOnly = True
        Me.TextBoxNumeroItem.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxNumeroItem.TabIndex = 1
        '
        'TextBoxProductoCodigo
        '
        Me.TextBoxProductoCodigo.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxProductoCodigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxProductoCodigo.Location = New System.Drawing.Point(343, 3)
        Me.TextBoxProductoCodigo.Name = "TextBoxProductoCodigo"
        Me.TextBoxProductoCodigo.ReadOnly = True
        Me.TextBoxProductoCodigo.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxProductoCodigo.TabIndex = 2
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBoxDescripcion, 3)
        Me.TextBoxDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(98, 28)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.ReadOnly = True
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(389, 20)
        Me.TextBoxDescripcion.TabIndex = 3
        '
        'TextBoxCantidadPlanificada
        '
        Me.TextBoxCantidadPlanificada.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCantidadPlanificada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCantidadPlanificada.Location = New System.Drawing.Point(343, 228)
        Me.TextBoxCantidadPlanificada.Name = "TextBoxCantidadPlanificada"
        Me.TextBoxCantidadPlanificada.ReadOnly = True
        Me.TextBoxCantidadPlanificada.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCantidadPlanificada.TabIndex = 5
        Me.TextBoxCantidadPlanificada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxCantidadSolicitada
        '
        Me.TextBoxCantidadSolicitada.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCantidadSolicitada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCantidadSolicitada.Location = New System.Drawing.Point(98, 228)
        Me.TextBoxCantidadSolicitada.Name = "TextBoxCantidadSolicitada"
        Me.TextBoxCantidadSolicitada.ReadOnly = True
        Me.TextBoxCantidadSolicitada.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCantidadSolicitada.TabIndex = 4
        Me.TextBoxCantidadSolicitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxSaldo
        '
        Me.TextBoxSaldo.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxSaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSaldo.Location = New System.Drawing.Point(98, 303)
        Me.TextBoxSaldo.Name = "TextBoxSaldo"
        Me.TextBoxSaldo.ReadOnly = True
        Me.TextBoxSaldo.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxSaldo.TabIndex = 12
        Me.TextBoxSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxCantidadOtrasNovedades
        '
        Me.TextBoxCantidadOtrasNovedades.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCantidadOtrasNovedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCantidadOtrasNovedades.Location = New System.Drawing.Point(98, 253)
        Me.TextBoxCantidadOtrasNovedades.Name = "TextBoxCantidadOtrasNovedades"
        Me.TextBoxCantidadOtrasNovedades.ReadOnly = True
        Me.TextBoxCantidadOtrasNovedades.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCantidadOtrasNovedades.TabIndex = 10
        Me.TextBoxCantidadOtrasNovedades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.LabelNumeroItem, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxNumeroItem, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelProductoCodigo, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxProductoCodigo, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelDescripcion, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxDescripcion, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntrega, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxCausalNovedad, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaDescripcion, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCausalNoEntregaDescripcion, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelIndicadorOTIF, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxIndicadorOTIF, 1, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelTipoNovedad, 0, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxTipoNovedad, 1, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCantidadSolicitada, 0, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCantidadSolicitada, 1, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCantidadPlanificada, 2, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCantidadPlanificada, 3, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCantidadOtrasNovedades, 0, 10)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCantidadOtrasNovedades, 1, 10)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCantidad, 0, 11)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelSaldo, 0, 12)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxSaldo, 1, 12)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaResponsable, 0, 14)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxCausalNovedadResponsable, 1, 14)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaResponsableInterno, 0, 15)
        Me.TableLayoutPanel6.Controls.Add(Me.ComboBoxCausalNovedadResponsableInterno, 1, 15)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelCausalNoEntregaNotas, 0, 17)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCausalNovedadNotas, 1, 17)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelNovedadUsuarioActualizacion, 0, 19)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBoxCausalNoEntregaUsuarioActualizacion, 1, 19)
        Me.TableLayoutPanel6.Controls.Add(Me.LabelNovedadFechaActualizacion, 2, 19)
        Me.TableLayoutPanel6.Controls.Add(Me.DTPCausalNoEntregaFechaActualizacion, 3, 19)
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanel1, 2, 21)
        Me.TableLayoutPanel6.Controls.Add(Me.NUDCantidad, 1, 11)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 22
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
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
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(505, 560)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'LabelTipoNovedad
        '
        Me.LabelTipoNovedad.AutoSize = True
        Me.LabelTipoNovedad.Location = New System.Drawing.Point(3, 203)
        Me.LabelTipoNovedad.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelTipoNovedad.Name = "LabelTipoNovedad"
        Me.LabelTipoNovedad.Size = New System.Drawing.Size(28, 13)
        Me.LabelTipoNovedad.TabIndex = 72
        Me.LabelTipoNovedad.Text = "Tipo"
        '
        'ComboBoxTipoNovedad
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.ComboBoxTipoNovedad, 3)
        Me.ComboBoxTipoNovedad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxTipoNovedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoNovedad.FormattingEnabled = True
        Me.ComboBoxTipoNovedad.Location = New System.Drawing.Point(98, 203)
        Me.ComboBoxTipoNovedad.Name = "ComboBoxTipoNovedad"
        Me.ComboBoxTipoNovedad.Size = New System.Drawing.Size(389, 21)
        Me.ComboBoxTipoNovedad.TabIndex = 9
        '
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Location = New System.Drawing.Point(3, 278)
        Me.LabelCantidad.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LabelCantidad.TabIndex = 74
        Me.LabelCantidad.Text = "Cantidad"
        '
        'FlowLayoutPanel1
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.FlowLayoutPanel1, 2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonAceptar)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonCancelar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(248, 528)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(239, 30)
        Me.FlowLayoutPanel1.TabIndex = 75
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonAceptar.Location = New System.Drawing.Point(161, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 18
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(80, 3)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 18
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'NUDCantidad
        '
        Me.NUDCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NUDCantidad.Location = New System.Drawing.Point(98, 278)
        Me.NUDCantidad.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NUDCantidad.Name = "NUDCantidad"
        Me.NUDCantidad.Size = New System.Drawing.Size(144, 20)
        Me.NUDCantidad.TabIndex = 76
        Me.NUDCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormEdicionNovedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancelar
        Me.ClientSize = New System.Drawing.Size(505, 560)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEdicionNovedad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva Novedad"
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.NUDCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelSaldo As Label
    Friend WithEvents LabelCantidadOtrasNovedades As Label
    Friend WithEvents LabelCantidadPlanificada As Label
    Friend WithEvents LabelCantidadSolicitada As Label
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents LabelProductoCodigo As Label
    Friend WithEvents LabelNumeroItem As Label
    Friend WithEvents DTPCausalNoEntregaFechaActualizacion As DateTimePicker
    Friend WithEvents LabelNovedadFechaActualizacion As Label
    Friend WithEvents TextBoxCausalNoEntregaUsuarioActualizacion As TextBox
    Friend WithEvents LabelNovedadUsuarioActualizacion As Label
    Friend WithEvents TextBoxCausalNovedadNotas As TextBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents ComboBoxTipoNovedad As ComboBox
    Friend WithEvents TextBoxCantidadOtrasNovedades As TextBox
    Friend WithEvents TextBoxSaldo As TextBox
    Friend WithEvents TextBoxCantidadSolicitada As TextBox
    Friend WithEvents TextBoxCantidadPlanificada As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents TextBoxProductoCodigo As TextBox
    Friend WithEvents TextBoxNumeroItem As TextBox
    Friend WithEvents LabelCausalNoEntrega As Label
    Friend WithEvents ComboBoxCausalNovedad As ComboBox
    Friend WithEvents LabelCausalNoEntregaDescripcion As Label
    Friend WithEvents TextBoxCausalNoEntregaDescripcion As TextBox
    Friend WithEvents LabelIndicadorOTIF As Label
    Friend WithEvents TextBoxIndicadorOTIF As TextBox
    Friend WithEvents LabelCausalNoEntregaResponsable As Label
    Friend WithEvents ComboBoxCausalNovedadResponsable As ComboBox
    Friend WithEvents LabelCausalNoEntregaResponsableInterno As Label
    Friend WithEvents ComboBoxCausalNovedadResponsableInterno As ComboBox
    Friend WithEvents LabelCausalNoEntregaNotas As Label
    Friend WithEvents LabelTipoNovedad As Label
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents NUDCantidad As NumericUpDown
End Class
