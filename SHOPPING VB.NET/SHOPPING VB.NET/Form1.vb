Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Rupees As Integer

        If CheckBox4.Checked Then
            Rupees += 250
        End If

        If CheckBox3.Checked Then
            Rupees += 750
        End If

        If CheckBox2.Checked Then
            Rupees += 550
        End If

        If CheckBox1.Checked Then
            Rupees += 995
        End If

        TextBox1.Text = Rupees


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        End

    End Sub
End Class
