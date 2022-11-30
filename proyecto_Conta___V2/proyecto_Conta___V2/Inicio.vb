Public Class Inicio
    Private Sub IngresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarToolStripMenuItem.Click

    End Sub

    Private Sub OrdenadorDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenadorDeCuentasToolStripMenuItem.Click
        frmIngresos_Cuentas.Show()

    End Sub

    Private Sub ConsultaDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeCuentasToolStripMenuItem.Click
        Consulta.Show()

    End Sub

    Private Sub CreadorDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreadorDeInventarioToolStripMenuItem.Click
        Inventario_Ingresos.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End

    End Sub

    Private Sub OrdenDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeCuentasToolStripMenuItem.Click
        Base_de_Datos.Show()

    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Form5.Show()


    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarBasedeDatos()



    End Sub
End Class
