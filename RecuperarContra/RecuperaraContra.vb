Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class RecuperaraContra
    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
        Iniciar_Sesion.Show()
    End Sub

    Private Sub RecuperaraContra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '/Cbo_Usuarios.SelectedIndex = 0
        Me.Opacity = 0 '//El formulario no se ve por completo
        TimerAbrir.Start()
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

    Private Sub RecuperaraContra_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBoxLogo_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelInferior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelInferior.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TimerAbrir_Tick(sender As Object, e As EventArgs) Handles TimerAbrir.Tick
        If Me.Opacity < 1 Then '//El formulario no debe de ser visible 
            Me.Opacity += 0.05
        End If

        If Opacity = 1 Then '//El formulario ya es visible al 100%
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

    Private Sub Cbo_Usuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Usuarios.SelectedIndexChanged
        If Cbo_Usuarios.Text = "Goretti" Then
            TxtContra.Text = "gore@gmail.com"


        ElseIf Cbo_Usuarios.Text = "Diana" Then
            TxtContra.Text = "diana@gmail.com"
        End If
    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        MsgBox(" solicitud de enviada al correo: " + TxtContra.Text, MsgBoxStyle.OkOnly, "Recuperacion")
    End Sub


End Class