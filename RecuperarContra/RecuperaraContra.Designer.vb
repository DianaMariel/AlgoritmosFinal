<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecuperaraContra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecuperaraContra))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.PanelInferior = New System.Windows.Forms.Panel()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.LabelRecContra = New System.Windows.Forms.Label()
        Me.TxtContra = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.Cbo_Usuarios = New System.Windows.Forms.ComboBox()
        Me.LabelUsuarios = New System.Windows.Forms.Label()
        Me.TimerAbrir = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCerrar = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
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
        Me.PanelTitulo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(267, 29)
        Me.PanelTitulo.TabIndex = 2
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
        Me.ButtonMinimizar.Location = New System.Drawing.Point(202, 0)
        Me.ButtonMinimizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(30, 29)
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
        Me.ButtonSalir.Location = New System.Drawing.Point(237, 0)
        Me.ButtonSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(30, 29)
        Me.ButtonSalir.TabIndex = 1
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'PanelInferior
        '
        Me.PanelInferior.BackColor = System.Drawing.Color.YellowGreen
        Me.PanelInferior.Controls.Add(Me.ButtonEnviar)
        Me.PanelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInferior.Location = New System.Drawing.Point(0, 421)
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelInferior.Name = "PanelInferior"
        Me.PanelInferior.Size = New System.Drawing.Size(267, 52)
        Me.PanelInferior.TabIndex = 10
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.ButtonEnviar.FlatAppearance.BorderSize = 2
        Me.ButtonEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.ButtonEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.ButtonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnviar.ForeColor = System.Drawing.Color.Black
        Me.ButtonEnviar.Location = New System.Drawing.Point(160, 15)
        Me.ButtonEnviar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(90, 23)
        Me.ButtonEnviar.TabIndex = 9
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'LabelRecContra
        '
        Me.LabelRecContra.AutoSize = True
        Me.LabelRecContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecContra.ForeColor = System.Drawing.Color.Black
        Me.LabelRecContra.Location = New System.Drawing.Point(48, 231)
        Me.LabelRecContra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRecContra.Name = "LabelRecContra"
        Me.LabelRecContra.Size = New System.Drawing.Size(172, 17)
        Me.LabelRecContra.TabIndex = 21
        Me.LabelRecContra.Text = "Recuperar Contraseña"
        '
        'TxtContra
        '
        Me.TxtContra.Location = New System.Drawing.Point(34, 346)
        Me.TxtContra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtContra.Name = "TxtContra"
        Me.TxtContra.Size = New System.Drawing.Size(203, 20)
        Me.TxtContra.TabIndex = 20
        Me.TxtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelPassword.Location = New System.Drawing.Point(32, 318)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(51, 17)
        Me.LabelPassword.TabIndex = 19
        Me.LabelPassword.Text = "Correo"
        '
        'Cbo_Usuarios
        '
        Me.Cbo_Usuarios.FormattingEnabled = True
        Me.Cbo_Usuarios.Items.AddRange(New Object() {"Goretti", "Yovan", "Diana", "Abisai"})
        Me.Cbo_Usuarios.Location = New System.Drawing.Point(34, 284)
        Me.Cbo_Usuarios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cbo_Usuarios.Name = "Cbo_Usuarios"
        Me.Cbo_Usuarios.Size = New System.Drawing.Size(203, 21)
        Me.Cbo_Usuarios.TabIndex = 18
        '
        'LabelUsuarios
        '
        Me.LabelUsuarios.AutoSize = True
        Me.LabelUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarios.ForeColor = System.Drawing.Color.Black
        Me.LabelUsuarios.Location = New System.Drawing.Point(32, 257)
        Me.LabelUsuarios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUsuarios.Name = "LabelUsuarios"
        Me.LabelUsuarios.Size = New System.Drawing.Size(57, 17)
        Me.LabelUsuarios.TabIndex = 17
        Me.LabelUsuarios.Text = "Usuario"
        '
        'TimerAbrir
        '
        Me.TimerAbrir.Interval = 15
        '
        'TimerCerrar
        '
        Me.TimerCerrar.Interval = 15
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(68, 49)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(152, 153)
        Me.PictureBoxLogo.TabIndex = 22
        Me.PictureBoxLogo.TabStop = False
        '
        'RecuperaraContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(267, 473)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.LabelRecContra)
        Me.Controls.Add(Me.TxtContra)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.Cbo_Usuarios)
        Me.Controls.Add(Me.LabelUsuarios)
        Me.Controls.Add(Me.PanelInferior)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RecuperaraContra"
        Me.Text = "RecuperaraContra"
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
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents LabelRecContra As Label
    Friend WithEvents TxtContra As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents Cbo_Usuarios As ComboBox
    Friend WithEvents LabelUsuarios As Label
    Friend WithEvents TimerAbrir As Timer
    Friend WithEvents TimerCerrar As Timer
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
