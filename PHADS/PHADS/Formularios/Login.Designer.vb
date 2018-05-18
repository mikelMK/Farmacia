<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.BtnLoguin = New System.Windows.Forms.Button()
        Me.BtnDebug = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(87, 53)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtPass.TabIndex = 2
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(87, 27)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(100, 20)
        Me.TxtDNI.TabIndex = 3
        '
        'BtnLoguin
        '
        Me.BtnLoguin.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLoguin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLoguin.Location = New System.Drawing.Point(0, 93)
        Me.BtnLoguin.Name = "BtnLoguin"
        Me.BtnLoguin.Size = New System.Drawing.Size(240, 23)
        Me.BtnLoguin.TabIndex = 4
        Me.BtnLoguin.Text = "ENTRAR"
        Me.BtnLoguin.UseVisualStyleBackColor = False
        '
        'BtnDebug
        '
        Me.BtnDebug.Location = New System.Drawing.Point(23, 12)
        Me.BtnDebug.Name = "BtnDebug"
        Me.BtnDebug.Size = New System.Drawing.Size(10, 10)
        Me.BtnDebug.TabIndex = 5
        Me.BtnDebug.Text = "Button1"
        Me.BtnDebug.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 116)
        Me.Controls.Add(Me.BtnDebug)
        Me.Controls.Add(Me.BtnLoguin)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents BtnLoguin As Button
    Friend WithEvents BtnDebug As Button
End Class
