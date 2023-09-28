Public Class Form1
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim weight As Double = Double.Parse(wText.Text)
        Dim height As Double = Double.Parse(hText.Text)

        Dim divideH As Double = height / 100
        Dim BMI As Double = weight / (divideH * divideH)

        BMIText.Text = BMI.ToString("0.00")

        If (BMI < 15) Then
            BMICText.Text = "Very Severely Underweight"
        ElseIf (BMI < 16 And BMI <= 18) Then
            BMICText.Text = "Severely Underweight"
        ElseIf (BMI < 18 And BMI <= 25) Then
            BMICText.Text = "Underweight"
        ElseIf (BMI < 25 And BMI <= 30) Then
            BMICText.Text = "Normal"
        ElseIf (BMI < 30 And BMI <= 35) Then
            BMICText.Text = "Overweight"
        ElseIf (BMI < 35 And BMI <= 40) Then
            BMICText.Text = "Moderately Obese"
        ElseIf (BMI < 40) Then
            BMICText.Text = "Severely Obese"
        Else
            BMICText.Text = "Very Severely Obese"
        End If
    End Sub

    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        wText.Text = ""
        hText.Text = ""
        BMIText.Text = ""
        BMICText.Text = ""



    End Sub
End Class
