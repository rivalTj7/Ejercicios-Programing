Public Class frmingresos
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        INICIO.Show()
        Me.Hide()
    End Sub

    Private Sub btnpersonal_Click(sender As Object, e As EventArgs) Handles btnpersonal.Click
        frmpersonal.Show()
        Me.Hide()


    End Sub

    Private Sub btnproducto_Click(sender As Object, e As EventArgs) Handles btnproducto.Click
        frmproducto.Show()
        Me.Hide()
    End Sub

    Private Sub btncategoria_Click(sender As Object, e As EventArgs) Handles btncategoria.Click
        frmcategoria.Show()
        Me.Hide()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()

    End Sub
End Class