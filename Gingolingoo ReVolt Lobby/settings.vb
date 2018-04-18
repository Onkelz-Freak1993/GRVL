Public Class settings
    Dim Nodes(4096) As TreeNode

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles browsebtn.Click
        OpenFileDialog1.ShowDialog()
        Try
            TextBox1.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles apply.Click
        My.Settings.nickname = TextBox3.Text
        My.Settings.flash_nick_mainchat = flashonmcmsg.Checked
        My.Settings.revolt_path = TextBox1.Text
        My.Settings.parameters = TextBox2.Text
        My.Settings.languagefile = Application.StartupPath & "\languages\" & ComboBox1.Text
        My.Settings.language = ComboBox1.Text
        My.Settings.Save()
        MainWindow.reloadall()
        '---------
        Me.Close()
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\languages\")
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.ini")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ComboBox1.Items.Add(dra)
        Next
        ComboBox1.Text = My.Settings.language
        TextBox3.Text = My.Settings.nickname
        flashonmcmsg.Checked = My.Settings.flash_nick_mainchat
        TextBox1.Text = My.Settings.revolt_path
        TextBox2.Text = My.Settings.parameters
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.languagefile = Application.StartupPath & "\languages\" & ComboBox1.Text
        My.Settings.language = ComboBox1.Text
        MainWindow.SetLang()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles grvlcheck.CheckedChanged
        If grvlcheck.Checked = True Then
            grvlup.Enabled = True
        Else
            grvlup.Enabled = False
        End If
    End Sub

    Private Sub rvglcheck_CheckedChanged(sender As Object, e As EventArgs) Handles rvglcheck.CheckedChanged
        If rvglcheck.Checked = True Then
            rvglup.Enabled = True
        Else
            rvglup.Enabled = False
        End If
    End Sub
End Class