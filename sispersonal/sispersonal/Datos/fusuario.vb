Imports System.Data
Imports System.Data.SqlClient

Public Class fusuario
    Inherits conexion

    Dim cmd As New SqlCommand


    Public Function Loginn(user As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()

            Using Command = New SqlCommand()
                Command.Connection = connection
                Command.CommandText = "select * from usuario where login =@login and password =@password"
                Command.Parameters.AddWithValue("@login", user)
                Command.Parameters.AddWithValue("@password", pass)
                Command.CommandType = CommandType.Text
                Dim reader = Command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.idusurio = reader.GetInt32(0)
                        ActiveUser.nombre = reader.GetString(1)
                        ActiveUser.apellido = reader.GetString(2)
                        ActiveUser.position = reader.GetString(3)
                        ActiveUser.email = reader.GetString(4)

                    End While
                    reader.Dispose()

                    Return True
                Else
                    Return False

                End If
            End Using
        End Using
    End Function


    'Public Function validar_usuario(ByVal dts As vusuario)
    ' Try
    '        conectado()
    '       cmd = New SqlCommand("validar_usuario")
    '      cmd.CommandType = CommandType.StoredProcedure
    '     cmd.Connection = cnn
    '    cmd.Parameters.AddWithValue("@login", dts.glogin)
    '   cmd.Parameters.AddWithValue("@password", dts.gpassword)


    'Dim dr As SqlDataReader
    '       dr = cmd.ExecuteReader
    '
    'If dr.HasRows = True Then
    'Return True
    'Else
    'Return False
    'End If
    '
    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'Return False
    'Finally
    '       desconectado()
    'End Try

    'End Function

End Class
