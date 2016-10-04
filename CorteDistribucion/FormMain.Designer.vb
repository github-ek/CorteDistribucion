<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TareasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CortesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CortesManualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCortesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularCortesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlanillasDeRutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CierreDeOrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrasportadorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConductoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CausalesDeAnulaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CausalesAnulacionDeCortesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CausalesAnulacionDeRutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CausdalesDeNovedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDePlanillasDeRutaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestCambioEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TareasToolStripMenuItem, Me.MaestrosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TareasToolStripMenuItem
        '
        Me.TareasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CitasToolStripMenuItem, Me.ToolStripMenuItem1, Me.CortesToolStripMenuItem, Me.CortesManualesToolStripMenuItem, Me.ModificarCortesToolStripMenuItem, Me.AnularCortesToolStripMenuItem, Me.ToolStripMenuItem6, Me.PlanillasDeRutasToolStripMenuItem, Me.ToolStripMenuItem8, Me.CierreDeOrdenesToolStripMenuItem, Me.TestCambioEstadoToolStripMenuItem})
        Me.TareasToolStripMenuItem.Name = "TareasToolStripMenuItem"
        Me.TareasToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TareasToolStripMenuItem.Text = "Tareas"
        '
        'CitasToolStripMenuItem
        '
        Me.CitasToolStripMenuItem.Name = "CitasToolStripMenuItem"
        Me.CitasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CitasToolStripMenuItem.Text = "Citas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(175, 6)
        '
        'CortesToolStripMenuItem
        '
        Me.CortesToolStripMenuItem.Name = "CortesToolStripMenuItem"
        Me.CortesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CortesToolStripMenuItem.Text = "Cortes"
        '
        'CortesManualesToolStripMenuItem
        '
        Me.CortesManualesToolStripMenuItem.Enabled = False
        Me.CortesManualesToolStripMenuItem.Name = "CortesManualesToolStripMenuItem"
        Me.CortesManualesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CortesManualesToolStripMenuItem.Text = "Cortes Manuales"
        '
        'ModificarCortesToolStripMenuItem
        '
        Me.ModificarCortesToolStripMenuItem.Enabled = False
        Me.ModificarCortesToolStripMenuItem.Name = "ModificarCortesToolStripMenuItem"
        Me.ModificarCortesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ModificarCortesToolStripMenuItem.Text = "Modificar cortes"
        '
        'AnularCortesToolStripMenuItem
        '
        Me.AnularCortesToolStripMenuItem.Enabled = False
        Me.AnularCortesToolStripMenuItem.Name = "AnularCortesToolStripMenuItem"
        Me.AnularCortesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AnularCortesToolStripMenuItem.Text = "Anular cortes"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(175, 6)
        '
        'PlanillasDeRutasToolStripMenuItem
        '
        Me.PlanillasDeRutasToolStripMenuItem.Name = "PlanillasDeRutasToolStripMenuItem"
        Me.PlanillasDeRutasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PlanillasDeRutasToolStripMenuItem.Text = "Rutas"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(175, 6)
        '
        'CierreDeOrdenesToolStripMenuItem
        '
        Me.CierreDeOrdenesToolStripMenuItem.Name = "CierreDeOrdenesToolStripMenuItem"
        Me.CierreDeOrdenesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CierreDeOrdenesToolStripMenuItem.Text = "Cierre de Ordenes"
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovilesToolStripMenuItem, Me.ToolStripMenuItem2, Me.TrasportadorasToolStripMenuItem, Me.TiposDeVehiculoToolStripMenuItem, Me.VehiculosToolStripMenuItem, Me.ConductoresToolStripMenuItem, Me.ToolStripMenuItem3, Me.CausalesDeAnulaciónToolStripMenuItem, Me.ToolStripMenuItem5, Me.CausdalesDeNovedadesToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'MovilesToolStripMenuItem
        '
        Me.MovilesToolStripMenuItem.Enabled = False
        Me.MovilesToolStripMenuItem.Name = "MovilesToolStripMenuItem"
        Me.MovilesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.MovilesToolStripMenuItem.Text = "Móviles"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 6)
        '
        'TrasportadorasToolStripMenuItem
        '
        Me.TrasportadorasToolStripMenuItem.Enabled = False
        Me.TrasportadorasToolStripMenuItem.Name = "TrasportadorasToolStripMenuItem"
        Me.TrasportadorasToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.TrasportadorasToolStripMenuItem.Text = "Trasportadoras"
        '
        'TiposDeVehiculoToolStripMenuItem
        '
        Me.TiposDeVehiculoToolStripMenuItem.Enabled = False
        Me.TiposDeVehiculoToolStripMenuItem.Name = "TiposDeVehiculoToolStripMenuItem"
        Me.TiposDeVehiculoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.TiposDeVehiculoToolStripMenuItem.Text = "Tipos de Vehiculo"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.Enabled = False
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculos"
        '
        'ConductoresToolStripMenuItem
        '
        Me.ConductoresToolStripMenuItem.Enabled = False
        Me.ConductoresToolStripMenuItem.Name = "ConductoresToolStripMenuItem"
        Me.ConductoresToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConductoresToolStripMenuItem.Text = "Conductores"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(193, 6)
        '
        'CausalesDeAnulaciónToolStripMenuItem
        '
        Me.CausalesDeAnulaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CausalesAnulacionDeCortesToolStripMenuItem, Me.CausalesAnulacionDeRutasToolStripMenuItem, Me.ToolStripMenuItem4})
        Me.CausalesDeAnulaciónToolStripMenuItem.Enabled = False
        Me.CausalesDeAnulaciónToolStripMenuItem.Name = "CausalesDeAnulaciónToolStripMenuItem"
        Me.CausalesDeAnulaciónToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CausalesDeAnulaciónToolStripMenuItem.Text = "Causales de anulación"
        '
        'CausalesAnulacionDeCortesToolStripMenuItem
        '
        Me.CausalesAnulacionDeCortesToolStripMenuItem.Name = "CausalesAnulacionDeCortesToolStripMenuItem"
        Me.CausalesAnulacionDeCortesToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CausalesAnulacionDeCortesToolStripMenuItem.Text = "Cortes"
        '
        'CausalesAnulacionDeRutasToolStripMenuItem
        '
        Me.CausalesAnulacionDeRutasToolStripMenuItem.Name = "CausalesAnulacionDeRutasToolStripMenuItem"
        Me.CausalesAnulacionDeRutasToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CausalesAnulacionDeRutasToolStripMenuItem.Text = "Rutas"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(105, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(193, 6)
        '
        'CausdalesDeNovedadesToolStripMenuItem
        '
        Me.CausdalesDeNovedadesToolStripMenuItem.Enabled = False
        Me.CausdalesDeNovedadesToolStripMenuItem.Name = "CausdalesDeNovedadesToolStripMenuItem"
        Me.CausdalesDeNovedadesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CausdalesDeNovedadesToolStripMenuItem.Text = "Causales de novedades"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDePlanillasDeRutaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDePlanillasDeRutaToolStripMenuItem
        '
        Me.ReporteDePlanillasDeRutaToolStripMenuItem.Name = "ReporteDePlanillasDeRutaToolStripMenuItem"
        Me.ReporteDePlanillasDeRutaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ReporteDePlanillasDeRutaToolStripMenuItem.Text = "Planillas de ruta"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        Me.TestToolStripMenuItem.Visible = False
        '
        'TestCambioEstadoToolStripMenuItem
        '
        Me.TestCambioEstadoToolStripMenuItem.Name = "TestCambioEstadoToolStripMenuItem"
        Me.TestCambioEstadoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.TestCambioEstadoToolStripMenuItem.Text = "Test Cambio Estado"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(770, 367)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "Tactic Connect <Distribución>"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDePlanillasDeRutaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TareasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CitasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CortesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarCortesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnularCortesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents TrasportadorasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConductoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents PlanillasDeRutasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents CierreDeOrdenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeVehiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents CausalesDeAnulaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CausalesAnulacionDeCortesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CausalesAnulacionDeRutasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents CausdalesDeNovedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortesManualesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestCambioEstadoToolStripMenuItem As ToolStripMenuItem
End Class
