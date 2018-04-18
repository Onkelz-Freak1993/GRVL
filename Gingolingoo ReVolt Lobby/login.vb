Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net
Imports System.ComponentModel

Public Class login

    Dim changelogad As String = "https://raw.githubusercontent.com/Onkelz-Freak1993/GRVL-Development/master/changelog.txt"
    Dim client As WebClient = New WebClient()
    Dim reader As StreamReader = New StreamReader(client.OpenRead(changelogad))

    Dim token
    Dim loginCheck

    Dim chatBold As New Font("Arial", 12, FontStyle.Bold)
    Dim chatStandart As New Font("Arial", 9, FontStyle.Regular)
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = reader.ReadToEnd
        TextBox1.Text = My.Settings.nickname
        version.Text = My.Application.Info.Version.ToString
        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\languages\")
        Dim diar1 As IO.FileInfo() = di.GetFiles("*.ini")
        Dim dra As IO.FileInfo
        'list the names of all files in the specified directory
        For Each dra In diar1
            ComboBox1.Items.Add(dra)
        Next
        ComboBox1.Text = My.Settings.language
    End Sub
    Public Shared Function GenerateSHA256String(ByVal inputString) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function
    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        ok.Image = My.Resources.scp_ajax_loader
        'ok.Enabled = False
        bgwLogin.RunWorkerAsync()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Application.Exit()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.languagefile = Application.StartupPath & "\languages\" & ComboBox1.Text
        My.Settings.language = ComboBox1.Text
        My.Settings.Save()
        MainWindow.SetLang()
    End Sub

    Private Sub CreateAcc_Click(sender As Object, e As EventArgs) Handles createAccount.Click
        My.Settings.Save()
        register.Show()
        MainWindow.reloadall()
    End Sub

    Private Sub visitus_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles visitus.LinkClicked
        Process.Start("https://www.gingolingoo.de/")
    End Sub

    Private Sub visitgithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles visitgithub.LinkClicked
        Process.Start("https://github.com/Onkelz-Freak1993/GRVL-Development")
    End Sub

    Private Sub visitproject_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles visitproject.LinkClicked
        Process.Start("https://www.gingolingoo.de/grvl-project/")
    End Sub

    Private Sub bgwLogin_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgwLogin.DoWork
        If TextBox2.Text = "" Then
            Using wd As New System.Net.WebClient()
                loginCheck = wd.DownloadString("https://grvl.gingolingoo.de/api.php?action=playAsGuest&uname=" + TextBox1.Text)
            End Using
        Else
            Dim pass As String = GenerateSHA256String(TextBox2.Text)
            Using wd As New System.Net.WebClient()
                Dim logR = wd.DownloadString("https://grvl.gingolingoo.de/api.php?action=login&uname=" + TextBox1.Text + "&pword=" + pass + "&ip=" + MainWindow.GetExternalIP())
                Dim logD() = logR.Split(";")
                loginCheck = logD(0)
                My.Settings.token = logD(1)
            End Using
        End If
    End Sub

    Private Sub bgwLogin_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwLogin.RunWorkerCompleted
        If TextBox2.Text = "" Then
            If loginCheck <> "0" Then
                console.RichTextBox1.AppendText("Logging on as guest " & TextBox1.Text & vbNewLine)
                My.Settings.nickname = TextBox1.Text
                My.Settings.Save()
                MainWindow.Show()
                MainWindow.reloadall()
                Me.Close()
            Else
                MsgBox("Username already taken")
                ok.Enabled = True
                ok.Image = Nothing
            End If
        Else
            If loginCheck <> "0" Then
                console.RichTextBox1.AppendText("Logging on as " & TextBox1.Text & vbNewLine)
                My.Settings.nickname = TextBox1.Text
                MainWindow.RichTextBox1.SelectionFont = chatBold
                MainWindow.ToolStripLabel2.Text = loginCheck
                MainWindow.RichTextBox1.SelectionFont = chatStandart
                My.Settings.Save()
                MainWindow.Show()
                MainWindow.reloadall()
                Me.Close()
            Else
                console.RichTextBox1.AppendText("Logging on as " & TextBox1.Text & " failed: Username or password wrong." & vbNewLine)
                MsgBox("Username or password wrong!")
                ok.Enabled = True
                ok.Image = Nothing
            End If
        End If
    End Sub
End Class

