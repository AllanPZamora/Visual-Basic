Public Class Form1
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
End Class
