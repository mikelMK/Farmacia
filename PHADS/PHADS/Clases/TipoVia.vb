Public Class TipoVia
    Private iIdVia As Integer
    Private sDespcripcion As String
#Region "Constructores"
    ''' <summary>
    ''' Constructo Usuario Con DataRow de Select * from Tipo_Via
    ''' </summary>
    ''' <param name="TipoVia">Datarow de Tipo_Via</param>
    Public Sub New(TipoVia As DataRow)
        Id = TipoVia(0)
        Despcripcion = TipoVia(1)
    End Sub
    ''' <summary>
    ''' Constructor Vacio
    ''' </summary>
    Public Sub New()

    End Sub
#End Region
#Region "Propiedades"
    Public Property Id As Integer
        Get
            Return iIdVia
        End Get
        Set(value As Integer)
            iIdVia = value
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
#End Region
#Region "Metodos"
    ''' <summary>
    ''' Retorna la SQl para el Insert.
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlInsert()
        Dim Query As String = "Insert Into Tipo_Via(Id_Via,Desc_Via)Values("
        Query = Query & Me.Id & ",'"
        Query = Query & Me.Despcripcion & "')"
        Return Query
    End Function
    ''' <summary>
    ''' Retorna la SQl para el Update.
    ''' NOTA El DNI no se puede actualizar
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlUpdate()
        Dim Query As String = "Update Tipo_Via Set "
        Query = Query & "Id_Via=" & Me.Id
        Query = Query & ",Desc_Via='" & Me.Despcripcion & "'"

        Return Query
    End Function
    ''' <summary>
    ''' Retorna la SQl para el Delete.
    ''' </summary>
    ''' <returns></returns>
    Public Function SqlDelete()
        Dim Query As String = "Delete From Tipo_Via where id_Via='" & Me.Id & "'"
        Return Query
    End Function
#End Region

End Class
