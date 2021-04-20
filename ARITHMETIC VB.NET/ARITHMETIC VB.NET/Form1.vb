Public Class Form1

    Dim Total As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Total = Val(TextBox4.Text) + Val(TextBox5.Text)
        TextBox6.Text = Total


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Total = Val(TextBox4.Text) - Val(TextBox5.Text)
        TextBox6.Text = Total

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Total = Val(TextBox4.Text) * Val(TextBox5.Text)
        TextBox6.Text = Total

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Total = Val(TextBox4.Text) / Val(TextBox5.Text)
        TextBox6.Text = Total

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        End

    End Sub
End Class
