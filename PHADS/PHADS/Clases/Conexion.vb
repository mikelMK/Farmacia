Imports MySql.Data.MySqlClient
Public Class Conexion
    Private StrinConxSelect As String
    Private StrinConxInsUpd As String
    Private StrinConx As String
    Private oConexion As MySqlConnection
    Private oDataAdapter As MySqlDataAdapter
    Private _Server As String
    Private _User As String
    Private _DataBase As String
    Private _Password As String

    Public Sub New(Server As String, User As String, Database As String, Password As String, Comprobar As Boolean)
        _Server = Server
        _User = User
        _DataBase = Database
        _Password = Password
        StrinConxSelect = "server=" & Server & "; user=" & User & "; database=" & Database & "; password=" & Password & "; Convert Zero Datetime=True"
        StrinConxInsUpd = "server=" & Server & "; user=" & User & "; database=" & Database & "; password=" & Password & ";Convert Zero Datetime=True; Allow Zero Datetime=True"
        StrinConx = "server=" & Server & "; user=" & User & "; database=" & Database & "; password=" & Password & ";"
        'MessageBox.Show(StrinConx)
        'MessageBox.Show(StrinConxInsUpd)
        'MessageBox.Show(StrinConxSelect)
        If Comprobar Then
            Me.Pruebaconexion(Comprobar)
        End If
    End Sub
    Public Function Consultar(SSQL As String) As DataTable 'Insetas una Sql y retorna un DataTable
        oConexion = New MySqlConnection(StrinConxSelect)
        oDataAdapter = New MySqlDataAdapter()
        Dim oDataTable As New DataTable
        Try
            oConexion.Open()
            Dim comand As New MySqlCommand(SSQL, oConexion)
            oDataAdapter.SelectCommand = comand
            oDataAdapter.Fill(oDataTable)
            oConexion.Close()
            oDataAdapter = Nothing
            oConexion = Nothing
            Return (oDataTable)
        Catch ex As Exception
            oConexion.Close()
            oDataAdapter = Nothing
            oConexion = Nothing
            Return (Nothing)
        End Try
    End Function
    Public Function Insetrar(SSQL As String) As Boolean 'Insetas una Sql y Inserta una fila
        oConexion = New MySqlConnection(StrinConx)
        Try
            oConexion.Open()
            Dim Commando As New MySqlCommand(SSQL, oConexion)
            Commando.ExecuteNonQuery()
            oConexion.Close()
            oConexion = Nothing
            Return (True)
        Catch ex As Exception
            oConexion.Close()
            oConexion = Nothing
            Return (False)
        End Try
    End Function
    Public Function Update(SSQL As String) As Boolean 'Insetas una Sql y hace update de una Fila
        oConexion = New MySqlConnection(StrinConx)
        Try
            oConexion.Open()
            Dim Commando As New MySqlCommand(SSQL, oConexion)
            Commando.ExecuteNonQuery()
            oConexion.Close()
            oConexion = Nothing
            Return (True)
        Catch ex As Exception
            oConexion.Close()
            oConexion = Nothing
            Return (False)
        End Try
    End Function
    Public Function Delete(SSQL As String) As Boolean 'Insetas una Sql y hace Borra una fila
        oConexion = New MySqlConnection(StrinConx)
        Try
            Dim Commando As New MySqlCommand(SSQL, oConexion)
            oConexion.Open()
            Commando.ExecuteNonQuery()
            oConexion.Close()
            oConexion = Nothing
            Return (True)
        Catch ex As Exception
            oConexion.Close()
            oConexion = Nothing
            Return (False)
        End Try
    End Function
    Public Function Pruebaconexion(Mensaje As Boolean) As Boolean 'Insetas una Sql y hace Borra una fila
        oConexion = New MySqlConnection(StrinConxSelect)
        oDataAdapter = New MySqlDataAdapter()
        Dim oDataTable As New DataTable
        Try
            oConexion.Open()
            Dim comand As New MySqlCommand("Descrive", oConexion)
            oDataAdapter.SelectCommand = comand
            oDataAdapter.Fill(oDataTable)
            oConexion.Close()
            oDataAdapter = Nothing
            oConexion = Nothing
            If Mensaje Then
                MessageBox.Show("Conexion Correcta", "Aviso")
            End If
            Return (True)
        Catch ex As Exception
            oConexion.Close()
            oDataAdapter = Nothing
            oConexion = Nothing
            If Mensaje Then
                MessageBox.Show("Error de Conxion con:" & _Server & "/" & _DataBase, "Error")
            End If
            Return (False)
        End Try
    End Function
End Class
