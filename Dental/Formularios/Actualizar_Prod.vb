Public Class Actualizar_Prod
    Dim idpro As String = ""
    Dim min As String = 0, max As String
    Dim newDt As New DataTable
    Dim newCantidad As String = "", antCantidad As String = ""

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            If txtNombre.Text = "" Or txtPrecio.Text = "" Then
                MsgBox("Alguno de los campos con asterisco contiene información no valida", MsgBoxStyle.Critical, MsgBoxResult.Ok)
            Else
                newCantidad = Val(txtCantidad.Text) + Val(antCantidad)
                consultas.updInventarioAll(cbCatDestino.Text, txtNombre.Text, txtMarca.Text, txtModelo.Text, txtColor.Text, txtPrecio.Text, txtBarcode.Text, newCantidad, txtMinimo.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd"), idpro)
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
            newDt = consultas.getProductosByID(txtID.Text)
            max = newDt.Rows.Count
            cbCatDestino.Text = newDt(0)("type")
            txtBarcode.Text = newDt(0)("barcode")
            txtCantidad.Text = newDt(0)("quantity")
            antCantidad = Val(txtCantidad.Text)

            txtColor.Text = newDt(0)("color")
            txtMarca.Text = newDt(0)("brand")
            txtMinimo.Text = newDt(0)("min")
            txtModelo.Text = newDt(0)("model")
            txtNombre.Text = newDt(0)("name")
            txtPrecio.Text = newDt(0)("price")
            idpro = txtID.Text
            iniciar()
        End If
    End Sub

    Private Sub TxtActCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtActCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            newDt = consultas.updBarcode(txtActCodigo.Text)
            max = newDt.Rows.Count
            cbCatDestino.Text = newDt(0)("type")
            txtBarcode.Text = newDt(0)("barcode")
            txtCantidad.Text = newDt(0)("quantity")
            antCantidad = Val(txtCantidad.Text)
            txtColor.Text = newDt(0)("color")
            txtMarca.Text = newDt(0)("brand")
            txtMinimo.Text = newDt(0)("min")
            txtModelo.Text = newDt(0)("model")
            txtNombre.Text = newDt(0)("name")
            txtPrecio.Text = newDt(0)("price")
            idpro = newDt(0)("id_product")
            iniciar()
        End If
    End Sub
    Private Sub iniciar()
        dtpFecha.Value = Today.Date

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
        txtActCodigo.Clear()
        txtActNombre.Clear()
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click


        min = Val(min) - 1
        If min >= 0 Then
            cbCatDestino.Text = newDt(min)("type")
            txtBarcode.Text = newDt(min)("barcode")
            txtCantidad.Text = newDt(min)("quantity")
            antCantidad = Val(txtCantidad.Text)
            txtColor.Text = newDt(min)("color")
            txtMarca.Text = newDt(min)("brand")
            txtMinimo.Text = newDt(min)("min")
            txtModelo.Text = newDt(min)("model")
            txtNombre.Text = newDt(min)("name")
            txtPrecio.Text = newDt(min)("price")
            idpro = newDt(min)("id_product")

        Else
            min = 0
        End If
    End Sub

    Private Sub BtnAdelante_Click(sender As Object, e As EventArgs) Handles btnAdelante.Click
        min = Val(min) + 1
        If min <= max - 1 Then
            cbCatDestino.Text = newDt(min)("type")
            txtBarcode.Text = newDt(min)("barcode")
            txtCantidad.Text = newDt(min)("quantity")
            antCantidad = Val(txtCantidad.Text)
            txtColor.Text = newDt(min)("color")
            txtMarca.Text = newDt(min)("brand")
            txtMinimo.Text = newDt(min)("min")
            txtModelo.Text = newDt(min)("model")
            txtNombre.Text = newDt(min)("name")
            txtPrecio.Text = newDt(min)("price")
            idpro = newDt(min)("id_product")
        Else
            min = max - 1
        End If
    End Sub

    Private Sub TxtActNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtActNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            newDt = consultas.getProductosByProductosParaInv(txtActNombre.Text)
            max = newDt.Rows.Count
            cbCatDestino.Text = newDt(0)("type")
            txtBarcode.Text = newDt(0)("barcode")
            txtCantidad.Text = newDt(0)("quantity")
            antCantidad = Val(txtCantidad.Text)
            txtColor.Text = newDt(0)("color")
            txtMarca.Text = newDt(0)("brand")
            txtMinimo.Text = newDt(0)("min")
            txtModelo.Text = newDt(0)("model")
            txtNombre.Text = newDt(0)("name")
            txtPrecio.Text = newDt(0)("price")
            idpro = newDt(0)("id_product")
            iniciar()
        End If



    End Sub
End Class