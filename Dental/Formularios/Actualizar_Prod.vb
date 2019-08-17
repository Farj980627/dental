Public Class Actualizar_Prod
    Dim idpro As String = ""
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If txtNombre.Text = "" Or txtPrecio.Text = "" Then
                MsgBox("Alguno de los campos con asterisco contiene información no valida", MsgBoxStyle.Critical, MsgBoxResult.Ok)
            Else
                consultas.updInventarioAll(cbCatDestino.Text, txtNombre.Text, txtMarca.Text, txtModelo.Text, txtColor.Text, txtPrecio.Text, txtBarcode.Text, txtCantidad.Text, txtMinimo.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd"), idpro)
                MsgBox("Producto actualizado correctamente", MsgBoxStyle.OkOnly)
                For Each txt As Control In Me.Controls
                    If TypeOf txt Is TextBox Then
                        txt.Text = ""
                    End If
                Next
                txtBarcode.Enabled = False
                txtCantidad.Enabled = False
                txtColor.Enabled = False
                txtMarca.Enabled = False
                txtModelo.Enabled = False
                dtpFecha.Enabled = False
                cbCatDestino.Enabled = False
                txtMinimo.Enabled = False
                txtNombre.Enabled = False
                txtPrecio.Enabled = False
                dtpFecha.Enabled = False
                btnActualizar.Enabled = False



            End If
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbCatDestino.Text = consultas.getProductosByID(txtID.Text)(0)("type")
            txtBarcode.Text = consultas.getProductosByID(txtID.Text)(0)("barcode")
            txtCantidad.Text = consultas.getProductosByID(txtID.Text)(0)("quantity")
            txtColor.Text = consultas.getProductosByID(txtID.Text)(0)("color")
            txtMarca.Text = consultas.getProductosByID(txtID.Text)(0)("brand")
            txtMinimo.Text = consultas.getProductosByID(txtID.Text)(0)("min")
            txtModelo.Text = consultas.getProductosByID(txtID.Text)(0)("model")
            txtNombre.Text = consultas.getProductosByID(txtID.Text)(0)("name")
            txtPrecio.Text = consultas.getProductosByID(txtID.Text)(0)("price")
            dtpFecha.Value = Today.Date
            idpro = txtID.Text
            txtBarcode.Enabled = True
            txtCantidad.Enabled = True
            txtColor.Enabled = True
            txtMarca.Enabled = True
            txtModelo.Enabled = True
            dtpFecha.Enabled = True
            cbCatDestino.Enabled = True
            txtMinimo.Enabled = True
            txtNombre.Enabled = True
            txtPrecio.Enabled = True
            dtpFecha.Enabled = True
            btnActualizar.Enabled = True
            txtID.Clear()
        End If
    End Sub
End Class