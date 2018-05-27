Imports PHADS.Conexion
Public Class Login
    Private MiConexion As Conexion
    Private MiUsuario As Usuario

    Public Sub New(pConexion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MiConexion = pConexion
    End Sub

    Public ReadOnly Property Usuario
        Get
            Return MiUsuario
        End Get
    End Property

    Private Sub BtnLoguin_Click(sender As Object, e As EventArgs) Handles BtnLoguin.Click
        Dim Sele As String
        Sele = "Select * From Empleados where DNI='" & TxtDNI.Text & "' And Contrasena='" & TxtPass.Text & "'"
        BtnLoguin.Enabled = False
        Dim tabla As DataTable = MiConexion.Consultar(Sele)
        BtnLoguin.Enabled = True
        If tabla IsNot Nothing Then
            MiUsuario = New Usuario(tabla.Rows.Item(0))
            MessageBox.Show("Bienvenido/a " + MiUsuario.Nombre)
            Me.Close()
        Else
            MessageBox.Show("Usuario o Contraseña Incorrecta")
        End If
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Login"
        Me.Top = (Screen.PrimaryScreen.Bounds.Height) / 2 - (Me.Height / 2)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width) / 2 - (Me.Width / 2)
    End Sub

    Private Sub BtnDebug_Click(sender As Object, e As EventArgs) Handles BtnDebug.Click
        TxtDNI.Text = "00000000A"
        TxtPass.Text = "Tere"
    End Sub
End Class