'My Editor
Public Class Form1
    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    'color

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog <> DialogResult.Cancel) Then
            RichTextBox1.SelectionColor = ColorDialog1.Color

        End If
    End Sub

    'font
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If (FontDialog1.ShowDialog <> DialogResult.Cancel) Then
            RichTextBox1.SelectionFont = FontDialog1.Font


        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'NEW
    Private Sub NewCtrlnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCtrlnToolStripMenuItem.Click

        RichTextBox1.Clear()

        Me.Text = "Untitled"

    End Sub

    'OPEN
    Private Sub OpenCtrlOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCtrlOToolStripMenuItem.Click

        OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        If (OpenFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName,
            RichTextBoxStreamType.RichText)
            Me.Text = OpenFileDialog1.FileName
        End If

    End Sub

    'SAVE
    Private Sub SaveCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCtrlSToolStripMenuItem.Click

        SaveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        If (SaveFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName,
            RichTextBoxStreamType.RichText)
            Me.Text = SaveFileDialog1.FileName
        End If

    End Sub

    'UNDO
    Private Sub UndoCtrlZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoCtrlZToolStripMenuItem.Click

        RichTextBox1.Undo()

    End Sub

    'SELECTALL
    Private Sub SelectAllCXtrlAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllCXtrlAToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    'PASTE
    Private Sub PasteCtrlVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteCtrlVToolStripMenuItem.Click
        RichTextBox1.Paste()

    End Sub

    'COPY
    Private Sub CopyCrtlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCrtlCToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    'CUT
    Private Sub CutCrtlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutCrtlXToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    'ABOUT
    Private Sub AboutUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUSToolStripMenuItem.Click
        Dim f As New about_form()
        f.Show()

    End Sub
End Class
