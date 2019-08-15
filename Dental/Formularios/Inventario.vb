Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Inventario
    Dim newDt As New DataTable
    Dim con As Integer = 0

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpFin.Value = Date.Today
            dtpInicio.Value = Date.Today
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            newDt = consultas.getProductosAll()

            dgvProducto.DataSource = newDt

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                newDt = consultas.getProductosByProductosParaInv(txtNombre.Text)
                dgvProducto.DataSource = newDt
                txtNombre.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click
        txtNombre.Clear()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Actualizar_Prod.ShowDialog()
    End Sub

    Private Sub btnBuscarFechas_Click(sender As Object, e As EventArgs) Handles btnBuscarFechas.Click
        Try
            If dtpFin.Value < dtpInicio.Value Then
                MsgBox("La Fecha de inicio es mayor que la final")
            Else
                dgvProducto.DataSource = consultas.getProductosByDate(dtpInicio.Value.Date.ToString("yyyy-MM-dd"), dtpFin.Value.Date.ToString("yyyy-MM-dd"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin_Categoria.ShowDialog()
    End Sub

    Private Sub txtCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCategoria.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                newDt = consultas.getProductosByCategoriaParaInv(txtCategoria.Text)

                dgvProducto.DataSource = newDt
                txtCategoria.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                newDt = consultas.getProductosByBarcodeParaInv(txtCodigo.Text)
                dgvProducto.DataSource = newDt
                txtCodigo.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Insertar_Prod.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar_Prod.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Favoritos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click
        Dim namae As String = InputBox("Nombre del Reporte?")
        Dim doc As Document = New Document(PageSize.A4.Rotate)
        Dim user As String = Environment.UserName

        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New System.IO.FileStream("C:\Users\" & user & "\Documents\" & namae & ".pdf", System.IO.FileMode.Create))
        doc.AddTitle("REPORTE DE INVENTARIO")

        doc.Open()

        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)

        doc.Add(Chunk.NEWLINE)
        Dim _standardFont As iTextSharp.text.Font = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 48, iTextSharp.text.Font.ITALIC, BaseColor.BLUE)
        Dim table As PdfPTable = New PdfPTable(dgvProducto.Columns.Count)
        table.WidthPercentage = 100
        For i As Integer = 0 To dgvProducto.Columns.Count - 1 Step +1
            Dim cell As PdfPCell = New PdfPCell()
            cell.AddElement(New Chunk(dgvProducto.Columns(i).Name.ToString()))
            cell.BorderWidth = 0
            cell.Colspan = 1
            table.AddCell(cell)
        Next
        For i As Integer = 0 To dgvProducto.Rows.Count - 2 Step +1
            For j As Integer = 0 To dgvProducto.Columns.Count - 1 Step +1
                Dim cell As PdfPCell = New PdfPCell()
                cell.AddElement(New Chunk(dgvProducto.Rows(i).Cells(j).Value.ToString()))
                cell.BorderColor = BaseColor.BLACK
                cell.BorderWidth = 1
                table.AddCell(cell)
            Next
        Next
        doc.Add(table)
        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)

        doc.Close()
        writer.Close()
        MessageBox.Show("¡PDF generado correctamente!")
    End Sub
End Class