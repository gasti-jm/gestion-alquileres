Public Class frmBuscarInq
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        BusquedaDinamicaI(True)
    End Sub

    Private Sub dgInquilinos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgInquilinos.CellMouseDoubleClick
        If dgInquilinos.RowCount > 0 Then
            frmAMAl.txtIDNI.Text = dgInquilinos.CurrentRow.Cells("DNI").Value
            frmAMAl.lblIDNI.Text = dgInquilinos.CurrentRow.Cells("Nombre").Value & " " & dgInquilinos.CurrentRow.Cells("Apellido").Value
            Me.Close()
        End If
    End Sub

    Private Sub frmBuscarInq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUpdateDGI(True)
    End Sub
End Class