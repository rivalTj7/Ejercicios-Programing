<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class INICIO
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
        Me.components = New System.ComponentModel.Container()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.barraTitulos = New System.Windows.Forms.Panel()
        Me.btnindex = New System.Windows.Forms.PictureBox()
        Me.Minimizar2 = New System.Windows.Forms.PictureBox()
        Me.maximizar = New System.Windows.Forms.PictureBox()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnRproducto = New System.Windows.Forms.Button()
        Me.btnreportes = New System.Windows.Forms.Button()
        Me.btnsalidas = New System.Windows.Forms.Button()
        Me.panelsub1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btningresos = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblposicion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmtMostarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barraTitulos.SuspendLayout()
        CType(Me.btnindex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimizar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelsub1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.PictureBox2)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(250, 50)
        Me.panelContenedor.MinimumSize = New System.Drawing.Size(350, 200)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(950, 550)
        Me.panelContenedor.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.sispersonal.My.Resources.Resources.trofeo
        Me.PictureBox2.Location = New System.Drawing.Point(366, 142)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(260, 215)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'barraTitulos
        '
        Me.barraTitulos.BackColor = System.Drawing.Color.DodgerBlue
        Me.barraTitulos.Controls.Add(Me.btnindex)
        Me.barraTitulos.Controls.Add(Me.Minimizar2)
        Me.barraTitulos.Controls.Add(Me.maximizar)
        Me.barraTitulos.Controls.Add(Me.minimizar)
        Me.barraTitulos.Controls.Add(Me.Cerrar)
        Me.barraTitulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.barraTitulos.Location = New System.Drawing.Point(250, 0)
        Me.barraTitulos.Name = "barraTitulos"
        Me.barraTitulos.Size = New System.Drawing.Size(950, 50)
        Me.barraTitulos.TabIndex = 4
        '
        'btnindex
        '
        Me.btnindex.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnindex.Image = Global.sispersonal.My.Resources.Resources.menu_abierto
        Me.btnindex.Location = New System.Drawing.Point(6, 9)
        Me.btnindex.Name = "btnindex"
        Me.btnindex.Size = New System.Drawing.Size(35, 35)
        Me.btnindex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnindex.TabIndex = 1
        Me.btnindex.TabStop = False
        '
        'Minimizar2
        '
        Me.Minimizar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar2.Image = Global.sispersonal.My.Resources.Resources.minimizar
        Me.Minimizar2.Location = New System.Drawing.Point(860, 3)
        Me.Minimizar2.Name = "Minimizar2"
        Me.Minimizar2.Size = New System.Drawing.Size(25, 25)
        Me.Minimizar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Minimizar2.TabIndex = 2
        Me.Minimizar2.TabStop = False
        '
        'maximizar
        '
        Me.maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizar.Image = Global.sispersonal.My.Resources.Resources.expandir
        Me.maximizar.Location = New System.Drawing.Point(891, 3)
        Me.maximizar.Name = "maximizar"
        Me.maximizar.Size = New System.Drawing.Size(25, 25)
        Me.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maximizar.TabIndex = 1
        Me.maximizar.TabStop = False
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.Image = Global.sispersonal.My.Resources.Resources.copiar
        Me.minimizar.Location = New System.Drawing.Point(891, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(25, 25)
        Me.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimizar.TabIndex = 1
        Me.minimizar.TabStop = False
        Me.minimizar.Visible = False
        '
        'Cerrar
        '
        Me.Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cerrar.Image = Global.sispersonal.My.Resources.Resources.cerrar
        Me.Cerrar.Location = New System.Drawing.Point(922, 3)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cerrar.TabIndex = 0
        Me.Cerrar.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.AutoScroll = True
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.btnbackup)
        Me.MenuVertical.Controls.Add(Me.Button4)
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.btnreportes)
        Me.MenuVertical.Controls.Add(Me.btnsalidas)
        Me.MenuVertical.Controls.Add(Me.panelsub1)
        Me.MenuVertical.Controls.Add(Me.btningresos)
        Me.MenuVertical.Controls.Add(Me.PanelLogo)
        Me.MenuVertical.Controls.Add(Me.Button6)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(250, 600)
        Me.MenuVertical.TabIndex = 3
        '
        'btnbackup
        '
        Me.btnbackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnbackup.FlatAppearance.BorderSize = 0
        Me.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackup.ForeColor = System.Drawing.Color.White
        Me.btnbackup.Image = Global.sispersonal.My.Resources.Resources.icons8_restauración_de_copia_de_seguridad_en_la_nube_50
        Me.btnbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbackup.Location = New System.Drawing.Point(0, 492)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(250, 45)
        Me.btnbackup.TabIndex = 20
        Me.btnbackup.Text = "&Backup"
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.sispersonal.My.Resources.Resources.icons8_usuario_masculino_50
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 447)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(250, 45)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Control de Usuarios"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.btnRproducto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 367)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 80)
        Me.Panel3.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.sispersonal.My.Resources.Resources.icons8_estimados_50
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(0, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(250, 40)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Personal"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnRproducto
        '
        Me.btnRproducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRproducto.FlatAppearance.BorderSize = 0
        Me.btnRproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRproducto.ForeColor = System.Drawing.Color.White
        Me.btnRproducto.Image = Global.sispersonal.My.Resources.Resources.icons8_entrega_50
        Me.btnRproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRproducto.Location = New System.Drawing.Point(0, 0)
        Me.btnRproducto.Name = "btnRproducto"
        Me.btnRproducto.Size = New System.Drawing.Size(250, 40)
        Me.btnRproducto.TabIndex = 0
        Me.btnRproducto.Text = "Producto"
        Me.btnRproducto.UseVisualStyleBackColor = True
        '
        'btnreportes
        '
        Me.btnreportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnreportes.FlatAppearance.BorderSize = 0
        Me.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportes.ForeColor = System.Drawing.Color.White
        Me.btnreportes.Image = Global.sispersonal.My.Resources.Resources.icons8_crear_nuevo_50
        Me.btnreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreportes.Location = New System.Drawing.Point(0, 322)
        Me.btnreportes.Name = "btnreportes"
        Me.btnreportes.Size = New System.Drawing.Size(250, 45)
        Me.btnreportes.TabIndex = 17
        Me.btnreportes.Text = "&Reportes"
        Me.btnreportes.UseVisualStyleBackColor = True
        '
        'btnsalidas
        '
        Me.btnsalidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsalidas.FlatAppearance.BorderSize = 0
        Me.btnsalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalidas.ForeColor = System.Drawing.Color.White
        Me.btnsalidas.Image = Global.sispersonal.My.Resources.Resources.icons8_carrito_de_la_compra_cargado_50
        Me.btnsalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalidas.Location = New System.Drawing.Point(0, 277)
        Me.btnsalidas.Name = "btnsalidas"
        Me.btnsalidas.Size = New System.Drawing.Size(250, 45)
        Me.btnsalidas.TabIndex = 16
        Me.btnsalidas.Text = "&Salidas"
        Me.btnsalidas.UseVisualStyleBackColor = True
        '
        'panelsub1
        '
        Me.panelsub1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelsub1.Controls.Add(Me.Button3)
        Me.panelsub1.Controls.Add(Me.Button2)
        Me.panelsub1.Controls.Add(Me.Button1)
        Me.panelsub1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelsub1.Location = New System.Drawing.Point(0, 157)
        Me.panelsub1.Name = "panelsub1"
        Me.panelsub1.Size = New System.Drawing.Size(250, 120)
        Me.panelsub1.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.sispersonal.My.Resources.Resources.icons8_soporte_en_línea_50
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Personal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.sispersonal.My.Resources.Resources.icons8_bolsa_de_compras_50
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Productos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.sispersonal.My.Resources.Resources.icons8_billetera_50
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Categorias"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btningresos
        '
        Me.btningresos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btningresos.FlatAppearance.BorderSize = 0
        Me.btningresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btningresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresos.ForeColor = System.Drawing.Color.White
        Me.btningresos.Image = Global.sispersonal.My.Resources.Resources.icons8_agregar_a_carrito_de_compras_50
        Me.btningresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btningresos.Location = New System.Drawing.Point(0, 112)
        Me.btningresos.Name = "btningresos"
        Me.btningresos.Size = New System.Drawing.Size(250, 45)
        Me.btningresos.TabIndex = 14
        Me.btningresos.Text = "&Ingresos"
        Me.btningresos.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelLogo.Controls.Add(Me.lblemail)
        Me.PanelLogo.Controls.Add(Me.lblposicion)
        Me.PanelLogo.Controls.Add(Me.lblNombre)
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 112)
        Me.PanelLogo.TabIndex = 14
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.White
        Me.lblemail.Location = New System.Drawing.Point(74, 82)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(66, 18)
        Me.lblemail.TabIndex = 3
        Me.lblemail.Text = "Nombre:"
        '
        'lblposicion
        '
        Me.lblposicion.AutoSize = True
        Me.lblposicion.BackColor = System.Drawing.Color.Transparent
        Me.lblposicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposicion.ForeColor = System.Drawing.Color.White
        Me.lblposicion.Location = New System.Drawing.Point(74, 50)
        Me.lblposicion.Name = "lblposicion"
        Me.lblposicion.Size = New System.Drawing.Size(66, 18)
        Me.lblposicion.TabIndex = 2
        Me.lblposicion.Text = "Nombre:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(74, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 18)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sispersonal.My.Resources.Resources.Administrator
        Me.PictureBox1.Location = New System.Drawing.Point(1, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Image = Global.sispersonal.My.Resources.Resources.icons8_salir_redondeado_50
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 548)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(250, 52)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Cerrar Secion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'tmOcultarMenu
        '
        '
        'tmtMostarMenu
        '
        '
        'INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.barraTitulos)
        Me.Controls.Add(Me.MenuVertical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "INICIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelContenedor.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barraTitulos.ResumeLayout(False)
        CType(Me.btnindex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimizar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.panelsub1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelContenedor As Panel
    Friend WithEvents barraTitulos As Panel
    Friend WithEvents Minimizar2 As PictureBox
    Friend WithEvents btnindex As PictureBox
    Friend WithEvents maximizar As PictureBox
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents Cerrar As PictureBox
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmtMostarMenu As Timer
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblemail As Label
    Friend WithEvents lblposicion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents panelsub1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btningresos As Button
    Friend WithEvents btnsalidas As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnRproducto As Button
    Friend WithEvents btnreportes As Button
    Friend WithEvents btnbackup As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
