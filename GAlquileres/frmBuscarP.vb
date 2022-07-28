Public Class frmBuscarP
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        BusquedaDinamicaP(True)
    End Sub

    Private Sub dgPropietarios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPropietarios.CellMouseDoubleClick
        If dgPropietarios.RowCount > 0 Then
            frmAMAl.txtPDNI.Text = dgPropietarios.CurrentRow.Cells("DNI").Value
            frmAMAl.lblPDNI.Text = dgPropietarios.CurrentRow.Cells("Nombre").Value & " " & dgPropietarios.CurrentRow.Cells("Apellido").Value
            Me.Close()
        End If
    End Sub

    Private Sub frmBuscarP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUpdateDGP(True)
    End Sub
End Class