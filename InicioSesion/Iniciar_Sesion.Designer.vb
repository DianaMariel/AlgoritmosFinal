<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Iniciar_Sesion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Iniciar_Sesion))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Bot_Mostrarcon = New System.Windows.Forms.Button()
        Me.Bot_Ocultarcont = New System.Windows.Forms.Button()
        Me.LinkLabelRecuperar = New System.Windows.Forms.LinkLabel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Cbo_Usuarios = New System.Windows.Forms.ComboBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTitulo.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.YellowGreen
        Me.PanelTitulo.Controls.Add(Me.ButtonMinimizar)
        Me.PanelTitulo.Controls.Add(Me.ButtonSalir)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(356, 36)
        Me.PanelTitulo.TabIndex = 1
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ButtonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.ForeColor = System.Drawing.Color.White
        Me.ButtonMinimizar.Image = CType(resources.GetObject("ButtonMinimizar.Image"), System.Drawing.Image)
        Me.ButtonMinimizar.Location = New System.Drawing.Point(270, 0)
        Me.ButtonMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(40, 36)
        Me.ButtonMinimizar.TabIndex = 2
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.ForeColor = System.Drawing.Color.White
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.Location = New System.Drawing.Point(316, 0)
        Me.ButtonSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(40, 36)
        Me.ButtonSalir.TabIndex = 1
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.YellowGreen
        Me.PanelInferior.Controls.Add(Me.ButtonAceptar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 518)
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(356, 64)
        Me.PanelInferior.TabIndex = 9
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.ButtonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.ButtonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.Black
        Me.ButtonAceptar.Location = New System.Drawing.Point(214, 18)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(120, 28)
        Me.ButtonAceptar.TabIndex = 9
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'Bot_Mostrarcon
        '
        Me.Bot_Mostrarcon.BackgroundImage = CType(resources.GetObject("Bot_Mostrarcon.BackgroundImage"), System.Drawing.Image)
        Me.Bot_Mostrarcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bot_Mostrarcon.Location = New System.Drawing.Point(282, 386)
        Me.Bot_Mostrarcon.Margin = New System.Windows.Forms.Padding(4)
        Me.Bot_Mostrarcon.Name = "Bot_Mostrarcon"
        Me.Bot_Mostrarcon.Size = New System.Drawing.Size(33, 25)
        Me.Bot_Mostrarcon.TabIndex = 21
        Me.Bot_Mostrarcon.UseVisualStyleBackColor = True
        '
        'Bot_Ocultarcont
        '
        Me.Bot_Ocultarcont.BackgroundImage = CType(resources.GetObject("Bot_Ocultarcont.BackgroundImage"), System.Drawing.Image)
        Me.Bot_Ocultarcont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bot_Ocultarcont.Location = New System.Drawing.Point(281, 386)
        Me.Bot_Ocultarcont.Margin = New System.Windows.Forms.Padding(4)
        Me.Bot_Ocultarcont.Name = "Bot_Ocultarcont"
        Me.Bot_Ocultarcont.Size = New System.Drawing.Size(33, 25)
        Me.Bot_Ocultarcont.TabIndex = 20
        Me.Bot_Ocultarcont.UseVisualStyleBackColor = True
        '
        'LinkLabelRecuperar
        '
        Me.LinkLabelRecuperar.AutoSize = True
        Me.LinkLabelRecuperar.ForeColor = System.Drawing.Color.Black
        Me.LinkLabelRecuperar.LinkColor = System.Drawing.Color.Black
        Me.LinkLabelRecuperar.Location = New System.Drawing.Point(118, 445)
        Me.LinkLabelRecuperar.Name = "LinkLabelRecuperar"
        Me.LinkLabelRecuperar.Size = New System.Drawing.Size(152, 17)
        Me.LinkLabelRecuperar.TabIndex = 19
        Me.LinkLabelRecuperar.TabStop = True
        Me.LinkLabelRecuperar.Text = "Recuperar Contraseña"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(46, 386)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(269, 22)
        Me.TxtPassword.TabIndex = 18
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cbo_Usuarios
        '
        Me.Cbo_Usuarios.FormattingEnabled = True
        Me.Cbo_Usuarios.Location = New System.Drawing.Point(46, 320)
        Me.Cbo_Usuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cbo_Usuarios.Name = "Cbo_Usuarios"
        Me.Cbo_Usuarios.Size = New System.Drawing.Size(269, 24)
        Me.Cbo_Usuarios.TabIndex = 17
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelPassword.Location = New System.Drawing.Point(41, 364)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(95, 20)
        Me.LabelPassword.TabIndex = 16
        Me.LabelPassword.Text = "Contraseña"
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarios.ForeColor = System.Drawing.Color.Black
        Me.LabelUsuarios.Location = New System.Drawing.Point(41, 297)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(76, 20)
        Me.LabelUsuarios.TabIndex = 15
        Me.LabelUsuarios.Text = "Usuarios"
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Black
        Me.LabelTitulo.Location = New System.Drawing.Point(117, 260)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(124, 20)
        Me.LabelTitulo.TabIndex = 14
        Me.LabelTitulo.Text = "Iniciar Sesión"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(82, 49)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(203, 188)
        Me.PictureBoxLogo.TabIndex = 13
        Me.PictureBoxLogo.TabStop = False
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 15
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 15
        '
        'Iniciar_Sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(356, 582)
        Me.Controls.Add(Me.Bot_Mostrarcon)
        Me.Controls.Add(Me.Bot_Ocultarcont)
        Me.Controls.Add(Me.LinkLabelRecuperar)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Cbo_Usuarios)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Iniciar_Sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar_Sesion"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents PanelInferior As Panel
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Bot_Mostrarcon As Button
    Friend WithEvents Bot_Ocultarcont As Button
    Friend WithEvents LinkLabelRecuperar As LinkLabel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Cbo_Usuarios As ComboBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelUsuarios As Label
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
End Class
