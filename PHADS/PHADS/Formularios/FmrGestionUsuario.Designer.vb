<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrGestionUsuario
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
        Me.LtsEmpleados = New System.Windows.Forms.ListBox()
        Me.BtnRecargarEmpleados = New System.Windows.Forms.Button()
        Me.ComboBoxTipoVia = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ChkCompras = New System.Windows.Forms.CheckBox()
        Me.ChkAlmacen = New System.Windows.Forms.CheckBox()
        Me.ChkVentas = New System.Windows.Forms.CheckBox()
        Me.ChkUsuarios = New System.Windows.Forms.CheckBox()
        Me.ChkControlTotal = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtCodPostal = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtPuerta = New System.Windows.Forms.TextBox()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.txtPortal = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtVia = New System.Windows.Forms.TextBox()
        Me.txtIdFarmacia = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GrpDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpPuesto = New System.Windows.Forms.GroupBox()
        Me.GrpPermisos = New System.Windows.Forms.GroupBox()
        Me.GrpDireccion = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SudSalario = New System.Windows.Forms.NumericUpDown()
        Me.BtnNewUser = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtDNIBusqueda = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GrpDatosPersonales.SuspendLayout()
        Me.GrpPuesto.SuspendLayout()
        Me.GrpPermisos.SuspendLayout()
        Me.GrpDireccion.SuspendLayout()
        CType(Me.SudSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LtsEmpleados
        '
        Me.LtsEmpleados.FormattingEnabled = True
        Me.LtsEmpleados.Location = New System.Drawing.Point(12, 77)
        Me.LtsEmpleados.Name = "LtsEmpleados"
        Me.LtsEmpleados.Size = New System.Drawing.Size(158, 381)
        Me.LtsEmpleados.TabIndex = 0
        '
        'BtnRecargarEmpleados
        '
        Me.BtnRecargarEmpleados.Location = New System.Drawing.Point(12, 462)
        Me.BtnRecargarEmpleados.Name = "BtnRecargarEmpleados"
        Me.BtnRecargarEmpleados.Size = New System.Drawing.Size(158, 23)
        Me.BtnRecargarEmpleados.TabIndex = 1
        Me.BtnRecargarEmpleados.Text = "Recargar"
        Me.BtnRecargarEmpleados.UseVisualStyleBackColor = True
        '
        'ComboBoxTipoVia
        '
        Me.ComboBoxTipoVia.FormattingEnabled = True
        Me.ComboBoxTipoVia.Location = New System.Drawing.Point(81, 23)
        Me.ComboBoxTipoVia.Name = "ComboBoxTipoVia"
        Me.ComboBoxTipoVia.Size = New System.Drawing.Size(139, 21)
        Me.ComboBoxTipoVia.TabIndex = 104
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "Tipo de Via"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(82, 75)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(219, 20)
        Me.txtPais.TabIndex = 102
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 78)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 13)
        Me.Label22.TabIndex = 101
        Me.Label22.Text = "Pais"
        '
        'ChkCompras
        '
        Me.ChkCompras.AutoSize = True
        Me.ChkCompras.Location = New System.Drawing.Point(359, 19)
        Me.ChkCompras.Name = "ChkCompras"
        Me.ChkCompras.Size = New System.Drawing.Size(67, 17)
        Me.ChkCompras.TabIndex = 100
        Me.ChkCompras.Text = "Compras"
        Me.ChkCompras.UseVisualStyleBackColor = True
        '
        'ChkAlmacen
        '
        Me.ChkAlmacen.AutoSize = True
        Me.ChkAlmacen.Location = New System.Drawing.Point(261, 19)
        Me.ChkAlmacen.Name = "ChkAlmacen"
        Me.ChkAlmacen.Size = New System.Drawing.Size(67, 17)
        Me.ChkAlmacen.TabIndex = 99
        Me.ChkAlmacen.Text = "Almacén"
        Me.ChkAlmacen.UseVisualStyleBackColor = True
        '
        'ChkVentas
        '
        Me.ChkVentas.AutoSize = True
        Me.ChkVentas.Location = New System.Drawing.Point(165, 19)
        Me.ChkVentas.Name = "ChkVentas"
        Me.ChkVentas.Size = New System.Drawing.Size(59, 17)
        Me.ChkVentas.TabIndex = 98
        Me.ChkVentas.Text = "Ventas"
        Me.ChkVentas.UseVisualStyleBackColor = True
        '
        'ChkUsuarios
        '
        Me.ChkUsuarios.AutoSize = True
        Me.ChkUsuarios.Location = New System.Drawing.Point(447, 19)
        Me.ChkUsuarios.Name = "ChkUsuarios"
        Me.ChkUsuarios.Size = New System.Drawing.Size(67, 17)
        Me.ChkUsuarios.TabIndex = 97
        Me.ChkUsuarios.Text = "Usuarios"
        Me.ChkUsuarios.UseVisualStyleBackColor = True
        '
        'ChkControlTotal
        '
        Me.ChkControlTotal.AutoSize = True
        Me.ChkControlTotal.Location = New System.Drawing.Point(45, 19)
        Me.ChkControlTotal.Name = "ChkControlTotal"
        Me.ChkControlTotal.Size = New System.Drawing.Size(86, 17)
        Me.ChkControlTotal.TabIndex = 96
        Me.ChkControlTotal.Text = "Control Total"
        Me.ChkControlTotal.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(312, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.ComboBox1.TabIndex = 94
        '
        'txtCodPostal
        '
        Me.txtCodPostal.Location = New System.Drawing.Point(386, 101)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(217, 20)
        Me.txtCodPostal.TabIndex = 93
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(386, 75)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(217, 20)
        Me.txtLocalidad.TabIndex = 92
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(82, 101)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(219, 20)
        Me.txtProvincia.TabIndex = 91
        '
        'txtPuerta
        '
        Me.txtPuerta.Location = New System.Drawing.Point(279, 49)
        Me.txtPuerta.Name = "txtPuerta"
        Me.txtPuerta.Size = New System.Drawing.Size(55, 20)
        Me.txtPuerta.TabIndex = 90
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(163, 49)
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(55, 20)
        Me.txtPiso.TabIndex = 89
        '
        'txtPortal
        '
        Me.txtPortal.Location = New System.Drawing.Point(81, 49)
        Me.txtPortal.Name = "txtPortal"
        Me.txtPortal.Size = New System.Drawing.Size(39, 20)
        Me.txtPortal.TabIndex = 88
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(1307, 408)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(42, 20)
        Me.txtNumero.TabIndex = 87
        '
        'txtVia
        '
        Me.txtVia.Location = New System.Drawing.Point(279, 23)
        Me.txtVia.Name = "txtVia"
        Me.txtVia.Size = New System.Drawing.Size(324, 20)
        Me.txtVia.TabIndex = 86
        '
        'txtIdFarmacia
        '
        Me.txtIdFarmacia.Location = New System.Drawing.Point(82, 29)
        Me.txtIdFarmacia.Name = "txtIdFarmacia"
        Me.txtIdFarmacia.Size = New System.Drawing.Size(153, 20)
        Me.txtIdFarmacia.TabIndex = 85
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(319, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Localidad"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Provincia"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(319, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "CodPostal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(224, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Puerta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(130, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Piso"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Portal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1286, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Nº"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(240, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Via"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(257, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Puesto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Id Farmacia"
        '
        'GrpDatosPersonales
        '
        Me.GrpDatosPersonales.Controls.Add(Me.DateTimePicker2)
        Me.GrpDatosPersonales.Controls.Add(Me.DateTimePicker1)
        Me.GrpDatosPersonales.Controls.Add(Me.txtEmail)
        Me.GrpDatosPersonales.Controls.Add(Me.txtApellido2)
        Me.GrpDatosPersonales.Controls.Add(Me.txtApellido1)
        Me.GrpDatosPersonales.Controls.Add(Me.txtNombre)
        Me.GrpDatosPersonales.Controls.Add(Me.txtContraseña)
        Me.GrpDatosPersonales.Controls.Add(Me.txtDni)
        Me.GrpDatosPersonales.Controls.Add(Me.Label8)
        Me.GrpDatosPersonales.Controls.Add(Me.Label7)
        Me.GrpDatosPersonales.Controls.Add(Me.Label6)
        Me.GrpDatosPersonales.Controls.Add(Me.Label5)
        Me.GrpDatosPersonales.Controls.Add(Me.Label4)
        Me.GrpDatosPersonales.Controls.Add(Me.Label3)
        Me.GrpDatosPersonales.Controls.Add(Me.Label2)
        Me.GrpDatosPersonales.Controls.Add(Me.Label1)
        Me.GrpDatosPersonales.Location = New System.Drawing.Point(192, 22)
        Me.GrpDatosPersonales.Name = "GrpDatosPersonales"
        Me.GrpDatosPersonales.Size = New System.Drawing.Size(634, 169)
        Me.GrpDatosPersonales.TabIndex = 109
        Me.GrpDatosPersonales.TabStop = False
        Me.GrpDatosPersonales.Text = "Datos Personales"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(82, 133)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(219, 20)
        Me.DateTimePicker2.TabIndex = 122
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(386, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 20)
        Me.DateTimePicker1.TabIndex = 121
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(82, 107)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 20)
        Me.txtEmail.TabIndex = 120
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(386, 81)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(217, 20)
        Me.txtApellido2.TabIndex = 119
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(82, 81)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(219, 20)
        Me.txtApellido1.TabIndex = 118
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(82, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 20)
        Me.txtNombre.TabIndex = 117
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(386, 29)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(217, 20)
        Me.txtContraseña.TabIndex = 116
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(82, 29)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(219, 20)
        Me.txtDni.TabIndex = 115
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Fecha Alta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(319, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Fecha Nacimiento"
        Me.Label7.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Apellido 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Apellido 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "DNI"
        '
        'GrpPuesto
        '
        Me.GrpPuesto.Controls.Add(Me.SudSalario)
        Me.GrpPuesto.Controls.Add(Me.Label19)
        Me.GrpPuesto.Controls.Add(Me.ComboBox1)
        Me.GrpPuesto.Controls.Add(Me.txtIdFarmacia)
        Me.GrpPuesto.Controls.Add(Me.Label10)
        Me.GrpPuesto.Controls.Add(Me.Label9)
        Me.GrpPuesto.Location = New System.Drawing.Point(192, 197)
        Me.GrpPuesto.Name = "GrpPuesto"
        Me.GrpPuesto.Size = New System.Drawing.Size(633, 63)
        Me.GrpPuesto.TabIndex = 110
        Me.GrpPuesto.TabStop = False
        Me.GrpPuesto.Text = "Puesto"
        '
        'GrpPermisos
        '
        Me.GrpPermisos.Controls.Add(Me.ChkCompras)
        Me.GrpPermisos.Controls.Add(Me.ChkAlmacen)
        Me.GrpPermisos.Controls.Add(Me.ChkVentas)
        Me.GrpPermisos.Controls.Add(Me.ChkUsuarios)
        Me.GrpPermisos.Controls.Add(Me.ChkControlTotal)
        Me.GrpPermisos.Location = New System.Drawing.Point(192, 404)
        Me.GrpPermisos.Name = "GrpPermisos"
        Me.GrpPermisos.Size = New System.Drawing.Size(633, 52)
        Me.GrpPermisos.TabIndex = 111
        Me.GrpPermisos.TabStop = False
        Me.GrpPermisos.Text = "Permisos"
        '
        'GrpDireccion
        '
        Me.GrpDireccion.Controls.Add(Me.Label23)
        Me.GrpDireccion.Controls.Add(Me.ComboBoxTipoVia)
        Me.GrpDireccion.Controls.Add(Me.txtVia)
        Me.GrpDireccion.Controls.Add(Me.Label11)
        Me.GrpDireccion.Controls.Add(Me.txtCodPostal)
        Me.GrpDireccion.Controls.Add(Me.txtPais)
        Me.GrpDireccion.Controls.Add(Me.txtProvincia)
        Me.GrpDireccion.Controls.Add(Me.Label16)
        Me.GrpDireccion.Controls.Add(Me.txtLocalidad)
        Me.GrpDireccion.Controls.Add(Me.Label13)
        Me.GrpDireccion.Controls.Add(Me.Label17)
        Me.GrpDireccion.Controls.Add(Me.Label22)
        Me.GrpDireccion.Controls.Add(Me.txtPortal)
        Me.GrpDireccion.Controls.Add(Me.Label18)
        Me.GrpDireccion.Controls.Add(Me.Label14)
        Me.GrpDireccion.Controls.Add(Me.txtPiso)
        Me.GrpDireccion.Controls.Add(Me.Label15)
        Me.GrpDireccion.Controls.Add(Me.txtPuerta)
        Me.GrpDireccion.Location = New System.Drawing.Point(192, 266)
        Me.GrpDireccion.Name = "GrpDireccion"
        Me.GrpDireccion.Size = New System.Drawing.Size(631, 132)
        Me.GrpDireccion.TabIndex = 112
        Me.GrpDireccion.TabStop = False
        Me.GrpDireccion.Text = "Direccion"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(455, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Salario"
        '
        'SudSalario
        '
        Me.SudSalario.Location = New System.Drawing.Point(500, 29)
        Me.SudSalario.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.SudSalario.Name = "SudSalario"
        Me.SudSalario.Size = New System.Drawing.Size(103, 20)
        Me.SudSalario.TabIndex = 97
        '
        'BtnNewUser
        '
        Me.BtnNewUser.Location = New System.Drawing.Point(192, 462)
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(105, 23)
        Me.BtnNewUser.TabIndex = 113
        Me.BtnNewUser.Text = "Nuevo Usuario"
        Me.BtnNewUser.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(555, 462)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(131, 23)
        Me.BtnGuardar.TabIndex = 114
        Me.BtnGuardar.Text = "Gaurdar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(695, 462)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 23)
        Me.BtnCancelar.TabIndex = 115
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(414, 462)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(105, 23)
        Me.BtnEliminar.TabIndex = 116
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtDNIBusqueda
        '
        Me.TxtDNIBusqueda.Location = New System.Drawing.Point(12, 22)
        Me.TxtDNIBusqueda.Name = "TxtDNIBusqueda"
        Me.TxtDNIBusqueda.Size = New System.Drawing.Size(158, 20)
        Me.TxtDNIBusqueda.TabIndex = 117
        Me.TxtDNIBusqueda.Text = "*"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(12, 48)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(158, 23)
        Me.BtnBuscar.TabIndex = 118
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(303, 462)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(105, 23)
        Me.BtnModificar.TabIndex = 119
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'FmrGestionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(842, 495)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtDNIBusqueda)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNewUser)
        Me.Controls.Add(Me.GrpDireccion)
        Me.Controls.Add(Me.GrpPermisos)
        Me.Controls.Add(Me.GrpPuesto)
        Me.Controls.Add(Me.GrpDatosPersonales)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnRecargarEmpleados)
        Me.Controls.Add(Me.LtsEmpleados)
        Me.Name = "FmrGestionUsuario"
        Me.Text = "Gestion De Usuarios"
        Me.GrpDatosPersonales.ResumeLayout(False)
        Me.GrpDatosPersonales.PerformLayout()
        Me.GrpPuesto.ResumeLayout(False)
        Me.GrpPuesto.PerformLayout()
        Me.GrpPermisos.ResumeLayout(False)
        Me.GrpPermisos.PerformLayout()
        Me.GrpDireccion.ResumeLayout(False)
        Me.GrpDireccion.PerformLayout()
        CType(Me.SudSalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LtsEmpleados As ListBox
    Friend WithEvents BtnRecargarEmpleados As Button
    Friend WithEvents ComboBoxTipoVia As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ChkCompras As CheckBox
    Friend WithEvents ChkAlmacen As CheckBox
    Friend WithEvents ChkVentas As CheckBox
    Friend WithEvents ChkUsuarios As CheckBox
    Friend WithEvents ChkControlTotal As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtCodPostal As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtPuerta As TextBox
    Friend WithEvents txtPiso As TextBox
    Friend WithEvents txtPortal As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtVia As TextBox
    Friend WithEvents txtIdFarmacia As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GrpDatosPersonales As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GrpPuesto As GroupBox
    Friend WithEvents GrpPermisos As GroupBox
    Friend WithEvents GrpDireccion As GroupBox
    Friend WithEvents SudSalario As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnNewUser As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtDNIBusqueda As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnModificar As Button
End Class
