﻿Public Class frmRecibo
    Private Sub frmRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFechaHoy.Text = Date.Now.ToShortDateString

        lblFechaVence.Text = frmAMAl.fInicio.Value.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
        lblFechaVence2.Text = frmAMAl.fInicio.Value.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
        lblFechaVence3.Text = frmAMAl.fInicio.Value.Day & "/" & Date.Now.Month & "/" & Date.Now.Year

        lblHonorarios.Text = "$" & frmAMAl.txtHonorarios.Text
        lblImpuestos.Text = "$" & Val(getNumbers(frmAMAl.txtImpuestos.Text))

        lblInquilino.Text = frmAMAl.lblIDNI.Text
        lblPropietario.Text = frmAMAl.lblPDNI.Text

        lblDesc.Text = "Alquiler: " & Date.Now.Month & "/" & Date.Now.Year
        lblTotal2.Text = "$" & frmAMAl.txtRecibo.Text
        lblInfo.Text = "POR MANDATO DEL LOCADOR RECIBÍ DEL LOCATARIO LA SUMA DE " & Num2Text(Val(frmAMAl.txtRecibo.Text)) & " POR EL ALQUILER DE UNA PROPIEDAD QUE OCUPA EN LA CALLE " & frmAMAl.txtCalle.Text & " " & frmAMAl.txtAltura.Text
    End Sub

    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES"
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

        Return Num2Text
    End Function

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        btnSalir.Visible = False
        Me.Refresh()

        'PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()


        If MsgBox("Desea imprimir una copia?", vbQuestion + vbYesNo + vbDefaultButton2, "COPIA DEL RECIBO") = vbYes Then
            lblTipo.Text = "COPIA"
            Me.Refresh()
            PrintForm1.Print()
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class