Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel

Public Class MainWindow
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Dim grvlClose As Boolean = False
    Dim nick As String
    Dim friendscount As Int32 = 0
    Dim globalcount As Int32 = 0
    Dim localcount As Int32 = 0
    Dim offlinecount As Int64 = 0

    Private Sub AddItem(ByVal s As String)
        'ListBox1.Items.Add(s)
        If s = "Refresh" Then
            reloadall()
        Else
            RichTextBox1.AppendText(s.ToString + vbNewLine)
        End If
    End Sub

    <DllImport("kernel32")>
    Private Shared Function GetPrivateProfileString(ByVal section As String,
                                                    ByVal key As String,
                                                    ByVal def As String,
                                                    ByVal retVal As StringBuilder,
                                                    ByVal size As Integer,
                                                    ByVal filePath As String) As Integer
    End Function

    Public Function GetIniValue(section As String, key As String, filename As String, Optional defaultValue As String = "") As String
        'how the Ini-Stream is formed
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, My.Settings.languagefile) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function

    Dim Nodes(4096) As TreeNode
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nick = My.Settings.nickname
        ExecuteParams() 'Executes the Start Parameters like dev or console
        Me.Hide() 'hides the main form for displaying the login form first
        wanip.Text = GetExternalIP().ToString
        ToolStripStatusLabel4.Text = My.Application.Info.Version.ToString
        login.ComboBox1.Text = My.Settings.language
        settings.flashonmcmsg.Checked = My.Settings.flash_nick_mainchat
        mutebtn.Checked = My.Settings.muted
        If mutebtn.CheckState = CheckState.Checked Then
            mutebtn.Image = My.Resources.sound_mute
        Else
            mutebtn.Image = My.Resources.sound
        End If
        console.RichTextBox1.AppendText(My.Computer.Clock.LocalTime.ToString & vbNewLine)
        console.RichTextBox1.AppendText("OS: " & My.Computer.Info.OSFullName & vbNewLine)
        console.RichTextBox1.AppendText("Version: " & My.Computer.Info.OSVersion & vbNewLine)
        console.RichTextBox1.AppendText("Total RAM: " & My.Computer.Info.TotalPhysicalMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Total VRAM: " & My.Computer.Info.TotalVirtualMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Available RAM: " & My.Computer.Info.AvailablePhysicalMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Available VRAM: " & My.Computer.Info.AvailableVirtualMemory & " bytes" & vbNewLine)
        console.RichTextBox1.AppendText("Is connected to a Network: " & My.Computer.Network.IsAvailable.ToString & vbNewLine)



        'use this to flash in taskbar:
        'Dim res = WindowsApi.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 5)
        reloadall()

        playermenu.Text = My.Settings.nickname

        lanip.Text = GetIpV4()
    End Sub

    Private Sub refreshServerlist()
        serverlist.Items.Clear()
        Dim server()
        Dim servercount As Integer = 0
        Using wc As New System.Net.WebClient()
            console.RichTextBox1.AppendText("Trying API call 'gServer' ..." & vbNewLine)
            Dim sData = wc.DownloadString("https://grvl.gingolingoo.de/api.php?action=getServer")
            server = sData.Split(";")
            For Each mData As String In server
                If mData <> "" Then
                    Dim mdt() = mData.Split("|")
                    If mdt(3) <> "" Then
                        serverlist.Items.Add("🔒")
                    Else
                        serverlist.Items.Add("")
                    End If
                    serverlist.Items(servercount).SubItems.Add(mdt(0))
                    serverlist.Items(servercount).SubItems.Add(mdt(1) & " / " & mdt(2))
                    serverlist.Items(servercount).SubItems.Add(mdt(4))
                    servercount = servercount + 1
                End If
            Next
        End Using
    End Sub


    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch
                If grvlClose = False Then

                End If
            End Try
        End While
    End Sub

    Public Function reloadall()
        'reloads the Nicklist in the Main-Window
        Dim treeview1nodes As TreeNodeCollection = TreeView1.Nodes

        'Dim friendscount = Nodes(0).GetNodeCount(True)
        'Dim globalcount = Nodes(1).GetNodeCount(True)
        'Dim localcount = Nodes(2).GetNodeCount(True)
        'Dim offlinecount = Nodes(3).GetNodeCount(True)

        Dim friendsnode As String = GetIniValue("language", "$friends", My.Settings.languagefile, "$friends")
        Dim globalnode As String = GetIniValue("language", "$global", My.Settings.languagefile, "$global")
        Dim localnode As String = GetIniValue("language", "$local", My.Settings.languagefile, "$local")
        Dim offlinenode As String = GetIniValue("language", "$offline", My.Settings.languagefile, "$offline")

        TreeView1.Nodes.Clear()

        Nodes(0) = New TreeNode(friendsnode)
        Nodes(0).ImageIndex = 0
        Nodes(0).SelectedImageIndex = 0
        Nodes(0).Name = "friends"
        Nodes(1) = New TreeNode(globalnode)
        Nodes(1).ImageIndex = 5
        Nodes(1).SelectedImageIndex = 5
        Nodes(1).Name = "global"
        Nodes(2) = New TreeNode(localnode)
        Nodes(2).ImageIndex = 6
        Nodes(2).SelectedImageIndex = 6
        Nodes(2).Name = "local"
        Nodes(3) = New TreeNode(offlinenode)
        Nodes(3).ImageIndex = 1
        Nodes(3).SelectedImageIndex = 1
        Nodes(3).Name = "offline"

        TreeView1.Nodes.Add(Nodes(0))
        TreeView1.Nodes.Add(Nodes(1))
        TreeView1.Nodes.Add(Nodes(2))
        TreeView1.Nodes.Add(Nodes(3))

        TreeView1.Refresh()

        If Not bgwChatConnect.IsBusy Then
            bgwChatConnect.RunWorkerAsync()
        End If
        If Not bgwUserlist.IsBusy Then
            bgwUserlist.RunWorkerAsync()
        End If
        refreshServerlist()
        Return Nothing
    End Function

    Public Shared Function GetExternalIP() As String
        'Resolve the External IP-Adress
        Dim Response As String = String.Empty
        Try
            Dim ExternalIP As String
            ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                     .Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch ex As Exception
            Response = ex.Message.ToString
            console.RichTextBox1.AppendText(ex.Message.ToString)
        End Try
        Return Response 'show the IP-Adress in the Statusbar
        console.RichTextBox1.AppendText("External IP " & Response & " resolved" & vbNewLine)
    End Function

    Public Function GetIpV4() As String

        Dim myHost As String = Dns.GetHostName
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(myHost)
        Dim ip As String = ""

        For Each tmpIpAddress As IPAddress In ipEntry.AddressList
            If tmpIpAddress.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                Dim ipAddress As String = tmpIpAddress.ToString
                ip = ipAddress
                Exit For
            End If
        Next

        If ip = "" Then
            Throw New Exception("No 10. IP found!")
        End If

        Return ip

    End Function



    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles settingsmenu.Click
        'Shows the Settings-Window
        settings.Show()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        'gets the ENTER-KeyDown Event on the Chat-Textbox
        If e.KeyData = Keys.Enter Then
            If TextBox1.Text = "/console" Then
                console.Show()
            ElseIf TextBox1.Text = "/dev" Then
                devtools.Visible = True
                My.Settings.devtools = True
            ElseIf TextBox1.Text = "/createserver" Then
                createserver.Show()
            ElseIf TextBox1.Text = "/cs" Then
                createserver.Show()
            ElseIf TextBox1.Text = "/settings" Then
                settings.Show()
            ElseIf TextBox1.Text = "/s" Then
                settings.Show()
            ElseIf TextBox1.Text = "/friendlist" Then
                'friendlist.Show() [not implemented yet]
            ElseIf TextBox1.Text = "/fl" Then
                'friendlist.Show() [not implemented yet]
            Else
                console.RichTextBox1.AppendText("Attempting to send Message: " & TextBox1.Text & vbNewLine)
                streamw.WriteLine(TextBox1.Text)
                streamw.Flush()
            End If
            e.SuppressKeyPress = True
            TextBox1.Clear()
        End If
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles quitmenu.Click
        'quits the application
        Application.Exit()
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        'quits the application
        Application.Exit()
    End Sub

    Private Sub delchathistory_Click(sender As Object, e As EventArgs) Handles delchathistory.Click
        'deletes the chat history
        RichTextBox1.Text = Nothing
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Timer1.Start()
        ToolStripLabel1.Visible = True
        ToolStripLabel1.Text = My.Settings.nickname & " $is_typing"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'shows who is typing in main chat
        ToolStripLabel1.Text = "$typing"
        ToolStripLabel1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub refreshall_Click(sender As Object, e As EventArgs) Handles refreshall.Click
        'reloads all TreeView1-Entries, also known as the Nicklist
        reloadall()
    End Sub

    Private Sub create_server_Click(sender As Object, e As EventArgs) Handles create_server.Click
        'show the New-Server-Window
        createserver.Show()
    End Sub

    Private Sub NewserverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newservermenu.Click
        'show the New-Server-Window
        createserver.Show()
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settingstoolstrip.Click
        'show the settings-window
        settings.Show()
    End Sub

    Private Sub savechatas_Click(sender As Object, e As EventArgs) Handles savechatas.Click
        SaveFileDialog1.ShowDialog()
        Try
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        Catch exc As Exception
            If devtools.Visible = True Then
                console.RichTextBox1.AppendText(exc.Message.ToString)
            End If
        End Try
    End Sub


    '------- Haupt-Sub -------
    ' console = starts program with the build-in console for troubleshooting
    ' dev = enables the Developer-Menu
    Public Sub ExecuteParams()
        Dim args As String()
        Dim arguments As String
        args = Environment.GetCommandLineArgs()

        For i As Integer = 1 To args.Length - 1
            Select Case args(i).ToLower
                Case "dev"
                    devtools.Visible = True
                    My.Settings.devtools = True

                Case "console"
                    devtools.Visible = True
                    My.Settings.devtools = True
                    console.Show()

                Case "ip " & arguments
                    Try
                        Process.Start(My.Settings.revolt_path, My.Settings.parameters & " -lobby " & arguments)
                    Catch exc As Exception
                        console.RichTextBox1.AppendText(exc.ToString & vbNewLine)
                        If My.Settings.devtools = True Then
                            MsgBox(exc.ToString)
                        End If
                    End Try

                Case Else
                    console.RichTextBox1.AppendText(args(i).ToString & " is no known Parameter." & vbNewLine)
            End Select
        Next

    End Sub

    Private Sub ConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleToolStripMenuItem.Click
        'show the Console-Window
        console.Show()
    End Sub


    Public Function SetLang()
        'Hier werden die Sprachateien ausgelesen und mit den Werten der INI ersetzt

        'Login
        login.ok.Text = GetIniValue("language", "$ok", My.Settings.languagefile, "$ok")
        login.quit.Text = GetIniValue("language", "$quit", My.Settings.languagefile, "$quit")
        login.nickname.Text = GetIniValue("language", "$nickname", My.Settings.languagefile, "$nickname")
        login.lang.Text = GetIniValue("language", "$language", My.Settings.languagefile, "$language")
        login.password.Text = GetIniValue("language", "$password", My.Settings.languagefile, "$password")
        login.createAccount.Text = GetIniValue("language", "$createAccount", My.Settings.languagefile, "$createAccount")
        'Register
        register.username.Text = GetIniValue("language", "$nickname", My.Settings.languagefile, "$nickname")
        register.password.Text = GetIniValue("language", "$password", My.Settings.languagefile, "$password")
        register.repassword.Text = GetIniValue("language", "$rePassword", My.Settings.languagefile, "$rePassword")
        register.email.Text = GetIniValue("language", "$email", My.Settings.languagefile, "$email")
        register.registerButton.Text = GetIniValue("language", "$register", My.Settings.languagefile, "$register")
        login.guestplay.Text = GetIniValue("language", "$guestplay", My.Settings.languagefile, "$guestplay")

        'Main window
        file.Text = GetIniValue("language", "$file", My.Settings.languagefile, "$file")
        newservermenu.Text = GetIniValue("language", "$new_server", My.Settings.languagefile, "$new_server")
        quitmenu.Text = GetIniValue("language", "$quit", My.Settings.languagefile, "$quit")
        quit.ToolTipText = GetIniValue("language", "$quit", My.Settings.languagefile, "$quit")
        create_server.ToolTipText = GetIniValue("language", "$new_server", My.Settings.languagefile, "$new_server")
        connect_server.ToolTipText = GetIniValue("language", "$join_server", My.Settings.languagefile, "$join_server")
        extip.Text = GetIniValue("language", "$your_external_ip", My.Settings.languagefile, "$your_external_ip")
        grvlversion.Text = GetIniValue("language", "$version", My.Settings.languagefile, "$version")
        playercountcol.Text = GetIniValue("language", "$playercount", My.Settings.languagefile, "$playercount")
        servernamecol.Text = GetIniValue("language", "$servername", My.Settings.languagefile, "$servername")
        ipcol.Text = GetIniValue("language", "$ip", My.Settings.languagefile, "$ip")
        refreshserver.ToolTipText = GetIniValue("language", "$refresh", My.Settings.languagefile, "$refresh")
        refreshall.ToolTipText = GetIniValue("language", "$refreshall", My.Settings.languagefile, "$refreshall")
        edit.Text = GetIniValue("language", "$edit", My.Settings.languagefile, "$edit")
        settingsmenu.Text = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        settingstoolstrip.Text = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        onlinemenu.Text = GetIniValue("language", "$online", My.Settings.languagefile, "$online")
        ingamemenu.Text = GetIniValue("language", "$ingame", My.Settings.languagefile, "$ingame")
        dndmenu.Text = GetIniValue("language", "$do_not_disturb", My.Settings.languagefile, "$do_not_disturb")
        invismenu.Text = GetIniValue("language", "$show_as_offline", My.Settings.languagefile, "$show_as_offline")
        manage.Text = GetIniValue("language", "$manage", My.Settings.languagefile, "$manage")
        friendlist.Text = GetIniValue("language", "$friendlist", My.Settings.languagefile, "$friendlist")
        FriendlistToolStripMenuItem.Text = GetIniValue("language", "$friendlist", My.Settings.languagefile, "$friendlist")
        savechatas.Text = GetIniValue("language", "$save_chat_log", My.Settings.languagefile, "$save_chat_log")
        delchathistory.Text = GetIniValue("language", "$delete_chat_history", My.Settings.languagefile, "$delete_chat_history")
        about.ToolTipText = GetIniValue("language", "$about", My.Settings.languagefile, "$about")
        mods.Text = GetIniValue("language", "$mods", My.Settings.languagefile, "$mods")
        'pwd.Text = GetIniValue("language", "$is_pwd_protected", My.Settings.languagefile, "$is_pwd_protected")
        'friendsonly.Text = GetIniValue("language", "$is_friends_only", My.Settings.languagefile, "$is_friends_only")
        'playermenu.Text = GetIniValue("language", "$player", My.Settings.languagefile, "$player")
        playermenu.Text = My.Settings.nickname

        'Settings
        settings.Text = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        settings.lang.Text = GetIniValue("language", "$language", My.Settings.languagefile, "$language")
        settings.nickname.Text = GetIniValue("language", "$nickname", My.Settings.languagefile, "$nickname")
        settings.flashonmcmsg.Text = GetIniValue("language", "$flash_on_mainchat_msg", My.Settings.languagefile, "$flash_on_mainchat_msg")
        settings.apply.Text = GetIniValue("language", "$apply", My.Settings.languagefile, "$apply")
        settings.cancel.Text = GetIniValue("language", "$cancel", My.Settings.languagefile, "$cancel")
        settings.chatsettings.Text = GetIniValue("language", "$chatsettings", My.Settings.languagefile, "$chatsettings")
        settings.programsettings.Text = GetIniValue("language", "$programsettings", My.Settings.languagefile, "$programsettings")
        settings.gamesettings.Text = GetIniValue("language", "$gamesettings", My.Settings.languagefile, "$gamesettings")
        settings.pathtoexe.Text = GetIniValue("language", "$path_to_executable", My.Settings.languagefile, "$path_to_executable")
        settings.addparameter.Text = GetIniValue("language", "$additional_parameters", My.Settings.languagefile, "$additional_parameters")
        settings.browsebtn.Text = GetIniValue("language", "$browse", My.Settings.languagefile, "$browse")

        'Multiplayer Lobby
        mplobby.readystate.Text = GetIniValue("language", "$ready_state", My.Settings.languagefile, "$ready_state")
        mplobby.closelobby.ToolTipText = GetIniValue("language", "$close_lobby", My.Settings.languagefile, "$close_lobby")
        mplobby.startgame.ToolTipText = GetIniValue("language", "$start_game", My.Settings.languagefile, "$start_game")
        mplobby.settings.ToolTipText = GetIniValue("language", "$settings", My.Settings.languagefile, "$settings")
        mplobby.invitefriend.ToolTipText = GetIniValue("language", "$invite", My.Settings.languagefile, "$invite")
        mplobby.savelog.ToolTipText = GetIniValue("language", "$save_chat_log", My.Settings.languagefile, "$save_chat_log")
        mplobby.delchathist.ToolTipText = GetIniValue("language", "$delete_chat_history", My.Settings.languagefile, "$delete_chat_history")
        mplobby.readybtn.ToolTipText = GetIniValue("language", "$ready", My.Settings.languagefile, "$ready")

        'New Server
        createserver.Text = GetIniValue("language", "$createserver", My.Settings.languagefile, "$createserver")
        createserver.ok.Text = GetIniValue("language", "$ok", My.Settings.languagefile, "$ok")
        createserver.cancel.Text = GetIniValue("language", "$cancel", My.Settings.languagefile, "$cancel")
        createserver.serverinfo.Text = GetIniValue("language", "$serverinfo", My.Settings.languagefile, "$serverinfo")
        createserver.servername.Text = GetIniValue("language", "$servername", My.Settings.languagefile, "$servername")
        createserver.password.Text = GetIniValue("language", "$password", My.Settings.languagefile, "$password")
        createserver.raceoptions.Text = GetIniValue("language", "$raceoptions", My.Settings.languagefile, "$raceoptions")
        createserver.pickups.Text = GetIniValue("language", "$pickups", My.Settings.languagefile, "$pickups")
        createserver.laps.Text = GetIniValue("language", "$laps", My.Settings.languagefile, "$laps")
        createserver.player.Text = GetIniValue("language", "$player", My.Settings.languagefile, "$player")
        createserver.friendsonly.Text = GetIniValue("language", "$friends_only", My.Settings.languagefile, "$friends_only")
        createserver.gameversion.Text = GetIniValue("language", "$gameversion", My.Settings.languagefile, "$gameversion")
        createserver.allversion.Text = GetIniValue("language", "$all", My.Settings.languagefile, "$all")
        createserver.rev12.Text = GetIniValue("language", "$revolt_1.2", My.Settings.languagefile, "$revolt_1.2")
        createserver.rvgl.Text = GetIniValue("language", "$rvgl", My.Settings.languagefile, "$rvgl")

        Return Nothing
    End Function

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        'show the 'About This Program'-Window
        aboutus.Show()
    End Sub

    Public Function GetIniSetting()
        'used to read the ini-files
        Dim file_stream As System.IO.StreamReader = New System.IO.StreamReader(My.Settings.languagefile)
        Dim inhalt As String = file_stream.ReadToEnd()
        Dim anfang_des_attributs As Integer = InStr(inhalt, "Wert ") + 12
        Dim ende_des_werts As Integer = InStr(anfang_des_attributs, inhalt, vbNewLine)
        Dim länge_des_werts As Integer = ende_des_werts - anfang_des_attributs
        Dim Wert As String = Mid(inhalt, anfang_des_attributs, länge_des_werts)
        MsgBox(Wert)
        Return Nothing
    End Function

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.ReadOnly = False
        If RichTextBox1.Text.Contains(":D") Then
            Dim smilie As Image = My.Resources.l
            Clipboard.SetImage(smilie)
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(":D")
            RichTextBox1.SelectionLength = 2
            RichTextBox1.Paste()
        End If
        If RichTextBox1.Text.Contains(":)") Then
            Dim smilie As Image = My.Resources.s
            Clipboard.SetImage(smilie)
            RichTextBox1.SelectionStart = RichTextBox1.Text.IndexOf(":)")
            RichTextBox1.SelectionLength = 2
            RichTextBox1.Paste()
        End If

        RichTextBox1.ReadOnly = True
        If My.Settings.flash_nick_mainchat = True Then
            Dim res = WindowsApi.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 5)
        End If
        If mutebtn.CheckState = CheckState.Unchecked Then
            My.Computer.Audio.Play(My.Resources.message, AudioPlayMode.Background)
        End If
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub mutebtn_Click(sender As Object, e As EventArgs) Handles mutebtn.Click
        If mutebtn.CheckState = CheckState.Checked Then
            mutebtn.Image = My.Resources.sound_mute
        Else
            mutebtn.Image = My.Resources.sound
        End If
        My.Settings.muted = mutebtn.Checked
    End Sub

    Private Sub MainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        grvlClose = True
        Try
            client.Close()
            t.Interrupt()
            t.Abort()
            Using wc As New System.Net.WebClient()
                Dim udata = wc.DownloadString("https://grvl.gingolingoo.de/api.php?action=setState&uuid=" + My.Settings.uuid + "&st=" + My.Settings.token + "&state=0&removeToken=1")
            End Using
        Catch ex As Exception
        End Try
        Application.Exit()
    End Sub

    Private Sub ModsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mods.Click
        modloader.Show()
    End Sub

    Private Sub onlinemenu_Click(sender As Object, e As EventArgs) Handles onlinemenu.Click
        Using wc As New System.Net.WebClient()
            Dim udata = wc.DownloadString("https://grvl.gingolingoo.de/api.php?action=setState&uuid=" + My.Settings.uuid + "&st=" + My.Settings.token + "&state=1")
        End Using
        playermenu.Image = My.Resources.user_green
    End Sub

    Private Sub ingamemenu_Click(sender As Object, e As EventArgs) Handles ingamemenu.Click
        Using wc As New System.Net.WebClient()
            Dim udata = wc.DownloadString("https://grvl.gingolingoo.de/api.php?action=setState&uuid=" + My.Settings.uuid + "&st=" + My.Settings.token + "&state=2")
        End Using
        playermenu.Image = My.Resources.user_orange
    End Sub

    Private Sub dndmenu_Click(sender As Object, e As EventArgs) Handles dndmenu.Click
        Using wc As New System.Net.WebClient()
            Dim udata = wc.DownloadString("https://grvl.gingolingoo.de/api.php?action=setState&uuid=" + My.Settings.uuid + "&st=" + My.Settings.token + "&state=3")
        End Using
        playermenu.Image = My.Resources.user_red
    End Sub

    Private Sub invismenu_Click(sender As Object, e As EventArgs) Handles invismenu.Click
        Using wc As New System.Net.WebClient()
            Dim udata = wc.DownloadString("https://grvl.gingolingoo.de/api.php?action=setState&uuid=" + My.Settings.uuid + "&st=" + My.Settings.token + "&state=0")
        End Using
        playermenu.Image = My.Resources.user_gray
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Clipboard.SetText(ToolStripLabel2.Text)
    End Sub

    Private Sub refreshserver_Click(sender As Object, e As EventArgs) Handles refreshserver.Click
        refreshServerlist()
    End Sub

    Private Sub RVGLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RVGLToolStripMenuItem.Click
        rvglupdater.Show()
    End Sub

    Private Sub bgwChatConnect_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwChatConnect.DoWork
        Try
            console.RichTextBox1.AppendText("Connection establishing to 134.255.217.252:9999 ... ")
            client.Connect("134.255.217.252", 9999) ' hier die ip des servers eintragen. 
            If client.Connected Then
                console.RichTextBox1.AppendText("Connected." & vbNewLine)
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine(nick) ' optional.
                streamw.Flush()
                t.Start()
            End If
        Catch ex As Exception
            console.RichTextBox1.AppendText("failed" & vbNewLine & "Couldn't connect to 134.255.217.252:9999" & vbNewLine)
        End Try
    End Sub
    Dim udata
    Private Sub bgwUserlist_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwUserlist.DoWork
        Try
            Using wc As New System.Net.WebClient()
                console.RichTextBox1.AppendText("Trying API call 'udata' ..." & vbNewLine)

                udata = wc.DownloadString("https://grvl.gingolingoo.de/api.php?action=getUsers")

            End Using
        Catch ex As Exception
            If My.Settings.devtools = True Then
                MsgBox(ex.ToString)
                console.RichTextBox1.AppendText(ex.ToString & vbNewLine)
            Else
                MsgBox(GetIniValue("language", "$no_inet_error", My.Settings.languagefile, "$no_inet_error"), 0, "Error")
            End If
        End Try
    End Sub

    Private Sub bgwUserlist_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwUserlist.RunWorkerCompleted
        Dim users()
        Dim uCount As Integer = 10
        Dim tmpNode() As TreeNode = TreeView1.Nodes.Find("global", True)
        Dim tmpNodeOffline() As TreeNode = TreeView1.Nodes.Find("offline", True)

        users = udata.Split(";")
        For Each item As String In users

            Dim userdata() = item.Split("|")
            If userdata(0) <> "" Then
                Nodes(uCount) = New TreeNode(userdata(0))
                If userdata(1) = 0 Then
                    Nodes(uCount).ImageIndex = 1
                    Nodes(uCount).SelectedImageIndex = 1
                End If
                If userdata(1) = 1 Then
                    Nodes(uCount).ImageIndex = 2
                    Nodes(uCount).SelectedImageIndex = 2
                End If
                If userdata(1) = 2 Then
                    Nodes(uCount).ImageIndex = 3
                    Nodes(uCount).SelectedImageIndex = 3
                End If
                If userdata(1) = 3 Then
                    Nodes(uCount).ImageIndex = 4
                    Nodes(uCount).SelectedImageIndex = 4
                End If
                If userdata(1) = 0 Then
                    tmpNodeOffline(0).Nodes.Add(Nodes(uCount))
                Else
                    tmpNode(0).Nodes.Add(Nodes(uCount))
                End If
            End If
        Next
        TreeView1.ExpandAll()
    End Sub

    Private Sub wanip_ButtonClick(sender As Object, e As EventArgs) Handles wanip.ButtonClick
        Clipboard.SetText(wanip.Text)
    End Sub

    Private Sub lanip_Click(sender As Object, e As EventArgs) Handles lanip.Click
        Clipboard.SetText(lanip.Text)
    End Sub

    Private Sub DeveloperManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperManagerToolStripMenuItem.Click
        prgmonitor.Show()
    End Sub

    Private Function connectToServer()
        If serverlist.SelectedItems Is Nothing Then
            'nothing :P
        Else
            Try
                Process.Start(My.Settings.revolt_path, My.Settings.parameters & " -lobby " & serverlist.SelectedItems.Item(0).SubItems(3).Text)
            Catch exc As Exception
                console.RichTextBox1.AppendText(exc.ToString & vbNewLine)
                If My.Settings.devtools = True Then
                    MsgBox(exc.ToString)
                End If
            End Try
        End If
    End Function
    Private Sub serverlist_DoubleClick(sender As Object, e As EventArgs) Handles serverlist.DoubleClick
        connectToServer()
    End Sub

    Private Sub ConnecttoipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnecttoipToolStripMenuItem.Click
        connectToServer()
    End Sub
End Class

Public Class WindowsApi
    Private Declare Function FlashWindowEx Lib "User32" (ByRef fwInfo As FLASHWINFO) As Boolean

    ' As defined by: http://msdn.microsoft.com/en-us/library/ms679347(v=vs.85).aspx
    Public Enum FlashWindowFlags As UInt32
        ' Stop flashing. The system restores the window to its original state.
        FLASHW_STOP = 0
        ' Flash the window caption.
        FLASHW_CAPTION = 1
        ' Flash the taskbar button.
        FLASHW_TRAY = 2
        ' Flash both the window caption and taskbar button.
        ' This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
        FLASHW_ALL = 3
        ' Flash continuously, until the FLASHW_STOP flag is set.
        FLASHW_TIMER = 4
        ' Flash continuously until the window comes to the foreground.
        FLASHW_TIMERNOFG = 12
    End Enum

    Public Structure FLASHWINFO
        'for flashing in taskbar
        Public cbSize As UInt32
        Public hwnd As IntPtr
        Public dwFlags As FlashWindowFlags
        Public uCount As UInt32
        Public dwTimeout As UInt32
    End Structure

    Public Shared Function FlashWindow(ByRef handle As IntPtr, ByVal FlashTitleBar As Boolean, ByVal FlashTray As Boolean, ByVal FlashCount As Integer) As Boolean

        ' for flashing in taskbar
        If handle = Nothing Then Return False
        Try
            Dim fwi As New FLASHWINFO
            With fwi
                .hwnd = handle
                If FlashTitleBar Then .dwFlags = .dwFlags Or FlashWindowFlags.FLASHW_CAPTION
                If FlashTray Then .dwFlags = .dwFlags Or FlashWindowFlags.FLASHW_TRAY
                .uCount = CUInt(FlashCount)
                If FlashCount = 0 Then .dwFlags = .dwFlags Or FlashWindowFlags.FLASHW_TIMERNOFG
                .dwTimeout = 0 ' Use the default cursor blink rate.
                .cbSize = CUInt(System.Runtime.InteropServices.Marshal.SizeOf(fwi))
            End With

            Return FlashWindowEx(fwi)
        Catch ex As Exception
            console.RichTextBox1.AppendText(ex.Message.ToString)
            Return False
        End Try
    End Function
End Class