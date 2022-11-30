<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenadorDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreadorDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenDeCuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.ConsultaDeCuentasToolStripMenuItem, Me.VerToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(371, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenadorDeCuentasToolStripMenuItem, Me.CreadorDeInventarioToolStripMenuItem})
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.IngresarToolStripMenuItem.Text = "Aplicaciones"
        '
        'OrdenadorDeCuentasToolStripMenuItem
        '
        Me.OrdenadorDeCuentasToolStripMenuItem.Name = "OrdenadorDeCuentasToolStripMenuItem"
        Me.OrdenadorDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.OrdenadorDeCuentasToolStripMenuItem.Text = "Ordenador de Cuentas"
        '
        'CreadorDeInventarioToolStripMenuItem
        '
        Me.CreadorDeInventarioToolStripMenuItem.Name = "CreadorDeInventarioToolStripMenuItem"
        Me.CreadorDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(227, 24)
        Me.CreadorDeInventarioToolStripMenuItem.Text = "Creador de inventario"
        '
        'ConsultaDeCuentasToolStripMenuItem
        '
        Me.ConsultaDeCuentasToolStripMenuItem.Name = "ConsultaDeCuentasToolStripMenuItem"
        Me.ConsultaDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.ConsultaDeCuentasToolStripMenuItem.Text = "Consulta de cuentas"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenDeCuentasToolStripMenuItem, Me.InventarioToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(45, 24)
        Me.VerToolStripMenuItem.Text = "ver "
        '
        'OrdenDeCuentasToolStripMenuItem
        '
        Me.OrdenDeCuentasToolStripMenuItem.Name = "OrdenDeCuentasToolStripMenuItem"
        Me.OrdenDeCuentasToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.OrdenDeCuentasToolStripMenuItem.Text = "Orden de cuentas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.InventarioToolStripMenuItem.Text = "inventario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEstado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 321)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(371, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEstado
        '
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(121, 17)
        Me.lblEstado.Text = "ToolStripStatusLabel1"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 343)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Inicio"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenadorDeCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreadorDeInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenDeCuentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblEstado As ToolStripStatusLabel
End Class
