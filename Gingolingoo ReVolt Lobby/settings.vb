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

        checkParams()

        My.Settings.languagefile = Application.StartupPath & "\languages\" & ComboBox1.Text
        My.Settings.language = ComboBox1.Text
        My.Settings.Save()
        MainWindow.reloadall()
        '---------
        Me.Close()
    End Sub

    Private Function checkParams()

        If devmode.Checked = True Then
            My.Settings.paramdevmode = True
        Else
            My.Settings.paramdevmode = False
        End If

        If nointro.Checked = True Then
            My.Settings.paramnointro = True
        Else
            My.Settings.paramnointro = False
        End If

        If sload.Checked = True Then
            My.Settings.paramnoloading = True
        Else
            My.Settings.paramnoloading = False
        End If

        If tvtime.Checked = True Then
            My.Settings.paramtvtime = True
        Else
            My.Settings.paramtvtime = False
        End If

        If winmode.Checked = True Then
            My.Settings.paramwinmode = True
        Else
            My.Settings.paramwinmode = False
        End If

        If winx.Text = "" Or winy.Text = "" Then
            My.Settings.paramwinmode = False
        Else
            My.Settings.paramwinmodex = winx.Text
            My.Settings.paramwinmodey = winy.Text
        End If

        If aspect.Checked = True Then
            My.Settings.paramaspect = True
        Else
            My.Settings.paramaspect = False
        End If

        If aspectx.Text = "" Or aspecty.Text = "" Or aspectfov.Text = "" Then
            My.Settings.paramaspect = False
        Else
            My.Settings.paramaspectx = aspectx.Text
            My.Settings.paramaspecty = aspecty.Text
            My.Settings.paramaspectfov = aspectfov.Text
        End If

        If profile.Checked = True Then
            My.Settings.paramprofile = True
        Else
            My.Settings.paramprofile = False
        End If

        If profilebox.Text = "" Then
            My.Settings.paramprofilename = Nothing
        Else
            My.Settings.paramprofilename = profilebox.Text
        End If

        If gazzasaicar.Checked = True Then
            My.Settings.paramaicar = True
        Else
            My.Settings.paramaicar = False
        End If

        Return Nothing
    End Function

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

    Private Sub winmode_CheckedChanged(sender As Object, e As EventArgs) Handles winmode.CheckedChanged
        If winmode.Checked = True Then
            winx.Enabled = True
            winy.Enabled = True
        Else
            winx.Enabled = False
            winy.Enabled = False
        End If
    End Sub

    Private Sub devmode_CheckedChanged(sender As Object, e As EventArgs) Handles devmode.CheckedChanged
        If devmode.Checked = True Then
            gazzasaicar.Enabled = True
        Else
            gazzasaicar.Enabled = False
        End If
    End Sub

    Private Sub aspect_CheckedChanged(sender As Object, e As EventArgs) Handles aspect.CheckedChanged
        If aspect.Checked = True Then
            aspectx.Enabled = True
            aspecty.Enabled = True
            aspectfov.Enabled = True
        Else
            aspectx.Enabled = False
            aspecty.Enabled = False
            aspectfov.Enabled = False
        End If
    End Sub

    Private Sub profile_CheckedChanged(sender As Object, e As EventArgs) Handles profile.CheckedChanged
        If profile.Checked = True Then
            profilebox.Enabled = True
        Else
            profilebox.Enabled = False
        End If
    End Sub
End Class