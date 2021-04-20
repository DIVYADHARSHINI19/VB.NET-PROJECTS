Public Class Form1
    Dim xdown, ydown, xup, yup As Integer
    Dim c As String
    Dim w, h As Integer
    Dim g As Graphics

    'rectangle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = "R"
    End Sub

    'eclipse
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = "E"
    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        xdown = e.X
        ydown = e.Y
    End Sub

    'clear
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Refresh()
    End Sub

    'exit
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        xup = e.X
        yup = e.Y
        w = xup - xdown
        h = yup - ydown
        g = PictureBox1.CreateGraphics()
        Select Case c
            Case "L"
                g.DrawLine(Pens.DarkGreen, xdown, ydown, xup, yup)
            Case "R"
                g.DrawRectangle(Pens.PaleGreen, xdown, ydown, w, h)
            Case "FR"
                g.FillRectangle(Brushes.DeepPink, xdown, ydown, w, h)
            Case "E"
                g.DrawEllipse(Pens.Orange, xdown, ydown, w, h)
            Case "FE"
                g.FillEllipse(Brushes.Aqua, xdown, ydown, w, h)
        End Select
    End Sub

    'filled rectangle
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = "FR"
    End Sub

    'filled eclipse
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = "FE"
    End Sub


    'LINE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        c = "L"

    End Sub
End Class
