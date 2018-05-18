<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionBaja
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
        Me.LstUsuarios = New System.Windows.Forms.ListBox()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstUsuarios
        '
        Me.LstUsuarios.FormattingEnabled = True
        Me.LstUsuarios.Location = New System.Drawing.Point(40, 78)
        Me.LstUsuarios.Name = "LstUsuarios"
        Me.LstUsuarios.Size = New System.Drawing.Size(597, 355)
        Me.LstUsuarios.TabIndex = 3
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(0, 460)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(671, 23)
        Me.btnEliminarUsuario.TabIndex = 4
        Me.btnEliminarUsuario.Text = "ELIMINAR USUARIO SELECCIONADO"
        Me.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(185, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(270, 20)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "GESTION DE BAJAS DE USUARIO"
        '
        'GestionBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 483)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnEliminarUsuario)
        Me.Controls.Add(Me.LstUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GestionBaja"
        Me.Text = "GestionBaja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstUsuarios As ListBox
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents Label20 As Label
End Class
