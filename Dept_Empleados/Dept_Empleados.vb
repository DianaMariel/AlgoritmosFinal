Imports System.Data
Imports System.Data.OleDb

Public Class Dept_Empleados
    Public emp_no As String
    Public dept_no As String
    Public from_date As String
    Public to_date As String

    Private Sub Dept_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Filtrar()
    End Sub

    Private Sub Mostrar_dept_emp()
        Try

            'VARIABLE QUE GUARDA TODA LA TABLA Y COLUMNAS DE ALUMNOS
            Dim Paquete As New DataSet
            'REALIZA LA CONSULTA DE DATOS SQL CON LA TABLA ALUMNOS
            Dim ConsultaSQL As String
            'CONECTA LA BASE DE DATOS (CONEXION) CON LA CONSULTA SQL QUE QUIERES VER.
            Dim Adaptador As New OleDbDataAdapter

            ConsultaSQL = "SELECT * FROM dept_emp"
            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            Paquete.Tables.Add("dept_emp")
            Adaptador.Fill(Paquete.Tables("dept_emp"))
            Grid_dept_emp.DataSource = Paquete.Tables("dept_emp")
            Labeltotal.Text = Grid_dept_emp.Rows.Count

            Grid_dept_emp.Columns("emp_no").Width = 50
            Grid_dept_emp.Columns("dept_no").Width = 100
            Grid_dept_emp.Columns("from_date").Width = 70
            Grid_dept_emp.Columns("to_date").Width = 80


        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub Filtrar()
        Try
            Dim Tabla As New DataTable
            Dim ConsultaSql As String = "SELECT from_date FROM dept_emp"
            Dim Adaptador As New OleDbDataAdapter(ConsultaSql, conexion)
            Adaptador.Fill(Tabla)
            Cbo_dept_empleados.DataSource = Tabla
            Cbo_dept_empleados.DisplayMember = "from_date"

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

            ConsultaSql = "Select emp_no,dept_no,from_date,to_date FROM dept_emp WHERE from_date = '" & Cbo_dept_empleados.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSql, conexion)
            Registro = New DataSet

            Adaptador.Fill(Registro, "dept_emp")
            Lista = Registro.Tables("dept_emp").Rows.Count

            If Lista <> 0 Then

                emp_no = Registro.Tables("dept_emp").Rows(0).Item("emp_no")
                dept_no = Registro.Tables("dept_emp").Rows(0).Item("dept_no")
                from_date = Registro.Tables("dept_emp").Rows(0).Item("from_date")
                to_date = Registro.Tables("dept_emp").Rows(0).Item("to_date")


            Else

            End If

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Cbo_dept_empleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_dept_empleados.SelectedIndexChanged
        CargarDatosDelEmpleado()
        txt_emp_no.Text = emp_no
        txt_from_date.Text = from_date
        txt_dept_no.Text = dept_no
        txt_to_date.Text = to_date

    End Sub
End Class