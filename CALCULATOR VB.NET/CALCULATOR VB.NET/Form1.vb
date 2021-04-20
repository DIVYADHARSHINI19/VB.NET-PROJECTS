Public Class Form1

    Dim a As Decimal
    Dim b As Decimal
    Dim c As Decimal
    Dim operation As Boolean = False

    'CLEAR
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        TextBox1.Clear()

    End Sub
    'DELETE
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        Dim d As String
        d = TextBox1.Text

        If (d.Length > 0) Then

            TextBox1.Text = d.Substring(0, d.Length - 1)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text += "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text += "2"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text += "3"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Text += "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox1.Text += "5"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox1.Text += "6"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox1.Text += "7"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text += "8"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox1.Text += "9"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox1.Text += "0"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        TextBox1.Text += "00"

    End Sub

    'dot
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim s As String
        s = TextBox1.Text
        If Not s.Contains(".") Then
            TextBox1.Text += "."
        End If


    End Sub

    'ADD
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        a = TextBox1.Text
        TextBox1.Text = ""
        c = 1
        operation = True


    End Sub

    'SUB
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        a = TextBox1.Text
        TextBox1.Text = ""
        c = 2
        operation = True

    End Sub

    'MUL
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        a = TextBox1.Text
        TextBox1.Text = ""
        c = 3
        operation = True

    End Sub

    'DIV
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        a = TextBox1.Text
        TextBox1.Text = ""
        c = 4
        operation = True

    End Sub

    'MOD
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        a = TextBox1.Text
        TextBox1.Text = ""
        c = 5
        operation = True

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        If operation = True Then
            b = TextBox1.Text
            If c = 1 Then
                TextBox1.Text = a + b
            ElseIf c = 2 Then
                TextBox1.Text = a - b
            ElseIf c = 3 Then
                TextBox1.Text = a * b
            ElseIf c = 5 Then
                TextBox1.Text = a Mod b

            ElseIf b = 0 Then
                TextBox1.Text = "Error"
            Else
                TextBox1.Text = a / b

            End If
        End If


    End Sub
End Class
