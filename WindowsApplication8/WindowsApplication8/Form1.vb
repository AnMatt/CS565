Public Class Form1

    Dim DOB As String
    Dim Sex As String
    Dim Color As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        sex = "Man"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        sex = "Woman"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If InStr(Color, "white") Then
        Else
            Color = Color + "white"
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If InStr(Color, "Black") Then
        Else
            Color = Color + ",Black"
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If InStr(Color, "Blue") Then
        Else
            Color = Color + ",Blue"
        End If


    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Color = Color + ",Pink"
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        Color = Color + ",Yellow"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MsgBox("My Name is " + TextBox1.Text + " My Age is " + ComboBox1.Text + " I am a " + Sex + " My Date of Birth is " + DateTimePicker1.Value + " My Favorite color is " + Color)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class