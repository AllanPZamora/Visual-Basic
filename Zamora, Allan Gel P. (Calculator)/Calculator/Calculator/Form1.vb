Public Class Form1

    Dim num1, num2, result As Double
    Dim operators As String

    Private Sub Buttonequal_Click(sender As Object, e As EventArgs) Handles Buttonequal.Click
        num2 = Convert.ToDouble(calcDisplay.Text)

        If operators = "+" Then
            result = num1 + num2
            calcDisplay.Text = Convert.ToString(result)

        ElseIf operators = "-" Then
            result = num1 - num2
            calcDisplay.Text = Convert.ToString(result)

        ElseIf operators = "x" Then
            result = num1 * num2
            calcDisplay.Text = Convert.ToString(result)

        ElseIf operators = "/" Then
            result = num1 / num2
            calcDisplay.Text = Convert.ToString(result)

        ElseIf operators = "%" Then
            result = num1 Mod num2
            calcDisplay.Text = Convert.ToString(result)

        ElseIf operators = "^" Then
            result = num1 ^ num2
            calcDisplay.Text = Convert.ToString(result)

        End If

    End Sub
    Private Sub buttonclear_Click(sender As Object, e As EventArgs) Handles buttonclear.Click
        calcDisplay.Clear()
        Dim firstnum, secondnum As String
        firstnum = Convert.ToString(num1)
        secondnum = Convert.ToString(num2)

        firstnum = ""
        secondnum = ""
    End Sub
    Private Sub buttonclear1_Click(sender As Object, e As EventArgs) Handles buttonclear1.Click
        If calcDisplay.Text.Length > 0 Then
            calcDisplay.Text = calcDisplay.Text.Remove(calcDisplay.Text.Length - 1, 1)

        End If

        If calcDisplay.Text = "" Then
            calcDisplay.Text = ""

        End If
    End Sub

    Private Sub numclicks(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click, Buttondeci.Click
        Dim btn As Button = sender
        If (calcDisplay.Text = "0") Then
            calcDisplay.Clear()
            calcDisplay.Text = btn.Text

        ElseIf (btn.Text = ".") Then
            If (Not calcDisplay.Text.Contains(".")) Then
                calcDisplay.Text = calcDisplay.Text + btn.Text
            End If

        Else
            calcDisplay.Text = calcDisplay.Text + btn.Text
        End If

    End Sub
    Private Sub btnop(sender As Object, e As EventArgs) Handles Buttonsub.Click, buttonmulti.Click, Buttonmod.Click, buttondivide.Click, ButtonAdd.Click, Buttonx2.Click

        Dim btnnop As Button = sender

        num1 = Convert.ToDouble(calcDisplay.Text)
        operators = btnnop.Text
        calcDisplay.Text = ""
    End Sub
    'Code created by Allan Zamora
End Class
