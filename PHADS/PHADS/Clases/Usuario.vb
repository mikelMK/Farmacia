Public Class Usuario
    Private sDNI As String
    Private sContraseña As String
    Private sNombre As String
    Private sApell_1 As String
    Private sApell_2 As String
    Private sEmail As String
    Private sFecha_Nac As String
    Private sFecha_Alta As String
    Private sPuesto As String
    Private bControl_Total As Boolean
    Private bVentas As Boolean
    Private bAlmacen As Boolean
    Private bCompras As Boolean
    Private bUsuarios As Boolean

    Public Sub New(Usuario As DataRow)
        sDNI = Usuario(0)
        sContraseña = Usuario(1)
        sNombre = Usuario(2)
        sApell_1 = Usuario(3)
        sApell_2 = Usuario(4)
        sEmail = Usuario(5)
        sFecha_Nac = Usuario(6)
        sFecha_Alta = Usuario(7)
        sPuesto = Usuario(8)
        If Usuario(21) = 1 Then
            bControl_Total = True
        Else
            bControl_Total = False
        End If
        If Usuario(22) = 1 Then
            bVentas = True
        Else
            bVentas = False
        End If
        If Usuario(23) = 1 Then
            bAlmacen = True
        Else
            bAlmacen = False
        End If
        If Usuario(24) = 1 Then
            bCompras = True
        Else
            bCompras = False
        End If
        If Usuario(25) = 1 Then
            bUsuarios = True
        Else
            bUsuarios = False
        End If
    End Sub


    Public ReadOnly Property DNI As String
        Get
            Return sDNI
        End Get
    End Property

    Public ReadOnly Property Contraseña As String
        Get
            Return sContraseña
        End Get
    End Property

    Public ReadOnly Property Nombre As String
        Get
            Return sNombre
        End Get
    End Property

    Public ReadOnly Property Apell_1 As String
        Get
            Return sApell_1
        End Get
    End Property

    Public ReadOnly Property Apell_2 As String
        Get
            Return sApell_2
        End Get
    End Property

    Public ReadOnly Property Email As String
        Get
            Return sEmail
        End Get
    End Property

    Public ReadOnly Property Fecha_Nac As String
        Get
            Return sFecha_Nac
        End Get
    End Property

    Public ReadOnly Property Fecha_Alta As String
        Get
            Return sFecha_Alta
        End Get
    End Property

    Public ReadOnly Property Puesto As String
        Get
            Return sPuesto
        End Get
    End Property

    Public ReadOnly Property Control_Total As Boolean
        Get
            Return bControl_Total
        End Get
    End Property

    Public ReadOnly Property Ventas As Boolean
        Get
            Return bVentas
        End Get
    End Property

    Public ReadOnly Property Almacen As Boolean
        Get
            Return bAlmacen
        End Get
    End Property

    Public ReadOnly Property Compras As Boolean
        Get
            Return bCompras
        End Get
    End Property

    Public ReadOnly Property Usuarios As Boolean
        Get
            Return bUsuarios
        End Get
    End Property
End Class
