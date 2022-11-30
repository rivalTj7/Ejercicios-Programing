Imports System.Data.SqlClient

Public Class conexion
    Protected cnn As New SqlConnection
    Public idusuario As Integer
    Private connectionString As String
    Protected Sub New()
        connectionString = "data source=(local);initial catalog=dbpersonal; integrated security=true"
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function


    Protected Function conectado()
        Try
            cnn = New SqlConnection("data source=(local);initial catalog=dbpersonal; integrated security=true")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
