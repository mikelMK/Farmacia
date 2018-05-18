Imports ProyectoV1.Conexion
Public Class FmrGestionUsuario
    Private MiConexion As Conexion
    Private Estado As Integer = 0
    Public Sub New(pConexion As Conexion)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub CargarListaEmpleados(DNI As String)
        LtsEmpleados.Items.Clear()
        Dim MiTabla As DataTable
        MiTabla = MiConexion.Consultar("Select DNI,Nombre,Apell_1,Appel_2 from Empleados")

        For Each MiRow As DataRow In MiTabla.Rows
            LtsEmpleados.Items.Add(MiRow(0) & " - " & MiRow(1) & " " & MiRow(2) & " " & MiRow(3))
        Next
        LtsEmpleados.SelectedIndex = 0
    End Sub
    Private Sub Estado_Consulta()
        Estado = 0
        GrpDatosPersonales.Enabled = False
        GrpDireccion.Enabled = False
        GrpPermisos.Enabled = False
        GrpPuesto.Enabled = False
        BtnBuscar.Enabled = True
        BtnNewUser.Enabled = True
        BtnEliminar.Enabled = True
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
    End Sub
    Private Sub Estado_Insert()
        Estado = 1
        GrpDatosPersonales.Enabled = True
        GrpDireccion.Enabled = True
        GrpPermisos.Enabled = True
        GrpPuesto.Enabled = True
        BtnBuscar.Enabled = False
        BtnNewUser.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
    End Sub
    Private Sub Estado_Modificacion()
        Estado = 2
        GrpDatosPersonales.Enabled = True
        GrpDireccion.Enabled = True
        GrpPermisos.Enabled = True
        GrpPuesto.Enabled = True
        BtnBuscar.Enabled = False
        BtnNewUser.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        txtDni.Enabled = False
    End Sub

    Private Sub FmrGestionUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarListaEmpleados(TxtDNIBusqueda.Text)
    End Sub

    Private Sub BtnRecargarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnRecargarEmpleados.Click
        TxtDNIBusqueda.Text = "*"
        CargarListaEmpleados(TxtDNIBusqueda.Text)
    End Sub

    Private Sub LtsEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtsEmpleados.SelectedIndexChanged
        Dim MiTabla As DataTable
        MiTabla = MiConexion.Consultar("Select * from Empleados Where DNI='" & LtsEmpleados.SelectedItem.ToString.Substring(0, 9) & "'")


    End Sub
End Class