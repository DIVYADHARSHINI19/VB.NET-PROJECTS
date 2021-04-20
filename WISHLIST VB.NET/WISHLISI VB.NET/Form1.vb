Public Class Form1

    'ADD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (ListBox1.Items.IndexOf(ComboBox1.Text) = -1) Then
            ListBox1.Items.Add(ComboBox1.Text)
            TextBox1.Text = ListBox1.Items.Count
        ElseIf (ListBox1.SelectedIndex = -1) Then
            MsgBox("Select Item To be added")
        End If

    End Sub

    'DELETE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("Select Item To be deleted")
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

            TextBox1.Text = ListBox1.Items.Count
        End If

    End Sub

    'SORT
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Sorted = True

    End Sub

    'CLEAR
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ListBox1.Items.Clear()
        TextBox1.Text = ""
    End Sub

    'favourite menu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Chicken Briyani")
        ComboBox1.Items.Add("Mutton Briyani")
        ComboBox1.Items.Add("Chicken Chukka")
        ComboBox1.Items.Add("Mutton Chukka")
        ComboBox1.Items.Add("Chicken Lollypop")
        ComboBox1.Items.Add("Mutton Soup")
        ComboBox1.Items.Add("Full Meals")
        ComboBox1.Items.Add("Grilled Chicken")
        ComboBox1.Items.Add("Roti with gravy")
        ComboBox1.Items.Add("Rose Milk")
        ComboBox1.Items.Add("Ice Cream")


    End Sub

    'order
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        MsgBox("Thanks for ordering. Your order has been received")
        End

    End Sub
End Class
