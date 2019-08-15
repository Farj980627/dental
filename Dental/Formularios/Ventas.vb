Public Class Ventas
    Dim carrito, carrito2, vacio, busProducto As New DataTable
    Dim idproducto, producto, price, model, colorr, barcode As String
    Dim dos = False, cuatro = False, seis = False, ocho = False, doce = False, diesiocho = False
    Dim id1, id2, id3, id4, id5, id6, id7, id8, id9, id10, id11, id12, id13, id14, id15 As String
    Public Shared sumTot As String
    Public Shared dtTodo As New DataTable
    Dim cantidad As New DataColumn("cantidad", GetType(System.String))
    Dim total As New DataColumn("total", GetType(System.String))

    Private Sub BtnFavorito13_Click(sender As Object, e As EventArgs) Handles btnFavorito13.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id13)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id13)(0)(1).ToString
                    price = consultas.getProductosByProduct(id13)(0)(2).ToString
                    model = consultas.getProductosByProduct(id13)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id13)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id13)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id13)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id13)(0)(1).ToString
                    price = consultas.getProductosByProduct(id13)(0)(2).ToString
                    model = consultas.getProductosByProduct(id13)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id13)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id13)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id13)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito14_Click(sender As Object, e As EventArgs) Handles btnFavorito14.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id14)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id14)(0)(1).ToString
                    price = consultas.getProductosByProduct(id14)(0)(2).ToString
                    model = consultas.getProductosByProduct(id14)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id14)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id14)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id14)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id14)(0)(1).ToString
                    price = consultas.getProductosByProduct(id14)(0)(2).ToString
                    model = consultas.getProductosByProduct(id14)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id14)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id14)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id14)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito15_Click(sender As Object, e As EventArgs) Handles btnFavorito15.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id15)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id15)(0)(1).ToString
                    price = consultas.getProductosByProduct(id15)(0)(2).ToString
                    model = consultas.getProductosByProduct(id15)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id15)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id15)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id15)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id15)(0)(1).ToString
                    price = consultas.getProductosByProduct(id15)(0)(2).ToString
                    model = consultas.getProductosByProduct(id15)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id15)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id15)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id15)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito12_Click(sender As Object, e As EventArgs) Handles btnFavorito12.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id12)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id12)(0)(1).ToString
                    price = consultas.getProductosByProduct(id12)(0)(2).ToString
                    model = consultas.getProductosByProduct(id12)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id12)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id12)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id12)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id12)(0)(1).ToString
                    price = consultas.getProductosByProduct(id12)(0)(2).ToString
                    model = consultas.getProductosByProduct(id12)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id12)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id12)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id12)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito11_Click(sender As Object, e As EventArgs) Handles btnFavorito11.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id11)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id11)(0)(1).ToString
                    price = consultas.getProductosByProduct(id11)(0)(2).ToString
                    model = consultas.getProductosByProduct(id11)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id11)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id11)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id11)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id11)(0)(1).ToString
                    price = consultas.getProductosByProduct(id11)(0)(2).ToString
                    model = consultas.getProductosByProduct(id11)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id11)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id11)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id11)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito10_Click(sender As Object, e As EventArgs) Handles btnFavorito10.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id10)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id10)(0)(1).ToString
                    price = consultas.getProductosByProduct(id10)(0)(2).ToString
                    model = consultas.getProductosByProduct(id10)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id10)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id10)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id10)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id10)(0)(1).ToString
                    price = consultas.getProductosByProduct(id10)(0)(2).ToString
                    model = consultas.getProductosByProduct(id10)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id10)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id10)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id10)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito9_Click(sender As Object, e As EventArgs) Handles btnFavorito9.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id9)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id9)(0)(1).ToString
                    price = consultas.getProductosByProduct(id9)(0)(2).ToString
                    model = consultas.getProductosByProduct(id9)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id9)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id9)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id9)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id9)(0)(1).ToString
                    price = consultas.getProductosByProduct(id9)(0)(2).ToString
                    model = consultas.getProductosByProduct(id9)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id9)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id9)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id9)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito8_Click(sender As Object, e As EventArgs) Handles btnFavorito8.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id8)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id8)(0)(1).ToString
                    price = consultas.getProductosByProduct(id8)(0)(2).ToString
                    model = consultas.getProductosByProduct(id8)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id8)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id8)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id8)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id8)(0)(1).ToString
                    price = consultas.getProductosByProduct(id8)(0)(2).ToString
                    model = consultas.getProductosByProduct(id8)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id8)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id8)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id8)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito7_Click(sender As Object, e As EventArgs) Handles btnFavorito7.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id7)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id7)(0)(1).ToString
                    price = consultas.getProductosByProduct(id7)(0)(2).ToString
                    model = consultas.getProductosByProduct(id7)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id7)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id7)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id7)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id7)(0)(1).ToString
                    price = consultas.getProductosByProduct(id7)(0)(2).ToString
                    model = consultas.getProductosByProduct(id7)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id7)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id7)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id7)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito6_Click(sender As Object, e As EventArgs) Handles btnFavorito6.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id6)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id6)(0)(1).ToString
                    price = consultas.getProductosByProduct(id6)(0)(2).ToString
                    model = consultas.getProductosByProduct(id6)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id6)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id6)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id6)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id6)(0)(1).ToString
                    price = consultas.getProductosByProduct(id6)(0)(2).ToString
                    model = consultas.getProductosByProduct(id6)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id6)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id6)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id6)
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



        Catch ex As Exception

        End Try

    End Sub


    Private Sub BtnFavorito1_Click(sender As Object, e As EventArgs) Handles btnFavorito1.Click
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
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id1)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id1)(0)(1).ToString
                    price = consultas.getProductosByProduct(id1)(0)(2).ToString
                    model = consultas.getProductosByProduct(id1)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id1)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id1)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id1)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito2_Click(sender As Object, e As EventArgs) Handles btnFavorito2.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id2)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id2)(0)(1).ToString
                    price = consultas.getProductosByProduct(id2)(0)(2).ToString
                    model = consultas.getProductosByProduct(id2)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id2)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id2)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id2)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id2)(0)(1).ToString
                    price = consultas.getProductosByProduct(id2)(0)(2).ToString
                    model = consultas.getProductosByProduct(id2)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id2)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id2)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id2)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito3_Click(sender As Object, e As EventArgs) Handles btnFavorito3.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id3)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id3)(0)(1).ToString
                    price = consultas.getProductosByProduct(id3)(0)(2).ToString
                    model = consultas.getProductosByProduct(id3)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id3)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id3)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id3)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id3)(0)(1).ToString
                    price = consultas.getProductosByProduct(id3)(0)(2).ToString
                    model = consultas.getProductosByProduct(id3)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id3)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id3)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id3)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito4_Click(sender As Object, e As EventArgs) Handles btnFavorito4.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id4)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id4)(0)(1).ToString
                    price = consultas.getProductosByProduct(id4)(0)(2).ToString
                    model = consultas.getProductosByProduct(id4)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id4)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id4)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id4)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id4)(0)(1).ToString
                    price = consultas.getProductosByProduct(id4)(0)(2).ToString
                    model = consultas.getProductosByProduct(id4)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id4)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id4)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id4)
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



        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnFavorito5_Click(sender As Object, e As EventArgs) Handles btnFavorito5.Click
        Try


            If carrito.Columns.Contains("cantidad") Then
                If txtCantidad.Text = "" Then
                    carrito2 = carrito
                    idproducto = consultas.getProductosByProduct(id5)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id5)(0)(1).ToString
                    price = consultas.getProductosByProduct(id5)(0)(2).ToString
                    model = consultas.getProductosByProduct(id5)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id5)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id5)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                    idproducto = consultas.getProductosByProduct(id5)(0)(0).ToString
                    producto = consultas.getProductosByProduct(id5)(0)(1).ToString
                    price = consultas.getProductosByProduct(id5)(0)(2).ToString
                    model = consultas.getProductosByProduct(id5)(0)(3).ToString
                    colorr = consultas.getProductosByProduct(id5)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(id5)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                carrito = consultas.getProductosByProduct(id5)
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



        Catch ex As Exception

        End Try

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
                            If consultas.getProductosByProduct(txtCodigo.Text).Rows.Count > 1 Then
                                idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                                producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                                price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                                model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                                colorr = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                                barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString
                            Else
                                idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                                producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                                price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                                model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                                colorr = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                                barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString

                            End If
                            Dim columnas As Integer = carrito2.Rows.Count + 1
                            For i As Integer = columnas - 1 To columnas - 1 Step +1
                                carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, "1", 0)
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
                            If consultas.getProductosByProduct(txtCodigo.Text).Rows.Count > 1 Then
                                idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                                producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                                price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                                model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                                colorr = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                                barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString
                            Else
                                idproducto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(0).ToString
                                producto = consultas.getProductoByBarCode(txtCodigo.Text)(0)(1).ToString
                                price = consultas.getProductoByBarCode(txtCodigo.Text)(0)(2).ToString
                                model = consultas.getProductoByBarCode(txtCodigo.Text)(0)(3).ToString
                                colorr = consultas.getProductoByBarCode(txtCodigo.Text)(0)(4).ToString
                                barcode = consultas.getProductoByBarCode(txtCodigo.Text)(0)(5).ToString

                            End If
                            Dim columnas As Integer = carrito2.Rows.Count + 1
                            For i As Integer = columnas - 1 To columnas - 1 Step +1
                                carrito2.Rows.Add(idproducto, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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
                        For i As Integer = 1 To carrito.Rows.Count - 1 Step +1
                            carrito.Rows.Remove(carrito.Rows(i))
                        Next
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
                    colorr = consultas.getProductosByProduct(prod)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(prod)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(prod, producto, price, model, colorr, barcode, "1", 0)
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
                    colorr = consultas.getProductosByProduct(prod)(0)(4).ToString
                    barcode = consultas.getProductosByProduct(prod)(0)(5).ToString
                    Dim columnas As Integer = carrito2.Rows.Count + 1
                    For i As Integer = columnas - 1 To columnas - 1 Step +1
                        carrito2.Rows.Add(prod, producto, price, model, colorr, barcode, txtCantidad.Text, 0)
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