Module MainModule

    Private MiFmrMain As FmrMain
    Public MiConexion As New Conexion("46.6.39.124", "Farma", "Farmacia", "325489@VBamraf", False)
    'Public MiConexion As New Conexion("192.168.1.55", "Farma", "Farmacia", "325489@VBamraf",False)

    Sub main()
        MiFmrMain = New FmrMain(MiConexion)
        MiFmrMain.Show()
        Application.Run(MiFmrMain)
    End Sub
End Module
