Public Class Insertar_Prod
    Dim newDt As New DataTable
    Dim desc, cod, min



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            txtCantidad.Clear()
            txtColor.Clear()
            txtMarca.Clear()
            txtMinimo.Clear()
            txtModelo.Clear()
            txtNombre.Clear()
            txtPrecio.Clear()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

            e.Handled = True
            MessageBox.Show("Introduzca sólo valores númericos")
        End If
    End Sub



    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception


        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If txtNombre.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Then
                MsgBox("Alguno de los campos con asteriscos contienen información no valida", MsgBoxStyle.Critical, MsgBoxResult.Ok)
            Else
                consultas.insProducto(cbTipo.Text, txtNombre.Text, txtMarca.Text, txtModelo.Text, txtColor.Text, txtPrecio.Text, txtBarcode.Text, txtCantidad.Text, txtMinimo.Text, dtpFecha.Value.Date.ToString("yyyy-MM-dd"))
                MsgBox("Producto agregado correctamente", MsgBoxStyle.OkOnly)
                For Each txt As Control In Me.Controls
                    If TypeOf txt Is TextBox Then
                        txt.Text = ""
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Posiblemente el codigo ya exista")

        End Try

    End Sub

    Private Sub Insertar_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpFecha.Value = Date.Today
            cbTipo.DataSource = consultas.getProducType
            cbTipo.DisplayMember = "type"
        Catch ex As Exception

        End Try
    End Sub
End Class