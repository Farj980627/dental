Public Class Favoritos
    Private Sub BntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub

    Private Sub Favoritos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            txtID1.Text = consultas.getFavorites(0)("id_1").ToString
            txtID2.Text = consultas.getFavorites(0)("id_2").ToString
            txtID3.Text = consultas.getFavorites(0)("id_3").ToString
            txtID4.Text = consultas.getFavorites(0)("id_4").ToString
            txtID5.Text = consultas.getFavorites(0)("id_5").ToString
            txtID6.Text = consultas.getFavorites(0)("id_6").ToString
            txtID7.Text = consultas.getFavorites(0)("id_7").ToString
            txtID8.Text = consultas.getFavorites(0)("id_8").ToString
            txtID9.Text = consultas.getFavorites(0)("id_9").ToString
            txtID10.Text = consultas.getFavorites(0)("id_10").ToString
            txtID11.Text = consultas.getFavorites(0)("id_11").ToString
            txtID12.Text = consultas.getFavorites(0)("id_12").ToString
            txtID13.Text = consultas.getFavorites(0)("id_13").ToString
            txtID14.Text = consultas.getFavorites(0)("id_14").ToString
            txtID15.Text = consultas.getFavorites(0)("id_15").ToString

            txtProd1.Text = consultas.getProdutToFav(txtID1.Text).ToString
            txtProd2.Text = consultas.getProdutToFav(txtID2.Text).ToString
            txtProd3.Text = consultas.getProdutToFav(txtID3.Text).ToString
            txtProd4.Text = consultas.getProdutToFav(txtID4.Text).ToString
            txtProd5.Text = consultas.getProdutToFav(txtID5.Text).ToString
            txtProd6.Text = consultas.getProdutToFav(txtID6.Text).ToString
            txtProd7.Text = consultas.getProdutToFav(txtID7.Text).ToString
            txtProd8.Text = consultas.getProdutToFav(txtID8.Text).ToString
            txtProd9.Text = consultas.getProdutToFav(txtID9.Text).ToString
            txtProd10.Text = consultas.getProdutToFav(txtID10.Text).ToString
            txtProd11.Text = consultas.getProdutToFav(txtID11.Text).ToString
            txtProd12.Text = consultas.getProdutToFav(txtID12.Text).ToString
            txtProd13.Text = consultas.getProdutToFav(txtID13.Text).ToString
            txtProd14.Text = consultas.getProdutToFav(txtID14.Text).ToString
            txtProd15.Text = consultas.getProdutToFav(txtID15.Text).ToString

        Catch ex As Exception


        End Try
    End Sub

    Private Sub TxtID1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd1.Text = consultas.getProdutToFav(txtID1.Text).ToString
        End If
    End Sub

    Private Sub TxtID2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd2.Text = consultas.getProdutToFav(txtID2.Text).ToString
        End If
    End Sub

    Private Sub TxtID3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID3.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd3.Text = consultas.getProdutToFav(txtID3.Text).ToString
        End If
    End Sub

    Private Sub TxtID4_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID4.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd4.Text = consultas.getProdutToFav(txtID4.Text).ToString
        End If
    End Sub

    Private Sub TxtID5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID5.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd5.Text = consultas.getProdutToFav(txtID5.Text).ToString
        End If
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try

            consultas.insFav(txtID1.Text, txtID2.Text, txtID3.Text, txtID4.Text, txtID5.Text, txtID6.Text, txtID7.Text,
                             txtID8.Text, txtID9.Text, txtID10.Text, txtID11.Text, txtID12.Text, txtID13.Text, txtID14.Text, txtID15.Text)
            MsgBox("Productos Guardados Correctamente")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtID6_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID6.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd6.Text = consultas.getProdutToFav(txtID6.Text).ToString
        End If
    End Sub

    Private Sub TxtID7_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID7.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd7.Text = consultas.getProdutToFav(txtID7.Text).ToString
        End If
    End Sub

    Private Sub TxtID8_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID8.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd8.Text = consultas.getProdutToFav(txtID8.Text).ToString
        End If
    End Sub

    Private Sub TxtID9_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID9.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd9.Text = consultas.getProdutToFav(txtID9.Text).ToString
        End If
    End Sub

    Private Sub TxtID10_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID10.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd10.Text = consultas.getProdutToFav(txtID10.Text).ToString
        End If
    End Sub

    Private Sub TxtID11_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID11.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd11.Text = consultas.getProdutToFav(txtID11.Text).ToString
        End If
    End Sub

    Private Sub TxtID12_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID12.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd12.Text = consultas.getProdutToFav(txtID12.Text).ToString
        End If
    End Sub

    Private Sub TxtID13_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID13.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd13.Text = consultas.getProdutToFav(txtID13.Text).ToString
        End If
    End Sub

    Private Sub TxtID14_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID14.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd14.Text = consultas.getProdutToFav(txtID14.Text).ToString
        End If
    End Sub

    Private Sub TxtID15_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID15.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProd15.Text = consultas.getProdutToFav(txtID15.Text).ToString
        End If
    End Sub
End Class