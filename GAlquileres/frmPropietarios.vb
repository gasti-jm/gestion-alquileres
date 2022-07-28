Public Class frmPropietarios
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAMPro.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        BorrarPropietario()
        LoadUpdateDGP()
    End Sub

    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUpdateDGP()
    End Sub

    Private Sub dgPropietarios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPropietarios.CellMouseDoubleClick
        If dgPropietarios.RowCount > 0 Then
            IDPSelected = dgPropietarios.CurrentRow.Cells("Id").Value
            Call BuscarObtenerPRO(IDPSelected)
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        BusquedaDinamicaP()
    End Sub

    Private Sub dgPropietarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPropietarios.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class