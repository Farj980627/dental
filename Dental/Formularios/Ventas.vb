Public Class Ventas
    Dim carrito, carrito2, vacio, busProducto As New DataTable
    Dim idproducto, producto, price, model, colorr, barcode As String
    Dim dos = False, cuatro = False, seis = False, ocho = False, doce = False, diesiocho = False
    Dim id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15 As String
    Public Shared sumTot As String
    Dim total As New DataColumn("total", GetType(System.String))
    Public Shared dtTodo As New DataTable
    Dim cantidad As New DataColumn("cantidad", GetType(System.String))
    Dim idExistente As String = ""
    Dim soyOtro As Boolean = False

    Dim listaIDS As New List(Of String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            id1 = consultas.getFavorites(0)("id_1")
            id2 = consultas.getFavorites(0)("id_2")
            id3 = consultas.getFavorites(0)("id_3")
            id4 = consultas.getFavorites(0)("id_4")
            id5 = consultas.getFavorites(0)("id_5")
            id6 = consultas.getFavorites(0)("id_6")
            id7 = consultas.getFavorites(0)("id_7")
            id8 = consultas.getFavorites(0)("id_8")
            id9 = consultas.getFavorites(0)("id_9")
            id10 = consultas.getFavorites(0)("id_10")
            id11 = consultas.getFavorites(0)("id_11")
            id12 = consultas.getFavorites(0)("id_12")
            id13 = consultas.getFavorites(0)("id_13")
            id14 = consultas.getFavorites(0)("id_14")
            id15 = consultas.getFavorites(0)("id_15")

            btnFavorito1.Text = consultas.viewDI1(id1).ToString
            btnFavorito2.Text = consultas.viewDI1(id2).ToString
            btnFavorito3.Text = consultas.viewDI1(id3).ToString
            btnFavorito4.Text = consultas.viewDI1(id4).ToString
            btnFavorito5.Text = consultas.viewDI1(id5).ToString
            btnFavorito6.Text = consultas.viewDI1(id6).ToString
            btnFavorito7.Text = consultas.viewDI1(id7).ToString
            btnFavorito8.Text = consultas.viewDI1(id8).ToString
            btnFavorito9.Text = consultas.viewDI1(id9).ToString
            btnFavorito10.Text = consultas.viewDI1(id10).ToString
            btnFavorito11.Text = consultas.viewDI1(id11).ToString
            btnFavorito12.Text = consultas.viewDI1(id12).ToString
            btnFavorito13.Text = consultas.viewDI1(id13).ToString
            btnFavorito14.Text = consultas.viewDI1(id14).ToString
            btnFavorito15.Text = consultas.viewDI1(id15).ToString
        Catch

        End Try
    End Sub

    Private Sub BtnFavorito13_Click(sender As Object, e As EventArgs) Handles btnFavorito13.Click
        Fav(consultas.getFavorites(0)("id_13"))
    End Sub

    Private Sub BtnFavorito14_Click(sender As Object, e As EventArgs) Handles btnFavorito14.Click
        Fav(consultas.getFavorites(0)("id_14"))
    End Sub

    Private Sub BtnFavorito15_Click(sender As Object, e As EventArgs) Handles btnFavorito15.Click
        Fav(consultas.getFavorites(0)("id_15"))

    End Sub

    Private Sub BtnFavorito12_Click(sender As Object, e As EventArgs) Handles btnFavorito12.Click
        Fav(consultas.getFavorites(0)("id_12"))
    End Sub

    Private Sub BtnFavorito11_Click(sender As Object, e As EventArgs) Handles btnFavorito11.Click
        Fav(consultas.getFavorites(0)("id_11"))

    End Sub

    Private Sub BtnFavorito10_Click(sender As Object, e As EventArgs) Handles btnFavorito10.Click
        Fav(consultas.getFavorites(0)("id_10"))

    End Sub

    Private Sub BtnFavorito9_Click(sender As Object, e As EventArgs) Handles btnFavorito9.Click
        Fav(consultas.getFavorites(0)("id_9"))
    End Sub

    Private Sub BtnFavorito8_Click(sender As Object, e As EventArgs) Handles btnFavorito8.Click
        Fav(consultas.getFavorites(0)("id_8"))

    End Sub

    Private Sub BtnFavorito7_Click(sender As Object, e As EventArgs) Handles btnFavorito7.Click
        Fav(consultas.getFavorites(0)("id_7"))
    End Sub

    Private Sub BtnFavorito6_Click(sender As Object, e As EventArgs) Handles btnFavorito6.Click
        Fav(consultas.getFavorites(0)("id_6"))
    End Sub
    Public Sub Fav(id1)
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id1)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id1)(0)(1).ToString
                    price = consultas.getProductosByProduct(id1)(0)(2).ToString
                    model = consultas.getProductosByProduct(id1)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id1)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id1)(0)(5).ToString

                    listaIDS.Clear()

                    For jk As Integer = 0 To carrito2.Rows.Count - 1 Step 1
                        listaIDS.Add(carrito2(jk)("id_product"))
                    Next

                    For Each row In carrito2.Rows
                        If row("id_product").ToString.Equals(idproducto) Then
                            idExistente = row("id_product").ToString

                            row("cantidad") = Val(row("cantidad") + Val(1))
                            row("total") = Val(row("cantidad")) * Val(row("price"))


                        End If
                    Next
                    For indice As Integer = 0 To listaIDS.Count - 1 Step 1
                        If listaIDS(indice) = idproducto Then
                            soyOtro = False
                            indice = listaIDS.Count - 1
                        Else
                            soyOtro = True
                        End If
                    Next
                    If soyOtro = True Then

                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
                        Dim tot As Integer = carrito2.Rows.Count - 1
                        carrito2(tot)("total") = Val(carrito2(tot)("cantidad")) * Val(carrito2(tot)("price"))
                        soyOtro = False
                    End If

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
                    idproducto = consultas.getProductosByProduct(id1)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id1)(0)(1).ToString
                    price = consultas.getProductosByProduct(id1)(0)(2).ToString
                    model = consultas.getProductosByProduct(id1)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id1)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id1)(0)(5).ToString
                    listaIDS.Clear()

                    For jk As Integer = 0 To carrito2.Rows.Count - 1 Step 1
                        listaIDS.Add(carrito2(jk)("id_product"))
                    Next


                    For Each row In carrito2.Rows
                        If row("id_product").ToString.Equals(idproducto) Then
                            idExistente = row("id_product").ToString
                            listaIDS.Add(row("id_product"))
                            row("cantidad") = Val(row("cantidad") + Val(txtCantidad.Text))
                            row("total") = Val(row("cantidad")) * Val(row("price"))
                        Else
                            For indice As Integer = 0 To listaIDS.Count - 1 Step 1
                                If listaIDS(indice) = idproducto Then
                                    soyOtro = False
                                Else
                                    soyOtro = True
                                End If
                            Next

                        End If
                    Next
                    If soyOtro = True Then

                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
                        Dim tot As Integer = carrito2.Rows.Count - 1
                        carrito2(tot)("total") = Val(carrito2(tot)("cantidad")) * Val(carrito2(tot)("price"))
                        soyOtro = False
                    End If

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
                carrito = consultas.getProductosByProduct(id1)
                carrito.Columns.Add(cantidad)
                carrito.Columns.Add(total)
            End If
            If carrito.Rows.Count = 1 Then
                If carrito(0)("id_product").ToString = idExistente Then


                Else
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
            txtCantidad.Clear()



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito1_Click(sender As Object, e As EventArgs) Handles btnFavorito1.Click
        Fav(consultas.getFavorites(0)("id_1"))
    End Sub

    Private Sub BtnFavorito2_Click(sender As Object, e As EventArgs) Handles btnFavorito2.Click
        Fav(consultas.getFavorites(0)("id_2"))

    End Sub

    Private Sub BtnFavorito3_Click(sender As Object, e As EventArgs) Handles btnFavorito3.Click
        Fav(consultas.getFavorites(0)("id_3"))

    End Sub

    Private Sub BtnFavorito4_Click(sender As Object, e As EventArgs) Handles btnFavorito4.Click
        Fav(consultas.getFavorites(0)("id_4"))

    End Sub

    Private Sub BtnFavorito5_Click(sender As Object, e As EventArgs) Handles btnFavorito5.Click
        Fav(consultas.getFavorites(0)("id_5"))

    End Sub


    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            id1 = consultas.getFavorites(0)("id_1")
            id2 = consultas.getFavorites(0)("id_2")
            id3 = consultas.getFavorites(0)("id_3")
            id4 = consultas.getFavorites(0)("id_4")
            id5 = consultas.getFavorites(0)("id_5")
            id6 = consultas.getFavorites(0)("id_6")
            id7 = consultas.getFavorites(0)("id_7")
            id8 = consultas.getFavorites(0)("id_8")
            id9 = consultas.getFavorites(0)("id_9")
            id10 = consultas.getFavorites(0)("id_10")
            id11 = consultas.getFavorites(0)("id_11")
            id12 = consultas.getFavorites(0)("id_12")
            id13 = consultas.getFavorites(0)("id_13")
            id14 = consultas.getFavorites(0)("id_14")
            id15 = consultas.getFavorites(0)("id_15")

            btnFavorito1.Text = consultas.viewDI1(id1).ToString
            btnFavorito2.Text = consultas.viewDI1(id2).ToString
            btnFavorito3.Text = consultas.viewDI1(id3).ToString
            btnFavorito4.Text = consultas.viewDI1(id4).ToString
            btnFavorito5.Text = consultas.viewDI1(id5).ToString
            btnFavorito6.Text = consultas.viewDI1(id6).ToString
            btnFavorito7.Text = consultas.viewDI1(id7).ToString
            btnFavorito8.Text = consultas.viewDI1(id8).ToString
            btnFavorito9.Text = consultas.viewDI1(id9).ToString
            btnFavorito10.Text = consultas.viewDI1(id10).ToString
            btnFavorito11.Text = consultas.viewDI1(id11).ToString
            btnFavorito12.Text = consultas.viewDI1(id12).ToString
            btnFavorito13.Text = consultas.viewDI1(id13).ToString
            btnFavorito14.Text = consultas.viewDI1(id14).ToString
            btnFavorito15.Text = consultas.viewDI1(id15).ToString
        Catch ex As Exception

        End Try

    End Sub





    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""
            txtCodigo.Text = ""
            idExistente = ""
            listaIDS.Clear()
            carrito.Columns.Remove("cantidad")
            carrito.Columns.Remove("total")
            carrito2.Clear()
            lblTotal.Text = "0"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Ventas_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Try
            dgvProducto.DataSource = vacio
            txtCantidad.Text = ""


            txtProducto.Text = "PRODUCTOS"
            dataBusProductos.DataSource = vacio
            dataBusProductos.Visible = False

            carrito.Columns.Remove("cantidad")
            carrito.Columns.Remove("total")
            lblTotal.Text = "0"
        Catch ex As Exception

        End Try

    End Sub

    Sub cancelaralv()
        dgvProducto.DataSource = vacio
        txtCantidad.Text = ""
        txtCodigo.Text = ""
        idExistente = ""
        listaIDS.Clear()
        carrito.Columns.Remove("cantidad")
        carrito.Columns.Remove("total")
        carrito2.Clear()
        lblTotal.Text = "0"
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try

            Dim a As String = ""
            Dim b As String = ""
            For i As Integer = 0 To dtTodo.Rows.Count - 1 Step +1
                If consultas.getSix(Ventas.dtTodo(i)("id_product")) = True Then

                    a = Val(6) * Val(Ventas.dtTodo(i)("cantidad"))

                    b = consultas.notgetSixDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    If Val(a) > (b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cancelaralv()
                    End If

                ElseIf consultas.getTwo(Ventas.dtTodo(i)("id_product")) = True Then

                    a = Val(2) * Val(Ventas.dtTodo(i)("cantidad"))

                    b = consultas.notgetTwoDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    If Val(a) > (b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cancelaralv()

                    End If
                ElseIf consultas.getDoce(Ventas.dtTodo(i)("id_product")) = True Then
                    a = Val(12) * Val(Ventas.dtTodo(i)("cantidad"))

                    b = consultas.notgetDoceDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    If Val(a) > (b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cancelaralv()
                    End If
                ElseIf consultas.getFour(Ventas.dtTodo(i)("id_product")) = True Then
                    a = Val(4) * Val(Ventas.dtTodo(i)("cantidad"))

                    b = consultas.notgetFourDT(Ventas.dtTodo(i)("barcode"))(0)("quantity").ToString
                    If Val(a) > (b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cancelaralv()
                    End If
                Else
                    a = Ventas.dtTodo(i)("cantidad").ToString()
                    b = consultas.getCantidadInventarioBYID(Ventas.dtTodo(i)("id_product"))
                    If Val(a) > (b) Then
                        MsgBox("Cantidad de " & Ventas.dtTodo(i)("name") & " en " & " Inventario es insuficiente para realizar la venta")
                        cancelaralv()

                    End If
                End If
            Next

            If dgvProducto.Rows.Count = 0 Then

            Else
                sumTot = lblTotal.Text
                dgvProducto.DataSource = ""
                Conf_Venta.ShowDialog()
                carrito.Columns.Remove("cantidad")
                carrito.Columns.Remove("total")
                idExistente = ""
                lblTotal.Text = ""
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

                Fav(consultas.getProductoByBarCode(txtCodigo.Text)(0)("id_product"))
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
            Fav(prod)


            dataBusProductos.DataSource = vacio
            dataBusProductos.Visible = False
            dgvProducto.Visible = True
        Catch ex As Exception
        End Try
    End Sub
End Class