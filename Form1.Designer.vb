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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FindAndReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.WindowThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProgramInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.FontDialog1 = New System.Windows.Forms.FontDialog()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AboutToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1283, 33)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(51, 29)
		Me.OpenToolStripMenuItem.Text = "FIle"
		'
		'OpenToolStripMenuItem1
		'
		Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
		Me.OpenToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(267, 30)
		Me.OpenToolStripMenuItem1.Text = "Open"
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
		Me.SaveToolStripMenuItem.Text = "Save"
		'
		'SaveAsToolStripMenuItem
		'
		Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
		Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(267, 30)
		Me.SaveAsToolStripMenuItem.Text = "Save As"
		'
		'EditToolStripMenuItem
		'
		Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.FontColorToolStripMenuItem, Me.FindToolStripMenuItem, Me.FindAndReplaceToolStripMenuItem})
		Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
		Me.EditToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
		Me.EditToolStripMenuItem.Text = "Edit"
		'
		'FontToolStripMenuItem
		'
		Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
		Me.FontToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
		Me.FontToolStripMenuItem.Size = New System.Drawing.Size(292, 30)
		Me.FontToolStripMenuItem.Text = "Font.."
		'
		'FontColorToolStripMenuItem
		'
		Me.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
		Me.FontColorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
		Me.FontColorToolStripMenuItem.Size = New System.Drawing.Size(292, 30)
		Me.FontColorToolStripMenuItem.Text = "Color"
		'
		'FindToolStripMenuItem
		'
		Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
		Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
		Me.FindToolStripMenuItem.Size = New System.Drawing.Size(292, 30)
		Me.FindToolStripMenuItem.Text = "Find"
		'
		'FindAndReplaceToolStripMenuItem
		'
		Me.FindAndReplaceToolStripMenuItem.Name = "FindAndReplaceToolStripMenuItem"
		Me.FindAndReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.FindAndReplaceToolStripMenuItem.Size = New System.Drawing.Size(292, 30)
		Me.FindAndReplaceToolStripMenuItem.Text = "Find and Replace"
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowThemeToolStripMenuItem, Me.WordWrapToolStripMenuItem})
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
		Me.ViewToolStripMenuItem.Text = "View"
		'
		'WindowThemeToolStripMenuItem
		'
		Me.WindowThemeToolStripMenuItem.Name = "WindowThemeToolStripMenuItem"
		Me.WindowThemeToolStripMenuItem.Size = New System.Drawing.Size(220, 30)
		Me.WindowThemeToolStripMenuItem.Text = "Window Theme"
		'
		'WordWrapToolStripMenuItem
		'
		Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
		Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(220, 30)
		Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramInformationToolStripMenuItem})
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
		Me.AboutToolStripMenuItem.Text = "About"
		'
		'ProgramInformationToolStripMenuItem
		'
		Me.ProgramInformationToolStripMenuItem.Name = "ProgramInformationToolStripMenuItem"
		Me.ProgramInformationToolStripMenuItem.Size = New System.Drawing.Size(264, 30)
		Me.ProgramInformationToolStripMenuItem.Text = "Program Information"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RichTextBox1.Location = New System.Drawing.Point(0, 33)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(1283, 211)
		Me.RichTextBox1.TabIndex = 2
		Me.RichTextBox1.Text = ""
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1283, 244)
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
	Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FindAndReplaceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WindowThemeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProgramInformationToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents FontDialog1 As FontDialog
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents ColorDialog1 As ColorDialog
End Class
