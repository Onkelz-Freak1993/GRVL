﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.programsettings = New System.Windows.Forms.TabPage()
        Me.lang = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.nickname = New System.Windows.Forms.Label()
        Me.chatsettings = New System.Windows.Forms.GroupBox()
        Me.flashonmcmsg = New System.Windows.Forms.CheckBox()
        Me.gamesettings = New System.Windows.Forms.TabPage()
        Me.devparams = New System.Windows.Forms.GroupBox()
        Me.gazzasaicar = New System.Windows.Forms.CheckBox()
        Me.profilebox = New System.Windows.Forms.ComboBox()
        Me.tvtime = New System.Windows.Forms.CheckBox()
        Me.aspectfov = New System.Windows.Forms.TextBox()
        Me.aspecty = New System.Windows.Forms.TextBox()
        Me.aspectx = New System.Windows.Forms.TextBox()
        Me.aspect = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.winy = New System.Windows.Forms.TextBox()
        Me.winx = New System.Windows.Forms.TextBox()
        Me.winmode = New System.Windows.Forms.CheckBox()
        Me.profile = New System.Windows.Forms.CheckBox()
        Me.sload = New System.Windows.Forms.CheckBox()
        Me.nointro = New System.Windows.Forms.CheckBox()
        Me.devmode = New System.Windows.Forms.CheckBox()
        Me.pathtoexe = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.addparameter = New System.Windows.Forms.Label()
        Me.browsebtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cancel = New System.Windows.Forms.Button()
        Me.apply = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.programsettings.SuspendLayout()
        Me.chatsettings.SuspendLayout()
        Me.gamesettings.SuspendLayout()
        Me.devparams.SuspendLayout()
        Me.pathtoexe.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.programsettings)
        Me.TabControl1.Controls.Add(Me.gamesettings)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(322, 249)
        Me.TabControl1.TabIndex = 1
        '
        'programsettings
        '
        Me.programsettings.Controls.Add(Me.lang)
        Me.programsettings.Controls.Add(Me.ComboBox1)
        Me.programsettings.Controls.Add(Me.TextBox3)
        Me.programsettings.Controls.Add(Me.nickname)
        Me.programsettings.Controls.Add(Me.chatsettings)
        Me.programsettings.Location = New System.Drawing.Point(4, 22)
        Me.programsettings.Name = "programsettings"
        Me.programsettings.Padding = New System.Windows.Forms.Padding(3)
        Me.programsettings.Size = New System.Drawing.Size(314, 223)
        Me.programsettings.TabIndex = 0
        Me.programsettings.Text = "$programsettings"
        Me.programsettings.UseVisualStyleBackColor = True
        '
        'lang
        '
        Me.lang.AutoSize = True
        Me.lang.Location = New System.Drawing.Point(11, 48)
        Me.lang.Name = "lang"
        Me.lang.Size = New System.Drawing.Size(60, 13)
        Me.lang.TabIndex = 5
        Me.lang.Text = "$language:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(297, 20)
        Me.TextBox3.TabIndex = 1
        '
        'nickname
        '
        Me.nickname.AutoSize = True
        Me.nickname.Location = New System.Drawing.Point(6, 3)
        Me.nickname.Name = "nickname"
        Me.nickname.Size = New System.Drawing.Size(59, 13)
        Me.nickname.TabIndex = 2
        Me.nickname.Text = "$nickname"
        '
        'chatsettings
        '
        Me.chatsettings.Controls.Add(Me.flashonmcmsg)
        Me.chatsettings.Location = New System.Drawing.Point(8, 89)
        Me.chatsettings.Name = "chatsettings"
        Me.chatsettings.Size = New System.Drawing.Size(298, 115)
        Me.chatsettings.TabIndex = 1
        Me.chatsettings.TabStop = False
        Me.chatsettings.Text = "$chatsettings"
        '
        'flashonmcmsg
        '
        Me.flashonmcmsg.AutoSize = True
        Me.flashonmcmsg.Location = New System.Drawing.Point(6, 19)
        Me.flashonmcmsg.Name = "flashonmcmsg"
        Me.flashonmcmsg.Size = New System.Drawing.Size(146, 17)
        Me.flashonmcmsg.TabIndex = 2
        Me.flashonmcmsg.Text = "$flash_on_mainchat_msg"
        Me.flashonmcmsg.UseVisualStyleBackColor = True
        '
        'gamesettings
        '
        Me.gamesettings.Controls.Add(Me.devparams)
        Me.gamesettings.Controls.Add(Me.pathtoexe)
        Me.gamesettings.Location = New System.Drawing.Point(4, 22)
        Me.gamesettings.Name = "gamesettings"
        Me.gamesettings.Padding = New System.Windows.Forms.Padding(3)
        Me.gamesettings.Size = New System.Drawing.Size(314, 223)
        Me.gamesettings.TabIndex = 1
        Me.gamesettings.Text = "$gamesettings"
        Me.gamesettings.UseVisualStyleBackColor = True
        '
        'devparams
        '
        Me.devparams.Controls.Add(Me.gazzasaicar)
        Me.devparams.Controls.Add(Me.profilebox)
        Me.devparams.Controls.Add(Me.tvtime)
        Me.devparams.Controls.Add(Me.aspectfov)
        Me.devparams.Controls.Add(Me.aspecty)
        Me.devparams.Controls.Add(Me.aspectx)
        Me.devparams.Controls.Add(Me.aspect)
        Me.devparams.Controls.Add(Me.Label1)
        Me.devparams.Controls.Add(Me.winy)
        Me.devparams.Controls.Add(Me.winx)
        Me.devparams.Controls.Add(Me.winmode)
        Me.devparams.Controls.Add(Me.profile)
        Me.devparams.Controls.Add(Me.sload)
        Me.devparams.Controls.Add(Me.nointro)
        Me.devparams.Controls.Add(Me.devmode)
        Me.devparams.Location = New System.Drawing.Point(8, 101)
        Me.devparams.Name = "devparams"
        Me.devparams.Size = New System.Drawing.Size(298, 116)
        Me.devparams.TabIndex = 2
        Me.devparams.TabStop = False
        Me.devparams.Text = "$devparams"
        '
        'gazzasaicar
        '
        Me.gazzasaicar.AutoSize = True
        Me.gazzasaicar.Enabled = False
        Me.gazzasaicar.Location = New System.Drawing.Point(105, 87)
        Me.gazzasaicar.Name = "gazzasaicar"
        Me.gazzasaicar.Size = New System.Drawing.Size(85, 17)
        Me.gazzasaicar.TabIndex = 14
        Me.gazzasaicar.Text = "-gazzasaicar"
        Me.gazzasaicar.UseVisualStyleBackColor = True
        '
        'profilebox
        '
        Me.profilebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profilebox.Enabled = False
        Me.profilebox.FormattingEnabled = True
        Me.profilebox.Location = New System.Drawing.Point(198, 62)
        Me.profilebox.Name = "profilebox"
        Me.profilebox.Size = New System.Drawing.Size(94, 21)
        Me.profilebox.TabIndex = 13
        '
        'tvtime
        '
        Me.tvtime.AutoSize = True
        Me.tvtime.Location = New System.Drawing.Point(6, 87)
        Me.tvtime.Name = "tvtime"
        Me.tvtime.Size = New System.Drawing.Size(57, 17)
        Me.tvtime.TabIndex = 12
        Me.tvtime.Text = "-tvtime"
        Me.tvtime.UseVisualStyleBackColor = True
        '
        'aspectfov
        '
        Me.aspectfov.Enabled = False
        Me.aspectfov.Location = New System.Drawing.Point(260, 40)
        Me.aspectfov.Name = "aspectfov"
        Me.aspectfov.Size = New System.Drawing.Size(32, 20)
        Me.aspectfov.TabIndex = 11
        '
        'aspecty
        '
        Me.aspecty.Enabled = False
        Me.aspecty.Location = New System.Drawing.Point(213, 40)
        Me.aspecty.Name = "aspecty"
        Me.aspecty.Size = New System.Drawing.Size(33, 20)
        Me.aspecty.TabIndex = 10
        '
        'aspectx
        '
        Me.aspectx.Enabled = False
        Me.aspectx.Location = New System.Drawing.Point(176, 40)
        Me.aspectx.Name = "aspectx"
        Me.aspectx.Size = New System.Drawing.Size(31, 20)
        Me.aspectx.TabIndex = 9
        '
        'aspect
        '
        Me.aspect.AutoSize = True
        Me.aspect.Location = New System.Drawing.Point(105, 42)
        Me.aspect.Name = "aspect"
        Me.aspect.Size = New System.Drawing.Size(61, 17)
        Me.aspect.TabIndex = 8
        Me.aspect.Text = "-aspect"
        Me.aspect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "x"
        '
        'winy
        '
        Me.winy.Enabled = False
        Me.winy.Location = New System.Drawing.Point(250, 17)
        Me.winy.Name = "winy"
        Me.winy.Size = New System.Drawing.Size(42, 20)
        Me.winy.TabIndex = 6
        '
        'winx
        '
        Me.winx.Enabled = False
        Me.winx.Location = New System.Drawing.Point(185, 17)
        Me.winx.Name = "winx"
        Me.winx.Size = New System.Drawing.Size(42, 20)
        Me.winx.TabIndex = 5
        '
        'winmode
        '
        Me.winmode.AutoSize = True
        Me.winmode.Location = New System.Drawing.Point(105, 19)
        Me.winmode.Name = "winmode"
        Me.winmode.Size = New System.Drawing.Size(65, 17)
        Me.winmode.TabIndex = 4
        Me.winmode.Text = "-window"
        Me.winmode.UseVisualStyleBackColor = True
        '
        'profile
        '
        Me.profile.AutoSize = True
        Me.profile.Location = New System.Drawing.Point(105, 64)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(57, 17)
        Me.profile.TabIndex = 3
        Me.profile.Text = "-profile"
        Me.profile.UseVisualStyleBackColor = True
        '
        'sload
        '
        Me.sload.AutoSize = True
        Me.sload.Location = New System.Drawing.Point(6, 64)
        Me.sload.Name = "sload"
        Me.sload.Size = New System.Drawing.Size(54, 17)
        Me.sload.TabIndex = 2
        Me.sload.Text = "-sload"
        Me.sload.UseVisualStyleBackColor = True
        '
        'nointro
        '
        Me.nointro.AutoSize = True
        Me.nointro.Location = New System.Drawing.Point(6, 42)
        Me.nointro.Name = "nointro"
        Me.nointro.Size = New System.Drawing.Size(61, 17)
        Me.nointro.TabIndex = 1
        Me.nointro.Text = "-nointro"
        Me.nointro.UseVisualStyleBackColor = True
        '
        'devmode
        '
        Me.devmode.AutoSize = True
        Me.devmode.Location = New System.Drawing.Point(6, 19)
        Me.devmode.Name = "devmode"
        Me.devmode.Size = New System.Drawing.Size(47, 17)
        Me.devmode.TabIndex = 0
        Me.devmode.Text = "-dev"
        Me.devmode.UseVisualStyleBackColor = True
        '
        'pathtoexe
        '
        Me.pathtoexe.Controls.Add(Me.TextBox2)
        Me.pathtoexe.Controls.Add(Me.addparameter)
        Me.pathtoexe.Controls.Add(Me.browsebtn)
        Me.pathtoexe.Controls.Add(Me.TextBox1)
        Me.pathtoexe.Location = New System.Drawing.Point(8, 6)
        Me.pathtoexe.Name = "pathtoexe"
        Me.pathtoexe.Size = New System.Drawing.Size(298, 89)
        Me.pathtoexe.TabIndex = 1
        Me.pathtoexe.TabStop = False
        Me.pathtoexe.Text = "$path_to_executable"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(286, 20)
        Me.TextBox2.TabIndex = 3
        '
        'addparameter
        '
        Me.addparameter.AutoSize = True
        Me.addparameter.Location = New System.Drawing.Point(6, 47)
        Me.addparameter.Name = "addparameter"
        Me.addparameter.Size = New System.Drawing.Size(116, 13)
        Me.addparameter.TabIndex = 2
        Me.addparameter.Text = "$additional_parameters"
        '
        'browsebtn
        '
        Me.browsebtn.Location = New System.Drawing.Point(198, 18)
        Me.browsebtn.Name = "browsebtn"
        Me.browsebtn.Size = New System.Drawing.Size(94, 23)
        Me.browsebtn.TabIndex = 1
        Me.browsebtn.Text = "$browse"
        Me.browsebtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 0
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(243, 255)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 2
        Me.cancel.Text = "$cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'apply
        '
        Me.apply.Location = New System.Drawing.Point(162, 255)
        Me.apply.Name = "apply"
        Me.apply.Size = New System.Drawing.Size(75, 23)
        Me.apply.TabIndex = 3
        Me.apply.Text = "$apply"
        Me.apply.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "(*.exe)|*.exe"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 290)
        Me.Controls.Add(Me.apply)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "$settings"
        Me.TabControl1.ResumeLayout(False)
        Me.programsettings.ResumeLayout(False)
        Me.programsettings.PerformLayout()
        Me.chatsettings.ResumeLayout(False)
        Me.chatsettings.PerformLayout()
        Me.gamesettings.ResumeLayout(False)
        Me.devparams.ResumeLayout(False)
        Me.devparams.PerformLayout()
        Me.pathtoexe.ResumeLayout(False)
        Me.pathtoexe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents programsettings As TabPage
    Friend WithEvents flashonmcmsg As CheckBox
    Friend WithEvents gamesettings As TabPage
    Friend WithEvents pathtoexe As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents addparameter As Label
    Friend WithEvents browsebtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cancel As Button
    Friend WithEvents apply As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents nickname As Label
    Friend WithEvents chatsettings As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lang As Label
    Friend WithEvents devparams As GroupBox
    Friend WithEvents aspectfov As TextBox
    Friend WithEvents aspectx As TextBox
    Friend WithEvents aspect As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents winy As TextBox
    Friend WithEvents winx As TextBox
    Friend WithEvents winmode As CheckBox
    Friend WithEvents profile As CheckBox
    Friend WithEvents sload As CheckBox
    Friend WithEvents nointro As CheckBox
    Friend WithEvents devmode As CheckBox
    Friend WithEvents profilebox As ComboBox
    Friend WithEvents tvtime As CheckBox
    Friend WithEvents gazzasaicar As CheckBox
    Friend WithEvents aspecty As TextBox
End Class
