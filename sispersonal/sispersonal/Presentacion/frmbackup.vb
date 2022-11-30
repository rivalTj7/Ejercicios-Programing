Public Class frmbackup
    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Try
            Dim func As New fbackup

            If func.backupbase Then
                MessageBox.Show("Bckup generado satisfactoriamente", "Backup BD", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Bckup no se a podido generar", "Backup BD", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '  Private Sub frmbackup_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '     INICIO.Hide()

    ' End Sub

    ' Private Sub frmbackup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    INICIO.Show()
    'End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()

    End Sub
End Class