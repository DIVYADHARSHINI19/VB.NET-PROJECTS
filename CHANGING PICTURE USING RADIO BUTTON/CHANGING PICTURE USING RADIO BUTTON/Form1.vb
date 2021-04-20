Public Class Form1

    'delhi
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        PictureBox1.Image = My.Resources.delhi

    End Sub

    'egypt
    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        PictureBox1.Image = My.Resources.egypt

    End Sub

    'kerala
    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        PictureBox1.Image = My.Resources.kerala

    End Sub

    'dubai
    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        PictureBox1.Image = My.Resources.dubai

    End Sub

    'paris
    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        PictureBox1.Image = My.Resources.pariss

    End Sub

    'kashmir
    Private Sub RadioButton6_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

        PictureBox1.Image = My.Resources.kashmir

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
