Public Class frmreporteproducto


    Private Sub frmreporteproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbpersonalDataSet.mostrar_producto' Puede moverla o quitarla según sea necesario.
        Me.mostrar_productoTableAdapter.Fill(Me.dbpersonalDataSet.mostrar_producto)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmreporteproducto_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        INICIO.Show()
    End Sub
End Class