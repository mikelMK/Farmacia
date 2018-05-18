Imports PHADS.Conexion

Public Class GestionBaja
    Private MiConexion As Conexion
    Private Usuarios As DataTable
    Dim UsuarioaEliminar As String

    Public Sub New(pConecxion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConecxion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub GestionBaja_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Bajas de usuario"
        Me.Top = (Screen.PrimaryScreen.Bounds.Height) / 2 - (Me.Height / 2)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width) / 2 - (Me.Width / 2)

        Usuarios = MiConexion.Consultar("Select DNI, Nombre, Apell_1 from Empleados")
        If Usuarios IsNot Nothing Then
            For Each oDataRow As DataRow In Usuarios.Rows
                LstUsuarios.Items.Add(oDataRow(0).ToString & " " & oDataRow(1).ToString & " " & oDataRow(2).ToString)
            Next
            btnEliminarUsuario.Enabled = False
        Else
            MessageBox.Show("Error Durante La Carga")
        End If
    End Sub

    Private Sub BtnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        UsuarioaEliminar = LSet(LstUsuarios.SelectedItem, 9)
        'UsuarioaEliminar = "02790888E"
        MessageBox.Show(UsuarioaEliminar)

        Dim query As String = "DELETE FROM Empleados WHERE DNI='" & UsuarioaEliminar & "'"
        If MiConexion.Delete(query) Then
            MessageBox.Show("Usuario Suprimido correctamente")
        Else
            MessageBox.Show("Error al Suprimir Usuario")
        End If
    End Sub

    Private Sub LstUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstUsuarios.SelectedIndexChanged
        If LstUsuarios.SelectedItem <> "" Then
            btnEliminarUsuario.Enabled = True
        End If
    End Sub
End Class