
Public Class Conf_Venta



    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = Ventas.sumTot
        chBEfectivo.Checked = True
        lblCambio.Visible = False
        Me.ActiveControl = txtPagar

    End Sub
    Private Sub vender()
        Try
            Dim a As String = ""
            Dim b As String = ""
            Dim newCantidad As String = ""



            For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1
                If consultas.getSix(Ventas.dtTodo(i)("id_product")) = True Then
                    a = Val(6) * Val(Ventas.dtTodo(i)("cantidad"))
                    b = consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    newCantidad = Val(b) - Val(a)
                    consultas.updInventario(newCantidad, consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))(0)("id_product"))
                    consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))
                    consultas.insUserxSale(Principal.idUsuario, consultas.getidSale)
                ElseIf consultas.getTwo(Ventas.dtTodo(i)("id_product")) = True Then
                    a = Val(2) * Val(Ventas.dtTodo(i)("cantidad"))
                    b = consultas.notgetTwoDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    newCantidad = Val(b) - Val(a)
                    consultas.updInventario(newCantidad, consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))(0)("id_product"))
                    consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))
                    consultas.insUserxSale(Principal.idUsuario, consultas.getidSale)
                ElseIf consultas.getFour(Ventas.dtTodo(i)("id_product")) = True Then
                    a = Val(4) * Val(Ventas.dtTodo(i)("cantidad"))
                    b = consultas.notgetFourDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    newCantidad = Val(b) - Val(a)
                    consultas.updInventario(newCantidad, consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))(0)("id_product"))
                    consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))
                    consultas.insUserxSale(Principal.idUsuario, consultas.getidSale)
                ElseIf consultas.getDoce(Ventas.dtTodo(i)("id_product")) = True Then
                    a = Val(12) * Val(Ventas.dtTodo(i)("cantidad"))
                    b = consultas.notgetDoceDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    newCantidad = Val(b) - Val(a)
                    consultas.updInventario(newCantidad, consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))(0)("id_product"))
                    consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))
                    consultas.insUserxSale(Principal.idUsuario, consultas.getidSale)
                Else
                    a = Ventas.dtTodo(i)("cantidad").ToString()
                    b = consultas.getCantidadInventarioBYID(Ventas.dtTodo(i)("id_product"))

                    newCantidad = Val(b) - Val(a)
                    consultas.updInventario(newCantidad, Ventas.dtTodo(i)("id_product"))
                    consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))

                    consultas.insUserxSale(Principal.idUsuario, consultas.getidSale)
                End If



            Next





            chBEfectivo.Checked = False
            txtPagar.Clear()
            chBEfectivo.Checked = False
            Me.Close()
            Ventas.Refresh()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        vender()
    End Sub

    Private Sub txtPagar_TextChanged(sender As Object, e As EventArgs) Handles txtPagar.TextChanged
        Try
            If Val(txtPagar.Text) >= Val(lblTotal.Text) Then
                btnConfirmar.Enabled = True
                lblCambio.Text = Val(txtPagar.Text) - Val(lblTotal.Text)
                lblCambio.Show()
            Else
                btnConfirmar.Enabled = False
                lblCambio.Visible = False

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagar.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack And Convert.ToInt32(e.KeyChar) = Convert.ToInt32(Keys.Enter) Then

                e.Handled = True

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        chBEfectivo.Checked = False

        txtPagar.Clear()
        Ventas.Close()
        Me.Close()
    End Sub

    Private Sub TxtPagar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPagar.KeyDown
        If e.KeyCode = Keys.Enter Then
            vender()
        End If
    End Sub
End Class