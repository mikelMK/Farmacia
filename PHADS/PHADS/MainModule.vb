Module MainModule

    Private MiLogIn As Login

    Public MiConexion As New Conexion("46.6.53.170", "Farma", "Farmacia", "325489@VBamraf", False)
    'Public MiConexion As New Conexion("192.168.1.55", "Farma", "Farmacia", "325489@VBamraf",False)
    Public MaceWindu As FmrMain

    Sub main()
        MiLogIn = New Login(MiConexion)
        MiLogIn.Show()
        Application.Run(MiLogIn)
    End Sub

End Module
