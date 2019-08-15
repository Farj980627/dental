
Public Class Conf_Venta
    Dim cerrar As Boolean = False
    Dim venta As Boolean = False

    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = Ventas.sumTot
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            Dim a As String = ""
            Dim b As String = ""
            Dim newCantidad As String = ""
            If chBEfectivo.Checked = True Then


                For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1

                    If consultas.getSix(Ventas.dtTodo(i)("id_product")) = True Then
                        If Ventas.dtTodo.Rows.Count > 0 Then
                            a = Val(6) * Val(Ventas.dtTodo(i)("cantidad"))
                        End If
                        b = consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    Else
                        a = Ventas.dtTodo(i)("cantidad").ToString()
                        b = consultas.getCantidadInventarioBYID(Ventas.dtTodo(i)("id_product"))
                    End If
                    If Val(a) > Val(b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cerrar = True
                        venta = False
                        Me.Close()
                        Ventas.Hide()
                    Else
                        venta = True
                    End If
                    If venta = True Then

                        If consultas.getSix(Ventas.dtTodo(i)("id_product")) = True Then
                            Dim dtSix As New DataTable
                            dtSix = consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))
                            newCantidad = Val(dtSix(0)("quantity")).ToString - Val(a)
                            consultas.updInventario(newCantidad, dtSix(0)("id_product"))
                            consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))

                        Else
                            newCantidad = Val(consultas.getCantidadInventarioBYID(Ventas.dtTodo(i)("id_product")) - Val(Ventas.dtTodo(i)("cantidad")))
                            consultas.updInventario(newCantidad, Ventas.dtTodo(i)("id_product"))
                            consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))
                        End If
                    End If
                Next
                cerrar = False
                If cerrar = False Then
                    MsgBox("Venta Realizada")
                End If
                chBEfectivo.Checked = False
                cbElectronico.Checked = False
                txtPagar.Clear()
                chBEfectivo.Checked = False
                cbElectronico.Checked = False
                Me.Close()
                Ventas.Hide()
            ElseIf chBEfectivo.Checked = False Then
                MsgBox("Selecciona una Forma de Pago")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPagar_TextChanged(sender As Object, e As EventArgs) Handles txtPagar.TextChanged
        Try
            If Val(txtPagar.Text) >= Val(lblTotal.Text) Then
                btnConfirmar.Enabled = True
            Else
                btnConfirmar.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPagar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagar.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then

                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        chBEfectivo.Checked = False
        cbElectronico.Checked = False
        txtPagar.Clear()
        Ventas.Close()
        Me.Close()
    End Sub

    Private Sub cbElectronico_CheckedChanged(sender As Object, e As EventArgs) Handles cbElectronico.CheckedChanged
        If cbElectronico.Checked = True And chBEfectivo.Checked = False Then
            btnConfirmar.Enabled = True
        End If
    End Sub
End Class