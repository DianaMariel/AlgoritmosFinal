<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.PanelBarraDeTitulo = New System.Windows.Forms.Panel()
        Me.Maximizar = New System.Windows.Forms.Button()
        Me.Restaurar = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.BotonCerrar = New System.Windows.Forms.Button()
        Me.Label_fecha = New System.Windows.Forms.Label()
        Me.Label_Hora = New System.Windows.Forms.Label()
        Me.Panel_lateral = New System.Windows.Forms.Panel()
        Me.Button_departamento = New System.Windows.Forms.Button()
        Me.Button_Puesto = New System.Windows.Forms.Button()
        Me.Button_dept_manager = New System.Windows.Forms.Button()
        Me.Bot_salir = New System.Windows.Forms.Button()
        Me.Button_dept_emp = New System.Windows.Forms.Button()
        Me.Button_Salarios = New System.Windows.Forms.Button()
        Me.Button_Empleados = New System.Windows.Forms.Button()
        Me.Button_Inicio = New System.Windows.Forms.Button()
        Me.Panel_logo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Contenedor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarraDeTitulo.SuspendLayout()
        Me.Panel_lateral.SuspendLayout()
        Me.Panel_logo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Contenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraDeTitulo
        '
        Me.PanelBarraDeTitulo.BackColor = System.Drawing.Color.YellowGreen
        Me.PanelBarraDeTitulo.Controls.Add(Me.Maximizar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.Restaurar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.Minimizar)
        Me.PanelBarraDeTitulo.Controls.Add(Me.BotonCerrar)
        Me.PanelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraDeTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraDeTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBarraDeTitulo.Name = "PanelBarraDeTitulo"
        Me.PanelBarraDeTitulo.Size = New System.Drawing.Size(825, 54)
        Me.PanelBarraDeTitulo.TabIndex = 1
        '
        'Maximizar
        '
        Me.Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximizar.BackColor = System.Drawing.Color.YellowGreen
        Me.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Maximizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maximizar.ForeColor = System.Drawing.Color.Black
        Me.Maximizar.Location = New System.Drawing.Point(754, 0)
        Me.Maximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Maximizar.Name = "Maximizar"
        Me.Maximizar.Size = New System.Drawing.Size(38, 54)
        Me.Maximizar.TabIndex = 5
        Me.Maximizar.Text = "Max"
        Me.Maximizar.UseVisualStyleBackColor = False
        '
        'Restaurar
        '
        Me.Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Restaurar.BackColor = System.Drawing.Color.YellowGreen
        Me.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Restaurar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Restaurar.ForeColor = System.Drawing.Color.Black
        Me.Restaurar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Restaurar.Location = New System.Drawing.Point(754, 0)
        Me.Restaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.Restaurar.Name = "Restaurar"
        Me.Restaurar.Size = New System.Drawing.Size(38, 54)
        Me.Restaurar.TabIndex = 4
        Me.Restaurar.Text = "R"
        Me.Restaurar.UseVisualStyleBackColor = False
        Me.Restaurar.Visible = False
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar.BackColor = System.Drawing.Color.YellowGreen
        Me.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizar.ForeColor = System.Drawing.Color.Black
        Me.Minimizar.Location = New System.Drawing.Point(723, 0)
        Me.Minimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(38, 54)
        Me.Minimizar.TabIndex = 6
        Me.Minimizar.Text = "Min"
        Me.Minimizar.UseVisualStyleBackColor = False
        '
        'BotonCerrar
        '
        Me.BotonCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonCerrar.BackColor = System.Drawing.Color.YellowGreen
        Me.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen
        Me.BotonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BotonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCerrar.ForeColor = System.Drawing.Color.Black
        Me.BotonCerrar.Location = New System.Drawing.Point(788, 0)
        Me.BotonCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BotonCerrar.Name = "BotonCerrar"
        Me.BotonCerrar.Size = New System.Drawing.Size(38, 54)
        Me.BotonCerrar.TabIndex = 3
        Me.BotonCerrar.Text = "X"
        Me.BotonCerrar.UseVisualStyleBackColor = False
        '
        'Label_fecha
        '
        Me.Label_fecha.AutoSize = True
        Me.Label_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_fecha.ForeColor = System.Drawing.Color.Black
        Me.Label_fecha.Location = New System.Drawing.Point(346, 289)
        Me.Label_fecha.Name = "Label_fecha"
        Me.Label_fecha.Size = New System.Drawing.Size(342, 24)
        Me.Label_fecha.TabIndex = 15
        Me.Label_fecha.Text = "Domingo 05 de septiembre de 2021"
        '
        'Label_Hora
        '
        Me.Label_Hora.AutoSize = True
        Me.Label_Hora.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Hora.ForeColor = System.Drawing.Color.Black
        Me.Label_Hora.Location = New System.Drawing.Point(452, 247)
        Me.Label_Hora.Name = "Label_Hora"
        Me.Label_Hora.Size = New System.Drawing.Size(88, 24)
        Me.Label_Hora.TabIndex = 14
        Me.Label_Hora.Text = "00:00:00"
        '
        'Panel_lateral
        '
        Me.Panel_lateral.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel_lateral.Controls.Add(Me.Button_departamento)
        Me.Panel_lateral.Controls.Add(Me.Button_Puesto)
        Me.Panel_lateral.Controls.Add(Me.Button_dept_manager)
        Me.Panel_lateral.Controls.Add(Me.Bot_salir)
        Me.Panel_lateral.Controls.Add(Me.Button_dept_emp)
        Me.Panel_lateral.Controls.Add(Me.Button_Salarios)
        Me.Panel_lateral.Controls.Add(Me.Button_Empleados)
        Me.Panel_lateral.Controls.Add(Me.Button_Inicio)
        Me.Panel_lateral.Controls.Add(Me.Panel_logo)
        Me.Panel_lateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_lateral.Location = New System.Drawing.Point(0, 54)
        Me.Panel_lateral.Name = "Panel_lateral"
        Me.Panel_lateral.Size = New System.Drawing.Size(162, 490)
        Me.Panel_lateral.TabIndex = 16
        '
        'Button_departamento
        '
        Me.Button_departamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_departamento.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_departamento.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_departamento.FlatAppearance.BorderSize = 0
        Me.Button_departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_departamento.Location = New System.Drawing.Point(0, 284)
        Me.Button_departamento.Name = "Button_departamento"
        Me.Button_departamento.Size = New System.Drawing.Size(162, 23)
        Me.Button_departamento.TabIndex = 16
        Me.Button_departamento.Text = "Departamento"
        Me.Button_departamento.UseVisualStyleBackColor = True
        '
        'Button_Puesto
        '
        Me.Button_Puesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Puesto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Puesto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Puesto.FlatAppearance.BorderSize = 0
        Me.Button_Puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Puesto.Location = New System.Drawing.Point(0, 261)
        Me.Button_Puesto.Name = "Button_Puesto"
        Me.Button_Puesto.Size = New System.Drawing.Size(162, 23)
        Me.Button_Puesto.TabIndex = 15
        Me.Button_Puesto.Text = "Puesto"
        Me.Button_Puesto.UseVisualStyleBackColor = True
        '
        'Button_dept_manager
        '
        Me.Button_dept_manager.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_dept_manager.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_dept_manager.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_dept_manager.FlatAppearance.BorderSize = 0
        Me.Button_dept_manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_dept_manager.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_dept_manager.Location = New System.Drawing.Point(0, 238)
        Me.Button_dept_manager.Name = "Button_dept_manager"
        Me.Button_dept_manager.Size = New System.Drawing.Size(162, 23)
        Me.Button_dept_manager.TabIndex = 14
        Me.Button_dept_manager.Text = "Dept Manager"
        Me.Button_dept_manager.UseVisualStyleBackColor = True
        '
        'Bot_salir
        '
        Me.Bot_salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_salir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Bot_salir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bot_salir.FlatAppearance.BorderSize = 0
        Me.Bot_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_salir.Location = New System.Drawing.Point(0, 467)
        Me.Bot_salir.Name = "Bot_salir"
        Me.Bot_salir.Size = New System.Drawing.Size(162, 23)
        Me.Bot_salir.TabIndex = 13
        Me.Bot_salir.Text = "Salir"
        Me.Bot_salir.UseVisualStyleBackColor = True
        '
        'Button_dept_emp
        '
        Me.Button_dept_emp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_dept_emp.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_dept_emp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_dept_emp.FlatAppearance.BorderSize = 0
        Me.Button_dept_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_dept_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_dept_emp.Location = New System.Drawing.Point(0, 215)
        Me.Button_dept_emp.Name = "Button_dept_emp"
        Me.Button_dept_emp.Size = New System.Drawing.Size(162, 23)
        Me.Button_dept_emp.TabIndex = 10
        Me.Button_dept_emp.Text = "Dept Empleados"
        Me.Button_dept_emp.UseVisualStyleBackColor = True
        '
        'Button_Salarios
        '
        Me.Button_Salarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Salarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Salarios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Salarios.FlatAppearance.BorderSize = 0
        Me.Button_Salarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Salarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Salarios.Location = New System.Drawing.Point(0, 192)
        Me.Button_Salarios.Name = "Button_Salarios"
        Me.Button_Salarios.Size = New System.Drawing.Size(162, 23)
        Me.Button_Salarios.TabIndex = 9
        Me.Button_Salarios.Text = "Salarios"
        Me.Button_Salarios.UseVisualStyleBackColor = True
        '
        'Button_Empleados
        '
        Me.Button_Empleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Empleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button_Empleados.FlatAppearance.BorderSize = 0
        Me.Button_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Empleados.Location = New System.Drawing.Point(0, 169)
        Me.Button_Empleados.Name = "Button_Empleados"
        Me.Button_Empleados.Size = New System.Drawing.Size(162, 23)
        Me.Button_Empleados.TabIndex = 8
        Me.Button_Empleados.Text = "Empleados"
        Me.Button_Empleados.UseVisualStyleBackColor = True
        '
        'Button_Inicio
        '
        Me.Button_Inicio.BackColor = System.Drawing.Color.Transparent
        Me.Button_Inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Inicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button_Inicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Inicio.FlatAppearance.BorderSize = 0
        Me.Button_Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Inicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Inicio.Location = New System.Drawing.Point(0, 146)
        Me.Button_Inicio.Name = "Button_Inicio"
        Me.Button_Inicio.Size = New System.Drawing.Size(162, 23)
        Me.Button_Inicio.TabIndex = 7
        Me.Button_Inicio.Text = "Inicio"
        Me.Button_Inicio.UseVisualStyleBackColor = False
        '
        'Panel_logo
        '
        Me.Panel_logo.Controls.Add(Me.PictureBox1)
        Me.Panel_logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_logo.Name = "Panel_logo"
        Me.Panel_logo.Size = New System.Drawing.Size(162, 146)
        Me.Panel_logo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel_Contenedor
        '
        Me.Panel_Contenedor.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel_Contenedor.Controls.Add(Me.Label1)
        Me.Panel_Contenedor.Controls.Add(Me.Label2)
        Me.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Contenedor.Location = New System.Drawing.Point(162, 54)
        Me.Panel_Contenedor.Name = "Panel_Contenedor"
        Me.Panel_Contenedor.Size = New System.Drawing.Size(663, 490)
        Me.Panel_Contenedor.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(188, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Domingo 05 de septiembre de 2021"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(294, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "00:00:00"
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(825, 544)
        Me.Controls.Add(Me.Panel_Contenedor)
        Me.Controls.Add(Me.Panel_lateral)
        Me.Controls.Add(Me.Label_fecha)
        Me.Controls.Add(Me.Label_Hora)
        Me.Controls.Add(Me.PanelBarraDeTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.PanelBarraDeTitulo.ResumeLayout(False)
        Me.Panel_lateral.ResumeLayout(False)
        Me.Panel_logo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Contenedor.ResumeLayout(False)
        Me.Panel_Contenedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBarraDeTitulo As Panel
    Friend WithEvents Minimizar As Button
    Friend WithEvents Maximizar As Button
    Friend WithEvents Restaurar As Button
    Friend WithEvents BotonCerrar As Button
    Friend WithEvents Label_fecha As Label
    Friend WithEvents Label_Hora As Label
    Friend WithEvents Panel_lateral As Panel
    Friend WithEvents Button_departamento As Button
    Friend WithEvents Button_Puesto As Button
    Friend WithEvents Button_dept_manager As Button
    Friend WithEvents Bot_salir As Button
    Friend WithEvents Button_dept_emp As Button
    Friend WithEvents Button_Salarios As Button
    Friend WithEvents Button_Empleados As Button
    Friend WithEvents Button_Inicio As Button
    Friend WithEvents Panel_logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel_Contenedor As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TimerHora As Timer
End Class
