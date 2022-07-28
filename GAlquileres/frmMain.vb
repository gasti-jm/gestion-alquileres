Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInquilinos_Click(sender As Object, e As EventArgs) Handles btnInquilinos.Click
        frmInquilinos.Show()
        Me.Close()
    End Sub

    Private Sub btnPropietarios_Click(sender As Object, e As EventArgs) Handles btnPropietarios.Click
        frmPropietarios.Show()
        Me.Close()
    End Sub

    Private Sub btnAlquileres_Click(sender As Object, e As EventArgs) Handles btnAlquileres.Click
        frmAlquileres.Show()
        Me.Close()
    End Sub
End Class