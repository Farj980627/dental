Public Class Eliminar_Prod
    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (MessageBox.Show("Estas seguro que deseas eliminar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                consultas.delProducto(txtID.Text)
                Me.Close()


                txtID.Clear()

                MsgBox("Producto Eliminado")
            End If
        End If
    End Sub

    Private Sub BntSalir_Click(sender As Object, e As EventArgs) Handles bntSalir.Click
        Me.Close()
    End Sub
End Class