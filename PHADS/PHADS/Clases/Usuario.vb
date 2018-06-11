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
    ''' Constructo Usuario Con DataRow de Select * from Empleados
    ''' </summary>
    ''' <param name="Usuario">Datarow de Empleados</param>
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
        Farmacia = Usuario(8)
        Puesto = Usuario(9)
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
            ControlTotal = True
        Else
            ControlTotal = False
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

    Public Property ControlTotal As Boolean
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

#Region "Metodos"
    ''' <summary>
    ''' Retorna la SQl para el Insert.
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlInsert()
        Dim Query As String = "Insert Into Empleados("
        Query = Query & "DNI,Contrasena,Nombre,Apell_1,Apell_2,Email,Fecha_Nac,Fecha_Alta,"
        Query = Query & "Id_Farmacia,Puesto,Salario,"
        Query = Query & "Tipo_Via,Nombre_Via,No_Via,No_Ptal,Piso,Puerta,Cod_Postal,Pais,Provincia,Localidad,"
        Query = Query & "ControlTotal,Ventas,Almacen,Compras,Usuarios) Values("
        Query = Query & "'" & Me.DNI & "',"
        Query = Query & "'" & Me.Password & "',"
        Query = Query & "'" & Me.Nombre & "',"
        Query = Query & "'" & Me.Apell_1 & "',"
        Query = Query & "'" & Me.Apell_2 & "',"
        Query = Query & "'" & Me.Email & "',"
        Query = Query & "str_to_date('" & Me.Fecha_Nac & "','%d/%m/%y'),"
        Query = Query & "str_to_date('" & Me.Fecha_Alta & "','%d/%m/%y'),"
        Query = Query & Me.Farmacia & ","
        Query = Query & Me.Puesto & ","
        Query = Query & Me.Salario & ","
        Query = Query & Me.TipoVia & ","
        Query = Query & "'" & Me.NombreVia & "',"
        Query = Query & "'" & Me.NoVia & "',"
        Query = Query & "'" & Me.NoPortal & "',"
        Query = Query & "'" & Me.Piso & "',"
        Query = Query & "'" & Me.Puerta & "',"
        Query = Query & "'" & Me.CodPostal & "',"
        Query = Query & "'" & Me.Pais & "',"
        Query = Query & "'" & Me.Provinca & "',"
        Query = Query & "'" & Me.Localidad & "',"

        If Me.ControlTotal Then
            Query = Query & "1" & ","
        Else
            Query = Query & "0" & ","
        End If
        If Me.Ventas Then
            Query = Query & "1" & ","
        Else
            Query = Query & "0" & ","
        End If
        If Me.Almacen Then
            Query = Query & "1" & ","
        Else
            Query = Query & "0" & ","
        End If
        If Me.Compras Then
            Query = Query & "1" & ","
        Else
            Query = Query & "0" & ","
        End If
        If Me.Usuarios Then
            Query = Query & "1"
        Else
            Query = Query & "0"
        End If

        Query = Query & ")"

        Return Query
    End Function
    ''' <summary>
    ''' Retorna la SQl para el Update.
    ''' NOTA El DNI no se puede actualizar
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlUpdate()
        Dim Query As String = "Update Empleados Set "
        Query = Query & "Contrasena='" & Me.Password & "',"
        Query = Query & "Nombre='" & Me.Nombre & "',"
        Query = Query & "Apell_1='" & Me.Apell_1 & "',"
        Query = Query & "Apell_2='" & Me.Apell_2 & "',"
        Query = Query & "Email='" & Me.Email & "',"
        Query = Query & "Fecha_Nac=str_to_date('" & Me.Fecha_Nac & "','%d/%m/%y'),"
        Query = Query & "Fecha_Alta=str_to_date('" & Me.Fecha_Alta & "','%d/%m/%y'),"
        Query = Query & "Id_Farmacia=" & Me.Farmacia & ","
        Query = Query & "Puesto=" & Me.Puesto & ","
        Query = Query & "Salario=" & Me.Salario & ","
        Query = Query & "Tipo_Via=" & Me.TipoVia & ","
        Query = Query & "Nombre_Via='" & Me.NombreVia & "',"
        Query = Query & "No_Via='" & Me.NoVia & "',"
        Query = Query & "No_Ptal='" & Me.NoPortal & "',"
        Query = Query & "Piso='" & Me.Piso & "',"
        Query = Query & "Puerta='" & Me.Puerta & "',"
        Query = Query & "Cod_Postal='" & Me.CodPostal & "',"
        Query = Query & "Pais='" & Me.Pais & "',"
        Query = Query & "Provincia='" & Me.Provinca & "',"
        Query = Query & "Localidad='" & Me.Localidad & "',"

        If Me.ControlTotal Then
            Query = Query & "ControlTotal=1,"
        Else
            Query = Query & "ControlTotal=0,"
        End If
        If Me.Ventas Then
            Query = Query & "ControlTotal=1,"
        Else
            Query = Query & "ControlTotal=0,"
        End If
        If Me.Almacen Then
            Query = Query & "ControlTotal=1,"
        Else
            Query = Query & "ControlTotal=0,"
        End If
        If Me.Compras Then
            Query = Query & "ControlTotal=1,"
        Else
            Query = Query & "ControlTotal=0,"
        End If
        If Me.Usuarios Then
            Query = Query & "ControlTotal=1"
        Else
            Query = Query & "ControlTotal=0"
        End If

        Query = Query & " Where DNI='" & Me.DNI & "'"
        Return Query
    End Function
    ''' <summary>
    ''' Retorna la SQl para el Delete.
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlDelete()
        Dim Query As String = "Delete From Empleados where DNI='" & Me.DNI & "'"
        Return Query
    End Function
#End Region
End Class
