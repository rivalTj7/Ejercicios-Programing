﻿Public Class frmdetalle_salida

    Private dt As New DataTable

    Private Sub frmdetalle_salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtcantidad.Value = 0
        txtstock.Value = 1
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fdetalle_salida
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Visible = True


        buscar()
    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = "idsalida='" & txtidsalida.Text & "'"

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


    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        mostrar()

    End Sub


    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buscar()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea quitar los artículos de la salida?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idddetalle_salida").Value)
                        Dim vdb As New vdetalle_salida
                        Dim func As New fdetalle_salida
                        vdb.giddetalle_salida = onekey

                        vdb.gidproducto = datalistado.SelectedCells.Item(3).Value
                        vdb.gidsalida = datalistado.SelectedCells.Item(2).Value
                        vdb.gcantidad = datalistado.SelectedCells.Item(5).Value



                        If func.eliminar(vdb) Then
                            If func.aumentar_stock(vdb) Then

                            End If
                        Else
                            MessageBox.Show("Artículo fue quitado de la salida", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

        Call limpiar()
    End Sub


    Private Sub btnbuscar_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_producto.Click
        frmproducto.txtflag.Text = "1"
        frmproducto.ShowDialog()

        If txtstock.Text < "4" Then
            MessageBox.Show("Su Estock Se Esta Agotando", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub txtcantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.ValueChanged
        Dim cant As Double

        cant = txtcantidad.Value

        If txtcantidad.Value > txtstock.Value Then
            MessageBox.Show("La cantidad que intenta vender supera stock", "Error al Salir el Articulo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Visible = 0
            txtcantidad.Value = txtstock.Value

        Else
            btnguardar.Visible = 1
        End If


        If txtcantidad.Value = 0 Then
            btnguardar.Visible = 0
        Else
            btnguardar.Visible = 1
        End If


    End Sub


    Private Sub btnguardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" Then
            Try
                Dim dts As New vdetalle_salida
                Dim func As New fdetalle_salida

                dts.gidsalida = txtidsalida.Text
                dts.gidproducto = txtidproducto.Text
                dts.gcantidad = txtcantidad.Text



                If func.insertar(dts) Then
                    If func.disminuir_stock(dts) Then

                    End If
                    MessageBox.Show("Artículo fue añadido correctamente a la Salida", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()



                Else
                    MessageBox.Show("Artículo fue añadido correctamente a la Salida intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cbeliminar_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub


    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub


    Private Sub txtidproducto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidproducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el producto para añadir a la salida, este dato es obligatorio")
        End If
    End Sub


    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        frmreportecomprobante.txtidventa.Text = Me.txtidsalida.Text
        frmreportecomprobante.ShowDialog()

    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        Me.Close()

    End Sub

    Private Sub frmdetalle_salida_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmsalidas.Show()
    End Sub


End Class