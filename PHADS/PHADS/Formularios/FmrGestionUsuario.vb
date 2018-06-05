Imports PHADS.Conexion
Imports PHADS.Usuario
Imports PHADS.TipoVia
Imports PHADS.TipoPuesto
Public Class FmrGestionUsuario
#Region "Variables"
    Private MiConexion As Conexion
    Private Estado As Integer = 0
    Dim MisEmpleados As List(Of Usuario) = New List(Of Usuario)
    Dim ListaVias As List(Of TipoVia) = New List(Of TipoVia)
    Dim ListaPuestos As List(Of TipoPuesto) = New List(Of TipoPuesto)
    Dim EmpleadoMostrado As Usuario = New Usuario()
#End Region
#Region "Constructores"
    Public Sub New(pConexion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
#End Region
#Region "Manejadores"
#Region "Load"
    Private Sub FmrGestionUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarListas()
        Me.Estado_Consulta()
    End Sub
#End Region

#Region "Botones"
    Private Sub BtnRecargarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnRecargarEmpleados.Click
        Me.ActualizarDatos()
    End Sub

    Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click
        LtsEmpleados.SelectedIndex = -1
        Me.Estado_Insert()
        Carga()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If LtsEmpleados.SelectedIndex <> -1 Then
            Me.Estado_Modificacion()
        Else
            MessageBox.Show("Selecione un empleado")
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If LtsEmpleados.SelectedIndex <> -1 Then
            If MessageBox.Show("Desea eliminar a " & EmpleadoMostrado.Nombre & " " & EmpleadoMostrado.Apell_1 & " " & EmpleadoMostrado.Apell_2, "Eliminar", MessageBoxButtons.YesNo) Then
                If MiConexion.Delete(EmpleadoMostrado.SqlDelete) Then
                    MessageBox.Show("Empleado eliminado")
                Else
                    MessageBox.Show("Error al eliminar empleado")
                End If
            End If
            Me.ActualizarDatos()
            LtsEmpleados.SelectedIndex = -1
        Else
            MessageBox.Show("Selecione un empleado")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Estado_Consulta()
        LtsEmpleados.SelectedIndex = -1
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        descarga()
        Select Case Estado
            Case 1
                Dim sql As String = EmpleadoMostrado.SqlInsert
                MessageBox.Show(sql)
                If MiConexion.Insetrar(sql) Then
                    MessageBox.Show("Empleado creado")
                    Me.ActualizarDatos()
                    Me.Estado_Consulta()
                Else
                    MessageBox.Show("Error al crear empleado")
                End If
            Case 2
                Dim sql As String = EmpleadoMostrado.SqlUpdate
                If MiConexion.Update(sql) Then
                    MessageBox.Show("Empleado actualizado")
                    Me.ActualizarDatos()
                    Me.Estado_Consulta()
                Else
                    MessageBox.Show("Error al actualizar empleado ")
                End If
        End Select
    End Sub
#End Region

#Region "Otros"
    Private Sub LtsEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtsEmpleados.SelectedIndexChanged
        If LtsEmpleados.SelectedIndex = -1 Then
            EmpleadoMostrado = New Usuario()
        Else
            EmpleadoMostrado = LtsEmpleados.SelectedItem
        End If
        Carga()
    End Sub
#End Region
#End Region
#Region "Procedimientos"
    Private Sub Carga()
        txtDni.Text = EmpleadoMostrado.DNI
        txtContraseña.Text = EmpleadoMostrado.Password
        txtNombre.Text = EmpleadoMostrado.Nombre
        txtApellido1.Text = EmpleadoMostrado.Apell_1
        txtApellido2.Text = EmpleadoMostrado.Apell_2
        txtEmail.Text = EmpleadoMostrado.Email
        If EmpleadoMostrado.Fecha_Alta = Nothing Then
            DtpAlta.Value = #01/01/2000#
        Else
            DtpAlta.Value = EmpleadoMostrado.Fecha_Alta
        End If
        If EmpleadoMostrado.Fecha_Nac = Nothing Then
            DtpNacimiento.Value = #01/01/2000#
        Else
            DtpNacimiento.Value = EmpleadoMostrado.Fecha_Nac
        End If
        txtIdFarmacia.Text = EmpleadoMostrado.Farmacia
        For i = 0 To CboPuesto.Items.Count - 1
            CboPuesto.SelectedIndex = i
            If CboPuesto.SelectedValue = EmpleadoMostrado.Puesto Then
                i = CboPuesto.Items.Count - 1
            End If
        Next
        SudSalario.Value = EmpleadoMostrado.Salario
        For i = 0 To CboTipoVia.Items.Count - 1
            CboTipoVia.SelectedIndex = i
            If CboTipoVia.SelectedValue = EmpleadoMostrado.TipoVia Then
                i = CboTipoVia.Items.Count - 1
            End If
        Next
        txtVia.Text = EmpleadoMostrado.NombreVia
        TxtNVia.Text = EmpleadoMostrado.NoVia
        txtPortal.Text = EmpleadoMostrado.NoPortal
        txtPiso.Text = EmpleadoMostrado.Piso
        txtPuerta.Text = EmpleadoMostrado.Puerta
        txtCodPostal.Text = EmpleadoMostrado.CodPostal
        txtPais.Text = EmpleadoMostrado.Pais
        txtProvincia.Text = EmpleadoMostrado.Provinca
        txtLocalidad.Text = EmpleadoMostrado.Localidad

        ChkControlTotal.Checked = EmpleadoMostrado.ControlTotal
        ChkVentas.Checked = EmpleadoMostrado.Ventas
        ChkCompras.Checked = EmpleadoMostrado.Compras
        ChkAlmacen.Checked = EmpleadoMostrado.Almacen
        ChkUsuarios.Checked = EmpleadoMostrado.Usuarios
    End Sub

    Private Sub descarga()
        EmpleadoMostrado.DNI = txtDni.Text
        EmpleadoMostrado.Password = txtContraseña.Text
        EmpleadoMostrado.Nombre = txtNombre.Text
        EmpleadoMostrado.Apell_1 = txtApellido1.Text
        EmpleadoMostrado.Apell_2 = txtApellido2.Text
        EmpleadoMostrado.Email = txtEmail.Text
        'date time piker
        EmpleadoMostrado.Fecha_Alta = DtpAlta.Value
        'date time piker
        EmpleadoMostrado.Fecha_Nac = DtpNacimiento.Value
        'Especial(WIP)
        EmpleadoMostrado.Farmacia = txtIdFarmacia.Text
        'Combo(Wip)
        EmpleadoMostrado.Puesto = CboPuesto.SelectedValue
        'Spiner
        EmpleadoMostrado.Salario = SudSalario.Value
        'COMBO
        EmpleadoMostrado.TipoVia = CboTipoVia.SelectedValue

        EmpleadoMostrado.NombreVia = txtVia.Text
        EmpleadoMostrado.NoVia = TxtNVia.Text
        EmpleadoMostrado.NoPortal = txtPortal.Text
        EmpleadoMostrado.Piso = txtPiso.Text
        EmpleadoMostrado.Puerta = txtPuerta.Text
        EmpleadoMostrado.CodPostal = txtCodPostal.Text
        EmpleadoMostrado.Pais = txtPais.Text
        EmpleadoMostrado.Provinca = txtProvincia.Text
        EmpleadoMostrado.Localidad = txtLocalidad.Text
        'Chex Box
        EmpleadoMostrado.ControlTotal = ChkControlTotal.Checked
        EmpleadoMostrado.Ventas = ChkVentas.Checked
        EmpleadoMostrado.Compras = ChkCompras.Checked
        EmpleadoMostrado.Almacen = ChkAlmacen.Checked
        EmpleadoMostrado.Usuarios = ChkUsuarios.Checked
    End Sub

    Private Sub Estado_Consulta()
        Estado = 0
        LtsEmpleados.Enabled = True
        GrpDatosPersonales.Enabled = False
        GrpDireccion.Enabled = False
        GrpPermisos.Enabled = False
        GrpPuesto.Enabled = False
        BtnNewUser.Enabled = True
        BtnEliminar.Enabled = True
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
    End Sub

    Private Sub Estado_Insert()
        Estado = 1
        txtDni.Enabled = True
        LtsEmpleados.Enabled = False
        GrpDatosPersonales.Enabled = True
        GrpDireccion.Enabled = True
        GrpPermisos.Enabled = True
        GrpPuesto.Enabled = True
        BtnNewUser.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
    End Sub

    Private Sub Estado_Modificacion()
        Estado = 2
        GrpDatosPersonales.Enabled = True
        LtsEmpleados.Enabled = True
        GrpDireccion.Enabled = True
        GrpPermisos.Enabled = True
        GrpPuesto.Enabled = True
        BtnNewUser.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        txtDni.Enabled = False
    End Sub

    Private Sub ActualizarDatos()

        Dim MiTabla As DataTable
        'Tipo_Via
        MiTabla = MiConexion.Consultar("Select * from Tipo_Via")
        ListaVias.Clear()
        For Each Mirow As DataRow In MiTabla.Rows
            ListaVias.Add(New TipoVia(Mirow))
        Next
        CboTipoVia.DataSource = ListaVias
        'Tipo_Puesto
        MiTabla = MiConexion.Consultar("Select * from Tipo_Puesto")
        ListaPuestos.Clear()
        For Each Mirow As DataRow In MiTabla.Rows
            ListaPuestos.Add(New TipoPuesto(Mirow))
        Next
        CboPuesto.DataSource = ListaPuestos
        'Empleados
        MiTabla = MiConexion.Consultar("Select * from Empleados")
        MisEmpleados.Clear()
        For Each Mirow As DataRow In MiTabla.Rows
            MisEmpleados.Add(New Usuario(Mirow))
        Next
        LtsEmpleados.DataSource = MisEmpleados

    End Sub

    Private Sub CargarListas()
        CboPuesto.DisplayMember = "Despcripcion"
        CboPuesto.ValueMember = "IdPuesto"

        CboTipoVia.DisplayMember = "Despcripcion"
        CboTipoVia.ValueMember = "Id"

        LtsEmpleados.DisplayMember = "DNI"
        LtsEmpleados.SelectedIndex = -1

        Me.ActualizarDatos()
    End Sub

    Private Sub CboPuesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPuesto.SelectedIndexChanged
        Dim puesto As TipoPuesto = CboPuesto.SelectedItem()
        ChkControlTotal.Checked = puesto.ControlTotal
        ChkVentas.Checked = puesto.Ventas
        ChkCompras.Checked = puesto.Compras
        ChkAlmacen.Checked = puesto.Almacen
        ChkUsuarios.Checked = puesto.Usuarios

    End Sub

    Private Sub ChkControlTotal_CheckedChanged(sender As Object, e As EventArgs) Handles ChkControlTotal.CheckedChanged
        If ChkControlTotal.Checked Then
            ChkVentas.Checked = True
            ChkCompras.Checked = True
            ChkAlmacen.Checked = True
            ChkUsuarios.Checked = True
        Else
            ChkVentas.Checked = False
            ChkCompras.Checked = False
            ChkAlmacen.Checked = False
            ChkUsuarios.Checked = False
        End If
    End Sub
#End Region
End Class