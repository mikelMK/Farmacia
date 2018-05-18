Imports PHADS.Conexion

Public Class GestionModificacion
    Private MiConexion As Conexion
    Private UsuarioModificar As DataTable
    Private TipoPuesto As DataTable
    Private TipoVia As DataTable

    Public Sub New(pConecxion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConecxion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        UsuarioModificar = MiConexion.Consultar("Select * from Empleados where DNI='" & txtBuscar.Text & "'")
        Me.Size = New Size(705, 682)
        btnModificar.Visible = True
        Me.Top = (Screen.PrimaryScreen.Bounds.Height) / 2 - (Me.Height / 2)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width) / 2 - (Me.Width / 2)

        For Each oDataRow As DataRow In UsuarioModificar.Rows
            'DATOS PERSONALES
            txtDNI.Text = (oDataRow(0).ToString)
            txtContraseña.Text = (oDataRow(1).ToString)
            txtNombre.Text = (oDataRow(2).ToString)
            txtApellido1.Text = (oDataRow(3).ToString)
            txtApellido2.Text = (oDataRow(4).ToString)
            txtEmail.Text = (oDataRow(5).ToString)
            DateTimePicker1.Text = (oDataRow(6).ToString)
            DateTimePicker2.Text = (oDataRow(7).ToString)
            txtIdFarmacia.Text = (oDataRow(8).ToString)
            ComboBox1.Text = (oDataRow(9).ToString) 'HACER QUE SE MUESTRE LA DESCRIPCION DEL PUESTO
            '(oDataRow(10).ToString) ES EL SALARIO

            'TIPO DE VIA
            ComboBoxTipoVia.Text = (oDataRow(11).ToString) 'HACER QUE SE MUESTRE EL TIPO DE VIA
            txtVia.Text = (oDataRow(12).ToString)
            txtNumero.Text = (oDataRow(13).ToString)
            txtPortal.Text = (oDataRow(14).ToString)
            txtPiso.Text = (oDataRow(15).ToString)
            txtPuerta.Text = (oDataRow(16).ToString)
            txtCodPostal.Text = (oDataRow(17).ToString)
            txtPais.Text = (oDataRow(18).ToString)
            txtProvincia.Text = (oDataRow(19).ToString)
            txtLocalidad.Text = (oDataRow(20).ToString)

            'PERMISOS

            ChkControlTotal.Checked = (oDataRow(21).ToString)
            ChkVentas.Checked = (oDataRow(21).ToString)
            ChkAlmacen.Checked = (oDataRow(22).ToString)
            ChkCompras.Checked = (oDataRow(23).ToString)
            ChkUsuarios.Checked = (oDataRow(24).ToString)
        Next

        TipoPuesto = MiConexion.Consultar("Select * from Tipo_Puesto where Id_Puesto=" & ComboBox1.Text & "")
        For Each oDataRow As DataRow In TipoPuesto.Rows
            ComboBox1.Text = (oDataRow(1).ToString)
        Next

        TipoVia = MiConexion.Consultar("Select * from Tipo_Via where Id_Via=" & ComboBoxTipoVia.Text & "")
        For Each oDataRow As DataRow In TipoVia.Rows
            ComboBoxTipoVia.Text = (oDataRow(1).ToString)
        Next


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim DNI As String = txtBuscar.Text
        Dim Contraseña As String = txtContraseña.Text
        Dim Nombre As String = txtNombre.Text
        Dim Apellido1 As String = txtApellido1.Text
        Dim Apellido2 As String = txtApellido2.Text
        Dim Email As String = txtEmail.Text
        Dim FechaNacimiento As Date = DateTimePicker1.Text
        Dim IdFarmacia As String = txtIdFarmacia.Text
        Dim Puesto As String = ComboBox1.SelectedItem
        Dim FechaAlta As Date = DateTimePicker2.Text
        Dim Via As String = txtVia.Text
        Dim Numero As String = txtNumero.Text
        Dim Portal As String = txtPortal.Text
        Dim Piso As String = txtPiso.Text
        Dim Puerta As String = txtPuerta.Text
        Dim Provincia As String = txtProvincia.Text
        Dim Localidad As String = txtLocalidad.Text
        Dim CodPostal As String = txtCodPostal.Text
        Dim Pais As String = txtPais.Text
        Dim TipoVia As String = ComboBoxTipoVia.SelectedItem
        Dim ControlTotal, Ventas, Almacen, Compras, Usuarios As Integer

        If ChkControlTotal.Checked Then
            ControlTotal = 1
        Else
            ControlTotal = 0
        End If

        If ChkVentas.Checked Then
            Ventas = 1
        Else
            Ventas = 0
        End If

        If ChkAlmacen.Checked Then
            Almacen = 1
        Else
            Almacen = 0
        End If

        If ChkCompras.Checked Then
            Compras = 1
        Else
            Compras = 0
        End If

        If ChkUsuarios.Checked Then
            Usuarios = 1
        Else
            Usuarios = 0
        End If

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"

        Dim query As String =
"UPDATE Empleados SET DNI='" & DNI & "',Contrasena='" & Contraseña & "',Nombre='" & Nombre & "'
        ,Apell_1='" & Apellido1 & "'
        ,Apell_2='" & Apellido2 & "'
        ,Email='" & Email & "'
        ,Fecha_Nac='" & FechaNacimiento & "'
        ,Fecha_Alta='" & FechaAlta & "'
        ,Id_Farmacia='" & IdFarmacia & "'
        ,Puesto='" & Puesto & "'
        ,Salario='0'
        ,Tipo_Via='" & TipoVia & "'
        ,Nombre_Via='" & Via & "'
        ,No_Via='" & Numero & "'
        ,No_Ptal='" & Portal & "'
        ,Piso='" & Piso & "'
        ,Puerta='" & Puerta & "'
        ,Cod_Postal='" & CodPostal & "'
        ,Pais='" & Pais & "'
        ,Provincia='" & Provincia & "'
        ,Localidad='" & Localidad & "'
        ,ControlTotal='" & ControlTotal & "'
        ,Ventas='" & Ventas & "'
        ,Almacen='" & Almacen & "'
        ,Compras='" & Compras & "'
        ,Usuarios='" & Usuarios & "' WHERE DNI='" & DNI & "'"

        If MiConexion.Update(query) Then
            MessageBox.Show("Usuario Modificado Con Exito")
        Else
            MessageBox.Show("Error Durante La Modificacion")
        End If


        LimpiarCampos()

    End Sub

    Private Sub GestionModificacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Modificación de usuario"
        Me.Top = (Screen.PrimaryScreen.Bounds.Height) / 2 - (Me.Height / 2)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width) / 2 - (Me.Width / 2)
        btnModificar.Visible = False

        TipoPuesto = MiConexion.Consultar("Select * from Tipo_Puesto")
        For Each oDataRow As DataRow In TipoPuesto.Rows
            ComboBox1.Text = (oDataRow(1).ToString)
        Next

        TipoVia = MiConexion.Consultar("Select * from Tipo_Via")
        For Each oDataRow As DataRow In TipoVia.Rows
            ComboBoxTipoVia.Text = (oDataRow(1).ToString)
        Next

    End Sub

    Public Sub LimpiarCampos()
        txtBuscar.Text = ""
        txtDNI.Text = ""
        txtContraseña.Text = ""
        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        txtEmail.Text = ""
        DateTimePicker1.Text = ""
        txtIdFarmacia.Text = ""
        ComboBox1.Text = ""
        DateTimePicker2.Text = ""
        txtVia.Text = ""
        txtNumero.Text = ""
        txtPortal.Text = ""
        txtPiso.Text = ""
        txtPuerta.Text = ""
        txtProvincia.Text = ""
        txtLocalidad.Text = ""
        txtCodPostal.Text = ""
        txtPais.Text = ""
        ComboBoxTipoVia.Text = ""
        ChkControlTotal.Checked = False
        ChkAlmacen.Checked = False
        ChkCompras.Checked = False
        ChkUsuarios.Checked = False
        ChkVentas.Checked = False
    End Sub

End Class