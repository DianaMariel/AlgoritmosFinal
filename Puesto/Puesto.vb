Imports System.Data
Imports System.Data.OleDb
Public Class Puesto
    Public emp_no As String
    Public title As String
    Public from_date As String
    Public to_date As String
    Private Sub Puesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFiltro()
        Mostrarpuesto()
    End Sub
    Private Sub Mostrarpuesto()
        Try
            'VARIABLE QUE GUARDA TODA LA TABLA Y COLUMNAS DE ALUMNOS
            Dim Paquete As New DataSet
            'REALIZA LA CONSULTA DE DATOS SQL CON LA TABLA ALUMNOS
            Dim ConsultaSQL As String
            'CONECTA LA BASE DE DATOS (CONEXION) CON LA CONSULTA SQL QUE QUIERES VER.
            Dim Adaptador As New OleDbDataAdapter

            ConsultaSQL = "SELECT * FROM titles"
            'CONECTA LA CONSULTA CON LA BASE DE DATOS(CONEXION)
            Adaptador = New OleDbDataAdapter(ConsultaSQL, conexion)
            'GUARDA LA TABLA ALUMNOS EN LA VARIABLE TIPO TABLA
            Paquete.Tables.Add("titles")
            'LLENA LA INFORMACION DE LA TABLA ALUMNOS EN EL PAQUETE
            Adaptador.Fill(Paquete.Tables("titles"))
            'MUESTRA LA INFORMACION QUE SE PIDIO EN EL DATAGRID
            Grid_Puestos.DataSource = Paquete.Tables("titles")
            'CONTRAR REGISTROS DEL DATAGRID,ESTAS SON LAS DOS MANERAS
            'txt_registros.Text = Grid_Alumnos.Rows.Count
            Labeltotal.Text = Grid_Puestos.Rows.Count

            'CAMBIA EL TAMAÑO DEFAULT DE LAS COLUMNAS
            Grid_Puestos.Columns("emp_no").Width = 50
            Grid_Puestos.Columns("title").Width = 100
            Grid_Puestos.Columns("from_date").Width = 120
            Grid_Puestos.Columns("to_date").Width = 120


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
            Dim ConsultaSql As String = "SELECT title FROM titles"
            'CONECTA LA CONSULTA SQL CON LA CONEXION DE LA DBA
            Dim Adaptador As New OleDbDataAdapter(ConsultaSql, conexion)
            'LLENA LA INFORMACION A LA VARIABLE TABLA 
            Adaptador.Fill(Tabla)
            'MUESTRA TU INFORMACION EN EL COMBO BOX
            Cbo_puesto.DataSource = Tabla
            Cbo_puesto.DisplayMember = "title"
        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CargarPuestos()
        Try

            Dim ConsultaSql As String
            Dim Adaptador As OleDbDataAdapter
            Dim Registro As DataSet
            Dim Lista As Long

            ConsultaSql = "Select emp_no,title,from_date,to_date FROM titles  WHERE title = '" & Cbo_puesto.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSql, conexion)
            Registro = New DataSet

            Adaptador.Fill(Registro, "titles")
            Lista = Registro.Tables("titles").Rows.Count

            If Lista <> 0 Then

                emp_no = Registro.Tables("titles").Rows(0).Item("emp_no")
                title = Registro.Tables("titles").Rows(0).Item("title")
                from_date = Registro.Tables("titles").Rows(0).Item("from_date")
                to_date = Registro.Tables("titles").Rows(0).Item("to_date")


            Else

            End If

        Catch ex As Exception
            '----------------------------------Mensaje de error----------------------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Cbo_puesto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_puesto.SelectedIndexChanged
        CargarPuestos()
        txt_emp_no.Text = emp_no
        txt_from_date.Text = from_date
        txt_puesto.Text = title
        txt_to_date.Text = to_date
    End Sub
End Class