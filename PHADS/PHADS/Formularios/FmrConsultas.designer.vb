<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrConsultas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrConsultas))
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.DgvPrincipal = New System.Windows.Forms.DataGridView()
        Me.TxtSelect = New System.Windows.Forms.TextBox()
        Me.BtnGenerarSQL = New System.Windows.Forms.Button()
        Me.LtsListaTablas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LtsSelecTablas = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkExpert = New System.Windows.Forms.CheckBox()
        Me.BtnAddTabla = New System.Windows.Forms.Button()
        Me.BtnRmTabla = New System.Windows.Forms.Button()
        Me.BtnClearTablas = New System.Windows.Forms.Button()
        Me.LtsListaCampos = New System.Windows.Forms.ListBox()
        Me.LtsSelecCampos = New System.Windows.Forms.ListBox()
        Me.BtnClearCampo = New System.Windows.Forms.Button()
        Me.BtnRmCampo = New System.Windows.Forms.Button()
        Me.BtnAddCampo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrbSelectTablas = New System.Windows.Forms.GroupBox()
        Me.ChkWhere = New System.Windows.Forms.CheckBox()
        Me.GrbWhere = New System.Windows.Forms.GroupBox()
        Me.GrbTrueFalse = New System.Windows.Forms.GroupBox()
        Me.RbFalse = New System.Windows.Forms.RadioButton()
        Me.RbTrue = New System.Windows.Forms.RadioButton()
        Me.DTPWhere = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LtsComparador = New System.Windows.Forms.ListBox()
        Me.TxtComparacion = New System.Windows.Forms.TextBox()
        Me.BtnClearWhere = New System.Windows.Forms.Button()
        Me.LtsSelectCondiciones = New System.Windows.Forms.ListBox()
        Me.BtnRmWhere = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAddWhere = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LtsCondicionesLogicas = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LtsListaCamposWhere = New System.Windows.Forms.ListBox()
        Me.GrbSelecCampos = New System.Windows.Forms.GroupBox()
        CType(Me.DgvPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbSelectTablas.SuspendLayout()
        Me.GrbWhere.SuspendLayout()
        Me.GrbTrueFalse.SuspendLayout()
        Me.GrbSelecCampos.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(12, 543)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 1
        Me.BtnSelect.Text = "Consultar"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'DgvPrincipal
        '
        Me.DgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPrincipal.Location = New System.Drawing.Point(12, 598)
        Me.DgvPrincipal.Name = "DgvPrincipal"
        Me.DgvPrincipal.Size = New System.Drawing.Size(856, 111)
        Me.DgvPrincipal.TabIndex = 2
        '
        'TxtSelect
        '
        Me.TxtSelect.Location = New System.Drawing.Point(12, 572)
        Me.TxtSelect.Name = "TxtSelect"
        Me.TxtSelect.Size = New System.Drawing.Size(856, 20)
        Me.TxtSelect.TabIndex = 3
        '
        'BtnGenerarSQL
        '
        Me.BtnGenerarSQL.Location = New System.Drawing.Point(93, 543)
        Me.BtnGenerarSQL.Name = "BtnGenerarSQL"
        Me.BtnGenerarSQL.Size = New System.Drawing.Size(114, 23)
        Me.BtnGenerarSQL.TabIndex = 16
        Me.BtnGenerarSQL.Text = "Generar Consulta"
        Me.BtnGenerarSQL.UseVisualStyleBackColor = True
        '
        'LtsListaTablas
        '
        Me.LtsListaTablas.FormattingEnabled = True
        Me.LtsListaTablas.Location = New System.Drawing.Point(17, 80)
        Me.LtsListaTablas.Name = "LtsListaTablas"
        Me.LtsListaTablas.Size = New System.Drawing.Size(120, 186)
        Me.LtsListaTablas.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Listado De Tablas"
        '
        'LtsSelecTablas
        '
        Me.LtsSelecTablas.FormattingEnabled = True
        Me.LtsSelecTablas.Location = New System.Drawing.Point(87, 34)
        Me.LtsSelecTablas.Name = "LtsSelecTablas"
        Me.LtsSelecTablas.Size = New System.Drawing.Size(120, 186)
        Me.LtsSelecTablas.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tablas Seleccionadas"
        '
        'ChkExpert
        '
        Me.ChkExpert.AutoSize = True
        Me.ChkExpert.Location = New System.Drawing.Point(17, 22)
        Me.ChkExpert.Name = "ChkExpert"
        Me.ChkExpert.Size = New System.Drawing.Size(62, 17)
        Me.ChkExpert.TabIndex = 4
        Me.ChkExpert.Text = "Experto"
        Me.ChkExpert.UseVisualStyleBackColor = True
        '
        'BtnAddTabla
        '
        Me.BtnAddTabla.Location = New System.Drawing.Point(6, 37)
        Me.BtnAddTabla.Name = "BtnAddTabla"
        Me.BtnAddTabla.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddTabla.TabIndex = 17
        Me.BtnAddTabla.Text = "Añadir"
        Me.BtnAddTabla.UseVisualStyleBackColor = True
        '
        'BtnRmTabla
        '
        Me.BtnRmTabla.Location = New System.Drawing.Point(6, 66)
        Me.BtnRmTabla.Name = "BtnRmTabla"
        Me.BtnRmTabla.Size = New System.Drawing.Size(75, 23)
        Me.BtnRmTabla.TabIndex = 18
        Me.BtnRmTabla.Text = "Quitar"
        Me.BtnRmTabla.UseVisualStyleBackColor = True
        '
        'BtnClearTablas
        '
        Me.BtnClearTablas.Location = New System.Drawing.Point(6, 95)
        Me.BtnClearTablas.Name = "BtnClearTablas"
        Me.BtnClearTablas.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearTablas.TabIndex = 19
        Me.BtnClearTablas.Text = "Vaciar"
        Me.BtnClearTablas.UseVisualStyleBackColor = True
        '
        'LtsListaCampos
        '
        Me.LtsListaCampos.FormattingEnabled = True
        Me.LtsListaCampos.Location = New System.Drawing.Point(376, 80)
        Me.LtsListaCampos.Name = "LtsListaCampos"
        Me.LtsListaCampos.Size = New System.Drawing.Size(120, 186)
        Me.LtsListaCampos.TabIndex = 20
        '
        'LtsSelecCampos
        '
        Me.LtsSelecCampos.FormattingEnabled = True
        Me.LtsSelecCampos.Location = New System.Drawing.Point(87, 34)
        Me.LtsSelecCampos.Name = "LtsSelecCampos"
        Me.LtsSelecCampos.Size = New System.Drawing.Size(273, 186)
        Me.LtsSelecCampos.TabIndex = 21
        '
        'BtnClearCampo
        '
        Me.BtnClearCampo.Location = New System.Drawing.Point(6, 97)
        Me.BtnClearCampo.Name = "BtnClearCampo"
        Me.BtnClearCampo.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearCampo.TabIndex = 24
        Me.BtnClearCampo.Text = "Borrar"
        Me.BtnClearCampo.UseVisualStyleBackColor = True
        '
        'BtnRmCampo
        '
        Me.BtnRmCampo.Location = New System.Drawing.Point(6, 68)
        Me.BtnRmCampo.Name = "BtnRmCampo"
        Me.BtnRmCampo.Size = New System.Drawing.Size(75, 23)
        Me.BtnRmCampo.TabIndex = 23
        Me.BtnRmCampo.Text = "Quitar"
        Me.BtnRmCampo.UseVisualStyleBackColor = True
        '
        'BtnAddCampo
        '
        Me.BtnAddCampo.Location = New System.Drawing.Point(6, 39)
        Me.BtnAddCampo.Name = "BtnAddCampo"
        Me.BtnAddCampo.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddCampo.TabIndex = 22
        Me.BtnAddCampo.Text = "Añadir"
        Me.BtnAddCampo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Campos Seleccionadas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Listado De Campos"
        '
        'GrbSelectTablas
        '
        Me.GrbSelectTablas.Controls.Add(Me.BtnClearTablas)
        Me.GrbSelectTablas.Controls.Add(Me.BtnRmTabla)
        Me.GrbSelectTablas.Controls.Add(Me.BtnAddTabla)
        Me.GrbSelectTablas.Controls.Add(Me.Label2)
        Me.GrbSelectTablas.Controls.Add(Me.LtsSelecTablas)
        Me.GrbSelectTablas.Location = New System.Drawing.Point(143, 46)
        Me.GrbSelectTablas.Name = "GrbSelectTablas"
        Me.GrbSelectTablas.Size = New System.Drawing.Size(222, 226)
        Me.GrbSelectTablas.TabIndex = 27
        Me.GrbSelectTablas.TabStop = False
        '
        'ChkWhere
        '
        Me.ChkWhere.AutoSize = True
        Me.ChkWhere.Location = New System.Drawing.Point(12, 285)
        Me.ChkWhere.Name = "ChkWhere"
        Me.ChkWhere.Size = New System.Drawing.Size(84, 17)
        Me.ChkWhere.TabIndex = 28
        Me.ChkWhere.Text = "Condiciones"
        Me.ChkWhere.UseVisualStyleBackColor = True
        '
        'GrbWhere
        '
        Me.GrbWhere.Controls.Add(Me.GrbTrueFalse)
        Me.GrbWhere.Controls.Add(Me.DTPWhere)
        Me.GrbWhere.Controls.Add(Me.Label6)
        Me.GrbWhere.Controls.Add(Me.LtsComparador)
        Me.GrbWhere.Controls.Add(Me.TxtComparacion)
        Me.GrbWhere.Controls.Add(Me.BtnClearWhere)
        Me.GrbWhere.Controls.Add(Me.LtsSelectCondiciones)
        Me.GrbWhere.Controls.Add(Me.BtnRmWhere)
        Me.GrbWhere.Controls.Add(Me.Label9)
        Me.GrbWhere.Controls.Add(Me.BtnAddWhere)
        Me.GrbWhere.Controls.Add(Me.Label8)
        Me.GrbWhere.Controls.Add(Me.Label7)
        Me.GrbWhere.Controls.Add(Me.LtsCondicionesLogicas)
        Me.GrbWhere.Controls.Add(Me.Label5)
        Me.GrbWhere.Controls.Add(Me.LtsListaCamposWhere)
        Me.GrbWhere.Location = New System.Drawing.Point(12, 308)
        Me.GrbWhere.Name = "GrbWhere"
        Me.GrbWhere.Size = New System.Drawing.Size(856, 209)
        Me.GrbWhere.TabIndex = 29
        Me.GrbWhere.TabStop = False
        '
        'GrbTrueFalse
        '
        Me.GrbTrueFalse.Controls.Add(Me.RbFalse)
        Me.GrbTrueFalse.Controls.Add(Me.RbTrue)
        Me.GrbTrueFalse.Location = New System.Drawing.Point(184, 109)
        Me.GrbTrueFalse.Name = "GrbTrueFalse"
        Me.GrbTrueFalse.Size = New System.Drawing.Size(153, 80)
        Me.GrbTrueFalse.TabIndex = 34
        Me.GrbTrueFalse.TabStop = False
        '
        'RbFalse
        '
        Me.RbFalse.AutoSize = True
        Me.RbFalse.Location = New System.Drawing.Point(6, 42)
        Me.RbFalse.Name = "RbFalse"
        Me.RbFalse.Size = New System.Drawing.Size(50, 17)
        Me.RbFalse.TabIndex = 1
        Me.RbFalse.TabStop = True
        Me.RbFalse.Text = "Falso"
        Me.RbFalse.UseVisualStyleBackColor = True
        '
        'RbTrue
        '
        Me.RbTrue.AutoSize = True
        Me.RbTrue.Location = New System.Drawing.Point(6, 19)
        Me.RbTrue.Name = "RbTrue"
        Me.RbTrue.Size = New System.Drawing.Size(74, 17)
        Me.RbTrue.TabIndex = 0
        Me.RbTrue.TabStop = True
        Me.RbTrue.Text = "Verdadero"
        Me.RbTrue.UseVisualStyleBackColor = True
        '
        'DTPWhere
        '
        Me.DTPWhere.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPWhere.Location = New System.Drawing.Point(184, 74)
        Me.DTPWhere.Name = "DTPWhere"
        Me.DTPWhere.Size = New System.Drawing.Size(154, 20)
        Me.DTPWhere.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Comparacion"
        '
        'LtsComparador
        '
        Me.LtsComparador.FormattingEnabled = True
        Me.LtsComparador.Location = New System.Drawing.Point(108, 42)
        Me.LtsComparador.Name = "LtsComparador"
        Me.LtsComparador.Size = New System.Drawing.Size(70, 147)
        Me.LtsComparador.TabIndex = 31
        '
        'TxtComparacion
        '
        Me.TxtComparacion.Location = New System.Drawing.Point(184, 42)
        Me.TxtComparacion.Name = "TxtComparacion"
        Me.TxtComparacion.Size = New System.Drawing.Size(154, 20)
        Me.TxtComparacion.TabIndex = 30
        '
        'BtnClearWhere
        '
        Me.BtnClearWhere.Location = New System.Drawing.Point(424, 100)
        Me.BtnClearWhere.Name = "BtnClearWhere"
        Me.BtnClearWhere.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearWhere.TabIndex = 29
        Me.BtnClearWhere.Text = "Vaciar"
        Me.BtnClearWhere.UseVisualStyleBackColor = True
        '
        'LtsSelectCondiciones
        '
        Me.LtsSelectCondiciones.FormattingEnabled = True
        Me.LtsSelectCondiciones.Location = New System.Drawing.Point(516, 42)
        Me.LtsSelectCondiciones.Name = "LtsSelectCondiciones"
        Me.LtsSelectCondiciones.Size = New System.Drawing.Size(334, 147)
        Me.LtsSelectCondiciones.TabIndex = 9
        '
        'BtnRmWhere
        '
        Me.BtnRmWhere.Location = New System.Drawing.Point(424, 71)
        Me.BtnRmWhere.Name = "BtnRmWhere"
        Me.BtnRmWhere.Size = New System.Drawing.Size(75, 23)
        Me.BtnRmWhere.TabIndex = 28
        Me.BtnRmWhere.Text = "Quitar"
        Me.BtnRmWhere.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(513, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Condiciones"
        '
        'BtnAddWhere
        '
        Me.BtnAddWhere.Location = New System.Drawing.Point(424, 42)
        Me.BtnAddWhere.Name = "BtnAddWhere"
        Me.BtnAddWhere.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddWhere.TabIndex = 27
        Me.BtnAddWhere.Text = "Añadir"
        Me.BtnAddWhere.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Comparador"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Concatenador"
        '
        'LtsCondicionesLogicas
        '
        Me.LtsCondicionesLogicas.FormattingEnabled = True
        Me.LtsCondicionesLogicas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LtsCondicionesLogicas.Items.AddRange(New Object() {".", "AND", "OR"})
        Me.LtsCondicionesLogicas.Location = New System.Drawing.Point(344, 42)
        Me.LtsCondicionesLogicas.Name = "LtsCondicionesLogicas"
        Me.LtsCondicionesLogicas.Size = New System.Drawing.Size(74, 147)
        Me.LtsCondicionesLogicas.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Campo Condicion"
        '
        'LtsListaCamposWhere
        '
        Me.LtsListaCamposWhere.FormattingEnabled = True
        Me.LtsListaCamposWhere.Location = New System.Drawing.Point(12, 42)
        Me.LtsListaCamposWhere.Name = "LtsListaCamposWhere"
        Me.LtsListaCamposWhere.Size = New System.Drawing.Size(87, 147)
        Me.LtsListaCamposWhere.TabIndex = 0
        '
        'GrbSelecCampos
        '
        Me.GrbSelecCampos.Controls.Add(Me.LtsSelecCampos)
        Me.GrbSelecCampos.Controls.Add(Me.Label3)
        Me.GrbSelecCampos.Controls.Add(Me.BtnAddCampo)
        Me.GrbSelecCampos.Controls.Add(Me.BtnRmCampo)
        Me.GrbSelecCampos.Controls.Add(Me.BtnClearCampo)
        Me.GrbSelecCampos.Location = New System.Drawing.Point(502, 46)
        Me.GrbSelecCampos.Name = "GrbSelecCampos"
        Me.GrbSelecCampos.Size = New System.Drawing.Size(366, 226)
        Me.GrbSelecCampos.TabIndex = 30
        Me.GrbSelecCampos.TabStop = False
        '
        'FmrConsultas
        '
        Me.AcceptButton = Me.BtnSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 746)
        Me.Controls.Add(Me.GrbSelecCampos)
        Me.Controls.Add(Me.GrbWhere)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChkWhere)
        Me.Controls.Add(Me.GrbSelectTablas)
        Me.Controls.Add(Me.BtnGenerarSQL)
        Me.Controls.Add(Me.ChkExpert)
        Me.Controls.Add(Me.LtsListaCampos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LtsListaTablas)
        Me.Controls.Add(Me.TxtSelect)
        Me.Controls.Add(Me.DgvPrincipal)
        Me.Controls.Add(Me.BtnSelect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FmrConsultas"
        Me.Text = "Generador de Consultas"
        CType(Me.DgvPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbSelectTablas.ResumeLayout(False)
        Me.GrbSelectTablas.PerformLayout()
        Me.GrbWhere.ResumeLayout(False)
        Me.GrbWhere.PerformLayout()
        Me.GrbTrueFalse.ResumeLayout(False)
        Me.GrbTrueFalse.PerformLayout()
        Me.GrbSelecCampos.ResumeLayout(False)
        Me.GrbSelecCampos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSelect As Button
    Friend WithEvents DgvPrincipal As DataGridView
    Friend WithEvents TxtSelect As TextBox
    Friend WithEvents BtnGenerarSQL As Button
    Friend WithEvents LtsListaTablas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LtsSelecTablas As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkExpert As CheckBox
    Friend WithEvents BtnAddTabla As Button
    Friend WithEvents BtnRmTabla As Button
    Friend WithEvents BtnClearTablas As Button
    Friend WithEvents LtsListaCampos As ListBox
    Friend WithEvents LtsSelecCampos As ListBox
    Friend WithEvents BtnClearCampo As Button
    Friend WithEvents BtnRmCampo As Button
    Friend WithEvents BtnAddCampo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GrbSelectTablas As GroupBox
    Friend WithEvents ChkWhere As CheckBox
    Friend WithEvents GrbWhere As GroupBox
    Friend WithEvents LtsListaCamposWhere As ListBox
    Friend WithEvents BtnClearWhere As Button
    Friend WithEvents LtsSelectCondiciones As ListBox
    Friend WithEvents BtnRmWhere As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAddWhere As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LtsCondicionesLogicas As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GrbSelecCampos As GroupBox
    Friend WithEvents TxtComparacion As TextBox
    Friend WithEvents LtsComparador As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DTPWhere As DateTimePicker
    Friend WithEvents GrbTrueFalse As GroupBox
    Friend WithEvents RbFalse As RadioButton
    Friend WithEvents RbTrue As RadioButton
End Class
