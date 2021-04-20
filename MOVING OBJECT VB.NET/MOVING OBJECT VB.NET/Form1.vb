Public Class Form1

    'START
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Interval = 100
        Timer1.Enabled = True


    End Sub

    'STOP
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer1.Enabled = False


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'LEFT

        If (RadioButton1.Checked) Then

            If PictureBox1.Left > 0 Then
                PictureBox1.Left -= 40
            Else
                PictureBox1.Left = Me.Width
            End If
        End If


        'RIGHT

        If (RadioButton2.Checked) Then
            If PictureBox1.Left < Me.Width Then
                PictureBox1.Left += 40
            Else
                PictureBox1.Left = 0

            End If
        End If

        'UP

        If (RadioButton3.Checked) Then
            If PictureBox1.Top > 0 Then
                PictureBox1.Top -= 40
            Else
                PictureBox1.Top = Me.Height
            End If
        End If

        'DOWN

        If (RadioButton4.Checked) Then
            If PictureBox1.Top < Me.Height Then
                PictureBox1.Top += 40
            Else
                PictureBox1.Top = 0
            End If
        End If

    End Sub
End Class
