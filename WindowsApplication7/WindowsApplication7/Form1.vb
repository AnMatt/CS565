Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num3, num4 As Integer
        num3 = Val(number1.Text)
        num4 = Val(Number2.Text)
        sum.Text = num3 + num4
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles number1.TextChanged


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles sum.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num3, num4 As Integer
        num3 = Val(number1.Text)
        num4 = Val(Number2.Text)
        sum.Text = num3 - num4
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num3, num4 As Integer
        num3 = Val(number1.Text)
        num4 = Val(Number2.Text)
        sum.Text = num3 / num4
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num3, num4 As Integer
        num3 = Val(number1.Text)
        num4 = Val(Number2.Text)
        sum.Text = num3 * num4
    End Sub

End Class
