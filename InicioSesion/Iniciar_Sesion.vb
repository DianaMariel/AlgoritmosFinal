'----------------------------------------------------
Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class Iniciar_Sesion

    '// VARIABLES PUBLICAS Y PRIVADAS
    '// VARAIBLES PUBLICAS SE UTILIZAN EN TODOS LOS FORMULARIOS
    '// VARIABLES PRIVADAS SE UTILIZAN SOLAMENTE EN EL FORMULARIO ACTUAL
    '// DECLARACION DE VARIABLES PRIVADAS: DIM, NOMBRE, AS TIPO DE DATO
    '// DECLARACION DE VARIABLES PUBLICAS: PUBLIC, NOMBRE AS TIPO DE DATO
    '// TIPOS DE VARIABLE: INTEGER, DOUBLE, STRING  

    Public Nombre_Usuario As String
    Public Correo_Usuario As String
    Public Edad_Usuario As Double
    Public Clave_Usuario As Double
    Public Sector_Usuario As String
    Public Genero_Usuario As String

    Private Sub Iniciar_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        Cbo_Usuarios.Text = "Selecciona Usuario"
        '// Cbo_Usuarios.SelectedIndex = 0 '//Comenzar con usuario seleccionario
        Me.Opacity = 0 '// El formulario no se ve por completo
        TimerAbrir.Start()
        CargarUsuarios()
    End Sub
    '------------------------------------------------------------------------------------------
    '------------------------ BOTON CERRAR , CODIGO -------------------------------------------
    '------------------------------------------------------------------------------------------
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        TimerCerrar.Start()
    End Sub
    '------------------------------------------------------------------------------------------
    '------------------------ BOTON MINIMIZAR , CODIGO ----------------------------------------
    '------------------------------------------------------------------------------------------
    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    '//**************************************************************
    '// Librerias y eventos para poder mover de lugar el formulario
    '//**************************************************************
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Iniciar_Sesion_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PanelInferior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelInferior.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        InicioSesion()

    End Sub

    Private Sub Cbo_Usuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Usuarios.SelectedIndexChanged
        Cargar_Datos_Del_Usuario()
        'If Cbo_Usuarios.Text = "Alex Vega" Then

        '    Nombre_Usuario = Cbo_Usuarios.Text
        '    Correo_Usuario = "AlexVega@gmail.com"
        '    Tipo_Usuario = "Administrador"
        '    Expediente_Usuario = 765678
        '    Pass_Usuario = "12"
        '    TxtPassword.Text = Pass_Usuario

        'ElseIf Cbo_Usuarios.Text = "Dolores Ortiz" Then

        '    Nombre_Usuario = Cbo_Usuarios.Text
        '    Correo_Usuario = "DoloresOrtiz@gmail.com"
        '    Tipo_Usuario = "Estandar"
        '    Expediente_Usuario = 987456
        '    Pass_Usuario = "123"
        '    TxtPassword.Text = Pass_Usuario

        'ElseIf Cbo_Usuarios.Text = "Linda Varela" Then

        '    Nombre_Usuario = Cbo_Usuarios.Text
        '    Correo_Usuario = "LindaVarela@outlook.com"
        '    Tipo_Usuario = "Invitado"
        '    Expediente_Usuario = 456390
        '    Pass_Usuario = "1"
        '    TxtPassword.Text = Pass_Usuario

        'End If

    End Sub
    Private Sub Cbo_Usuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbo_Usuarios.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then

            Codigo_Aceptar_Iniciar()

        End If

    End Sub

    '// PROCESOS PRIVADOS Y PUBLICOS
    '// PROCESOS PRIVADOS, SOLAMENTE SE UTILIZAN EN EL FORMULARIO ACTUAL
    '// PROCESOS PUBLICOS, SE UTILIZAN DESDE CUALQUIER FORMULARIO.
    '// DECLARACION DE PROCESOS PRIVADOS: PRIVATE SUB, NOMBRE, END SUB
    '// DECLARACION DE PROCESOS PUBLICOS: SUB, NOMBRE, END SUB

    Private Sub Codigo_Aceptar_Iniciar()

        If Cbo_Usuarios.Text = "Diana" And TxtPassword.Text = "123" Or
           Cbo_Usuarios.Text = "Goretti" And TxtPassword.Text = "123" Then

            '// Instrucciones si se cumple la condicion

            Me.Hide()
            Bienvenida.ShowDialog()
            Principal.Show()

        Else
            '------------------------------- MENSAJE DE ERROR -------------------------------
            MsgBox("Contraseña incorrecta, intenta nuevamente", MsgBoxStyle.Critical, "Login")
            '--------------------------------------------------------------------------------
            TxtPassword.Clear()
            TxtPassword.Focus()

        End If

        '// ESTRUCTURA DE UN MENSAJE DE ERROR O VENTANA EMERGENTE
        '//MSGBOX, MENSAJE(ENTRE COMILLAS DOBLES), ESTILO DE LA VENTANA, TITULO DE LA VENTANA
        '// ESTILOS: CRITICAL, OKONLY, YES/NO

    End Sub
    '// Temporizador, serie de instrucciones durante cierto tiempo.
    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick

        '// La opacidad se mide de 0 a 1

        If Me.Opacity < 1 Then '// El formulario no debe de ser visible

            Me.Opacity += 0.05

        End If

        If Me.Opacity = 1 Then '// El formulario ya es visible al 100%

            TimerAbrir.Stop()

        End If



    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick

        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then

            TimerCerrar.Stop()
            Me.Close()

        End If

    End Sub

    Private Sub CargarUsuarios()
        Try

            Dim Tabla As New DataTable
            Dim ConsultaSql As String = "SELECT Nombre FROM Usuarios"
            Dim Adaptador As New OleDbDataAdapter(ConsultaSql, Conexion)
            Adaptador.Fill(Tabla)
            Cbo_Usuarios.DataSource = Tabla
            Cbo_Usuarios.DisplayMember = "Nombre"


        Catch ex As Exception
            '----------------------------MENSAJE DE ERROR---------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '-----------------------------------------------------------------
        End Try
    End Sub

    Private Sub InicioSesion()
        Try

            Dim ConsultaSql As String
            Dim Adaptador As New OleDbDataAdapter
            Dim Comando As New OleDb.OleDbCommand
            Dim Lector As OleDb.OleDbDataReader

            ConsultaSql = "SELECT * FROM Usuarios WHERE Nombre = '" & Cbo_Usuarios.Text & "' AND Clave = '" & TxtPassword.Text & "'"
            Comando = New OleDb.OleDbCommand(ConsultaSql, Conexion)
            Adaptador.SelectCommand = Comando
            Lector = Comando.ExecuteReader

            If Lector.Read = True Then
                Me.Hide()
                Bienvenida.ShowDialog()
                Principal.Show()

            Else
                '------------------------------- MENSAJE DE ERROR -------------------------------
                MsgBox("Contraseña incorrecta, intenta nuevamente", MsgBoxStyle.Critical, "Login")
                '--------------------------------------------------------------------------------
                TxtPassword.Clear()
            End If

        Catch ex As Exception
            '----------------------------MENSAJE DE ERROR---------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '-----------------------------------------------------------------
        End Try
    End Sub

    '--------------------------------------------------------------------------
    '----------------PROCESO PARA CARGAR DATOS DEL USUARIO---------------------
    '--------------------------------------------------------------------------

    Private Sub Cargar_Datos_Del_Usuario()
        Try

            Dim ConsultaSQL As String
            Dim Adaptador As OleDbDataAdapter
            Dim Registro As DataSet
            Dim Lista As Long

            ConsultaSQL = "SELECT Nombre, Clave, Correo, Edad, Genero, Sector FROM Usuarios WHERE Nombre = '" & Cbo_Usuarios.Text & "'"
            Adaptador = New OleDbDataAdapter(ConsultaSQL, Conexion)
            Registro = New DataSet
            Adaptador.Fill(Registro, "Usuarios")
            Lista = Registro.Tables("Usuarios").Rows.Count

            If Lista <> 0 Then

                Nombre_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Nombre")
                Clave_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Clave")
                Correo_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Correo")
                Edad_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Edad")
                Genero_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Genero")
                Sector_Usuario = Registro.Tables("Usuarios").Rows(0).Item("Sector")


            End If

        Catch ex As Exception
            '----------------------------MENSAJE DE ERROR---------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '-----------------------------------------------------------------
        End Try
    End Sub

    Private Sub Bot_Mostrarcon_Click(sender As Object, e As EventArgs) Handles Bot_Mostrarcon.Click
        If TxtPassword.PasswordChar = "*" Then
            TxtPassword.PasswordChar = ""
        End If
        Bot_Mostrarcon.Hide()
        Bot_Ocultarcont.Show()
    End Sub

    Private Sub Bot_Ocultarcont_Click(sender As Object, e As EventArgs) Handles Bot_Ocultarcont.Click
        TxtPassword.PasswordChar = "*"
        Bot_Mostrarcon.Show()
        Bot_Ocultarcont.Hide()
    End Sub

    Private Sub LinkLabelRecuperar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRecuperar.LinkClicked
        Me.Hide()
        RecuperaraContra.Show()
    End Sub
End Class