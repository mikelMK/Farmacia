Imports PHADS.Conexion
Imports PHADS.Usuario
Public Class FmrMain
    Private alta As GestionAlta
    Private baja As GestionBaja
    Private modificacion As GestionModificacion
    Private GeneradorConsultas As FmrConsultas
    Private Login As Login
    Private MiConexion As Conexion
    Private Usuario As Usuario
    Private _FmrGestionUsuarios As FmrGestionUsuario



    Public Sub New(pConecxion As Conexion, pUsuario As Usuario)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConecxion
        Usuario = pUsuario
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub FmrMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AltaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MsiAlta.Click
        alta = New GestionAlta(MiConexion)
        alta.Show()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsiBaja.Click
        baja = New GestionBaja(MiConexion)
        baja.Show()
    End Sub

    Private Sub ModificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsiMod.Click
        modificacion = New GestionModificacion(MiConexion)
        modificacion.Show()
    End Sub

    Private Sub GeneradorConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsGeneradorConsultas.Click
        GeneradorConsultas = New FmrConsultas(MiConexion)
        GeneradorConsultas.Show()
    End Sub

    Private Sub MsiUsuarios_Click(sender As Object, e As EventArgs) Handles MsiUsuarios.Click
        _FmrGestionUsuarios = New FmrGestionUsuario(MiConexion)
        _FmrGestionUsuarios.Show()
    End Sub
End Class
