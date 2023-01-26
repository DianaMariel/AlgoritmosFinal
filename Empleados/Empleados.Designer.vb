<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_last_name = New System.Windows.Forms.TextBox()
        Me.txt_hire_date = New System.Windows.Forms.TextBox()
        Me.txt_birth_date = New System.Windows.Forms.TextBox()
        Me.txt_emp_no = New System.Windows.Forms.TextBox()
        Me.LabelFiltro = New System.Windows.Forms.Label()
        Me.Cbo_Empleados = New System.Windows.Forms.ComboBox()
        Me.Labeltotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelRegistros = New System.Windows.Forms.Label()
        Me.Grid_Empleados = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Labeltipo = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_first_name = New System.Windows.Forms.TextBox()
        CType(Me.Grid_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(40, 360)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Género"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 283)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 320)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(278, 324)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Fecha de nacimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(364, 286)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Emp_no"
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(151, 358)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.ReadOnly = True
        Me.txt_gender.Size = New System.Drawing.Size(100, 20)
        Me.txt_gender.TabIndex = 66
        '
        'txt_last_name
        '
        Me.txt_last_name.Location = New System.Drawing.Point(151, 282)
        Me.txt_last_name.Name = "txt_last_name"
        Me.txt_last_name.ReadOnly = True
        Me.txt_last_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_last_name.TabIndex = 65
        '
        'txt_hire_date
        '
        Me.txt_hire_date.Location = New System.Drawing.Point(480, 360)
        Me.txt_hire_date.Name = "txt_hire_date"
        Me.txt_hire_date.ReadOnly = True
        Me.txt_hire_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_hire_date.TabIndex = 64
        '
        'txt_birth_date
        '
        Me.txt_birth_date.Location = New System.Drawing.Point(480, 322)
        Me.txt_birth_date.Name = "txt_birth_date"
        Me.txt_birth_date.ReadOnly = True
        Me.txt_birth_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_birth_date.TabIndex = 63
        '
        'txt_emp_no
        '
        Me.txt_emp_no.Location = New System.Drawing.Point(480, 285)
        Me.txt_emp_no.Name = "txt_emp_no"
        Me.txt_emp_no.ReadOnly = True
        Me.txt_emp_no.Size = New System.Drawing.Size(100, 20)
        Me.txt_emp_no.TabIndex = 62
        '
        'LabelFiltro
        '
        Me.LabelFiltro.AutoSize = True
        Me.LabelFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro.ForeColor = System.Drawing.Color.Black
        Me.LabelFiltro.Location = New System.Drawing.Point(250, 67)
        Me.LabelFiltro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFiltro.Name = "LabelFiltro"
        Me.LabelFiltro.Size = New System.Drawing.Size(141, 16)
        Me.LabelFiltro.TabIndex = 61
        Me.LabelFiltro.Text = "Seleccione el no. emp"
        '
        'Cbo_Empleados
        '
        Me.Cbo_Empleados.FormattingEnabled = True
        Me.Cbo_Empleados.Location = New System.Drawing.Point(396, 63)
        Me.Cbo_Empleados.Name = "Cbo_Empleados"
        Me.Cbo_Empleados.Size = New System.Drawing.Size(184, 21)
        Me.Cbo_Empleados.TabIndex = 60
        '
        'Labeltotal
        '
        Me.Labeltotal.AutoSize = True
        Me.Labeltotal.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotal.Location = New System.Drawing.Point(181, 70)
        Me.Labeltotal.Name = "Labeltotal"
        Me.Labeltotal.Size = New System.Drawing.Size(40, 14)
        Me.Labeltotal.TabIndex = 59
        Me.Labeltotal.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(392, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 58
        '
        'LabelRegistros
        '
        Me.LabelRegistros.AutoSize = True
        Me.LabelRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistros.ForeColor = System.Drawing.Color.Black
        Me.LabelRegistros.Location = New System.Drawing.Point(20, 67)
        Me.LabelRegistros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRegistros.Name = "LabelRegistros"
        Me.LabelRegistros.Size = New System.Drawing.Size(147, 18)
        Me.LabelRegistros.TabIndex = 57
        Me.LabelRegistros.Text = "Total de Registros"
        '
        'Grid_Empleados
        '
        Me.Grid_Empleados.AllowUserToAddRows = False
        Me.Grid_Empleados.AllowUserToResizeColumns = False
        Me.Grid_Empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid_Empleados.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Grid_Empleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Empleados.Location = New System.Drawing.Point(113, 107)
        Me.Grid_Empleados.Name = "Grid_Empleados"
        Me.Grid_Empleados.ReadOnly = True
        Me.Grid_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid_Empleados.Size = New System.Drawing.Size(544, 116)
        Me.Grid_Empleados.TabIndex = 56
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel2.Controls.Add(Me.Labeltipo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(785, 55)
        Me.Panel2.TabIndex = 55
        '
        'Labeltipo
        '
        Me.Labeltipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Labeltipo.AutoSize = True
        Me.Labeltipo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltipo.ForeColor = System.Drawing.Color.Black
        Me.Labeltipo.Location = New System.Drawing.Point(44, -25)
        Me.Labeltipo.Name = "Labeltipo"
        Me.Labeltipo.Size = New System.Drawing.Size(31, 13)
        Me.Labeltipo.TabIndex = 11
        Me.Labeltipo.Text = "Tipo"
        Me.Labeltipo.Visible = False
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Black
        Me.LabelTitulo.Location = New System.Drawing.Point(215, 19)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(115, 24)
        Me.LabelTitulo.TabIndex = 54
        Me.LabelTitulo.Text = "Empleados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(269, 361)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 16)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Fecha de contratación"
        '
        'txt_first_name
        '
        Me.txt_first_name.Location = New System.Drawing.Point(151, 321)
        Me.txt_first_name.Name = "txt_first_name"
        Me.txt_first_name.ReadOnly = True
        Me.txt_first_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_first_name.TabIndex = 72
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(785, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_first_name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.txt_last_name)
        Me.Controls.Add(Me.txt_hire_date)
        Me.Controls.Add(Me.txt_birth_date)
        Me.Controls.Add(Me.txt_emp_no)
        Me.Controls.Add(Me.LabelFiltro)
        Me.Controls.Add(Me.Cbo_Empleados)
        Me.Controls.Add(Me.Labeltotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelRegistros)
        Me.Controls.Add(Me.Grid_Empleados)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.Grid_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_last_name As TextBox
    Friend WithEvents txt_hire_date As TextBox
    Friend WithEvents txt_birth_date As TextBox
    Friend WithEvents txt_emp_no As TextBox
    Friend WithEvents LabelFiltro As Label
    Friend WithEvents Cbo_Empleados As ComboBox
    Friend WithEvents Labeltotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelRegistros As Label
    Friend WithEvents Grid_Empleados As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Labeltipo As Label
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_first_name As TextBox
End Class
