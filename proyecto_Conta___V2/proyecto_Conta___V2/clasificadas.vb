Public Class Form5
    Private cuenta(100) As String
    Private i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        queTipo()

        If buscarTodo("Cuentas") Then
            While (tblDatos.Read)
                grdCuentas.Rows.Add(tblDatos(0), tblDatos(2))
                cuenta(i) = tblDatos(0)
                i = i + 1
            End While
        Else
            MsgBox("no hay registros aun")
        End If
        'no olvide cerrar el datareader
        tblDatos.Close()

    End Sub

    Private Sub queTipo()
        Dim j As Integer
        Dim sqlstr As String

        For j = 0 To i - 1 Step 1
            sqlstr = "select * from Cuentas where Cuenta =" + "'" + cuenta(j) + "'"
            If buscarSql(sqlstr) Then
                tblDatos.Read()
                If (tblDatos(2) = "Activo") Then
                    grdCuentas.Rows.Add(tblDatos(0), tblDatos(2))
                ElseIf (tblDatos(2) = "Pasivo") Then
                    grdCuentas.Rows.Add(tblDatos(0), "x", tblDatos(2))
                End If

            End If
        Next
        tblDatos.Close()
    End Sub
End Class