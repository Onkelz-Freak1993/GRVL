<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.extip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.wanip = New System.Windows.Forms.ToolStripSplitButton()
        Me.lanip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.grvlversion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.file = New System.Windows.Forms.ToolStripMenuItem()
        Me.newservermenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.quitmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.settingsmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.playermenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.onlinemenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ingamemenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.dndmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.invismenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.manage = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriendlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mods = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RVGLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.devtools = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.userlistContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.addAsFriend = New System.Windows.Forms.ToolStripMenuItem()
        Me.userimagelist = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.serverlist = New System.Windows.Forms.ListView()
        Me.pwd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.servernamecol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playercountcol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ipcol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.savechatas = New System.Windows.Forms.ToolStripButton()
        Me.delchathistory = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.mutebtn = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.quit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.create_server = New System.Windows.Forms.ToolStripButton()
        Me.connect_server = New System.Windows.Forms.ToolStripButton()
        Me.refreshserver = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.settingstoolstrip = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.friendlist = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.refreshall = New System.Windows.Forms.ToolStripButton()
        Me.about = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.bgwChatConnect = New System.ComponentModel.BackgroundWorker()
        Me.bgwUserlist = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.userlistContext.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.extip, Me.wanip, Me.ToolStripSeparator3, Me.grvlversion, Me.ToolStripStatusLabel4, Me.ToolStripSeparator4, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 491)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(757, 23)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'extip
        '
        Me.extip.Name = "extip"
        Me.extip.Size = New System.Drawing.Size(101, 18)
        Me.extip.Text = "$your_external_ip:"
        '
        'wanip
        '
        Me.wanip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lanip})
        Me.wanip.Name = "wanip"
        Me.wanip.Size = New System.Drawing.Size(66, 21)
        Me.wanip.Text = "$wan_ip"
        '
        'lanip
        '
        Me.lanip.Name = "lanip"
        Me.lanip.Size = New System.Drawing.Size(122, 22)
        Me.lanip.Text = "$lan_ip_1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'grvlversion
        '
        Me.grvlversion.Name = "grvlversion"
        Me.grvlversion.Size = New System.Drawing.Size(54, 18)
        Me.grvlversion.Text = "$version:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(72, 18)
        Me.ToolStripStatusLabel4.Text = "#.#.#.#####"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(44, 18)
        Me.ToolStripStatusLabel3.Text = "$status"
        Me.ToolStripStatusLabel3.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.file, Me.edit, Me.playermenu, Me.manage, Me.devtools})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(757, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'file
        '
        Me.file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newservermenu, Me.ToolStripMenuItem1, Me.quitmenu})
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(41, 20)
        Me.file.Text = "$file"
        '
        'newservermenu
        '
        Me.newservermenu.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.server_add
        Me.newservermenu.Name = "newservermenu"
        Me.newservermenu.Size = New System.Drawing.Size(138, 22)
        Me.newservermenu.Text = "$new_server"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 6)
        '
        'quitmenu
        '
        Me.quitmenu.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.cancel
        Me.quitmenu.Name = "quitmenu"
        Me.quitmenu.Size = New System.Drawing.Size(138, 22)
        Me.quitmenu.Text = "$quit"
        '
        'edit
        '
        Me.edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.settingsmenu})
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(45, 20)
        Me.edit.Text = "$edit"
        '
        'settingsmenu
        '
        Me.settingsmenu.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.cog
        Me.settingsmenu.Name = "settingsmenu"
        Me.settingsmenu.Size = New System.Drawing.Size(121, 22)
        Me.settingsmenu.Text = "$settings"
        '
        'playermenu
        '
        Me.playermenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.onlinemenu, Me.ingamemenu, Me.dndmenu, Me.ToolStripMenuItem2, Me.invismenu})
        Me.playermenu.Name = "playermenu"
        Me.playermenu.Size = New System.Drawing.Size(57, 20)
        Me.playermenu.Text = "$player"
        '
        'onlinemenu
        '
        Me.onlinemenu.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.user_green
        Me.onlinemenu.Name = "onlinemenu"
        Me.onlinemenu.Size = New System.Drawing.Size(163, 22)
        Me.onlinemenu.Text = "$online"
        '
        'ingamemenu
        '
        Me.ingamemenu.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.user_orange
        Me.ingamemenu.Name = "ingamemenu"
        Me.ingamemenu.Size = New System.Drawing.Size(163, 22)
        Me.ingamemenu.Text = "$ingame"
        '
        'dndmenu
        '
        Me.dndmenu.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.user_red
        Me.dndmenu.Name = "dndmenu"
        Me.dndmenu.Size = New System.Drawing.Size(163, 22)
        Me.dndmenu.Text = "$do_not_disturb"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 6)
        '
        'invismenu
        '
        Me.invismenu.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.user_gray
        Me.invismenu.Name = "invismenu"
        Me.invismenu.Size = New System.Drawing.Size(163, 22)
        Me.invismenu.Text = "$show_as_offline"
        '
        'manage
        '
        Me.manage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FriendlistToolStripMenuItem, Me.mods, Me.ToolStripMenuItem4, Me.RVGLToolStripMenuItem})
        Me.manage.Name = "manage"
        Me.manage.Size = New System.Drawing.Size(68, 20)
        Me.manage.Text = "$manage"
        '
        'FriendlistToolStripMenuItem
        '
        Me.FriendlistToolStripMenuItem.Enabled = False
        Me.FriendlistToolStripMenuItem.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.user
        Me.FriendlistToolStripMenuItem.Name = "FriendlistToolStripMenuItem"
        Me.FriendlistToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.FriendlistToolStripMenuItem.Text = "$friendlist"
        '
        'mods
        '
        Me.mods.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.wrench_orange
        Me.mods.Name = "mods"
        Me.mods.Size = New System.Drawing.Size(149, 22)
        Me.mods.Text = "$mods"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(146, 6)
        '
        'RVGLToolStripMenuItem
        '
        Me.RVGLToolStripMenuItem.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.RVGL_16x16
        Me.RVGLToolStripMenuItem.Name = "RVGLToolStripMenuItem"
        Me.RVGLToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.RVGLToolStripMenuItem.Text = "RVGL-Updater"
        '
        'devtools
        '
        Me.devtools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsoleToolStripMenuItem, Me.DeveloperManagerToolStripMenuItem})
        Me.devtools.Name = "devtools"
        Me.devtools.Size = New System.Drawing.Size(72, 20)
        Me.devtools.Text = "Developer"
        Me.devtools.Visible = False
        '
        'ConsoleToolStripMenuItem
        '
        Me.ConsoleToolStripMenuItem.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.application_xp_terminal
        Me.ConsoleToolStripMenuItem.Name = "ConsoleToolStripMenuItem"
        Me.ConsoleToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ConsoleToolStripMenuItem.Text = "Console"
        '
        'DeveloperManagerToolStripMenuItem
        '
        Me.DeveloperManagerToolStripMenuItem.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.chart_curve
        Me.DeveloperManagerToolStripMenuItem.Name = "DeveloperManagerToolStripMenuItem"
        Me.DeveloperManagerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DeveloperManagerToolStripMenuItem.Text = "Program Monitor"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(757, 443)
        Me.SplitContainer1.SplitterDistance = 202
        Me.SplitContainer1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.userlistContext
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.userimagelist
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(202, 443)
        Me.TreeView1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.TreeView1, "$nicklist")
        '
        'userlistContext
        '
        Me.userlistContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addAsFriend})
        Me.userlistContext.Name = "userlistContext"
        Me.userlistContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.userlistContext.Size = New System.Drawing.Size(131, 26)
        '
        'addAsFriend
        '
        Me.addAsFriend.Enabled = False
        Me.addAsFriend.Name = "addAsFriend"
        Me.addAsFriend.Size = New System.Drawing.Size(130, 22)
        Me.addAsFriend.Text = "Add friend"
        '
        'userimagelist
        '
        Me.userimagelist.ImageStream = CType(resources.GetObject("userimagelist.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.userimagelist.TransparentColor = System.Drawing.Color.Transparent
        Me.userimagelist.Images.SetKeyName(0, "user.png")
        Me.userimagelist.Images.SetKeyName(1, "user_gray.png")
        Me.userimagelist.Images.SetKeyName(2, "user_green.png")
        Me.userimagelist.Images.SetKeyName(3, "user_orange.png")
        Me.userimagelist.Images.SetKeyName(4, "user_red.png")
        Me.userimagelist.Images.SetKeyName(5, "world.png")
        Me.userimagelist.Images.SetKeyName(6, "house.png")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.serverlist)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(551, 443)
        Me.SplitContainer2.SplitterDistance = 141
        Me.SplitContainer2.TabIndex = 0
        '
        'serverlist
        '
        Me.serverlist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.pwd, Me.servernamecol, Me.playercountcol, Me.ipcol})
        Me.serverlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.serverlist.FullRowSelect = True
        Me.serverlist.Location = New System.Drawing.Point(0, 0)
        Me.serverlist.Name = "serverlist"
        Me.serverlist.Size = New System.Drawing.Size(551, 141)
        Me.serverlist.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.serverlist, "$serverlist")
        Me.serverlist.UseCompatibleStateImageBehavior = False
        Me.serverlist.View = System.Windows.Forms.View.Details
        '
        'pwd
        '
        Me.pwd.Text = ""
        Me.pwd.Width = 20
        '
        'servernamecol
        '
        Me.servernamecol.Text = "$server_name"
        Me.servernamecol.Width = 145
        '
        'playercountcol
        '
        Me.playercountcol.Text = "$playercount"
        Me.playercountcol.Width = 100
        '
        'ipcol
        '
        Me.ipcol.Text = "$ip"
        Me.ipcol.Width = 100
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.savechatas, Me.delchathistory, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.mutebtn})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(551, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'savechatas
        '
        Me.savechatas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.savechatas.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.script_save
        Me.savechatas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.savechatas.Name = "savechatas"
        Me.savechatas.Size = New System.Drawing.Size(23, 22)
        Me.savechatas.Text = "$save_chat_log"
        '
        'delchathistory
        '
        Me.delchathistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.delchathistory.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.script_delete
        Me.delchathistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.delchathistory.Name = "delchathistory"
        Me.delchathistory.Size = New System.Drawing.Size(23, 22)
        Me.delchathistory.Text = "$delete_chat_history"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel1.Text = "$typing"
        Me.ToolStripLabel1.Visible = False
        '
        'mutebtn
        '
        Me.mutebtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mutebtn.CheckOnClick = True
        Me.mutebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mutebtn.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.sound
        Me.mutebtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mutebtn.Name = "mutebtn"
        Me.mutebtn.Size = New System.Drawing.Size(23, 22)
        Me.mutebtn.Text = "ToolStripButton1"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(0, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(551, 20)
        Me.TextBox1.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(551, 253)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.quit, Me.ToolStripSeparator1, Me.create_server, Me.connect_server, Me.refreshserver, Me.ToolStripSeparator2, Me.settingstoolstrip, Me.ToolStripSeparator7, Me.friendlist, Me.ToolStripSeparator6, Me.refreshall, Me.about, Me.ToolStripButton1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(757, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'quit
        '
        Me.quit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.quit.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.cancel
        Me.quit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(23, 22)
        Me.quit.Text = "ToolStripButton2"
        Me.quit.ToolTipText = "$quit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'create_server
        '
        Me.create_server.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.create_server.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.server_add
        Me.create_server.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.create_server.Name = "create_server"
        Me.create_server.Size = New System.Drawing.Size(23, 22)
        Me.create_server.Text = "$new_server"
        Me.create_server.ToolTipText = "$create_server"
        '
        'connect_server
        '
        Me.connect_server.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.connect_server.Enabled = False
        Me.connect_server.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.server_connect
        Me.connect_server.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.connect_server.Name = "connect_server"
        Me.connect_server.Size = New System.Drawing.Size(23, 22)
        Me.connect_server.Text = "ToolStripButton3"
        Me.connect_server.ToolTipText = "$join_server"
        '
        'refreshserver
        '
        Me.refreshserver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.refreshserver.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.arrow_refresh
        Me.refreshserver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.refreshserver.Name = "refreshserver"
        Me.refreshserver.Size = New System.Drawing.Size(23, 22)
        Me.refreshserver.Text = "$refresh_server"
        Me.refreshserver.ToolTipText = "$refresh"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'settingstoolstrip
        '
        Me.settingstoolstrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.settingstoolstrip.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.cog
        Me.settingstoolstrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.settingstoolstrip.Name = "settingstoolstrip"
        Me.settingstoolstrip.Size = New System.Drawing.Size(23, 22)
        Me.settingstoolstrip.Text = "$settings"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'friendlist
        '
        Me.friendlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.friendlist.Enabled = False
        Me.friendlist.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.user
        Me.friendlist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.friendlist.Name = "friendlist"
        Me.friendlist.Size = New System.Drawing.Size(23, 22)
        Me.friendlist.Text = "$friendlist"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'refreshall
        '
        Me.refreshall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.refreshall.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.action_refresh_blue
        Me.refreshall.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.refreshall.Name = "refreshall"
        Me.refreshall.Size = New System.Drawing.Size(23, 22)
        Me.refreshall.Text = "$refresh_all"
        '
        'about
        '
        Me.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.about.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.information
        Me.about.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(23, 22)
        Me.about.Text = "ToolStripButton1"
        Me.about.ToolTipText = "$about"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ActiveLinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.LinkColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel2.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel2.Text = "$token"
        Me.ToolStripLabel2.VisitedLinkColor = System.Drawing.Color.Black
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Token:"
        Me.ToolStripLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckPathExists = False
        Me.SaveFileDialog1.DefaultExt = "*.txt"
        Me.SaveFileDialog1.Filter = "Text-Dateien|*.txt|Alle Dateien|*.*"
        Me.SaveFileDialog1.SupportMultiDottedExtensions = True
        '
        'bgwChatConnect
        '
        Me.bgwChatConnect.WorkerReportsProgress = True
        Me.bgwChatConnect.WorkerSupportsCancellation = True
        '
        'bgwUserlist
        '
        Me.bgwUserlist.WorkerReportsProgress = True
        Me.bgwUserlist.WorkerSupportsCancellation = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 514)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gingolingoo Re-Volt Lobby"
        Me.ToolTip1.SetToolTip(Me, "$new_server")
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.userlistContext.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents file As ToolStripMenuItem
    Friend WithEvents newservermenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents quitmenu As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents create_server As ToolStripButton
    Friend WithEvents quit As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents connect_server As ToolStripButton
    Friend WithEvents refreshserver As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents about As ToolStripButton
    Friend WithEvents edit As ToolStripMenuItem
    Friend WithEvents settingsmenu As ToolStripMenuItem
    Friend WithEvents extip As ToolStripStatusLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents serverlist As ListView
    Friend WithEvents servernamecol As ColumnHeader
    Friend WithEvents playercountcol As ColumnHeader
    Friend WithEvents ipcol As ColumnHeader
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents grvlversion As ToolStripStatusLabel
    Friend WithEvents refreshall As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents delchathistory As ToolStripButton
    Friend WithEvents savechatas As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents manage As ToolStripMenuItem
    Friend WithEvents FriendlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents settingstoolstrip As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents friendlist As ToolStripButton
    Friend WithEvents userimagelist As ImageList
    Friend WithEvents playermenu As ToolStripMenuItem
    Friend WithEvents onlinemenu As ToolStripMenuItem
    Friend WithEvents ingamemenu As ToolStripMenuItem
    Friend WithEvents dndmenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents invismenu As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents devtools As ToolStripMenuItem
    Friend WithEvents ConsoleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pwd As ColumnHeader
    Friend WithEvents mutebtn As ToolStripButton
    Friend WithEvents mods As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents userlistContext As ContextMenuStrip
    Friend WithEvents addAsFriend As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents RVGLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgwChatConnect As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwUserlist As System.ComponentModel.BackgroundWorker
    Friend WithEvents wanip As ToolStripSplitButton
    Friend WithEvents lanip As ToolStripMenuItem
    Friend WithEvents DeveloperManagerToolStripMenuItem As ToolStripMenuItem
End Class
