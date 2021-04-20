Public Class Form1

    Dim index As Integer
    Dim first, last As Integer

    'FIRST
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        index = first
        PictureBox1.Image = ImageList1.Images(index)

    End Sub

    'BACK
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (index <> first) Then
            index -= 1
        Else
            index = last
        End If
        PictureBox1.Image = ImageList1.Images(index)

    End Sub

    'NEXT
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If (index <> last) Then
            index += 1
        Else
            index = first
        End If
        PictureBox1.Image = ImageList1.Images(index)

    End Sub

    'LAST
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        index = last
        PictureBox1.Image = ImageList1.Images(index)

    End Sub

    'TIMER
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Call Button3_Click(sender, e)

    End Sub

    'SLIDESHOW
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If (CheckBox1.Checked) Then
            Timer1.Interval = 500
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If


    End Sub

    'LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        first = 0
        last = ImageList1.Images.Count - 1
        Call Button1_Click(sender, e)
    End Sub


End Class
