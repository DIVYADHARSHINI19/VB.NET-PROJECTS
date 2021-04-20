Public Class Form1

    'timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = Date.Now.ToString("M")
        Label1.Text = Date.Now.ToString("T")
        Label3.Text = Date.Now.ToString("yyyy")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer1.Enabled = True
        Timer1.Interval = 300

    End Sub


End Class
