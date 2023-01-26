'// IMPORTAR LINRERIAS PARA CONEXCION A KA DBA
Imports System.Data
Imports System.Data.OleDb

Module Conexion_Base
    Dim Ruta As String = Application.StartupPath '//GUARDA LA RUTA HASTA LA CARPETA DEBUG

    '//VARIABLE QUE REALICE LA CONEXION
    Public conexion As New OleDbConnection

    Sub enlace()

        Try

            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & vbLf &
            Ruta + "\Recursos\Principal.accdb"
            conexion.Open()

        Catch ex As Exception
            '----------------------------MENSAJE DE ERROR---------------------
            MsgBox("Error de operación: " & ex.Message, MsgBoxStyle.Critical)
            '-----------------------------------------------------------------
        End Try

    End Sub

End Module
