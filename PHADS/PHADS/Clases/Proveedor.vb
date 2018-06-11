Public Class Proveedor
#Region "Variables"
    Private _Id_Proveedor As Integer
    Private _Nombre As String
    Private _Tipo_Via As Integer
    Private _Nombre_Via As String
    Private _No_Via As String
    Private _Cod_Postal As String
    Private _Provincia As String
    Private _Localidad As String
#End Region
#Region "Propiedades"
    Public Property Id_Proveedor As Integer
        Get
            Return _Id_Proveedor
        End Get
        Set(value As Integer)
            _Id_Proveedor = value
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
    Public Property Tipo_Via As Integer
        Get
            Return _Tipo_Via
        End Get
        Set(value As Integer)
            _Tipo_Via = value
        End Set
    End Property
    Public Property Nombre_Via As String
        Get
            Return _Nombre_Via
        End Get
        Set(value As String)
            _Nombre_Via = value
        End Set
    End Property
    Public Property No_Via As String
        Get
            Return _No_Via
        End Get
        Set(value As String)
            _No_Via = value
        End Set
    End Property
    Public Property Cod_Postal As String
        Get
            Return _Cod_Postal
        End Get
        Set(value As String)
            _Cod_Postal = value
        End Set
    End Property
    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property
    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property
#End Region
#Region "Constructores"
    Public Sub New(Row As DataRow)
        Me.Id_Proveedor = Row(0)
        Me.Nombre = Row(1)
        Me.Tipo_Via = Row(2)
        Me.Nombre_Via = Row(3)
        Me.No_Via = Row(4)
        Me.Cod_Postal = Row(5)
        Me.Provincia = Row(6)
        Me.Localidad = Row(7)
    End Sub

#End Region
#Region "Metodos"
    Public Function SqlInsert() As String
        Dim Query As String = "INSERT INTO Proveedores(Nombre,Tipo_Via,Nombre_Via,No_Via,Cod_Postal,Provincia,Localidad) VALUES('"
        Query += Me.Nombre + "',"
        Query += Me.Tipo_Via + ",'"
        Query += Me.Nombre_Via + "','"
        Query += Me.No_Via + "','"
        Query += Me.Cod_Postal + "','"
        Query += Me.Provincia + "','"
        Query += Me.Localidad + "')"
        Return Query
    End Function
    Public Function SqlUpdate() As String
        Dim Query As String = "UPDATE Proveedores SET"
        Query += "Nombre = '" + Me.Nombre + "', "
        Query += "Tipo_Via = " + Me.Tipo_Via + ", "
        Query += "Nombre_Via ='" + Me._Nombre_Via + "',"
        Query += "No_Via ='" + Me._No_Via + "',"
        Query += "Cod_Postal ='" + Me.Cod_Postal + "',"
        Query += "Provincia = '" + Me.Provincia + "',"
        Query += "Localidad = '" + Me.Localidad + "'"
        Query += "WHERE Id_Proveedore =" + Me.Id_Proveedor
        Return Query
    End Function
    Public Function SqlDelete() As String
        Dim Query As String = "DELETE FROM Proveedores WHERE Id_Proveedore=" + Me.Id_Proveedor
        Return Query
    End Function
#End Region


End Class
