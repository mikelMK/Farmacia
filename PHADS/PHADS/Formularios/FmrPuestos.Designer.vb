<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrPuestos
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
        Me.LstRoles = New System.Windows.Forms.ListBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.ChkVentas = New System.Windows.Forms.CheckBox()
        Me.ChkCompras = New System.Windows.Forms.CheckBox()
        Me.ChkAlmacen = New System.Windows.Forms.CheckBox()
        Me.ChkUsuarios = New System.Windows.Forms.CheckBox()
        Me.ChkControlTotal = New System.Windows.Forms.CheckBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstRoles
        '
        Me.LstRoles.FormattingEnabled = True
        Me.LstRoles.Location = New System.Drawing.Point(12, 12)
        Me.LstRoles.Name = "LstRoles"
        Me.LstRoles.Size = New System.Drawing.Size(194, 212)
        Me.LstRoles.TabIndex = 0
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(212, 12)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(238, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'ChkVentas
        '
        Me.ChkVentas.AutoSize = True
        Me.ChkVentas.Location = New System.Drawing.Point(212, 38)
        Me.ChkVentas.Name = "ChkVentas"
        Me.ChkVentas.Size = New System.Drawing.Size(59, 17)
        Me.ChkVentas.TabIndex = 2
        Me.ChkVentas.Text = "Ventas"
        Me.ChkVentas.UseVisualStyleBackColor = True
        '
        'ChkCompras
        '
        Me.ChkCompras.AutoSize = True
        Me.ChkCompras.Location = New System.Drawing.Point(212, 61)
        Me.ChkCompras.Name = "ChkCompras"
        Me.ChkCompras.Size = New System.Drawing.Size(67, 17)
        Me.ChkCompras.TabIndex = 3
        Me.ChkCompras.Text = "Compras"
        Me.ChkCompras.UseVisualStyleBackColor = True
        '
        'ChkAlmacen
        '
        Me.ChkAlmacen.AutoSize = True
        Me.ChkAlmacen.Location = New System.Drawing.Point(212, 84)
        Me.ChkAlmacen.Name = "ChkAlmacen"
        Me.ChkAlmacen.Size = New System.Drawing.Size(67, 17)
        Me.ChkAlmacen.TabIndex = 4
        Me.ChkAlmacen.Text = "Almacen"
        Me.ChkAlmacen.UseVisualStyleBackColor = True
        '
        'ChkUsuarios
        '
        Me.ChkUsuarios.AutoSize = True
        Me.ChkUsuarios.Location = New System.Drawing.Point(212, 107)
        Me.ChkUsuarios.Name = "ChkUsuarios"
        Me.ChkUsuarios.Size = New System.Drawing.Size(67, 17)
        Me.ChkUsuarios.TabIndex = 5
        Me.ChkUsuarios.Text = "Usuarios"
        Me.ChkUsuarios.UseVisualStyleBackColor = True
        '
        'ChkControlTotal
        '
        Me.ChkControlTotal.AutoSize = True
        Me.ChkControlTotal.Location = New System.Drawing.Point(212, 130)
        Me.ChkControlTotal.Name = "ChkControlTotal"
        Me.ChkControlTotal.Size = New System.Drawing.Size(86, 17)
        Me.ChkControlTotal.TabIndex = 6
        Me.ChkControlTotal.Text = "Control Total"
        Me.ChkControlTotal.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(376, 201)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(213, 200)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 8
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(294, 170)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 9
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(376, 170)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(213, 170)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 11
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'FmrPuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 238)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.ChkControlTotal)
        Me.Controls.Add(Me.ChkUsuarios)
        Me.Controls.Add(Me.ChkAlmacen)
        Me.Controls.Add(Me.ChkCompras)
        Me.Controls.Add(Me.ChkVentas)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LstRoles)
        Me.Name = "FmrPuestos"
        Me.Text = "Puestos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstRoles As ListBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents ChkVentas As CheckBox
    Friend WithEvents ChkCompras As CheckBox
    Friend WithEvents ChkAlmacen As CheckBox
    Friend WithEvents ChkUsuarios As CheckBox
    Friend WithEvents ChkControlTotal As CheckBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnNuevo As Button
End Class
