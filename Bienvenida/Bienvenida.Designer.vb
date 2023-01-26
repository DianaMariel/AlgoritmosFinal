<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenida))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonMini = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BarraDeProgreso = New System.Windows.Forms.ProgressBar()
        Me.cargando = New System.Windows.Forms.Label()
        Me.LabelSector = New System.Windows.Forms.Label()
        Me.LabelGenero = New System.Windows.Forms.Label()
        Me.LabelEdad = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.correob = New System.Windows.Forms.Label()
        Me.bienvenidos = New System.Windows.Forms.Label()
        Me.Timerabrir = New System.Windows.Forms.Timer(Me.components)
        Me.Timercerrar = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.ButtonMini)
        Me.Panel1.Controls.Add(Me.ButtonClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 76)
        Me.Panel1.TabIndex = 2
        '
        'ButtonMini
        '
        Me.ButtonMini.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonMini.FlatAppearance.BorderSize = 0
        Me.ButtonMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.ButtonMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.ButtonMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMini.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMini.Location = New System.Drawing.Point(959, 0)
        Me.ButtonMini.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMini.Name = "ButtonMini"
        Me.ButtonMini.Size = New System.Drawing.Size(68, 76)
        Me.ButtonMini.TabIndex = 3
        Me.ButtonMini.Text = "_"
        Me.ButtonMini.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.Location = New System.Drawing.Point(1029, 0)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(68, 76)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BarraDeProgreso)
        Me.Panel2.Controls.Add(Me.cargando)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 486)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1100, 76)
        Me.Panel2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(947, 24)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BarraDeProgreso
        '
        Me.BarraDeProgreso.BackColor = System.Drawing.Color.ForestGreen
        Me.BarraDeProgreso.ForeColor = System.Drawing.Color.ForestGreen
        Me.BarraDeProgreso.Location = New System.Drawing.Point(34, 24)
        Me.BarraDeProgreso.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraDeProgreso.Name = "BarraDeProgreso"
        Me.BarraDeProgreso.Size = New System.Drawing.Size(763, 36)
        Me.BarraDeProgreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.BarraDeProgreso.TabIndex = 11
        Me.BarraDeProgreso.Value = 50
        '
        'cargando
        '
        Me.cargando.AutoSize = True
        Me.cargando.Location = New System.Drawing.Point(848, 32)
        Me.cargando.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cargando.Name = "cargando"
        Me.cargando.Size = New System.Drawing.Size(24, 17)
        Me.cargando.TabIndex = 12
        Me.cargando.Text = "10"
        '
        'LabelSector
        '
        Me.LabelSector.AutoSize = True
        Me.LabelSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSector.ForeColor = System.Drawing.Color.Black
        Me.LabelSector.Location = New System.Drawing.Point(69, 384)
        Me.LabelSector.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSector.Name = "LabelSector"
        Me.LabelSector.Size = New System.Drawing.Size(64, 20)
        Me.LabelSector.TabIndex = 21
        Me.LabelSector.Text = "Sector"
        '
        'LabelGenero
        '
        Me.LabelGenero.AutoSize = True
        Me.LabelGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenero.ForeColor = System.Drawing.Color.Black
        Me.LabelGenero.Location = New System.Drawing.Point(66, 331)
        Me.LabelGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelGenero.Name = "LabelGenero"
        Me.LabelGenero.Size = New System.Drawing.Size(70, 20)
        Me.LabelGenero.TabIndex = 20
        Me.LabelGenero.Text = "Genero"
        '
        'LabelEdad
        '
        Me.LabelEdad.AutoSize = True
        Me.LabelEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEdad.ForeColor = System.Drawing.Color.Black
        Me.LabelEdad.Location = New System.Drawing.Point(73, 281)
        Me.LabelEdad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEdad.Name = "LabelEdad"
        Me.LabelEdad.Size = New System.Drawing.Size(51, 20)
        Me.LabelEdad.TabIndex = 19
        Me.LabelEdad.Text = "Edad"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.Black
        Me.nombre.Location = New System.Drawing.Point(69, 189)
        Me.nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(74, 20)
        Me.nombre.TabIndex = 18
        Me.nombre.Text = "Nombre"
        '
        'correob
        '
        Me.correob.AutoSize = True
        Me.correob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correob.ForeColor = System.Drawing.Color.Black
        Me.correob.Location = New System.Drawing.Point(68, 237)
        Me.correob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.correob.Name = "correob"
        Me.correob.Size = New System.Drawing.Size(66, 20)
        Me.correob.TabIndex = 17
        Me.correob.Text = "Correo"
        '
        'bienvenidos
        '
        Me.bienvenidos.AutoSize = True
        Me.bienvenidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bienvenidos.ForeColor = System.Drawing.Color.Black
        Me.bienvenidos.Location = New System.Drawing.Point(116, 98)
        Me.bienvenidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bienvenidos.Name = "bienvenidos"
        Me.bienvenidos.Size = New System.Drawing.Size(375, 55)
        Me.bienvenidos.TabIndex = 16
        Me.bienvenidos.Text = "BIENVENID@S"
        '
        'Timerabrir
        '
        Me.Timerabrir.Interval = 30
        '
        'Timercerrar
        '
        Me.Timercerrar.Interval = 30
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(637, 112)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(353, 302)
        Me.PictureBoxLogo.TabIndex = 22
        Me.PictureBoxLogo.TabStop = False
        '
        'Bienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1100, 562)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.LabelSector)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelGenero)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelEdad)
        Me.Controls.Add(Me.correob)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.bienvenidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenida"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonMini As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BarraDeProgreso As ProgressBar
    Friend WithEvents cargando As Label
    Friend WithEvents LabelSector As Label
    Friend WithEvents LabelGenero As Label
    Friend WithEvents LabelEdad As Label
    Friend WithEvents nombre As Label
    Friend WithEvents correob As Label
    Friend WithEvents bienvenidos As Label
    Friend WithEvents Timerabrir As Timer
    Friend WithEvents Timercerrar As Timer
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
