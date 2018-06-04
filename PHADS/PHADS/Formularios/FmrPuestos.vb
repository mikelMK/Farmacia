Imports PHADS.Conexion
Imports PHADS.TipoPuesto
Public Class FmrPuestos
    Dim miConecxion As Conexion
    Dim ListaPuestos As List(Of TipoPuesto)
    Dim PuestoSelected As TipoPuesto
    Dim Estado As Integer
    Public Sub New(pConexion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        miConecxion = pConexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub CargarDatos()
        Dim Datos As DataTable = miConecxion.Consultar("Select * from Tipo_Puesto")
        For Each row As DataRow In Datos.Rows
            ListaPuestos.Add(New TipoPuesto(row))
        Next
    End Sub

    Private Sub Vincular()
        LstRoles.DataSource = ListaPuestos
        LstRoles.DisplayMember = "Despcripcion"
    End Sub

    Private Sub LstRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstRoles.SelectedIndexChanged
        PuestoSelected = LstRoles.SelectedItem
    End Sub

    Private Sub Estado_Consulta()
        Estado = 0
        ChkAlmacen.Enabled = False
        ChkCompras.Enabled = False
        ChkControlTotal.Enabled = False
        ChkUsuarios.Enabled = False
        ChkVentas.Enabled = False
        TxtNombre.Enabled = False
        BtnAceptar.Enabled = False
        BtnCancelar.Enabled = False
        BtnEliminar.Enabled = True
        BtnModificar.Enabled = True
        BtnNuevo.Enabled = True

    End Sub

    Private Sub Estado_Insert()
        Estado = 1
        ChkAlmacen.Enabled = True
        ChkCompras.Enabled = True
        ChkControlTotal.Enabled = True
        ChkUsuarios.Enabled = True
        ChkVentas.Enabled = True
        TxtNombre.Enabled = True
        BtnAceptar.Enabled = True
        BtnCancelar.Enabled = True
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnNuevo.Enabled = False
    End Sub

    Private Sub Estado_Modificacion()
        Estado = 2
        ChkAlmacen.Enabled = True
        ChkCompras.Enabled = True
        ChkControlTotal.Enabled = True
        ChkUsuarios.Enabled = True
        ChkVentas.Enabled = True
        TxtNombre.Enabled = True
        BtnAceptar.Enabled = True
        BtnCancelar.Enabled = True
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnNuevo.Enabled = False
    End Sub

    Private Sub Cargar()
        TxtNombre.Text = PuestoSelected.Despcripcion
        ChkAlmacen.Checked = PuestoSelected.Almacen
        ChkCompras.Checked = PuestoSelected.Compras
        ChkControlTotal.Checked = PuestoSelected.ControlTotal
        ChkUsuarios.Checked = PuestoSelected.Usuarios
        ChkVentas.Checked = PuestoSelected.Ventas
    End Sub
    Private Sub Descargar()
        PuestoSelected.Despcripcion = TxtNombre.Text
        PuestoSelected.Almacen = ChkAlmacen.Checked
        PuestoSelected.Compras = ChkCompras.Checked
        PuestoSelected.ControlTotal = ChkControlTotal.Checked
        PuestoSelected.Usuarios = ChkUsuarios.Checked
        PuestoSelected.Ventas = ChkUsuarios.Checked
    End Sub

End Class