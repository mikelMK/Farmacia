Imports PHADS.Conexion
Public Class FmrGestionUsuario
    Private MiConexion As Conexion
    Private Estado As Integer = 0
    Dim MiTabla As DataTable
    Public Sub New(pConexion As Conexion)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Sub ActualizarDatos()
        MiTabla = MiConexion.Consultar("Select * from Empleados")
    End Sub


    Private Sub CargarListaEmpleados(DNI As String)
        Me.ActualizarDatos()
        LtsEmpleados.Items.Clear()
        'For Each MiRow As DataRow In MiTabla.Rows
        '    LtsEmpleados.Items.Add(MiRow(0) & " - " & MiRow(1) & " " & MiRow(2) & " " & MiRow(3))
        'Next
        LtsEmpleados.DataSource = MiTabla
        LtsEmpleados.DisplayMember = MiTabla.Columns(0).ColumnName
        LtsEmpleados.ValueMember = MiTabla.Columns(0).ColumnName
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
        Me.Estado_Consulta()
    End Sub

    Private Sub BtnRecargarEmpleados_Click(sender As Object, e As EventArgs) Handles BtnRecargarEmpleados.Click
        TxtDNIBusqueda.Text = "%"
        Me.ActualizarDatos()
    End Sub

    Private Sub LtsEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtsEmpleados.SelectedIndexChanged
        Me.ActualizarDatos()
        txtDni.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(0)
        txtContraseña.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(1)
        txtNombre.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(2)
        txtApellido1.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(3)
        txtApellido2.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(4)
        txtEmail.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(5)
        Try
            DtpNacimiento.Value = MiTabla(LtsEmpleados.SelectedIndex).Item(6)
        Catch ex As Exception
            'DtpNacimiento.Value = Nothing
        End Try
        Try
            DtpAlta.Value = MiTabla(LtsEmpleados.SelectedIndex).Item(7).ToString()
        Catch ex As Exception
            'DtpAlta.Value = Nothing
        End Try
        txtIdFarmacia.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(8)
        'CboPuesto.SelectedIndex = Integer.Parse(MiTabla(LtsEmpleados.SelectedIndex).Item(9))
        SudSalario.Value = MiTabla(LtsEmpleados.SelectedIndex).Item(10)
        'ComboBoxTipoVia.SelectedIndex = Integer.Parse(MiTabla(LtsEmpleados.SelectedIndex).Item(11))
        txtVia.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(12)
        TxtNVia.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(13)
        txtPortal.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(14)
        txtPiso.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(15)
        txtPuerta.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(16)
        txtCodPostal.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(17)
        txtPais.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(18)
        txtProvincia.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(19)
        txtLocalidad.Text = MiTabla(LtsEmpleados.SelectedIndex).Item(20)

        If MiTabla(LtsEmpleados.SelectedIndex).Item(21) = 1 Then
            ChkControlTotal.Checked = True
        Else
            ChkControlTotal.Checked = False
        End If

        If MiTabla(LtsEmpleados.SelectedIndex).Item(21) = 1 Then
            ChkVentas.Checked = True
        Else
            ChkVentas.Checked = False
        End If

        If MiTabla(LtsEmpleados.SelectedIndex).Item(21) = 1 Then
            ChkAlmacen.Checked = True
        Else
            ChkAlmacen.Checked = False
        End If

        If MiTabla(LtsEmpleados.SelectedIndex).Item(21) = 1 Then
            ChkCompras.Checked = True
        Else
            ChkAlmacen.Checked = False
        End If

        If MiTabla(LtsEmpleados.SelectedIndex).Item(21) = 1 Then
            ChkUsuarios.Checked = True
        Else
            ChkUsuarios.Checked = False
        End If

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