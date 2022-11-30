Public Class frmsalidas
    Private dt As New DataTable

    Private Sub frmsalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidpersonal.Text = ""
        txtnombre_personal.Text = ""
        txtnum_documento.Text = ""
        txtnum_documento.Text = ""
        txtidsalida.Text = ""
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fsalida
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidpersonal.Text <> "" And txtnombre_personal.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                Dim dts As New vsalida
                Dim func As New fsalida

                dts.gidpersonal = txtidpersonal.Text
                dts.gfecha_salida = txtfecha.Text
                dts.gtipo_documento = cbtipo_documento.Text
                dts.gnum_documento = txtnum_documento.Text

                If func.insertar(dts) Then
                    MessageBox.Show("Salida registrada correctamente vamos añadir Articulos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cargar_detalle()


                Else
                    MessageBox.Show("Salida no fue registrada intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Hide()

    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidsalida.Text = datalistado.SelectedCells.Item(1).Value
        txtidpersonal.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_personal.Text = datalistado.SelectedCells.Item(3).Value
        txtfecha.Text = datalistado.SelectedCells.Item(5).Value
        cbtipo_documento.Text = datalistado.SelectedCells.Item(7).Value
        txtnum_documento.Text = datalistado.SelectedCells.Item(6).Value
        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la venta?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidpersonal.Text <> "" And txtnum_documento.Text <> "" And txtidsalida.Text <> "" Then
                Try
                    Dim dts As New vsalida
                    Dim func As New fsalida

                    dts.gidsalida = txtidsalida.Text
                    dts.gidpersonal = txtidpersonal.Text
                    dts.gfecha_salida = txtfecha.Text
                    dts.gtipo_documento = cbtipo_documento.Text
                    dts.gnum_documento = txtnum_documento.Text


                    If func.editar(dts) Then
                        MessageBox.Show("Salida MOdificada correctamente", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Salida no fue modifcada intente de nuevo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub


    Private Sub cargar_detalle()
        frmdetalle_salida.txtidsalida.Text = datalistado.SelectedCells.Item(1).Value
        frmdetalle_salida.txtidpersonal.Text = datalistado.SelectedCells.Item(2).Value
        frmdetalle_salida.txtnombre_personal.Text = datalistado.SelectedCells.Item(3).Value
        frmdetalle_salida.txtfecha.Text = datalistado.SelectedCells.Item(5).Value
        frmdetalle_salida.cbtipo_documento.Text = datalistado.SelectedCells.Item(6).Value
        frmdetalle_salida.txtnum_documento.Text = datalistado.SelectedCells.Item(7).Value

        frmdetalle_salida.ShowDialog()
    End Sub


    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()
    End Sub


    Private Sub btnbuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_cliente.Click
        frmpersonal.txtflag.Text = "1"
        frmpersonal.ShowDialog()
    End Sub



    Private Sub txtidcliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidpersonal.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el Personal de la Salida, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtnum_documento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnum_documento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el número de comprobante, este dato es obligatorio")
        End If
    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        Me.Close()
        INICIO.Show()

    End Sub

    Private Sub frmsalidas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        INICIO.Show()
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()

    End Sub
End Class