Imports PHADS.Conexion

Public Class GestionAlta
    Private MiConexion As Conexion
    Private TipoPuesto As DataTable
    Private TipoVia As DataTable

    Public Sub New(pConecxion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        MiConexion = pConecxion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CrearUsuario.Click
        Dim DNI As String = txtDni.Text
        Dim Contraseña As String = txtContraseña.Text
        Dim Nombre As String = txtNombre.Text
        Dim Apellido1 As String = txtApellido1.Text
        Dim Apellido2 As String = txtApellido2.Text
        Dim Email As String = txtEmail.Text
        Dim FechaNacimiento As Date = DateTimePicker1.Text
        Dim IdFarmacia As String = txtIdFarmacia.Text
        Dim Puesto As String = ComboBox1.SelectedItem
        Dim FechaAlta As Date = DateTimePicker1.Text
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


        Dim query As String =
             "INSERT INTO Empleados VALUES ('" & DNI & "','" & Contraseña & "','" & Nombre & "','" & Apellido1 & "','" & Apellido2 & "','" & Email & "'," & FechaNacimiento.ToShortDateString & "," & FechaAlta.ToShortDateString & "," & IdFarmacia & ",'" & Puesto & "','0','" & TipoVia & "','" & Via & "'," & Numero & "," & Portal & ",'" & Piso & "','" & Puerta & "'," & CodPostal & ",'" & Pais & "','" & Provincia & "','" & Localidad & "'," & ControlTotal & "," & Ventas & "," & Almacen & "," & Compras & "," & Usuarios & ")"
        If MiConexion.Insetrar(query) Then
            MessageBox.Show("Usuario introducido correctamente")
            LimpiarCampos()
        Else
            MessageBox.Show("Error durante el alta")
        End If



    End Sub

    Private Sub GestionAlta_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Altas de usuario"
        Me.Top = (Screen.PrimaryScreen.Bounds.Height) / 2 - (Me.Height / 2)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width) / 2 - (Me.Width / 2)

        TipoPuesto = MiConexion.Consultar("Select * from Tipo_Puesto")
        For Each oDataRow As DataRow In TipoPuesto.Rows
            ComboBox1.Items.Add(oDataRow(1).ToString)

        Next

        TipoVia = MiConexion.Consultar("Select * from Tipo_Via")
        For Each oDataRow As DataRow In TipoVia.Rows
            ComboBoxTipoVia.Items.Add(oDataRow(1).ToString)
        Next



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        For Each oDataRow As DataRow In TipoPuesto.Rows

            If oDataRow(1).ToString.Equals(ComboBox1.SelectedItem.ToString) Then
                ChkControlTotal.Checked = oDataRow(2)
                ChkVentas.Checked = oDataRow(3)
                ChkAlmacen.Checked = oDataRow(4)
                ChkCompras.Checked = oDataRow(5)
                ChkUsuarios.Checked = oDataRow(6)
            End If

        Next
    End Sub

    Public Function LimpiarCampos()
        txtDni.Text = ""
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
    End Function

End Class