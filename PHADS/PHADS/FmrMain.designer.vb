<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrMain
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
        Me.MsMain = New System.Windows.Forms.MenuStrip()
        Me.MsVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiVentas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsCompras = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiPedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiMod = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiPuestos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsiChanPass = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsGeneradorConsultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MsMain
        '
        Me.MsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsVentas, Me.MsAlmacen, Me.MsCompras, Me.MsUsuarios, Me.MsGeneradorConsultas})
        Me.MsMain.Location = New System.Drawing.Point(0, 0)
        Me.MsMain.Name = "MsMain"
        Me.MsMain.Size = New System.Drawing.Size(756, 24)
        Me.MsMain.TabIndex = 0
        Me.MsMain.Text = "MenuStrip1"
        '
        'MsVentas
        '
        Me.MsVentas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiVentas})
        Me.MsVentas.Name = "MsVentas"
        Me.MsVentas.Size = New System.Drawing.Size(52, 20)
        Me.MsVentas.Text = "Ventas"
        '
        'MsiVentas
        '
        Me.MsiVentas.Name = "MsiVentas"
        Me.MsiVentas.Size = New System.Drawing.Size(163, 22)
        Me.MsiVentas.Text = "Venta de producto"
        '
        'MsAlmacen
        '
        Me.MsAlmacen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiAlmacen})
        Me.MsAlmacen.Name = "MsAlmacen"
        Me.MsAlmacen.Size = New System.Drawing.Size(59, 20)
        Me.MsAlmacen.Text = "Almacen"
        '
        'MsiAlmacen
        '
        Me.MsiAlmacen.Name = "MsiAlmacen"
        Me.MsiAlmacen.Size = New System.Drawing.Size(168, 22)
        Me.MsiAlmacen.Text = "Gestion de Almacen"
        '
        'MsCompras
        '
        Me.MsCompras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiProductos, Me.MsiPedidos, Me.MsiProveedores})
        Me.MsCompras.Name = "MsCompras"
        Me.MsCompras.Size = New System.Drawing.Size(61, 20)
        Me.MsCompras.Text = "Compras"
        '
        'MsiProductos
        '
        Me.MsiProductos.Name = "MsiProductos"
        Me.MsiProductos.Size = New System.Drawing.Size(135, 22)
        Me.MsiProductos.Text = "Productos"
        '
        'MsiPedidos
        '
        Me.MsiPedidos.Name = "MsiPedidos"
        Me.MsiPedidos.Size = New System.Drawing.Size(135, 22)
        Me.MsiPedidos.Text = "Pedidos"
        '
        'MsiProveedores
        '
        Me.MsiProveedores.Name = "MsiProveedores"
        Me.MsiProveedores.Size = New System.Drawing.Size(135, 22)
        Me.MsiProveedores.Text = "Proveedores"
        '
        'MsUsuarios
        '
        Me.MsUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsiAlta, Me.MsiBaja, Me.MsiMod, Me.MsiUsuarios, Me.MsiPuestos, Me.MsiChanPass})
        Me.MsUsuarios.Name = "MsUsuarios"
        Me.MsUsuarios.Size = New System.Drawing.Size(60, 20)
        Me.MsUsuarios.Text = "Usuarios"
        '
        'MsiAlta
        '
        Me.MsiAlta.Name = "MsiAlta"
        Me.MsiAlta.Size = New System.Drawing.Size(180, 22)
        Me.MsiAlta.Text = "Alta (Legado)"
        '
        'MsiBaja
        '
        Me.MsiBaja.Name = "MsiBaja"
        Me.MsiBaja.Size = New System.Drawing.Size(180, 22)
        Me.MsiBaja.Text = "Baja (Legado)"
        '
        'MsiMod
        '
        Me.MsiMod.Name = "MsiMod"
        Me.MsiMod.Size = New System.Drawing.Size(180, 22)
        Me.MsiMod.Text = "Modificación (Legado)"
        '
        'MsiUsuarios
        '
        Me.MsiUsuarios.Name = "MsiUsuarios"
        Me.MsiUsuarios.Size = New System.Drawing.Size(180, 22)
        Me.MsiUsuarios.Text = "Usuarios"
        '
        'MsiPuestos
        '
        Me.MsiPuestos.Name = "MsiPuestos"
        Me.MsiPuestos.Size = New System.Drawing.Size(180, 22)
        Me.MsiPuestos.Text = "Puestos"
        '
        'MsiChanPass
        '
        Me.MsiChanPass.Name = "MsiChanPass"
        Me.MsiChanPass.Size = New System.Drawing.Size(180, 22)
        Me.MsiChanPass.Text = "Cambiar Contraseña"
        '
        'MsGeneradorConsultas
        '
        Me.MsGeneradorConsultas.Name = "MsGeneradorConsultas"
        Me.MsGeneradorConsultas.Size = New System.Drawing.Size(120, 20)
        Me.MsGeneradorConsultas.Text = "Generador Consultas"
        '
        'FmrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 262)
        Me.Controls.Add(Me.MsMain)
        Me.MainMenuStrip = Me.MsMain
        Me.Name = "FmrMain"
        Me.Text = "Form1"
        Me.MsMain.ResumeLayout(False)
        Me.MsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsMain As MenuStrip
    Friend WithEvents MsUsuarios As ToolStripMenuItem
    Friend WithEvents MsiAlta As ToolStripMenuItem
    Friend WithEvents MsiBaja As ToolStripMenuItem
    Friend WithEvents MsiMod As ToolStripMenuItem
    Friend WithEvents MsVentas As ToolStripMenuItem
    Friend WithEvents MsAlmacen As ToolStripMenuItem
    Friend WithEvents MsCompras As ToolStripMenuItem
    Friend WithEvents MsGeneradorConsultas As ToolStripMenuItem
    Friend WithEvents MsiVentas As ToolStripMenuItem
    Friend WithEvents MsiAlmacen As ToolStripMenuItem
    Friend WithEvents MsiProductos As ToolStripMenuItem
    Friend WithEvents MsiPedidos As ToolStripMenuItem
    Friend WithEvents MsiUsuarios As ToolStripMenuItem
    Friend WithEvents MsiPuestos As ToolStripMenuItem
    Friend WithEvents MsiChanPass As ToolStripMenuItem
    Friend WithEvents MsiProveedores As ToolStripMenuItem
End Class
