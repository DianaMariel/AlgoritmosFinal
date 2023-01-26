'IMPORTAR LIBERARIAS PARA BASE DE DATOS
Imports System.Data
Imports System.Data.OleDb
Public Class Empleados

    Public emp_no As String
    Public birth_date As String
    Public first_name As String
    Public last_name As String
    Public gender As String
    Public hire_date As String

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDocentes()
        Filtrar()
    End Sub

    Private Sub MostrarDocentes()
        Try

            'VARIABLE QUE GUARDA TODA LA TABLA Y COLUMNAS DE ALUMNOS
            Dim Paquete As New DataSet
            'REALIZA LA CONSULTA DE DATOS SQL CON LA TABLA ALUMNOS
            Dim ConsultaSQL As String
            'CONECTA LA BASE DE DATOS (CONEXION) CON LA CONSULTA SQL QUE QUIERES VER.
            Dim Adaptador As New OleDbDataAdapter

            ConsultaSQL = "SELECT * FROM employees"
            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            Paquete.Tables.Add("employees")
            Adaptador.Fill(Paquete.Tables("employees"))
            Grid_Empleados.DataSource = Paquete.Tables("employees")
            Labeltotal.Text = Grid_Empleados.Rows.Count

            Grid_Empleados.Columns("emp_no").Width = 50
            Grid_Empleados.Columns("birth_date").Width = 100
            Grid_Empleados.Columns("first_name").Width = 70
            Grid_Empleados.Columns("last_name").Width = 80
            Grid_Empleados.Columns("gender").Width = 1
            Grid_Empleados.Columns("hire_date").Width = 50

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Filtrar()
        Try
            Dim Tabla As New DataTable
            Dim ConsultaSql As String = "SELECT emp_no FROM employees"
            Dim Adaptador As New OleDbDataAdapter(ConsultaSql, conexion)
            Adaptador.Fill(Tabla)
            Cbo_Empleados.DataSource = Tabla
            Cbo_Empleados.DisplayMember = "emp_no"

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CargarDatosDelEmpleado()
        Try

            Dim ConsultaSql As String
            Dim Adaptador As OleDbDataAdapter
            Dim Registro As DataSet
            Dim Lista As Long

            ConsultaSql = "Select emp_no,birth_date,first_name,last_name,gender,hire_date FROM employees WHERE emp_no = '" & Cbo_Empleados.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSql, conexion)
            Registro = New DataSet

            Adaptador.Fill(Registro, "employees")
            Lista = Registro.Tables("employees").Rows.Count

            If Lista <> 0 Then

                emp_no = Registro.Tables("employees").Rows(0).Item("emp_no")
                birth_date = Registro.Tables("employees").Rows(0).Item("birth_date")
                first_name = Registro.Tables("employees").Rows(0).Item("first_name")
                last_name = Registro.Tables("employees").Rows(0).Item("last_name")
                gender = Registro.Tables("employees").Rows(0).Item("gender")
                hire_date = Registro.Tables("employees").Rows(0).Item("hire_date")

            Else

            End If

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Cbo_Empleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Empleados.SelectedIndexChanged

        CargarDatosDelEmpleado()
        txt_birth_date.Text = birth_date
        txt_emp_no.Text = emp_no
        txt_first_name.Text = first_name
        txt_gender.Text = gender
        txt_hire_date.Text = hire_date
        txt_last_name.Text = last_name

    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs)

    End Sub
End Class