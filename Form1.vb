Imports System.IO
Imports System.Windows.Forms

Public Class Form1

	Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

	End Sub

	Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click

		With OpenFileDialog1
			.Title = "Open File"
			.Filter = "Rich Text Files | *.rtf"
			.FileName = ""
			.CheckFileExists = vbTrue
		End With

		If OpenFileDialog1.ShowDialog = DialogResult.OK Then
			RichTextBox1.LoadFile(OpenFileDialog1.FileName,
								  RichTextBoxStreamType.RichText)
		End If

	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

		With SaveFileDialog1
			.Title = "Save File"
			.Filter = "Rich Text Files | *.rtf"
			.DefaultExt = ".rtf"
			.OverwritePrompt = True
		End With

		If SaveFileDialog1.ShowDialog = DialogResult.OK Then
			RichTextBox1.SaveFile(SaveFileDialog1.FileName,
								  RichTextBoxStreamType.RichText)
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

	Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
		MessageBox.Show(FindMyText(New Char()).ToString())
	End Sub

	Public Function FindMyText(text As String) As Boolean
		' Initialize the return value to false by default.
		Dim returnValue As Boolean = False

		' Ensure a search string has been specified.
		If text.Length > 0 Then
			' Obtain the location of the search string in richTextBox1.
			Dim indexToText As Integer = RichTextBox1.Find(text, RichTextBoxFinds.MatchCase)
			' Determine if the text was found in richTextBox1.
			If indexToText >= 0 Then
				returnValue = True
			End If
		End If

		Return returnValue
	End Function





End Class
