Public Class frmAMAl
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Agregar" Then
            AgregarAlquiler()
        Else
            ModificarAlquiler()
        End If

        LoadUpdateDGA()
    End Sub

    Private Sub txtPDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPDNI.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtIDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDNI.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtAltura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAltura.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtRecibo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecibo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub txtHonorarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHonorarios.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btnBuscarPDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarPDNI.Click
        frmBuscarP.Show()
    End Sub

    Private Sub btnBuscarIDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarIDNI.Click
        frmBuscarInq.Show()
    End Sub

    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        frmRecibo.PictureBox1.Image = Image.FromFile(Application.StartupPath() & "\Resources\RECIBOa.png")
        frmRecibo.lblTotal.Text = "$" & txtRecibo.Text

        frmRecibo.lblImpuestos.Top = frmRecibo.lblHonorarios.Top
        frmRecibo.lblFechaVence3.Top = frmRecibo.lblFechaVence2.Top
        frmRecibo.lblDescI.Top = frmRecibo.lblDescH.Top

        If MsgBox("Desea sumar los Impuestos?", vbQuestion + vbYesNo + vbDefaultButton2, "IMPUESTOS") = vbYes Then
            frmRecibo.lblTotal.Text = "$" & (Val(txtRecibo.Text) + Val(getNumbers(txtImpuestos.Text)))
        Else
            frmRecibo.lblTotal.Text = "$" & (Val(txtRecibo.Text) - Val(getNumbers(txtImpuestos.Text)))
        End If

        frmRecibo.Show()
    End Sub

    Private Sub frmAMAl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnReciboPropietario_Click(sender As Object, e As EventArgs) Handles btnReciboPropietario.Click
        frmRecibo.PictureBox1.Image = Image.FromFile(Application.StartupPath() & "\Resources\RECIBO2.png")
        frmRecibo.lblHonorarios.Visible = True
        frmRecibo.lblFechaVence2.Visible = True
        frmRecibo.lblDescH.Visible = True

        frmRecibo.lblTotal.Text = "$" & (Val(txtRecibo.Text) - Val(txtHonorarios.Text))

        If MsgBox("Desea sumar los Impuestos?", vbQuestion + vbYesNo + vbDefaultButton2, "IMPUESTOS") = vbYes Then
            frmRecibo.lblTotal.Text = "$" & (Val(txtRecibo.Text) - Val(txtHonorarios.Text) + Val(getNumbers(txtImpuestos.Text)))
        Else
            frmRecibo.lblTotal.Text = "$" & (Val(txtRecibo.Text) - Val(txtHonorarios.Text) - Val(getNumbers(txtImpuestos.Text)))
        End If

        frmRecibo.Show()
    End Sub
End Class