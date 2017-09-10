Imports System.IO
Imports System.Windows.Forms

Public Class Form1


	Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click

		With OpenFileDialog1
			.Title = "Open File"
			.Filter = "Text Files | *.txt"
			.FileName = ""
			.CheckFileExists = vbTrue
		End With

		If OpenFileDialog1.ShowDialog = DialogResult.OK Then
			RichTextBox1.LoadFile(OpenFileDialog1.FileName,
							  RichTextBoxStreamType.PlainText)
		End If

	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

		With SaveFileDialog1
			.Title = "Save File"
			.Filter = "Text Files | *.txt"
			.DefaultExt = ".txt"
			.OverwritePrompt = True
		End With

		If SaveFileDialog1.ShowDialog = DialogResult.OK Then
			RichTextBox1.SaveFile(SaveFileDialog1.FileName,
							  RichTextBoxStreamType.PlainText)
		End If

	End Sub

	Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

		If SaveFileDialog1.ShowDialog = DialogResult.OK Then

			SaveToolStripMenuItem_Click(sender, e)

		End If

	End Sub

	Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
		If FontDialog1.ShowDialog = DialogResult.OK Then
			RichTextBox1.Font = FontDialog1.Font
		End If
	End Sub

	Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
		If ColorDialog1.ShowDialog = DialogResult.OK Then
			RichTextBox1.ForeColor = ColorDialog1.Color
		End If

	End Sub

	Private Sub ProgramInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramInformationToolStripMenuItem.Click
		AboutBox1.ShowDialog()
		'When Program Information Button clicks it calls the built in AboutBox1.ShowDialog() method as if the user clicked the About button.
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

	End Sub

	Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click

		If WordWrapToolStripMenuItem.CheckState = CheckState.Checked Then
			RichTextBox1.WordWrap = True
		End If

		If WordWrapToolStripMenuItem.CheckState = CheckState.Unchecked Then
			RichTextBox1.WordWrap = False
		End If

	End Sub

End Class
