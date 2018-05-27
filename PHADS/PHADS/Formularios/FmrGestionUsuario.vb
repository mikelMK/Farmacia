Imports PHADS.Conexion
Imports PHADS.Usuario
Imports PHADS.TipoVia
Public Class FmrGestionUsuario
    Private MiConexion As Conexion
    Private Estado As Integer = 0
    Dim MisEmpleados As List(Of Usuario) = New List(Of Usuario)
    Dim ListaVias As List(Of TipoVia) = New List(Of TipoVia)
    Dim EmpleadoMostrado As Usuario = New Usuario()

    Public Sub New(pConexion As Conexion)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub ActualizarDatos()
        Dim MiTabla As DataTable = MiConexion.Consultar("Select * from Empleados")
        MisEmpleados.Clear()
        For Each Mirow As DataRow In MiTabla.Rows
            MisEmpleados.Add(New Usuario(Mirow))
        Next
        MiTabla = MiConexion.Consultar("Select * from Tipo_Via")
        ListaVias.Clear()
        For Each Mirow As DataRow In MiTabla.Rows
            ListaVias.Add(New TipoVia(Mirow))
        Next
    End Sub

    Private Sub CargarListaEmpleados(DNI As String)
        Me.ActualizarDatos()
        LtsEmpleados.DataSource = MisEmpleados
        LtsEmpleados.DisplayMember = "DNI"
        LtsEmpleados.SelectedIndex = 0

        CboPuesto.DataSource = ListaVias
        CboPuesto.DisplayMember = "Despcripcion"
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
        Me.Estado_Consulta()
        LtsEmpleados.SelectedItem = -1
    End Sub

    Private Sub BtnRecargarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnRecargarEmpleados.Click
        TxtDNIBusqueda.Text = "%"
        Me.ActualizarDatos()
    End Sub

    Private Sub LtsEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtsEmpleados.SelectedIndexChanged
        Me.ActualizarDatos()
        EmpleadoMostrado = LtsEmpleados.SelectedItem
        txtDni.Text = EmpleadoMostrado.DNI
        txtContraseña.Text = EmpleadoMostrado.Password
        txtNombre.Text = EmpleadoMostrado.Nombre
        txtApellido1.Text = EmpleadoMostrado.Apell_1
        txtApellido2.Text = EmpleadoMostrado.Apell_2
        txtEmail.Text = EmpleadoMostrado.Email
        If EmpleadoMostrado.Fecha_Alta = Nothing Then
            DtpAlta.Value = Today
        Else
            DtpAlta.Value = EmpleadoMostrado.Fecha_Alta
        End If
        If EmpleadoMostrado.Fecha_Nac = Nothing Then
            DtpNacimiento.Value = Today
        Else
            DtpNacimiento.Value = EmpleadoMostrado.Fecha_Nac
        End If
        txtIdFarmacia.Text = EmpleadoMostrado.Farmacia
        'CboPuesto.SelectedIndex = Integer.Parse(EmpleadoMostrado(9))
        SudSalario.Value = EmpleadoMostrado.Salario
        'ComboBoxTipoVia.SelectedIndex = EmpleadoMostrado.TipoVia
        txtVia.Text = EmpleadoMostrado.NombreVia
        TxtNVia.Text = EmpleadoMostrado.NoVia
        txtPortal.Text = EmpleadoMostrado.NoPortal
        txtPiso.Text = EmpleadoMostrado.Piso
        txtPuerta.Text = EmpleadoMostrado.Puerta
        txtCodPostal.Text = EmpleadoMostrado.CodPostal
        txtPais.Text = EmpleadoMostrado.Pais
        txtProvincia.Text = EmpleadoMostrado.Provinca
        txtLocalidad.Text = EmpleadoMostrado.Localidad

        ChkControlTotal.Checked = EmpleadoMostrado.Control_Total
        ChkVentas.Checked = EmpleadoMostrado.Ventas
        ChkCompras.Checked = EmpleadoMostrado.Compras
        ChkAlmacen.Checked = EmpleadoMostrado.Almacen
        ChkUsuarios.Checked = EmpleadoMostrado.Usuarios

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim Loc As Integer = LtsEmpleados.FindString(TxtDNIBusqueda.Text)
        If Loc = -1 Then
            MessageBox.Show("No Encontrado")
        Else
            LtsEmpleados.SelectedIndex = Loc
        End If
    End Sub

    Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click
        Me.Estado_Insert()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Me.Estado_Modificacion()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Estado_Consulta()
    End Sub
End Class