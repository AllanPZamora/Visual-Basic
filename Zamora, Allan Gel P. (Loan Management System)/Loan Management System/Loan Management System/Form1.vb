Imports System.Net
Imports System.Security.Principal
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form1
    Private Sub txtlrn_TextChanged(sender As Object, e As EventArgs) Handles txtlrn.TextChanged
        txtlrn.Text = 1
        txtlrn.Text = ToString("0000")


    End Sub


    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click


        Dim account As String = txtaccnum.Text
        Dim tname As String = txtname.Text
        Dim address As String = txtaddress.Text
        Dim amountloan As Double = txtamount.Text
        Dim taxrate As Double = txtrate.Text
        Dim yearpay As Double = txtyeartpay.Text


        Dim taxconvert As Double = taxrate / 100

        txtaccnumR.Text = account
        txtnameR.Text = tname
        txtaddressR.Text = address
        txtamountR.Text = Format(amountloan, "₱#,##.00")
        txtrateR.Text = taxrate
        txtyeartpayR.Text = yearpay


        Dim totalinterest As Double = amountloan * taxconvert * yearpay
        Dim totalloanpayment As Double = amountloan + totalinterest
        Dim totalannualpayment As Double = totalloanpayment / yearpay
        Dim monthpayment As Double = totalloanpayment / (yearpay * 12)


        txtmonthlypay.Text = Format(monthpayment, "₱#,##.00")
        txttotalint.Text = Format(totalinterest, "₱#,##.00")
        txttotalapay.Text = Format(totalannualpayment, "₱#,##.00")
        txtloanpay.Text = Format(totalloanpayment, "₱#,##.00")

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
