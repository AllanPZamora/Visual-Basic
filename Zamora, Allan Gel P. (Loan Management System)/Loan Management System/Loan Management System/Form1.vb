Imports System.Net
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Dim lrn As String = txtlrn.Text
        Dim account As String = txtaccnum.Text
        Dim tname As String = txtname.Text
        Dim address As String = txtaddress.Text
        Dim amountloan As Double = txtamount.Text
        Dim taxrate As Double = txtrate.Text
        Dim yearpay As Double = txtyeartpay.Text


        Dim taxconvert As Double = taxrate / 100


        txtlrnR.Text = lrn
        txtaccnumR.Text = account
        txtnameR.Text = tname
        txtaddressR.Text = address
        txtamountR.Text = amountloan
        txtrateR.Text = taxconvert
        txtyeartpayR.Text = yearpay


        Dim totalinterest As Double = amountloan * taxconvert * yearpay
        Dim totalloanpayment As Double = amountloan + totalinterest
        Dim totalannualpayment As Double = totalloanpayment / yearpay
        Dim monthpayment As Double = totalloanpayment / (yearpay * 12)


        txtmonthlypay.Text = monthpayment.ToString("N")
        txttotalint.Text = totalinterest.ToString("N")
        txttotalapay.Text = totalannualpayment.ToString("N")
        txtloanpay.Text = totalloanpayment.ToString("N")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtlrn.Text = ""
        txtaccnum.Text = ""
        txtname.Text = ""
        txtaddress.Text = ""
        txtamount.Text = ""
        txtrate.Text = ""
        txtyeartpay.Text = ""
        txtlrnR.Text = ""
        txtaccnumR.Text = ""
        txtnameR.Text = ""
        txtaddressR.Text = ""
        txtamountR.Text = ""
        txtrateR.Text = ""
        txtyeartpayR.Text = ""
        txtmonthlypay.Text = ""
        txttotalapay.Text = ""
        txttotalint.Text = ""
        txttotalapay.Text = ""
        txtloanpay.Text = ""



    End Sub
End Class
