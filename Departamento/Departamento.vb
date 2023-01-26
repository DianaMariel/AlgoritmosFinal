Imports System.Data
Imports System.Data.OleDb
Public Class Departamento
    Public dept_no As String
    Public name As String

    Private Sub Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFiltro()
        MostrarDepartamento()
    End Sub

    Private Sub MostrarDepartamento()
        Try
            'VARIABLE QUE GUARDA TODA LA TABLA Y COLUMNAS DE ALUMNOS
            Dim Paquete As New DataSet
            'REALIZA LA CONSULTA DE DATOS SQL CON LA TABLA ALUMNOS
            Dim ConsultaSQL As String
            'CONECTA LA BASE DE DATOS (CONEXION) CON LA CONSULTA SQL QUE QUIERES VER.
            Dim Adaptador As New OleDbDataAdapter

            ConsultaSQL = "SELECT * FROM departments"
            'CONECTA LA CONSULTA CON LA BASE DE DATOS(CONEXION)
            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            'GUARDA LA TABLA ALUMNOS EN LA VARIABLE TIPO TABLA
            Paquete.Tables.Add("departments")
            'LLENA LA INFORMACION DE LA TABLA ALUMNOS EN EL PAQUETE
            Adaptador.Fill(Paquete.Tables("departments"))
            'MUESTRA LA INFORMACION QUE SE PIDIO EN EL DATAGRID
            Grid_Departamento.DataSource = Paquete.Tables("departments")
            'CONTRAR REGISTROS DEL DATAGRID,ESTAS SON LAS DOS MANERAS
            'txt_registros.Text = Grid_Alumnos.Rows.Count
            Labeltotal.Text = Grid_Departamento.Rows.Count

            'CAMBIA EL TAMAÑO DEFAULT DE LAS COLUMNAS
            Grid_Departamento.Columns("dept_no").Width = 50
            Grid_Departamento.Columns("dept_name").Width = 100

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CargarFiltro()
        Try
            'Guarda la informacion de una columna de tu tabla
            Dim Tabla As New DataTable
            'CONSULTA PARA PEDIR LA COLUMNA FACULTAD DE LA TABLA LUMNOS
            Dim ConsultaSql As String = "SELECT dept_name FROM departments"
            'CONECTA LA CONSULTA SQL CON LA CONEXION DE LA DBA
            Dim Adaptador As New OleDbDataAdapter(ConsultaSql, conexion)
            'LLENA LA INFORMACION A LA VARIABLE TABLA 
            Adaptador.Fill(Tabla)
            'MUESTRA TU INFORMACION EN EL COMBO BOX
            Cbo_departaments.DataSource = Tabla
            Cbo_departaments.DisplayMember = "dept_name"
        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Cargardpt()
        Try

            Dim ConsultaSql As String
            Dim Adaptador As OleDbDataAdapter
            Dim Registro As DataSet
            Dim Lista As Long

            ConsultaSql = "Select dept_no,dept_name FROM departments  WHERE dept_name = '" & Cbo_departaments.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSql, conexion)
            Registro = New DataSet

            Adaptador.Fill(Registro, "departments")
            Lista = Registro.Tables("departments").Rows.Count

            If Lista <> 0 Then

                dept_no = Registro.Tables("departments").Rows(0).Item("dept_no")
                name = Registro.Tables("departments").Rows(0).Item("dept_name")



            Else

            End If

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Cbo_departaments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_departaments.SelectedIndexChanged
        Cargardpt()
        txt_dpt.Text = name
        txt_dept_no.Text = dept_no
    End Sub
End Class