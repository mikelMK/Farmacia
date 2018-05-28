Imports PHADS.Conexion
Public Class FmrConsultas
    Private MiConexion As Conexion
    Private Campos As DataTable
    Private TablaDGW As DataTable

    Public Sub New(pConexion As Conexion)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MiConexion = pConexion
    End Sub
    'Load Añade Lista tablas
    Private Sub FmrConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height) / 2 - (Me.Height / 2)
        Me.Left = (Screen.PrimaryScreen.Bounds.Width) / 2 - (Me.Width / 2)

        'Cargar Lista de Tablas
        Dim query As String = "Show Tables"
        Dim oDataTable As DataTable = MiConexion.Consultar(query)
        If Not oDataTable Is Nothing Then
            For Each odatarow As DataRow In oDataTable.Rows
                LtsListaTablas.Items.Add(odatarow(0).ToString)
            Next
            'Comprobaciones 
            LtsListaTablas.SelectedIndex = 0
            LtsCondicionesLogicas.SelectedIndex = 0
            ChkExpert.CheckState = CheckState.Unchecked
            ChkExpert_CheckedChanged(ChkExpert, Nothing)
            ChkBtnTablas()
            ChkBtnCampos()
            ChkBtnCondiciones()
        Else
            MessageBox.Show("Error durante la carga" & vbCrLf & "El " & Me.Text & " se cerrara", "Error")
            Me.Close()
        End If
    End Sub
    'Funcion de Consultar Parametro una Query Como String, resultado una dataTable
    'Cambiar Modo Experto
    Private Sub ChkExpert_CheckedChanged(sender As Object, e As EventArgs) Handles ChkExpert.CheckedChanged
        GrbSelectTablas.Enabled = Not ChkExpert.Checked
        GrbSelecCampos.Enabled = Not ChkExpert.Checked
        ChkWhere.CheckState = CheckState.Unchecked
        ChkWhere_CheckedChanged(ChkWhere, Nothing)
        ChkWhere.Enabled = Not ChkExpert.Checked
        BtnGenerarSQL.Enabled = Not ChkExpert.Checked
        TxtSelect.Enabled = ChkExpert.Checked
    End Sub
    'Añadir clausula Where
    Private Sub ChkWhere_CheckedChanged(sender As Object, e As EventArgs) Handles ChkWhere.CheckedChanged
        GrbWhere.Enabled = ChkWhere.Checked
    End Sub
    'Generar Query
    Private Sub BtnGenerarSQL_Click(sender As Object, e As EventArgs) Handles BtnGenerarSQL.Click
        Dim Sepue As Boolean = True
        'Comprobaciones
        If LtsSelecTablas.Items.Count < 1 Then
            Sepue = False
            MessageBox.Show("Selecione al menos 1 Tabla")
        End If
        If LtsSelecCampos.Items.Count < 1 Then
            Sepue = False
            MessageBox.Show("Selecione al menos 1 Campo")
        End If
        If ChkWhere.Checked Then
            If LtsSelectCondiciones.Items.Count < 1 Then
                Sepue = False
                MessageBox.Show("Genere al menos 1 condicion")
            Else
                'Si esta habilitado no se ha añadido el concatenador final
                If BtnAddWhere.Enabled Then
                    Sepue = False
                    MessageBox.Show("La ultima condicion tiene que tener el concatenador '.'")
                End If
            End If
        End If
        If Sepue Then
            Dim SqlQuery As String = "Select "
            'Campos
            For Each oItem In LtsSelecCampos.Items
                SqlQuery = SqlQuery & oItem.ToString & ", "
            Next

            SqlQuery = SqlQuery.Substring(0, SqlQuery.Length - 2) & " From "
            'Tablas
            For Each oItem In LtsSelecTablas.Items
                SqlQuery = SqlQuery & oItem.ToString & ", "
            Next
            SqlQuery = SqlQuery.Substring(0, SqlQuery.Length - 2)
            'Clausula Where
            If ChkWhere.Checked Then
                SqlQuery = SqlQuery & " Where "
                For Each oItem In LtsSelectCondiciones.Items
                    SqlQuery = SqlQuery & oItem.ToString & " "
                Next
                SqlQuery = SqlQuery.Substring(0, SqlQuery.Length - 3)
            End If
            TxtSelect.Text = SqlQuery
        End If
    End Sub
    'Boton de Consultar
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

        Dim query = TxtSelect.Text
        Dim Selec As Boolean = True
        'If Not query.ToUpper.IndexOf("INSERT INTO") = -1 Then
        '    Selec = False
        'End If
        'If Not query.ToUpper.IndexOf("DELETE FROM") = -1 Then
        '    Selec = False
        'End If
        'If Not query.ToUpper.IndexOf("UPDATE") = -1 Then
        '    Selec = False
        'End If
        'If Not query.ToUpper.IndexOf("DROP") = -1 Then
        '    Selec = False
        'End If
        'If Not query.ToUpper.IndexOf("ALTER") = -1 Then
        '    Selec = False
        'End If
        'If Not query.ToUpper.IndexOf("CREATE") = -1 Then
        '    Selec = False
        'End If
        'If Not query.ToUpper.IndexOf(";") = -1 Then
        '    Selec = False
        'End If
        'If query.ToUpper.IndexOf("SELECT") = -1 Then
        '    Selec = False
        'End If
        If Selec Then
            TablaDGW = MiConexion.Consultar(query)
            If Not TablaDGW Is Nothing Then
                DgvPrincipal.DataSource = TablaDGW
            Else
                MessageBox.Show("Sentencia Select incorrecta")
            End If
        Else
            MessageBox.Show("Sentencia Select incorrecta")
        End If


    End Sub
    'Procedimiento De Botones De Tablas
    Private Sub ChkBtnTablas()
        If LtsSelecTablas.Items.Count < 1 Then
            BtnAddTabla.Enabled = True
            BtnRmTabla.Enabled = False
            BtnClearTablas.Enabled = False
        Else
            BtnAddTabla.Enabled = True
            BtnRmTabla.Enabled = True
            BtnClearTablas.Enabled = True
        End If
    End Sub
    'Añadir Tabla
    Private Sub BtnAddTabla_Click(sender As Object, e As EventArgs) Handles BtnAddTabla.Click
        If LtsSelecTablas.Items.IndexOf(LtsListaTablas.SelectedItem) = -1 Then
            LtsSelecTablas.Items.Add(LtsListaTablas.SelectedItem)
        End If

        If Not LtsSelecTablas.Items.Count < 1 Then
            LtsSelecTablas.SelectedIndex = 0
        End If
        ChkBtnTablas()
        ChkBtnCampos()
    End Sub
    'Borrar Tabla
    Private Sub BtnRmTabla_Click(sender As Object, e As EventArgs) Handles BtnRmTabla.Click
        Dim oItem
        Dim j As Integer = LtsSelecCampos.Items.Count
        Dim i As Integer = 0
        While (i < j)
            oItem = LtsSelecCampos.Items(i)
            If oItem.StartsWith(LtsSelecTablas.SelectedItem) Then
                LtsSelecCampos.Items.Remove(oItem)
                j = LtsSelecCampos.Items.Count
            Else
                i += 1
            End If
        End While
        j = LtsSelectCondiciones.Items.Count
        i = 0
        While (i < j)
            oItem = LtsSelectCondiciones.Items(i)
            If oItem.StartsWith(LtsSelecTablas.SelectedItem) Then
                LtsSelectCondiciones.Items.Remove(oItem)
                j = LtsSelectCondiciones.Items.Count
            Else
                i += 1
            End If
        End While
        LtsSelecTablas.Items.RemoveAt(LtsSelecTablas.SelectedIndex)
        If LtsSelecTablas.Items.Count >= 1 Then
            LtsSelecTablas.SelectedIndex = 0
        End If
        LtsListaCampos.Items.Clear()
        LtsListaCamposWhere.Items.Clear()
        ChkBtnTablas()
        ChkBtnCampos()

    End Sub
    'Vaciar Tablas
    Private Sub BtnClearTablas_Click(sender As Object, e As EventArgs) Handles BtnClearTablas.Click
        BtnClearCampo_Click(BtnClearCampo, Nothing)
        BtnClearWhere_Click(BtnClearWhere, Nothing)
        LtsListaCampos.Items.Clear()
        LtsListaCamposWhere.Items.Clear()
        LtsSelecTablas.Items.Clear()
        LtsComparador.Items.Clear()
        ChkBtnTablas()
        ChkBtnCampos()
        ChkBtnCondiciones()
    End Sub
    'Carga De Campos con Click Modo Basico
    Private Sub LtsSelecTablas_Click(sender As Object, e As EventArgs) Handles LtsSelecTablas.Click
        LtsListaCampos.Items.Clear()
        LtsListaCamposWhere.Items.Clear()
        Dim query As String = "Describe " & LtsSelecTablas.SelectedItem.ToString
        Campos = MiConexion.Consultar(query)
        LtsListaCampos.Items.Add("Todos")
        For Each odatarow As DataRow In Campos.Rows
            LtsListaCampos.Items.Add(odatarow(0).ToString)
            LtsListaCamposWhere.Items.Add(odatarow(0).ToString)
        Next
        LtsListaCampos.SelectedIndex = 0
        LtsListaCamposWhere.SelectedIndex = 0
        ChkBtnCampos()
        LtsListaCamposWhere_Click(LtsListaCamposWhere, Nothing)
    End Sub
    'Carga De Campos con Click Modo Experto
    Private Sub LtsListaTablas_Click(sender As Object, e As EventArgs) Handles LtsListaTablas.Click
        If ChkExpert.Checked Then
            LtsListaCampos.Enabled = True
            LtsListaCampos.Items.Clear()
            Dim query As String = "Describe " & LtsListaTablas.SelectedItem.ToString
            Dim oDataTable As DataTable
            oDataTable = MiConexion.Consultar(query)
            LtsListaCampos.Items.Add("Todos")
            For Each odatarow As DataRow In oDataTable.Rows
                LtsListaCampos.Items.Add(odatarow(0).ToString)
            Next
        End If
    End Sub
    'Procedimiento De Botones De Campos
    Private Sub ChkBtnCampos()
        If LtsSelecCampos.Items.Count < 1 Then
            BtnAddCampo.Enabled = True
            BtnRmCampo.Enabled = False
            BtnClearCampo.Enabled = False
        Else
            BtnAddCampo.Enabled = True
            BtnRmCampo.Enabled = True
            BtnClearCampo.Enabled = True
        End If

        If LtsListaCampos.Items.Count < 1 Then
            BtnAddCampo.Enabled = False
        Else
            BtnAddCampo.Enabled = True
        End If
    End Sub
    'Añadir Campos
    Private Sub BtnAddCampo_Click(sender As Object, e As EventArgs) Handles BtnAddCampo.Click
        If LtsListaCampos.SelectedItem.ToString.Equals("Todos") Then
            LtsSelecCampos.Items.Add(LtsSelecTablas.SelectedItem & ".*")
        Else
            LtsSelecCampos.Items.Add(LtsSelecTablas.SelectedItem & "." & LtsListaCampos.SelectedItem)
        End If
        If LtsSelecCampos.Items.Count = 1 Then
            LtsSelecCampos.SelectedIndex = 0
        End If
        ChkBtnCampos()
    End Sub
    'Borrar Campos
    Private Sub BtnRmCampo_Click(sender As Object, e As EventArgs) Handles BtnRmCampo.Click
        LtsSelecCampos.Items.RemoveAt(LtsSelecCampos.SelectedIndex)
        If LtsSelecCampos.Items.Count >= 1 Then
            LtsSelecCampos.SelectedIndex = 0
        End If
        ChkBtnCampos()
    End Sub
    'Limpiar Campos
    Private Sub BtnClearCampo_Click(sender As Object, e As EventArgs) Handles BtnClearCampo.Click
        LtsSelecCampos.Items.Clear()
        ChkBtnCampos()
    End Sub
    'Cargar Lista Comparadores
    Private Sub LtsListaCamposWhere_Click(sender As Object, e As EventArgs) Handles LtsListaCamposWhere.Click
        Dim Tipo As String = Campos.Rows(LtsListaCamposWhere.SelectedIndex)(1).ToString
        If Not Tipo.IndexOf("(") = -1 Then
            Tipo = Tipo.Substring(0, Tipo.IndexOf("("))
        End If
        TxtComparacion.Text = ""
        LtsComparador.Items.Clear()
        LtsComparador.Items.Add("=")
        Select Case Tipo
            Case "int"
                LtsComparador.Items.Add("<")
                LtsComparador.Items.Add("<=")
                LtsComparador.Items.Add(">")
                LtsComparador.Items.Add(">=")
                TxtComparacion.Enabled = True
                DTPWhere.Enabled = False
                GrbTrueFalse.Enabled = False
            Case "date"
                LtsComparador.Items.Add("<")
                LtsComparador.Items.Add("<=")
                LtsComparador.Items.Add(">")
                LtsComparador.Items.Add(">=")
                TxtComparacion.Enabled = False
                DTPWhere.Enabled = True
                GrbTrueFalse.Enabled = False
                TxtComparacion.Text = DTPWhere.Value.ToShortDateString
            Case "varchar"
                LtsComparador.Items.Add("Like")
                TxtComparacion.Enabled = True
                DTPWhere.Enabled = False
                GrbTrueFalse.Enabled = False
            Case "tinyint"
                TxtComparacion.Enabled = False
                DTPWhere.Enabled = False
                GrbTrueFalse.Enabled = True
                TxtComparacion.Text = "1"
                RbTrue.Checked = True
        End Select

        LtsComparador.SelectedIndex = 0


    End Sub
    'Procedimiento De Botones De Condiciones
    Private Sub ChkBtnCondiciones()
        If LtsSelectCondiciones.Items.Count < 1 Then
            BtnAddWhere.Enabled = True
            BtnRmWhere.Enabled = False
            BtnClearWhere.Enabled = False
        Else
            BtnRmWhere.Enabled = True
            BtnClearWhere.Enabled = True
            Dim CondicionFinal As String = LtsSelectCondiciones.Items(LtsSelectCondiciones.Items.Count - 1).ToString
            CondicionFinal = CondicionFinal.Substring(CondicionFinal.Length - 2, 1)
            If CondicionFinal.Equals(".") Then
                BtnAddWhere.Enabled = False
            Else
                BtnAddWhere.Enabled = True
            End If
            LtsSelectCondiciones.SelectedIndex = 0
        End If
    End Sub
    'Añadir Condicion
    Private Sub BtnAddWhere_Click(sender As Object, e As EventArgs) Handles BtnAddWhere.Click
        Dim condicion As String
        condicion = LtsSelecTablas.SelectedItem.ToString & "." & LtsListaCamposWhere.SelectedItem.ToString & " "
        If LtsComparador.SelectedItem.ToString.Equals("Like") Then
            condicion = condicion & "Like('" & TxtComparacion.Text & "')"
        Else
            condicion = condicion & LtsComparador.SelectedItem.ToString & TxtComparacion.Text
        End If

        condicion = condicion & " " & LtsCondicionesLogicas.SelectedItem.ToString & " "
        LtsSelectCondiciones.Items.Add(condicion)
        ChkBtnCondiciones()
    End Sub
    'Borrar Condicion
    Private Sub BtnRmWhere_Click(sender As Object, e As EventArgs) Handles BtnRmWhere.Click
        LtsSelectCondiciones.Items.Remove(LtsSelectCondiciones.SelectedItem)
        ChkBtnCondiciones()
    End Sub
    'Borrar Condiciones
    Private Sub BtnClearWhere_Click(sender As Object, e As EventArgs) Handles BtnClearWhere.Click
        LtsSelectCondiciones.Items.Clear()
        ChkBtnCondiciones()
    End Sub
    'Referente al DateTimePiker del Where
    Private Sub DTPWhere_ValueChanged(sender As Object, e As EventArgs) Handles DTPWhere.ValueChanged
        TxtComparacion.Text = DTPWhere.Value.ToShortDateString
    End Sub
    'Referente al Radio Button True
    Private Sub RbTrue_CheckedChanged(sender As Object, e As EventArgs) Handles RbTrue.CheckedChanged
        TxtComparacion.Text = "1"
    End Sub
    'Referente al Radio Button False
    Private Sub RbFalse_CheckedChanged(sender As Object, e As EventArgs) Handles RbFalse.CheckedChanged
        TxtComparacion.Text = "0"
    End Sub
End Class
