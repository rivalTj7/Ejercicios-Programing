<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmingresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmingresos))
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.btnpersonal = New System.Windows.Forms.Button()
        Me.btnproducto = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncategoria
        '
        Me.btncategoria.BackColor = System.Drawing.Color.White
        Me.btncategoria.BackgroundImage = Global.sispersonal.My.Resources.Resources.Windows_Marketplace
        Me.btncategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncategoria.Location = New System.Drawing.Point(161, 90)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(109, 86)
        Me.btncategoria.TabIndex = 3
        Me.btncategoria.UseVisualStyleBackColor = False
        '
        'btnpersonal
        '
        Me.btnpersonal.BackColor = System.Drawing.Color.White
        Me.btnpersonal.BackgroundImage = Global.sispersonal.My.Resources.Resources._02ea9139401feb6921516fb12bb75061_icono_de_contacto_de_conversaci__n_personal_by_vexels
        Me.btnpersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpersonal.Location = New System.Drawing.Point(18, 90)
        Me.btnpersonal.Name = "btnpersonal"
        Me.btnpersonal.Size = New System.Drawing.Size(109, 86)
        Me.btnpersonal.TabIndex = 1
        Me.btnpersonal.UseVisualStyleBackColor = False
        '
        'btnproducto
        '
        Me.btnproducto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnproducto.BackgroundImage = Global.sispersonal.My.Resources.Resources._31351
        Me.btnproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnproducto.Location = New System.Drawing.Point(309, 90)
        Me.btnproducto.Name = "btnproducto"
        Me.btnproducto.Size = New System.Drawing.Size(120, 86)
        Me.btnproducto.TabIndex = 0
        Me.btnproducto.UseVisualStyleBackColor = False
        '
        'Cerrar
        '
        Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cerrar.Image = Global.sispersonal.My.Resources.Resources.cerrar
        Me.Cerrar.Location = New System.Drawing.Point(419, 0)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cerrar.TabIndex = 4
        Me.Cerrar.TabStop = False
        '
        'frmingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(445, 211)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.btncategoria)
        Me.Controls.Add(Me.btnpersonal)
        Me.Controls.Add(Me.btnproducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmingresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmingresos"
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnproducto As Button
    Friend WithEvents btnpersonal As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents btncategoria As Button
    Friend WithEvents Cerrar As PictureBox
End Class
