Imports PHADS.Conexion
Imports PHADS.Usuario
Public Class FmrCambioPass
    Private _Usuario As Usuario
    Private _Conexion As Conexion
    Public Sub New(pUsuario As Usuario, pConexion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _Usuario = pUsuario
        _Conexion = pConexion
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtNuevaPass.Equals(TxtRepetirPass.Text) Then
            _Usuario.Password = TxtNuevaPass.Text
            _Conexion.Insetrar(_Usuario.SqlInsert)
            MessageBox.Show("Mensaje", "Contraseña cambiada")
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class