Public Class frmIngresos_Cuentas
    Public pos As Integer = 0

    Private Sub frmIngresos_Cuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEstado.Text = "cuentas registradas" + Str(pos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qtabla As String
        Dim columnas As String
        Dim valores As String
        Dim guardo As Boolean
        Dim strsql As String
        Dim Cuenta As String
        Dim no As Integer
        Dim cu As String
        Dim Monto As String
        Dim tipo As String

        'numericos se leen como textos
        ' textos

        Cuenta = "'" + txtBuscar.Text + "'"
        Monto = "'" + txtvalor.Text + "'"
        tipo = "'" + lblTipo.Text + "'"

        qtabla = "Cuentas"
        columnas = "Cuenta,Cantidad,Tipo"
        valores = Cuenta + "," + Monto + "," + tipo
        If guardar(qtabla, columnas, valores) Then
            guardo = True
        End If
        Button1.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nuevoCodigo As Integer
        nuevoCodigo = mayor("Cuentas", "Cuenta") + 1
        lblEstado.Text = nuevoCodigo
        txtBuscar.Focus()
        limpiarTextos()
        Button1.Enabled = True
        Button4.Enabled = False
    End Sub
    Public Sub limpiarTextos()
        txtBuscar.Clear()
        txtvalor.Clear()

    End Sub



    Private Sub txtBuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyUp
        Dim strsql As String
        Dim no As Integer
        Dim cu As String
        Dim cuenta As String

        cuenta = txtBuscar.Text

        If e.KeyCode = Keys.Enter Then

            strsql = "select * from Lcuentas where Cuenta = " + "'" + cuenta + "'"

            If buscarSql(strsql) Then
                If tblDatos.HasRows Then
                    tblDatos.Read()


                    cu = tblDatos(0)
                    lblTipo.Text = tblDatos(1)

                End If
                tblDatos.Close()
            End If
        End If
    End Sub
End Class