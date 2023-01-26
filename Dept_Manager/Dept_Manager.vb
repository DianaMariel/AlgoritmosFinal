Imports System.Data
Imports System.Data.OleDb

Public Class Dept_Manager
    Public emp_no As String
    Public dept_no As String
    Public from_date As String
    Public to_date As String

    Private Sub Dept_Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFiltro()
        MostrarManager()
    End Sub

    Private Sub MostrarManager()
        Try
            'VARIABLE QUE GUARDA TODA LA TABLA Y COLUMNAS DE ALUMNOS
            Dim Paquete As New DataSet
            'REALIZA LA CONSULTA DE DATOS SQL CON LA TABLA ALUMNOS
            Dim ConsultaSQL As String
            'CONECTA LA BASE DE DATOS (CONEXION) CON LA CONSULTA SQL QUE QUIERES VER.
            Dim Adaptador As New OleDbDataAdapter

            ConsultaSQL = "SELECT * FROM dept_manager"
            'CONECTA LA CONSULTA CON LA BASE DE DATOS(CONEXION)
            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            'GUARDA LA TABLA ALUMNOS EN LA VARIABLE TIPO TABLA
            Paquete.Tables.Add("dept_manager")
            'LLENA LA INFORMACION DE LA TABLA ALUMNOS EN EL PAQUETE
            Adaptador.Fill(Paquete.Tables("dept_manager"))
            'MUESTRA LA INFORMACION QUE SE PIDIO EN EL DATAGRID
            Grid_manager.DataSource = Paquete.Tables("dept_manager")
            'CONTRAR REGISTROS DEL DATAGRID,ESTAS SON LAS DOS MANERAS
            'txt_registros.Text = Grid_Alumnos.Rows.Count
            Labeltotal.Text = Grid_manager.Rows.Count

            'CAMBIA EL TAMAÑO DEFAULT DE LAS COLUMNAS
            Grid_manager.Columns("emp_no").Width = 50
            Grid_manager.Columns("dept_no").Width = 100
            Grid_manager.Columns("from_date").Width = 120
            Grid_manager.Columns("to_date").Width = 120


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
            Dim ConsultaSql As String = "SELECT emp_no FROM dept_manager"
            'CONECTA LA CONSULTA SQL CON LA CONEXION DE LA DBA
            Dim Adaptador As New OleDbDataAdapter(ConsultaSql, conexion)
            'LLENA LA INFORMACION A LA VARIABLE TABLA 
            Adaptador.Fill(Tabla)
            'MUESTRA TU INFORMACION EN EL COMBO BOX
            Cbo_dept_manager.DataSource = Tabla
            Cbo_dept_manager.DisplayMember = "emp_no"
        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CargarManager()
        Try

            Dim ConsultaSql As String
            Dim Adaptador As OleDbDataAdapter
            Dim Registro As DataSet
            Dim Lista As Long

            ConsultaSql = "Select emp_no,dept_no,from_date,to_date FROM dept_manager  WHERE emp_no = '" & Cbo_dept_manager.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSql, conexion)
            Registro = New DataSet

            Adaptador.Fill(Registro, "dept_manager")
            Lista = Registro.Tables("dept_manager").Rows.Count

            If Lista <> 0 Then

                emp_no = Registro.Tables("dept_manager").Rows(0).Item("emp_no")
                dept_no = Registro.Tables("dept_manager").Rows(0).Item("dept_no")
                from_date = Registro.Tables("dept_manager").Rows(0).Item("from_date")
                to_date = Registro.Tables("dept_manager").Rows(0).Item("to_date")


            Else

            End If

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Cbo_dept_manager_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_dept_manager.SelectedIndexChanged
        CargarManager()
        txt_emp_no.Text = emp_no
        txt_from_date.Text = from_date
        txt_dept_no.Text = dept_no
        txt_to_date.Text = to_date
    End Sub
End Class