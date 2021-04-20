<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCtrlnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCtrlOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCtrlSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoCtrlZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutCrtlXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCrtlCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllCXtrlAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1108, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCtrlnToolStripMenuItem, Me.OpenCtrlOToolStripMenuItem, Me.SaveCtrlSToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripComboBox1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewCtrlnToolStripMenuItem
        '
        Me.NewCtrlnToolStripMenuItem.Name = "NewCtrlnToolStripMenuItem"
        Me.NewCtrlnToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.NewCtrlnToolStripMenuItem.Text = "New   Ctrl+N"
        '
        'OpenCtrlOToolStripMenuItem
        '
        Me.OpenCtrlOToolStripMenuItem.Name = "OpenCtrlOToolStripMenuItem"
        Me.OpenCtrlOToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.OpenCtrlOToolStripMenuItem.Text = "Open  Ctrl+O"
        '
        'SaveCtrlSToolStripMenuItem
        '
        Me.SaveCtrlSToolStripMenuItem.Name = "SaveCtrlSToolStripMenuItem"
        Me.SaveCtrlSToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.SaveCtrlSToolStripMenuItem.Text = "Save   Ctrl+S"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoCtrlZToolStripMenuItem, Me.CutCrtlXToolStripMenuItem, Me.CopyCrtlCToolStripMenuItem, Me.PasteCtrlVToolStripMenuItem, Me.SelectAllCXtrlAToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoCtrlZToolStripMenuItem
        '
        Me.UndoCtrlZToolStripMenuItem.Name = "UndoCtrlZToolStripMenuItem"
        Me.UndoCtrlZToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.UndoCtrlZToolStripMenuItem.Text = "Undo          Ctrl+Z"
        '
        'CutCrtlXToolStripMenuItem
        '
        Me.CutCrtlXToolStripMenuItem.Name = "CutCrtlXToolStripMenuItem"
        Me.CutCrtlXToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.CutCrtlXToolStripMenuItem.Text = "Cut              Crtl+X"
        '
        'CopyCrtlCToolStripMenuItem
        '
        Me.CopyCrtlCToolStripMenuItem.Name = "CopyCrtlCToolStripMenuItem"
        Me.CopyCrtlCToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.CopyCrtlCToolStripMenuItem.Text = "Copy           Crtl+C"
        '
        'PasteCtrlVToolStripMenuItem
        '
        Me.PasteCtrlVToolStripMenuItem.Name = "PasteCtrlVToolStripMenuItem"
        Me.PasteCtrlVToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.PasteCtrlVToolStripMenuItem.Text = "Paste           Ctrl+V"
        '
        'SelectAllCXtrlAToolStripMenuItem
        '
        Me.SelectAllCXtrlAToolStripMenuItem.Name = "SelectAllCXtrlAToolStripMenuItem"
        Me.SelectAllCXtrlAToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.SelectAllCXtrlAToolStripMenuItem.Text = "SelectAll     Ctrl+A"
        '
        'FormateToolStripMenuItem
        '
        Me.FormateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ColorToolStripMenuItem})
        Me.FormateToolStripMenuItem.Name = "FormateToolStripMenuItem"
        Me.FormateToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.FormateToolStripMenuItem.Text = "&Format"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem1.Text = "Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(36, 55)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1020, 489)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUSToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutUSToolStripMenuItem
        '
        Me.AboutUSToolStripMenuItem.Name = "AboutUSToolStripMenuItem"
        Me.AboutUSToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutUSToolStripMenuItem.Text = "About Us"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1108, 617)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCtrlnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenCtrlOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveCtrlSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoCtrlZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutCrtlXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCrtlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllCXtrlAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUSToolStripMenuItem As ToolStripMenuItem
End Class
