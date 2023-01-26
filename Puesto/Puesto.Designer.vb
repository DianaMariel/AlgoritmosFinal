<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puesto
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
        Me.Grid_Puestos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_puesto = New System.Windows.Forms.TextBox()
        Me.txt_to_date = New System.Windows.Forms.TextBox()
        Me.txt_from_date = New System.Windows.Forms.TextBox()
        Me.txt_emp_no = New System.Windows.Forms.TextBox()
        Me.LabelFiltro = New System.Windows.Forms.Label()
        Me.Cbo_puesto = New System.Windows.Forms.ComboBox()
        Me.Labeltotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelRegistros = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Labelexpediente = New System.Windows.Forms.Label()
        Me.Labeltipo = New System.Windows.Forms.Label()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        CType(Me.Grid_Puestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid_Puestos
        '
        Me.Grid_Puestos.AllowUserToAddRows = False
        Me.Grid_Puestos.AllowUserToResizeColumns = False
        Me.Grid_Puestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid_Puestos.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.Grid_Puestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grid_Puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Puestos.GridColor = System.Drawing.Color.LemonChiffon
        Me.Grid_Puestos.Location = New System.Drawing.Point(93, 251)
        Me.Grid_Puestos.Name = "Grid_Puestos"
        Me.Grid_Puestos.ReadOnly = True
        Me.Grid_Puestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid_Puestos.Size = New System.Drawing.Size(544, 116)
        Me.Grid_Puestos.TabIndex = 123
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(367, 204)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Fecha final" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(77, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Puesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(337, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Fecha de inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 203)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Emp_no"
        '
        'txt_puesto
        '
        Me.txt_puesto.Location = New System.Drawing.Point(178, 161)
        Me.txt_puesto.Name = "txt_puesto"
        Me.txt_puesto.ReadOnly = True
        Me.txt_puesto.Size = New System.Drawing.Size(100, 20)
        Me.txt_puesto.TabIndex = 118
        '
        'txt_to_date
        '
        Me.txt_to_date.Location = New System.Drawing.Point(494, 203)
        Me.txt_to_date.Name = "txt_to_date"
        Me.txt_to_date.ReadOnly = True
        Me.txt_to_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_to_date.TabIndex = 117
        '
        'txt_from_date
        '
        Me.txt_from_date.Location = New System.Drawing.Point(494, 162)
        Me.txt_from_date.Name = "txt_from_date"
        Me.txt_from_date.ReadOnly = True
        Me.txt_from_date.Size = New System.Drawing.Size(100, 20)
        Me.txt_from_date.TabIndex = 116
        '
        'txt_emp_no
        '
        Me.txt_emp_no.Location = New System.Drawing.Point(178, 202)
        Me.txt_emp_no.Name = "txt_emp_no"
        Me.txt_emp_no.ReadOnly = True
        Me.txt_emp_no.Size = New System.Drawing.Size(100, 20)
        Me.txt_emp_no.TabIndex = 115
        '
        'LabelFiltro
        '
        Me.LabelFiltro.AutoSize = True
        Me.LabelFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFiltro.ForeColor = System.Drawing.Color.Black
        Me.LabelFiltro.Location = New System.Drawing.Point(35, 111)
        Me.LabelFiltro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFiltro.Name = "LabelFiltro"
        Me.LabelFiltro.Size = New System.Drawing.Size(120, 16)
        Me.LabelFiltro.TabIndex = 114
        Me.LabelFiltro.Text = "Seleccione puesto"
        '
        'Cbo_puesto
        '
        Me.Cbo_puesto.FormattingEnabled = True
        Me.Cbo_puesto.Location = New System.Drawing.Point(233, 106)
        Me.Cbo_puesto.Name = "Cbo_puesto"
        Me.Cbo_puesto.Size = New System.Drawing.Size(184, 21)
        Me.Cbo_puesto.TabIndex = 113
        '
        'Labeltotal
        '
        Me.Labeltotal.AutoSize = True
        Me.Labeltotal.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltotal.Location = New System.Drawing.Point(186, 72)
        Me.Labeltotal.Name = "Labeltotal"
        Me.Labeltotal.Size = New System.Drawing.Size(40, 14)
        Me.Labeltotal.TabIndex = 112
        Me.Labeltotal.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(200, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 111
        '
        'LabelRegistros
        '
        Me.LabelRegistros.AutoSize = True
        Me.LabelRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistros.ForeColor = System.Drawing.Color.Black
        Me.LabelRegistros.Location = New System.Drawing.Point(34, 69)
        Me.LabelRegistros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRegistros.Name = "LabelRegistros"
        Me.LabelRegistros.Size = New System.Drawing.Size(147, 18)
        Me.LabelRegistros.TabIndex = 110
        Me.LabelRegistros.Text = "Total de Registros"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel2.Controls.Add(Me.Labelexpediente)
        Me.Panel2.Controls.Add(Me.Labeltipo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 55)
        Me.Panel2.TabIndex = 109
        '
        'Labelexpediente
        '
        Me.Labelexpediente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Labelexpediente.AutoSize = True
        Me.Labelexpediente.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelexpediente.ForeColor = System.Drawing.Color.Black
        Me.Labelexpediente.Location = New System.Drawing.Point(44, -55)
        Me.Labelexpediente.Name = "Labelexpediente"
        Me.Labelexpediente.Size = New System.Drawing.Size(70, 13)
        Me.Labelexpediente.TabIndex = 12
        Me.Labelexpediente.Text = "Expediente"
        Me.Labelexpediente.Visible = False
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
        Me.LabelTitulo.Location = New System.Drawing.Point(215, 5)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(74, 24)
        Me.LabelTitulo.TabIndex = 108
        Me.LabelTitulo.Text = "Puesto"
        '
        'Puesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Grid_Puestos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_puesto)
        Me.Controls.Add(Me.txt_to_date)
        Me.Controls.Add(Me.txt_from_date)
        Me.Controls.Add(Me.txt_emp_no)
        Me.Controls.Add(Me.LabelFiltro)
        Me.Controls.Add(Me.Cbo_puesto)
        Me.Controls.Add(Me.Labeltotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelRegistros)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Puesto"
        Me.Text = "Puesto"
        CType(Me.Grid_Puestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grid_Puestos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_puesto As TextBox
    Friend WithEvents txt_to_date As TextBox
    Friend WithEvents txt_from_date As TextBox
    Friend WithEvents txt_emp_no As TextBox
    Friend WithEvents LabelFiltro As Label
    Friend WithEvents Cbo_puesto As ComboBox
    Friend WithEvents Labeltotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelRegistros As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Labelexpediente As Label
    Friend WithEvents Labeltipo As Label
    Friend WithEvents LabelTitulo As Label
End Class
