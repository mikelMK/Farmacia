Public Class TipoVia
    Private iIdVia As Integer
    Private sDespcripcion As String

    Public Sub New(TipoVia As DataRow)
        Id = TipoVia(0)
        Despcripcion = TipoVia(1)
    End Sub

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
End Class
