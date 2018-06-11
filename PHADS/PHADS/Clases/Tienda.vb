Public Class Tienda
#Region "Variables"
    Private _Id_Tiendas As Integer
    Private _Id_Gerente As String
    Private _Tipo_Via As Integer
    Private _Nombre_Via As String
    Private _No_Via As String
    Private _No_Ptal As String
    Private _Piso As String
    Private _Puerta As String
    Private _Cod_Postal As String
    Private _Provincia As String
    Private _Localidad As String
#End Region

#Region "Propiedades"
    Public Property Id_Tiendas As Integer
        Get
            Return _Id_Tiendas
        End Get
        Set(value As Integer)
            _Id_Tiendas = value
        End Set
    End Property

    Public Property Id_Gerente As String
        Get
            Return _Id_Gerente
        End Get
        Set(value As String)
            _Id_Gerente = value
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

    Public Property No_Ptal As String
        Get
            Return _No_Ptal
        End Get
        Set(value As String)
            _No_Ptal = value
        End Set
    End Property

    Public Property Piso As String
        Get
            Return _Piso
        End Get
        Set(value As String)
            _Piso = value
        End Set
    End Property

    Public Property Puerta As String
        Get
            Return _Puerta
        End Get
        Set(value As String)
            _Puerta = value
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
        Me.Id_Tiendas = Row(0)
        Me.Id_Gerente = Row(1)
        Me.Tipo_Via = Row(2)
        Me.Nombre_Via = Row(3)
        Me.No_Via = Row(4)
        Me.No_Ptal = Row(5)
        Me.Piso = Row(6)
        Me.Puerta = Row(7)
        Me.Cod_Postal = Row(8)
        Me.Provincia = Row(9)
        Me.Localidad = Row(10)
    End Sub
#End Region

#Region "metodos"
    Public Function SqlInsert() As String
        Dim Query As String = "INSERT INTO Tienda(Id_Gerente,Tipo_Via,Nombre_Via,No_Via,Piso,Puerta,Cod_Postal,Provincia,Localidad) VALUES('"
        Query &= Me.Id_Gerente & "',"
        Query &= Me.Tipo_Via & ",'"
        Query &= Me.Nombre_Via & "','"
        Query &= Me.No_Via & "','"
        Query &= Me.No_Ptal & "','"
        Query &= Me.Piso & "','"
        Query &= Me.Puerta & "','"
        Query &= Me.Cod_Postal & "','"
        Query &= Me.Provincia & "','"
        Query &= Me.Localidad & "')"
        Return Query
    End Function

    Public Function SqlUpdate() As String
        Dim Query As String = "UPDATE Tienda SET"
        Query &= "Id_Gerente = '" & Me.Id_Gerente & "', "
        Query &= "Tipo_Via = " & Me.Tipo_Via & ", "
        Query &= "Nombre_Via ='" & Me.Nombre_Via & "',"
        Query &= "No_Via ='" & Me.No_Via & "',"
        Query &= "No_Ptal ='" & Me.No_Ptal & "',"
        Query &= "Piso ='" & Me.Piso & "',"
        Query &= "Puerta ='" & Me.Puerta & "',"
        Query &= "Cod_Postal ='" & Me.Cod_Postal & "',"
        Query &= "Provincia = '" & Me.Provincia & "',"
        Query &= "Localidad = '" & Me.Localidad & "'"
        Query &= "WHERE Id_Tiendas =" & Me.Id_Tiendas
    End Function

    Public Function SqlDelete() As String
        Dim Query As String = "DELETE FROM Tienda WHERE Id_tiendas=" & Me.Id_Tiendas
        Return Query
    End Function
#End Region
End Class
