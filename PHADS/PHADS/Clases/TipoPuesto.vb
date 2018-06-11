Public Class TipoPuesto
    Private iIdPuesto As Integer
    Private sDespcripcion As String
    Private bControlTotal As Boolean
    Private bVentas As Boolean
    Private bAlmacen As Boolean
    Private bCompras As Boolean
    Private bUsuarios As Boolean


#Region "Constructores"
    ''' <summary>
    ''' Constructo Usuario Con DataRow de Select * from Tipo_Puesto
    ''' </summary>
    ''' <param name="pTipoPuesto">Datarow de Tipo_Puesto</param>
    Public Sub New(pTipoPuesto As DataRow)
        Me.IdPuesto = pTipoPuesto(0)
        Me.Despcripcion = pTipoPuesto(1)
        If pTipoPuesto(2) = 1 Then
            Me.ControlTotal = True
        Else
            Me.ControlTotal = False
        End If
        If pTipoPuesto(3) = 1 Then
            Me.Ventas = True
        Else
            Me.Ventas = False
        End If
        If pTipoPuesto(4) = 1 Then
            Me.Almacen = True
        Else
            Me.Almacen = False
        End If
        If pTipoPuesto(5) = 1 Then
            Me.Compras = True
        Else
            Me.Compras = False
        End If
        If pTipoPuesto(6) = 1 Then
            Me.Usuarios = True
        Else
            Me.Usuarios = False
        End If
    End Sub

    ''' <summary>
    ''' Constructor Vacio
    ''' </summary>
    Public Sub New()

    End Sub
#End Region
#Region "Propiedades"
    Public Property IdPuesto As Integer
        Get
            Return iIdPuesto
        End Get
        Set(value As Integer)
            iIdPuesto = value
        End Set
    End Property

    Public Property Despcripcion As String
        Get
            Return sDespcripcion
        End Get
        Set(value As String)
            sDespcripcion = value
        End Set
    End Property

    Public Property ControlTotal As Boolean
        Get
            Return bControlTotal
        End Get
        Set(value As Boolean)
            bControlTotal = value
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
        Dim Query As String = "Insert Into Tipo_Puesto(Id_Puesto,Desc_Puesto,ControlTotal,Ventas,Almacen,Compras,Usuarios)Values("
        Query = Query & Me.IdPuesto & ",'"
        Query = Query & Me.Despcripcion & "','"

        If Me.ControlTotal Then
            Query = Query & "1,"
        Else
            Query = Query & "0,"
        End If

        If Me.Ventas Then
            Query = Query & "1,"
        Else
            Query = Query & "0,"
        End If

        If Me.Almacen Then
            Query = Query & "1,"
        Else
            Query = Query & "0,"
        End If

        If Me.Compras Then
            Query = Query & "1,"
        Else
            Query = Query & "0,"
        End If

        If Me.Usuarios Then
            Query = Query & "1)"
        Else
            Query = Query & "0)"
        End If

        Return Query
    End Function
    ''' <summary>
    ''' Retorna la SQl para el Update.
    ''' NOTA El DNI no se puede actualizar
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlUpdate()
        Dim Query As String = "Update Tipo_Puesto Set "
        Query = Query & "Id_Puesto=" & Me.IdPuesto
        Query = Query & ", Desc_Puesto='" & Me.Despcripcion & "',"
        If Me.ControlTotal Then
            Query = Query & "ControlTotal=1,"
        Else
            Query = Query & "ControlTotal=0,"
        End If

        If Me.Ventas Then
            Query = Query & "Ventas=1,"
        Else
            Query = Query & "Ventas=0,"
        End If

        If Me.Almacen Then
            Query = Query & "Almacen=1,"
        Else
            Query = Query & "Almacen=0,"
        End If

        If Me.Ventas Then
            Query = Query & "Compras=1,"
        Else
            Query = Query & "Compras=0,"
        End If

        If Me.Usuarios Then
            Query = Query & "Usuarios=1)"
        Else
            Query = Query & "Usuarios=0)"
        End If



        Return Query
    End Function
    ''' <summary>
    ''' Retorna la SQl para el Delete.
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlDelete()
        Dim Query As String = "Delete From Tipo_Puesto where Id_Puesto='" & Me.IdPuesto & "'"
        Return Query
    End Function
#End Region
End Class
