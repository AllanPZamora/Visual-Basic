Imports System.Windows.Forms.AxHost

Public Class Form1
    Private Sub Com_Click(sender As Object, e As EventArgs) Handles Com.Click

        Dim sname As String = txtname.Text
        Dim dept As String = txtdept.Text
        Dim workhours As Integer = txtworkhours.Text
        Dim regrate As Integer = txtrate.Text
        Dim overtime As Integer = txtovertime.Text
        Dim overrate As Integer = txtovertimerate.Text

        ' Place Holder %

        Dim SSS As Double = 0.15
        Dim PhilH As Double = 0.05
        Dim PagIbig As Double = 0.03
        Dim Tax As Double = 0.02

        Dim regpay As Double = workhours * regrate
        Dim overpay As Double = overtime * overrate
        Dim grosspay As Double = regpay + overpay

        Dim SSSdec As Double = grosspay * SSS
        Dim PHdec As Double = grosspay * PhilH
        Dim PGdec As Double = grosspay * PagIbig

        Dim tax2 As Double = grosspay - (SSSdec + PHdec + PGdec)
        Dim taxdec As Double = tax2 * Tax
        Dim totaldec As Double = SSSdec + PHdec + PGdec + taxdec

        Dim netpay As Double = SSSdec + PHdec + PGdec + taxdec
        Dim taxpay As Double = grosspay - netpay

        txtnameR.Text = sname
        txtdeptR.Text = dept
        txtworkhoursR.Text = workhours
        txtrateR.Text = regrate
        txtovertimeR.Text = overtime
        txtovertimerateR.Text = overrate
        txtgross.Text = grosspay
        txtSSS.Text = SSSdec
        txtPH.Text = PHdec
        txtPI.Text = PGdec
        txtincometax.Text = taxdec
        txtDeduc.Text = totaldec
        txtNetpay.Text = taxpay

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtname.Text = ""
        txtdept.Text = ""
        txtworkhours.Text = ""
        txtrate.Text = ""
        txtovertime.Text = ""
        txtovertimerate.Text = ""

        txtnameR.Text = ""
        txtdeptR.Text = ""
        txtworkhoursR.Text = ""
        txtrateR.Text = ""
        txtovertimeR.Text = ""
        txtovertimerateR.Text = ""

        txtgross.Text = ""
        txtSSS.Text = ""
        txtPH.Text = ""
        txtPI.Text = ""
        txtincometax.Text = ""
        txtDeduc.Text = ""
        txtNetpay.Text = ""

    End Sub
    'Code created by Allan Zamora
End Class
