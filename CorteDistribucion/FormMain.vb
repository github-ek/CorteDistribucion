Imports System.Security.Principal
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration
Imports CorteDistribucion
Imports System.Windows.Forms.ListBox
Imports DgvFilterPopup
Imports System.ComponentModel

Public Class FormMain
    Dim mainStatusBar As New StatusBar()
    Dim statusPanel As New StatusBarPanel()
    Dim datetimePanel As New StatusBarPanel()
    Dim statusPanel_Text As String

    Public gOrdenes As List(Of String) = New List(Of String)
    Public fecha_cita As String
    Public hora_max As DateTime
    Public horamin_cita As String
    Public horamax_cita As String
    Public notas_cita As String
    Public causal_reprogramacion As Integer

#Region "Inicialización"
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createStatusBar()
    End Sub
    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub

    Private Sub createStatusBar()
        statusPanel.BorderStyle = StatusBarPanelBorderStyle.Sunken
        statusPanel.Text = "Planificador: " & Environment.UserName
        statusPanel.ToolTipText = "Planificador"
        statusPanel.AutoSize = StatusBarPanelAutoSize.Spring
        mainStatusBar.Panels.Add(statusPanel)

        datetimePanel.BorderStyle = StatusBarPanelBorderStyle.Raised
        datetimePanel.ToolTipText = "Fecha Hora: " + System.DateTime.Today.ToString()
        datetimePanel.Text = System.DateTime.Today.ToLongDateString()
        datetimePanel.AutoSize = StatusBarPanelAutoSize.Contents
        mainStatusBar.Panels.Add(datetimePanel)

        mainStatusBar.ShowPanels = True
        Controls.Add(mainStatusBar)
    End Sub
#End Region

#Region "Metodos Compartidos"
    Public Sub inicioProceso()
        statusPanel_Text = statusPanel.Text
        statusPanel.Text = "PROCESANDO..."
    End Sub

    Public Sub FinProceso()
        statusPanel.Text = statusPanel_Text
    End Sub
#End Region

#Region "Comandos Menú Tareas"
    Private Sub AsignarCitas()
        With FormCitas
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub CorteDeRutas()
        With FormCorte
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub ModificarCortesDeRutasManuales()

    End Sub
    Private Sub ModificarCortesDeRutas()

    End Sub
    Private Sub AnularCortesDeRutas()

    End Sub
    Private Sub GestionRutas()
        With FormRutas
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
#End Region

#Region "Comandos Menú Maestros"
    Private Sub MaestroVehiculos()
    End Sub
#End Region

#Region "Comandos Menú Reportes"
    Private Sub ReporteDePlanillasDeRuta()

    End Sub

#End Region

#Region "Metodos MenuItem Tareas"

    Private Sub CitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CitasToolStripMenuItem.Click
        AsignarCitas()
    End Sub

    Private Sub CortesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortesToolStripMenuItem.Click
        CorteDeRutas()
    End Sub

    Private Sub CortesManualesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortesManualesToolStripMenuItem.Click
        ModificarCortesDeRutasManuales()
    End Sub

    Private Sub ModificarCortesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarCortesToolStripMenuItem.Click
        ModificarCortesDeRutas()
    End Sub

    Private Sub AnularCortesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularCortesToolStripMenuItem.Click
        AnularCortesDeRutas()
    End Sub
    Private Sub PlanillasDeRutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanillasDeRutasToolStripMenuItem.Click
        GestionRutas()
    End Sub

    Private Sub CierreDeOrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDeOrdenesToolStripMenuItem.Click

    End Sub

    Private Sub TestCambioEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestCambioEstadoToolStripMenuItem.Click
    End Sub
#End Region

#Region "Metodos MenuItem Maestros"
    Private Sub MovilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovilesToolStripMenuItem.Click

    End Sub

    Private Sub TrasportadorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrasportadorasToolStripMenuItem.Click

    End Sub

    Private Sub TiposDeVehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeVehiculoToolStripMenuItem.Click

    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculosToolStripMenuItem.Click
        MaestroVehiculos()
    End Sub

    Private Sub ConductoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConductoresToolStripMenuItem.Click

    End Sub

    Private Sub CausalesDeAnulaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CausalesDeAnulaciónToolStripMenuItem.Click

    End Sub

    Private Sub CausalesAnulacionDeCortesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CausalesAnulacionDeCortesToolStripMenuItem.Click

    End Sub

    Private Sub CausalesAnulacionDeRutasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CausalesAnulacionDeRutasToolStripMenuItem.Click

    End Sub

    Private Sub CausdalesDeNovedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CausdalesDeNovedadesToolStripMenuItem.Click

    End Sub
#End Region

#Region "Metodos MenuItem Reportes"
    Private Sub ReporteDePlanillasDeRutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDePlanillasDeRutaToolStripMenuItem.Click
        ReporteDePlanillasDeRuta()
    End Sub


#End Region

End Class