Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Integer
        num1 = Val(Number1.Text)
        num2 = Val(Number2.Text)
        Sum.Text = num1 + num2
    End Sub
End Class
