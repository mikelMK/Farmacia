Public Class Producto
#Region "Varibles"

    Private _Id_Productos As Integer
    Private _Nombre As String
    Private _Proveedores As Integer
    Private _Coste As Integer
#End Region
#Region "Propiedades"
    Public Property Id_Productos As Integer
        Get
            Return _Id_Productos
        End Get
        Set(value As Integer)
            _Id_Productos = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Proveedores As Integer
        Get
            Return _Proveedores
        End Get
        Set(value As Integer)
            _Proveedores = value
        End Set
    End Property

    Public Property Coste As Integer
        Get
            Return _Coste
        End Get
        Set(value As Integer)
            _Coste = value
        End Set
    End Property
#End Region
#Region "Costructores"
    Private Sub New(Row As DataRow)
        Me.Id_Productos = Row(0)
        Me.Nombre = Row(1)
        Me.Proveedores = Row(2)
        Me.Coste = Row(3)
    End Sub
    Private Sub New()

    End Sub
#End Region
End Class
