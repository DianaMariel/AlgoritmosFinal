Imports System.Runtime.InteropServices

Public Class Bienvenida
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Iniciar_Sesion.Show()
        Me.Close()

    End Sub


    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre.Text = Iniciar_Sesion.Nombre_Usuario
        correob.Text = Iniciar_Sesion.Correo_Usuario
        LabelEdad.Text = Iniciar_Sesion.Edad_Usuario
        LabelGenero.Text = Iniciar_Sesion.Genero_Usuario
        LabelSector.Text = Iniciar_Sesion.Sector_Usuario
        Me.Opacity = 0
        BarraDeProgreso.Value = 0
        Timerabrir.Start()


    End Sub


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Bienvenida_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Timerabrir_Tick(sender As Object, e As EventArgs) Handles Timerabrir.Tick
        BarraDeProgreso.Value += 1
        cargando.Text = BarraDeProgreso.Value & "%"
        If Me.Opacity < 1 Then
            Me.Opacity += 0.5
        End If

        If BarraDeProgreso.Value = 100 Then
            Timerabrir.Stop()
            Timercerrar.Start()
        End If
    End Sub

    Private Sub Timercerrar_Tick(sender As Object, e As EventArgs) Handles Timercerrar.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timercerrar.Stop()
            Me.Close()

        End If
    End Sub

End Class