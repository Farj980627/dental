Imports WL
Imports LibPrintTicket
Public Class Conf_Venta
    Dim cerrar As Boolean = False
    Dim venta As Boolean = False

    Private Sub Conf_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = Ventas.sumTot
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If chBEfectivo.Checked = True And cbElectronico.Checked = False Then
                For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1

                    Dim a As String = Ventas.dtTodo(i)("cantidad").ToString()
                    Dim b As String = consultas.getCantidadInventario(Ventas.dtTodo(i)("barcode"))
                    If Val(a) > Val(b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cerrar = True
                        venta = False
                        Me.Close()
                        Ventas.Close()
                    Else
                        venta = True
                    End If
                Next
                If venta = True Then
                    For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1
                        Dim newCantidad As String
                        newCantidad = Val(consultas.getCantidadInventario(Ventas.dtTodo(i)("barcode")) - Val(Ventas.dtTodo(i)("cantidad")))
                        consultas.updInventario(newCantidad, Ventas.dtTodo(i)("id_product"))
                        consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Efectivo", Ventas.dtTodo(i)("total"))
                    Next
                    cerrar = False
                End If
                If cerrar = False Then

                    Dim ticket3 As Tickets = New Tickets

                    ticket3.Logo("logo nuevo.png")
                    ticket3.Titulo("TESLACEL")
                    ticket3.Encabezado("PINO SUAREZ #2014")
                    ticket3.Encabezado("DURANGO,DGO CP:34270")
                    ticket3.Encabezado("HORARIO 10:00 - 20:00 LUN-VIE ")
                    ticket3.Encabezado("10:00 - 16:00 SABADO ")
                    ticket3.Encabezado("TELEFONO: 618 195 1338")
                    ticket3.Encabezado("RFC: HEGE940315HE6")
                    ticket3.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                    For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1
                        ticket3.Articulo("CODE", Ventas.dtTodo(i)("cantidad").ToString, Ventas.dtTodo(i)("name").ToString & " " & Ventas.dtTodo(i)("model").ToString, Ventas.dtTodo(i)("price").ToString, Ventas.dtTodo(i)("total").ToString)
                    Next
                    ticket3.NumArticulos(Ventas.dtTodo.Rows.Count)
                    ticket3.Total(Ventas.sumTot)
                    ticket3.Pago("RECIBI: ", txtPagar.Text)
                    ticket3.Pago("CAMBIO: ", Val(txtPagar.Text) - Val(Ventas.sumTot))

                    ticket3.Pie("Este ticket solo es un comprobante de pago por compra de un artículo. En caso de que el cliente solicite un cambio de articulo, el producto debe estar en perfectas condiciones, sin haber retirado hules, protecciones o haber dañado el articulo comprado. El gerente tiene la autorización de negar cambio de artículo en base a su criterio.")
                    ticket3.Pie("En ningún caso hay devoluciones de efectivo.")
                    ticket3.Pie("Los artículos que se prueben al momento de la compra no tienen garantía.")
                    ticket3.Pie("Los siguientes artículos no tienen garantía por lo cual deben de ser probados al momento de la compra, Pilas, Cristales Templados, Cables, Cubos de Carga, Fundas.")
                    ticket3.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")

                    ticket3.VistaPrevia()

                    MsgBox("Venta Realizada")

                End If
                chBEfectivo.Checked = False
                cbElectronico.Checked = False
                txtPagar.Clear()
                chBEfectivo.Checked = False
                cbElectronico.Checked = False

                Me.Close()
                Ventas.Close()
            ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = False Then
                MsgBox("Selecciona una Forma de Pago")

            ElseIf chBEfectivo.Checked = False And cbElectronico.Checked = True Then
                For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1

                    Dim a As String = Ventas.dtTodo(i)("cantidad").ToString()
                    Dim b As String = consultas.getCantidadInventario(Ventas.dtTodo(i)("barcode"))
                    If Val(a) > Val(b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cerrar = True
                        venta = False
                        Me.Close()
                        Ventas.Close()
                    Else
                        venta = True
                    End If
                Next
                If venta = True Then
                    For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1
                        Dim newCantidad As String
                        newCantidad = Val(consultas.getCantidadInventario(Ventas.dtTodo(i)("barcode")) - Val(Ventas.dtTodo(i)("cantidad")))
                        consultas.updInventario(newCantidad, Ventas.dtTodo(i)("id_product"))
                        consultas.insSale(Ventas.dtTodo(i)("id_product"), Ventas.dtTodo(i)("cantidad"), Date.Today.ToString("yyyy-MM-dd"), DateTime.Now.ToShortTimeString, "Electrónico ", Ventas.dtTodo(i)("total"))
                    Next
                    cerrar = False
                End If
                If cerrar = False Then

                    Dim ticket4 As Tickets = New Tickets

                    ticket4.Logo("logo nuevo.png")
                    ticket4.Titulo("TESLACEL")
                    ticket4.Encabezado("PINO SUAREZ #2014")
                    ticket4.Encabezado("DURANGO,DGO CP:34270")
                    ticket4.Encabezado("HORARIO 10:00 - 20:00 LUN-VIE")
                    ticket4.Encabezado("10:00 - 16:00 SABADO")
                    ticket4.Encabezado("TELEFONO: 618 195 1338")
                    ticket4.Encabezado("RFC: HEGE940315HE6")
                    ticket4.Encabezado("FECHA: " & Date.Today.ToShortDateString)
                    For i As Integer = 0 To Ventas.dtTodo.Rows.Count - 1 Step +1
                        ticket4.Articulo("CODE", Ventas.dtTodo(i)("cantidad").ToString, Ventas.dtTodo(i)("name").ToString & " " & Ventas.dtTodo(i)("model").ToString, Ventas.dtTodo(i)("price").ToString, Ventas.dtTodo(i)("total").ToString)
                    Next
                    ticket4.NumArticulos(Ventas.dtTodo.Rows.Count)
                    ticket4.Total(Ventas.sumTot)
                    ticket4.Pago("PAGO ELEC : ", Ventas.sumTot)

                    ticket4.Pie("Este ticket solo es un comprobante de pago por compra de un artículo. En caso de que el cliente solicite un cambio de articulo, el producto debe estar en perfectas condiciones, sin haber retirado hules, protecciones o haber dañado el articulo comprado. El gerente tiene la autorización de negar cambio de artículo en base a su criterio.")
                    ticket4.Pie("En ningún caso hay devoluciones de efectivo.")
                    ticket4.Pie("Los artículos que se prueben al momento de la compra no tienen garantía.")
                    ticket4.Pie("Los siguientes artículos no tienen garantía por lo cual deben de ser probados al momento de la compra, Pilas, Cristales Templados, Cables, Cubos de Carga, Fundas.")
                    ticket4.Pie("GRACIAS POR SU COMPRA, VUELVA PRONTO")

                    ticket4.VistaPrevia()

                    MsgBox("Venta Realizada")

                End If
                chBEfectivo.Checked = False
                cbElectronico.Checked = False
                txtPagar.Clear()
                chBEfectivo.Checked = False
                cbElectronico.Checked = False
                Me.Close()
                Ventas.Close()
            ElseIf chBEfectivo.Checked = True And cbElectronico.Checked = True Then
                MsgBox("Solo puedes seleccionar un tipo de pago")

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