'-------------------------------------------------------
'-------------- Se importan librerias para movimientos y diseño ----
'------------------------------------------------------------
Imports System.Runtime.InteropServices

Public Class Principal
    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles Maximizar.Click
        MaximizarAR()
    End Sub
    Dim LocalizacionX As Integer
    Dim LocalizacionY As Integer
    Dim TamañoAnchura As Integer
    Dim TamañoAltura As Integer

    Private Sub MaximizarAR()

        LocalizacionX = Me.Location.X
        LocalizacionY = Me.Location.Y
        TamañoAnchura = Me.Size.Width
        TamañoAltura = Me.Size.Height

        Maximizar.Visible = False
        Restaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub Restaurar_Click(sender As Object, e As EventArgs) Handles Restaurar.Click
        Me.Size = New Size(TamañoAnchura, TamañoAltura)
        Me.Location = New Point(LocalizacionX, LocalizacionY)

        Maximizar.Visible = True
        Restaurar.Visible = False
    End Sub

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Application.Exit()
    End Sub

    Private Sub Regresar_Colores_Originales()
        Button_Empleados.FlatAppearance.BorderSize = 0
        Button_Inicio.FlatAppearance.BorderColor = Color.Gray

        Button_departamento.FlatAppearance.BorderSize = 0
        Button_Inicio.FlatAppearance.BorderColor = Color.Gray

        Button_dept_emp.FlatAppearance.BorderSize = 0
        Button_Inicio.FlatAppearance.BorderColor = Color.Gray

        Button_dept_manager.FlatAppearance.BorderSize = 0
        Button_Inicio.FlatAppearance.BorderColor = Color.Gray

        Button_Puesto.FlatAppearance.BorderSize = 0
        Button_Inicio.FlatAppearance.BorderColor = Color.Gray

        Button_Salarios.FlatAppearance.BorderSize = 0
        Button_Inicio.FlatAppearance.BorderColor = Color.Gray
    End Sub

    '//PARA ABRIR UN FORMULARIO DENTRO DEL PANEL CONTENEDOR
    '-------------------------------------------------------

    Dim FormularioActivo As Form = Nothing
    Sub Abrir_Formulario_Panel_contenedor(ByVal FormularioHijo As Form)

        If FormularioActivo IsNot Nothing Then '//si existe algo abierto
            FormularioActivo.Close()

        End If

        FormularioActivo = FormularioHijo '//El formulario secundario pasa a ser el principal o activo
        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        Panel_Contenedor.Controls.Add(FormularioHijo) '/Aqui agrega al formulario seleccionado para
        Panel_Contenedor.Tag = FormularioHijo '//Permite interaccion entre todos los formularios y paneles
        FormularioHijo.BringToFront() '//Envia el formulario seleccionado al frente
        FormularioHijo.Show()


    End Sub

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick
        Label_Hora.Text = DateTime.Now.ToString("HH:mm:ss")
        Label_fecha.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub Button_Empleados_Click(sender As Object, e As EventArgs) Handles Button_Empleados.Click
        Regresar_Colores_Originales()
        Abrir_Formulario_Panel_contenedor(New Empleados)
        Button_Empleados.FlatAppearance.BorderSize = 1
        Button_Empleados.FlatAppearance.BorderColor = Color.DimGray
    End Sub

    Private Sub Button_Salarios_Click(sender As Object, e As EventArgs) Handles Button_Salarios.Click
        Regresar_Colores_Originales()
        Abrir_Formulario_Panel_contenedor(New Salarios)
        Button_Empleados.FlatAppearance.BorderSize = 1
        Button_Empleados.FlatAppearance.BorderColor = Color.DimGray
    End Sub

    Private Sub Button_dept_emp_Click(sender As Object, e As EventArgs) Handles Button_dept_emp.Click
        Regresar_Colores_Originales()
        Abrir_Formulario_Panel_contenedor(New Dept_Empleados)
        Button_Empleados.FlatAppearance.BorderSize = 1
        Button_Empleados.FlatAppearance.BorderColor = Color.DimGray
    End Sub

    Private Sub Button_dept_manager_Click(sender As Object, e As EventArgs) Handles Button_dept_manager.Click
        Regresar_Colores_Originales()
        Abrir_Formulario_Panel_contenedor(New Dept_Manager)
        Button_Empleados.FlatAppearance.BorderSize = 1
        Button_Empleados.FlatAppearance.BorderColor = Color.DimGray
    End Sub

    Private Sub Button_Puesto_Click(sender As Object, e As EventArgs) Handles Button_Puesto.Click
        Regresar_Colores_Originales()
        Abrir_Formulario_Panel_contenedor(New Puesto)
        Button_Empleados.FlatAppearance.BorderSize = 1
        Button_Empleados.FlatAppearance.BorderColor = Color.DimGray
    End Sub

    Private Sub Button_departamento_Click(sender As Object, e As EventArgs) Handles Button_departamento.Click
        Regresar_Colores_Originales()
        Abrir_Formulario_Panel_contenedor(New Departamento)
        Button_Empleados.FlatAppearance.BorderSize = 1
        Button_Empleados.FlatAppearance.BorderColor = Color.DimGray
    End Sub

    Private Sub Bot_salir_Click(sender As Object, e As EventArgs) Handles Bot_salir.Click
        Me.Close()
        Iniciar_Sesion.Show()
    End Sub

    Private Sub Button_Inicio_Click(sender As Object, e As EventArgs) Handles Button_Inicio.Click
        Regresar_Colores_Originales()
        Button_Inicio.FlatAppearance.BorderSize = 1
        Button_Inicio.FlatAppearance.BorderColor = Color.DimGray
        If FormularioActivo IsNot Nothing Then '//si existe algo abierto
            FormularioActivo.Close()

        End If
    End Sub

    Private Sub Panel_Contenedor_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Contenedor.Paint

    End Sub
End Class