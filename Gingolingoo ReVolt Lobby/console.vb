Public Class console

    Private Sub console_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            If TextBox1.Text = "/createserver" Then
                RichTextBox1.AppendText("Opening 'Create Server' ..." & vbNewLine)
                createserver.Show()
            ElseIf TextBox1.Text = "/cs" Then
                RichTextBox1.AppendText("Opening 'Create Server' ..." & vbNewLine)
                createserver.Show()
            ElseIf TextBox1.Text = "/settings" Then
                RichTextBox1.AppendText("Opening 'Settings' ..." & vbNewLine)
                settings.Show()
            ElseIf TextBox1.Text = "/s" Then
                RichTextBox1.AppendText("Opening 'Settings' ..." & vbNewLine)
                settings.Show()
            ElseIf TextBox1.Text = "/friendlist" Then
                'RichTextBox1.AppendText("Opening 'Friendlist' ..." & vbNewLine)
                'friendlist.Show() [not implemented yet]
            ElseIf TextBox1.Text = "/fl" Then
                'RichTextBox1.AppendText("Opening 'Friendlist' ..." & vbNewLine)
                'friendlist.Show() [not implemented yet]
            ElseIf TextBox1.Text = "/log" Then
                Try
                    If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\logs\") = False Then
                        My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\logs\")
                    End If
                    SaveFileDialog1.FileName = Application.StartupPath & "\logs\" &
                        Date.Now.Date.Day.ToString & "-" &
                        Date.Now.Date.Month.ToString & "-" &
                        Date.Now.Date.Year.ToString & "_" &
                        Date.Now.TimeOfDay.Hours.ToString & "-" &
                        Date.Now.TimeOfDay.Minutes.ToString & "-" &
                        Date.Now.TimeOfDay.Seconds.ToString & ".log"
                    MsgBox(SaveFileDialog1.FileName)
                    RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    RichTextBox1.AppendText("Logfile created: " & SaveFileDialog1.FileName & vbNewLine)
                Catch exc As Exception
                    RichTextBox1.AppendText("An Error occurred while creating a Log-File: " & exc.ToString & vbNewLine)
                End Try
            Else
                RichTextBox1.AppendText("Error: Could not recognize command: " & TextBox1.Text & vbNewLine)
            End If
            e.SuppressKeyPress = True
            TextBox1.Clear()
        End If
    End Sub
End Class