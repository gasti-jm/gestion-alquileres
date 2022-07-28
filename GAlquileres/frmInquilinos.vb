Public Class frmInquilinos
    Private Sub frmInquilinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUpdateDGI()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAMInq.Show()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        BorrarInquilino()
        LoadUpdateDGI()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub dgInquilinos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgInquilinos.CellMouseDoubleClick
        If dgInquilinos.RowCount > 0 Then
            IDISelected = dgInquilinos.CurrentRow.Cells("Id").Value
            Call BuscarObtenerINQ(IDISelected)
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        BusquedaDinamicaI()
    End Sub
End Class
