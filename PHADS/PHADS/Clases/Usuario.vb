Public Class Usuario
#Region "Variables"
    Private sDNI As String
    Private sContraseña As String
    Private sNombre As String
    Private sApell_1 As String
    Private sApell_2 As String
    Private sEmail As String
    Private sFecha_Nac As DateTime
    Private sFecha_Alta As DateTime
    Private iFarmacia As Integer
    Private iPuesto As Integer
    Private iSalario As Integer
    Private iTipoVia As Integer
    Private iNombreVia As String
    Private sNoVia As String
    Private sNoPortal As String
    Private sPiso As String
    Private sPuerta As String
    Private sCodPostal As String
    Private sPais As String
    Private sProvinca As String
    Private sLocalidad As String
    Private bControl_Total As Boolean
    Private bVentas As Boolean
    Private bAlmacen As Boolean
    Private bCompras As Boolean
    Private bUsuarios As Boolean


#End Region

#Region "Constructores"
    ''' <summary>
    ''' Constructo Usuario Con DataRow de Select * from Usuarios
    ''' </summary>
    ''' <param name="Usuario">Datarow de usuario</param>
    Public Sub New(Usuario As DataRow)
        DNI = Usuario(0)
        Password = Usuario(1)
        Nombre = Usuario(2)
        Apell_1 = Usuario(3)
        Apell_2 = Usuario(4)
        Email = Usuario(5)
        If IsDBNull(Usuario(6)) Then
            Fecha_Nac = Nothing
        Else
            Fecha_Nac = Usuario(6)
        End If
        If IsDBNull(Usuario(7)) Then
            Fecha_Alta = Nothing
        Else
            Fecha_Alta = Usuario(7)
        End If
        Farmacia = Usuario(9)
        Puesto = Usuario(8)
        Salario = Usuario(10)
        TipoVia = Usuario(11)
        NombreVia = Usuario(12)
        NoVia = Usuario(13)
        NoPortal = Usuario(14)
        Piso = Usuario(15)
        Puerta = Usuario(16)
        CodPostal = Usuario(17)
        Pais = Usuario(18)
        Provinca = Usuario(19)
        Localidad = Usuario(20)
        If Usuario(21) = 1 Then
            Control_Total = True
        Else
            Control_Total = False
        End If
        If Usuario(22) = 1 Then
            Ventas = True
        Else
            Ventas = False
        End If
        If Usuario(23) = 1 Then
            Almacen = True
        Else
            Almacen = False
        End If
        If Usuario(24) = 1 Then
            Compras = True
        Else
            Compras = False
        End If
        If Usuario(25) = 1 Then
            Usuarios = True
        Else
            Usuarios = False
        End If
    End Sub
    ''' <summary>
    ''' Constructor Vacio
    ''' </summary>
    Public Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public Property DNI As String
        Get
            Return sDNI
        End Get
        Set(value As String)
            sDNI = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return sContraseña
        End Get
        Set(value As String)
            sContraseña = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return sNombre
        End Get
        Set(value As String)
            sNombre = value
        End Set
    End Property

    Public Property Apell_1 As String
        Get
            Return sApell_1
        End Get
        Set(value As String)
            sApell_1 = value
        End Set
    End Property

    Public Property Apell_2 As String
        Get
            Return sApell_2
        End Get
        Set(value As String)
            sApell_2 = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return sEmail
        End Get
        Set(value As String)
            sEmail = value
        End Set
    End Property

    Public Property Fecha_Nac As DateTime
        Get
            Return sFecha_Nac
        End Get
        Set(value As Date)
            sFecha_Nac = value
        End Set
    End Property

    Public Property Fecha_Alta As DateTime
        Get
            Return sFecha_Alta
        End Get
        Set(value As Date)
            sFecha_Alta = value
        End Set
    End Property

    Public Property Farmacia As Integer
        Get
            Return iFarmacia
        End Get
        Set(value As Integer)
            iFarmacia = value
        End Set
    End Property

    Public Property Puesto As Integer
        Get
            Return iPuesto
        End Get
        Set(value As Integer)
            iPuesto = value
        End Set
    End Property

    Public Property Salario As Integer
        Get
            Return iSalario
        End Get
        Set(value As Integer)
            iSalario = value
        End Set
    End Property

    Public Property TipoVia As Integer
        Get
            Return iTipoVia
        End Get
        Set(value As Integer)
            iTipoVia = value
        End Set
    End Property

    Public Property NombreVia As String
        Get
            Return iNombreVia
        End Get
        Set(value As String)
            iNombreVia = value
        End Set
    End Property

    Public Property NoVia As String
        Get
            Return sNoVia
        End Get
        Set(value As String)
            sNoVia = value
        End Set
    End Property

    Public Property NoPortal As String
        Get
            Return sNoPortal
        End Get
        Set(value As String)
            sNoPortal = value
        End Set
    End Property

    Public Property Piso As String
        Get
            Return sPiso
        End Get
        Set(value As String)
            sPiso = value
        End Set
    End Property

    Public Property Puerta As String
        Get
            Return sPuerta
        End Get
        Set(value As String)
            sPuerta = value
        End Set
    End Property

    Public Property CodPostal As String
        Get
            Return sCodPostal
        End Get
        Set(value As String)
            sCodPostal = value
        End Set
    End Property

    Public Property Pais As String
        Get
            Return sPais
        End Get
        Set(value As String)
            sPais = value
        End Set
    End Property

    Public Property Provinca As String
        Get
            Return sProvinca
        End Get
        Set(value As String)
            sProvinca = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return sLocalidad
        End Get
        Set(value As String)
            sLocalidad = value
        End Set
    End Property

    Public Property Control_Total As Boolean
        Get
            Return bControl_Total
        End Get
        Set(value As Boolean)
            bControl_Total = value
        End Set
    End Property

    Public Property Ventas As Boolean
        Get
            Return bVentas
        End Get
        Set(value As Boolean)
            bVentas = value
        End Set
    End Property

    Public Property Almacen As Boolean
        Get
            Return bAlmacen
        End Get
        Set(value As Boolean)
            bAlmacen = value
        End Set
    End Property

    Public Property Compras As Boolean
        Get
            Return bCompras
        End Get
        Set(value As Boolean)
            bCompras = value
        End Set
    End Property

    Public Property Usuarios As Boolean
        Get
            Return bUsuarios
        End Get
        Set(value As Boolean)
            bUsuarios = value
        End Set
    End Property
#End Region

End Class
