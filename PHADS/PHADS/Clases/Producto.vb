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
#Region "Metodos"
    Public Function SqlInsert() As String
        Dim Query As String = "INSERT INTO Productos(Nombre,Proveedores,Coste)VALUES('"
        Query &= Me.Nombre & "',"
        Query &= Me.Proveedores & ","
        Query &= Me.Coste & ")"
        Return Query
    End Function

    Public Function SqlUpdate() As String
        Dim Query As String = "UPDATE Productos SET "
        Query &= "Nombre ='" & Me.Nombre & "',"
        Query &= "Proveedores = " & Me.Proveedores & ","
        Query &= "Coste =" & Me.Coste & ","
        Query &= "WHERE Id_Productos = " & Me.Id_Productos

        Return Query
    End Function

    Public Function SqlDelete() As String
        Dim Query As String = "DELETE FROM Productos WHERE Id_Productos = " & Me.Id_Productos
        Return Query
    End Function
#End Region
End Class
