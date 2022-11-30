Public Class frmreportepersonal

    Private Sub frmreportepersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbpersonalDataSet.personal' Puede moverla o quitarla según sea necesario.
        Me.personalTableAdapter.Fill(Me.dbpersonalDataSet.personal)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmreportepersonal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        INICIO.Show()
    End Sub
End Class