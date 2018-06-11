Public Class Almacen
#Region "Variables"
    Private _Lote As String
    Private _Id_Producto As Integer
    Private _Id_Tienda As Integer
    Private _Cantidad As Integer
    Private _Fecha_Cad As DateTime
#End Region

#Region "Propiedades"
    Public Property Lote As String
        Get
            Return _Lote
        End Get
        Set(value As String)
            _Lote = value
        End Set
    End Property

    Public Property Id_Producto As Integer
        Get
            Return _Id_Producto
        End Get
        Set(value As Integer)
            _Id_Producto = value
        End Set
    End Property

    Public Property Id_Tienda As Integer
        Get
            Return _Id_Tienda
        End Get
        Set(value As Integer)
            _Id_Tienda = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property Fecha_Cad As Date
        Get
            Return _Fecha_Cad
        End Get
        Set(value As Date)
            _Fecha_Cad = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New(Row As DataRow)
        Me.Lote = Row(0)
        Me.Id_Producto = Row(1)
        Me.Id_Tienda = Row(2)
        Me.Cantidad = Row(3)
        Me.Fecha_Cad = Row(4)
    End Sub
#End Region

#Region "metodos"
    Public Function SqlInsert() As String
        Dim Query As String = "INSERT INTO Almacen(Lote,_Id_Producto,_Id_Tienda,_Cantidad,_Fecha_Cad) VALUES('"
        Query &= Me.Lote & "',"
        Query &= Me.Id_Producto & ",'"
        Query &= Me.Id_Tienda & "','"
        Query &= Me.Cantidad & "','"
        Query &= "str_to_date('" & Me.Fecha_Cad & "','%d/%m/%y'))"
        Return Query
    End Function

    Public Function SqlUpdate() As String
        Dim Query As String = "UPDATE Tienda SET"
        Query &= "Lote = '" & Me.Lote & "', "
        Query &= "Id_Producto = " & Me.Id_Producto & ", "
        Query &= "Id_Tienda ='" & Me.Id_Tienda & "',"
        Query &= "Cantidad ='" & Me.Cantidad & "',"
        Query &= "str_to_date('" & Me.Fecha_Cad & "','%d/%m/%y'))"
        Return Query
    End Function

    Public Function SqlDelete() As String
        Dim Query As String = "DELETE FROM Almacen WHERE Lote=" & Me.Lote & "and Id_Producto=" & Me.Id_Producto
        Return Query
    End Function
#End Region
End Class
