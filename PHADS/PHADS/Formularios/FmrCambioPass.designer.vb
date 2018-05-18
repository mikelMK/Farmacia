<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrCambioPass
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNuevaPass = New System.Windows.Forms.TextBox()
        Me.TxtRepetirPass = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nueva Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Repetir Contraseña"
        '
        'TxtNuevaPass
        '
        Me.TxtNuevaPass.Location = New System.Drawing.Point(135, 12)
        Me.TxtNuevaPass.Name = "TxtNuevaPass"
        Me.TxtNuevaPass.Size = New System.Drawing.Size(127, 20)
        Me.TxtNuevaPass.TabIndex = 2
        '
        'TxtRepetirPass
        '
        Me.TxtRepetirPass.Location = New System.Drawing.Point(135, 49)
        Me.TxtRepetirPass.Name = "TxtRepetirPass"
        Me.TxtRepetirPass.Size = New System.Drawing.Size(127, 20)
        Me.TxtRepetirPass.TabIndex = 3
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(187, 91)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(15, 91)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FmrCambioPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(277, 126)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtRepetirPass)
        Me.Controls.Add(Me.TxtNuevaPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmrCambioPass"
        Me.Text = "Cambio De Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNuevaPass As TextBox
    Friend WithEvents TxtRepetirPass As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
End Class
