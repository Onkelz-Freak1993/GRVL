Imports System
Imports System.IO
Imports System.Collections
Imports System.Text
Imports System.Security.Cryptography

Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.nickname

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
        If TextBox2.Text = "" Then
            console.RichTextBox1.AppendText("Logging on as guest " & TextBox1.Text & vbNewLine)
            My.Settings.nickname = TextBox1.Text
            My.Settings.Save()
            MainWindow.Show()
            MainWindow.reloadall()
            Me.Close()
        Else
            Dim pass As String = GenerateSHA256String(TextBox2.Text)
            Using wd As New System.Net.WebClient()
                Dim loginCheck = wd.DownloadString("https://grvl.gingolingoo.de/api.php?action=login&uname=" + TextBox1.Text + "&pword=" + pass + "&ip=" + MainWindow.GetExternalIP())
                If loginCheck <> "0" Then
                    console.RichTextBox1.AppendText("Logging on as " & TextBox1.Text & vbNewLine)
                    My.Settings.nickname = loginCheck
                    My.Settings.Save()
                    MainWindow.Show()
                    MainWindow.reloadall()
                    Me.Close()
                Else
                    console.RichTextBox1.AppendText("Logging on as " & TextBox1.Text & " failed: Username or password wrong." & vbNewLine)
                    MsgBox("Username or password wrong!")
                End If
            End Using
        End If



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
End Class

