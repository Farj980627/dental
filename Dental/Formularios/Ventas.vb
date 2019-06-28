Public Class Ventas
    Dim carrito, carrito2, vacio, busProducto As New DataTable
    Dim idproducto, producto, price, model, color, barcode As String
    Public Shared sumTot As String
    Public Shared dtTodo As New DataTable

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""
            txtCodigo.Text = ""
            carrito.Columns.Remove("cantidad")
            carrito.Columns.Remove("total")
            lblTotal.Text = "0"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Ventas_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""
            txtCodigo.Text = "CODIGO DE BARRAS"

            txtProducto.Text = "PRODUCTOS"
            dataBusProductos.DataSource = vacio
            dataBusProductos.Visible = False

            carrito.Columns.Remove("cantidad")
            carrito.Columns.Remove("total")
            lblTotal.Text = "0"
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If dgvProducto.Rows.Count = 0 Then
                MsgBox("No se a agregado ningun producto")
            Else
                sumTot = lblTotal.Text
                dgvProducto.DataSource = ""
                Conf_Venta.ShowDialog()
                sumTot = lblTotal.Text


            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        txtCodigo.Text = ""
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtCodigo.Text = "" Then

                Else
                    If carrito.Columns.Contains("cantidad") Then
                        If txtCantidad.Text = "" Then
                            carrito2 = carrito
                            idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                            producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                            price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                            model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                            color = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                            barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString
                            Dim columnas As Integer = carrito2.Rows.Count + 1
                            For i As Integer = columnas - 1 To columnas - 1 Step +1
                                carrito2.Rows.Add(idproducto, producto, price, model, color, barcode, "1", 0)
                                Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                                carrito2.Rows(columnas - 1)("total") = tot
                            Next
                            For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                                Dim sumas As Double
                                sumas = sumas + carrito2(i)("total")
                                lblTotal.Text = sumas
                            Next
                            dgvProducto.DataSource = carrito2
                            dtTodo = carrito2
                            carrito = carrito2
                        Else
                            carrito2 = carrito
                            idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                            producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                            price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                            model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                            color = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                            barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString
                            Dim columnas As Integer = carrito2.Rows.Count + 1
                            For i As Integer = columnas - 1 To columnas - 1 Step +1
                                carrito2.Rows.Add(idproducto, producto, price, model, color, barcode, txtCantidad.Text, 0)
                                Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                                carrito2.Rows(columnas - 1)("total") = tot
                            Next
                            dgvProducto.DataSource = carrito2
                            For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                                Dim sumas As Double
                                sumas = sumas + carrito2(i)("total")
                                lblTotal.Text = sumas
                            Next
                            dtTodo = carrito2
                            carrito = carrito2
                        End If
                        txtCantidad.Clear()
                    Else
                        carrito = consultas.getProductoByBarCode(txtCodigo.Text)
                        carrito.Columns.Add(cantidad)
                        carrito.Columns.Add(total)
                    End If
                    If carrito.Rows.Count = 1 Then
                        If txtCantidad.Text = "" Then
                            carrito(0)("cantidad") = "1"
                            carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                            dgvProducto.DataSource = carrito
                            lblTotal.Text = carrito(0)("total")
                            dtTodo = carrito
                        Else
                            carrito(0)("cantidad") = txtCantidad.Text
                            carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                            dgvProducto.DataSource = carrito
                            lblTotal.Text = carrito(0)("total")
                            dtTodo = carrito
                        End If
                    End If
                End If
                txtCodigo.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            busProducto = consultas.getProductosByProductosParaInv(txtProducto.Text)
            dataBusProductos.DataSource = busProducto
            dgvProducto.Visible = False
            dataBusProductos.Visible = True
        End If
    End Sub

    Private Sub txtProducto_Leave(sender As Object, e As EventArgs) Handles txtProducto.Leave
        If txtProducto.Text = "" Then
            txtProducto.Text = "PRODUCTOS"
        End If
    End Sub

    Private Sub txtProducto_Click(sender As Object, e As EventArgs) Handles txtProducto.Click
        txtProducto.Clear()
    End Sub

    Dim cantidad As New DataColumn("cantidad", GetType(System.String))
    Dim total As New DataColumn("total", GetType(System.String))
    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
                e.Handled = True
                MessageBox.Show("Introduzca sólo valores númericos")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dataBusProductos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataBusProductos.CellContentDoubleClick
        Try
            Dim prod As String
            prod = dataBusProductos.CurrentRow.Cells(0).Value.ToString

            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito

                    producto = consultas.getProductosByProduct(prod)(0)(1).ToString
                    price = consultas.getProductosByProduct(prod)(0)(2).ToString
                    model = consultas.getProductosByProduct(prod)(0)(3).ToString
                    color = consultas.getProductosByProduct(prod)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(prod)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(prod, producto, price, model, color, barcode, "1", 0)
                        Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                        carrito2.Rows(columnas - 1)("total") = tot
                    Next
                    For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                        Dim sumas As Double
                        sumas = sumas + carrito2(i)("total")
                        lblTotal.Text = sumas
                    Next
                    dgvProducto.DataSource = carrito2
                    dtTodo = carrito2
                    carrito = carrito2
                Else
                    carrito2 = carrito
                    producto = consultas.getProductosByProduct(prod)(0)(1).ToString
                    price = consultas.getProductosByProduct(prod)(0)(2).ToString
                    model = consultas.getProductosByProduct(prod)(0)(3).ToString
                    color = consultas.getProductosByProduct(prod)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(prod)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(prod, producto, price, model, color, barcode, txtCantidad.Text, 0)
                        Dim tot As String = carrito2.Rows(columnas - 1)("cantidad") * carrito2.Rows(columnas - 1)("price")
                        carrito2.Rows(columnas - 1)("total") = tot
                    Next
                    dgvProducto.DataSource = carrito2
                    For i As Integer = 0 To carrito2.Rows.Count - 1 Step +1
                        Dim sumas As Double
                        sumas = sumas + carrito2(i)("total")
                        lblTotal.Text = sumas
                    Next
                    dtTodo = carrito2
                    carrito = carrito2
                End If
                txtCantidad.Clear()
            Else
                carrito = consultas.getProductosByProduct(prod)
                carrito.Columns.Add(cantidad)
                carrito.Columns.Add(total)
            End If
            If carrito.Rows.Count = 1 Then
                If txtCantidad.Text = "" Then
                    carrito(0)("cantidad") = "1"
                    carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                    dgvProducto.DataSource = carrito
                    lblTotal.Text = carrito(0)("total")
                    dtTodo = carrito
                Else
                    carrito(0)("cantidad") = txtCantidad.Text
                    carrito(0)("total") = carrito(0)("cantidad") * carrito(0)("price")
                    dgvProducto.DataSource = carrito
                    lblTotal.Text = carrito(0)("total")
                    dtTodo = carrito
                End If

            End If
            txtCantidad.Clear()
            dataBusProductos.DataSource = vacio
            dataBusProductos.Visible = False
            dgvProducto.Visible = True
        Catch ex As Exception
        End Try
    End Sub
End Class