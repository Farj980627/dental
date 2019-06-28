Public Class Principal
    Sub loadForm(ByVal form As Object)
        Try
            If Me.contenedor.Controls.Count > 0 Then
                Me.contenedor.Controls.RemoveAt(0)
            End If
            Dim opened As Form = TryCast(form, Form)
            opened.TopLevel = False
            opened.Dock = DockStyle.Fill
            Me.contenedor.Controls.Add(opened)
            Me.contenedor.Tag = opened
            opened.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = PictureBox1
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        loadForm(Inventario)
        lblTitulo.Text = "INVENTARIO"
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        loadForm(Ventas)
        lblTitulo.Text = "VENTAS"
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        loadForm(Reportes)
        lblTitulo.Text = "REPORTES"
    End Sub
End Class