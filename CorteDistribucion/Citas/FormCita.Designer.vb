<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCita
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
        Dim cmdAceptar As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCita))
        Me.lblAMPM = New System.Windows.Forms.Label()
        Me.cbxAMPM = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.mcFechaCita = New System.Windows.Forms.MonthCalendar()
        Me.lblHoraMax = New System.Windows.Forms.Label()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.cbxHoraMax = New System.Windows.Forms.ComboBox()
        Me.nudVentanaHoraria = New System.Windows.Forms.NumericUpDown()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.ToolStripButtonSeleccionarTodosSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonInvertirSeleccionSeleccionados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonRemoverSeleccion = New System.Windows.Forms.ToolStripButton()
        Me.dgvSeleccionadas = New System.Windows.Forms.DataGridView()
        cmdAceptar = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudVentanaHoraria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.bnSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnSeleccionadas.SuspendLayout()
        CType(Me.dgvSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAceptar
        '
        cmdAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        cmdAceptar.Location = New System.Drawing.Point(483, 33)
        cmdAceptar.Name = "cmdAceptar"
        cmdAceptar.Size = New System.Drawing.Size(75, 23)
        cmdAceptar.TabIndex = 23
        cmdAceptar.Text = "Aceptar"
        cmdAceptar.UseVisualStyleBackColor = True
        AddHandler cmdAceptar.Click, AddressOf Me.cmdAceptar_Click
        '
        'lblAMPM
        '
        Me.lblAMPM.AutoSize = True
        Me.lblAMPM.Location = New System.Drawing.Point(217, 33)
        Me.lblAMPM.Margin = New System.Windows.Forms.Padding(3)
        Me.lblAMPM.Name = "lblAMPM"
        Me.lblAMPM.Size = New System.Drawing.Size(44, 13)
        Me.lblAMPM.TabIndex = 7
        Me.lblAMPM.Text = "AM/PM"
        '
        'cbxAMPM
        '
        Me.cbxAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAMPM.FormattingEnabled = True
        Me.cbxAMPM.Items.AddRange(New Object() {"AM", "PM", "AM/PM"})
        Me.cbxAMPM.Location = New System.Drawing.Point(323, 33)
        Me.cbxAMPM.Name = "cbxAMPM"
        Me.cbxAMPM.Size = New System.Drawing.Size(121, 21)
        Me.cbxAMPM.TabIndex = 16
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(877, 539)
        Me.SplitContainer1.SplitterDistance = 195
        Me.SplitContainer1.TabIndex = 18
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.cbxAMPM, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAMPM, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.mcFechaCita, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHoraMax, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHoras, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblResumen, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxHoraMax, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.nudVentanaHoraria, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(cmdAceptar, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdCancelar, 3, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(877, 195)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'mcFechaCita
        '
        Me.mcFechaCita.Location = New System.Drawing.Point(9, 9)
        Me.mcFechaCita.Name = "mcFechaCita"
        Me.TableLayoutPanel1.SetRowSpan(Me.mcFechaCita, 6)
        Me.mcFechaCita.TabIndex = 17
        '
        'lblHoraMax
        '
        Me.lblHoraMax.AutoSize = True
        Me.lblHoraMax.Location = New System.Drawing.Point(217, 63)
        Me.lblHoraMax.Margin = New System.Windows.Forms.Padding(3)
        Me.lblHoraMax.Name = "lblHoraMax"
        Me.lblHoraMax.Size = New System.Drawing.Size(70, 13)
        Me.lblHoraMax.TabIndex = 18
        Me.lblHoraMax.Text = "Hora maxíma"
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Location = New System.Drawing.Point(217, 93)
        Me.lblHoras.Margin = New System.Windows.Forms.Padding(3)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(82, 13)
        Me.lblHoras.TabIndex = 19
        Me.lblHoras.Text = "Ventana horaria"
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.BackColor = System.Drawing.SystemColors.Control
        Me.lblResumen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblResumen, 4)
        Me.lblResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResumen.Location = New System.Drawing.Point(217, 123)
        Me.lblResumen.Margin = New System.Windows.Forms.Padding(3)
        Me.lblResumen.Name = "lblResumen"
        Me.TableLayoutPanel1.SetRowSpan(Me.lblResumen, 2)
        Me.lblResumen.Size = New System.Drawing.Size(23, 22)
        Me.lblResumen.TabIndex = 20
        Me.lblResumen.Text = "   "
        '
        'cbxHoraMax
        '
        Me.cbxHoraMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxHoraMax.FormattingEnabled = True
        Me.cbxHoraMax.Location = New System.Drawing.Point(323, 63)
        Me.cbxHoraMax.Name = "cbxHoraMax"
        Me.cbxHoraMax.Size = New System.Drawing.Size(121, 21)
        Me.cbxHoraMax.TabIndex = 21
        '
        'nudVentanaHoraria
        '
        Me.nudVentanaHoraria.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.CorteDistribucion.My.MySettings.Default, "CitaVentanaHoraria", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.nudVentanaHoraria.Location = New System.Drawing.Point(323, 93)
        Me.nudVentanaHoraria.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudVentanaHoraria.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudVentanaHoraria.Name = "nudVentanaHoraria"
        Me.nudVentanaHoraria.Size = New System.Drawing.Size(120, 20)
        Me.nudVentanaHoraria.TabIndex = 22
        Me.nudVentanaHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudVentanaHoraria.Value = Global.CorteDistribucion.My.MySettings.Default.CitaVentanaHoraria
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Location = New System.Drawing.Point(483, 63)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 24
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.bnSeleccionadas, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvSeleccionadas, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(877, 340)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'bnSeleccionadas
        '
        Me.bnSeleccionadas.AddNewItem = Nothing
        Me.bnSeleccionadas.CountItem = Me.ToolStripLabel1
        Me.bnSeleccionadas.DeleteItem = Nothing
        Me.bnSeleccionadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bnSeleccionadas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelFiltrarSeleccionadas, Me.ToolStripTextBoxFiltroSeleccionadas, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripTextBox2, Me.ToolStripLabel1, Me.ToolStripSeparator3, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator10, Me.ToolStripButtonSeleccionarTodosSeleccionados, Me.ToolStripSeparator8, Me.ToolStripButtonInvertirSeleccionSeleccionados, Me.ToolStripSeparator9, Me.ToolStripButtonRemoverSeleccion})
        Me.bnSeleccionadas.Location = New System.Drawing.Point(0, 0)
        Me.bnSeleccionadas.MoveFirstItem = Me.ToolStripButton1
        Me.bnSeleccionadas.MoveLastItem = Me.ToolStripButton4
        Me.bnSeleccionadas.MoveNextItem = Me.ToolStripButton3
        Me.bnSeleccionadas.MovePreviousItem = Me.ToolStripButton2
        Me.bnSeleccionadas.Name = "bnSeleccionadas"
        Me.bnSeleccionadas.PositionItem = Me.ToolStripTextBox2
        Me.bnSeleccionadas.Size = New System.Drawing.Size(877, 30)
        Me.bnSeleccionadas.Stretch = True
        Me.bnSeleccionadas.TabIndex = 33
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
        Me.ToolStripButtonRemoverSeleccion.Size = New System.Drawing.Size(58, 27)
        Me.ToolStripButtonRemoverSeleccion.Text = "Remover"
        Me.ToolStripButtonRemoverSeleccion.ToolTipText = "Remover"
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
        Me.dgvSeleccionadas.Size = New System.Drawing.Size(871, 304)
        Me.dgvSeleccionadas.TabIndex = 31
        '
        'FormAsignarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 539)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAsignarCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar Cita"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudVentanaHoraria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.bnSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnSeleccionadas.ResumeLayout(False)
        Me.bnSeleccionadas.PerformLayout()
        CType(Me.dgvSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAMPM As Label
    Friend WithEvents cbxAMPM As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
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
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripButtonSeleccionarTodosSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButtonInvertirSeleccionSeleccionados As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripButtonRemoverSeleccion As ToolStripButton
    Friend WithEvents dgvSeleccionadas As DataGridView
    Friend WithEvents mcFechaCita As MonthCalendar
    Friend WithEvents lblHoraMax As Label
    Friend WithEvents lblHoras As Label
    Friend WithEvents lblResumen As Label
    Friend WithEvents cbxHoraMax As ComboBox
    Friend WithEvents nudVentanaHoraria As NumericUpDown
    Friend WithEvents cmdCancelar As Button
End Class
