Public Class frmAlquileres
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmMain.Show()
        DetectarContratos.Enabled = False
        Me.Close()
    End Sub

    Private Sub frmAlquileres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUpdateDGA()
        BuscarContratosVencidos()
        DetectarContratos.Enabled = True
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        BorrarAlquiler()
        LoadUpdateDGA()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        BusquedaDinamicaA()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAMAl.Show()
    End Sub

    Private Sub dgAlquileres_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgAlquileres.CellMouseDoubleClick
        If dgAlquileres.RowCount > 0 Then
            IDASelected = dgAlquileres.CurrentRow.Cells("Id").Value
            Call BuscarObtenerALQ(IDASelected)
            Call ObtenerDatosIP(Val(frmAMAl.txtPDNI.Text), Val(frmAMAl.txtIDNI.Text))
        End If
    End Sub

    Private Sub DetectarContratos_Tick(sender As Object, e As EventArgs) Handles DetectarContratos.Tick
        If frmMain.Visible = True Then Exit Sub
        If frmAMInq.Visible = True Then Exit Sub
        If frmAMPro.Visible = True Then Exit Sub
        If frmInquilinos.Visible = True Then Exit Sub
        If frmPropietarios.Visible = True Then Exit Sub
        If frmAMAl.Visible = True Then Exit Sub
        If frmBuscarInq.Visible = True Then Exit Sub
        If frmBuscarP.Visible = True Then Exit Sub
        If frmRecibo.Visible = True Then Exit Sub

        BuscarContratosVencidos()
    End Sub
End Class