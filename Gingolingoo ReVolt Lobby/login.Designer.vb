﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.nickname = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.quit = New System.Windows.Forms.Button()
        Me.ok = New System.Windows.Forms.Button()
        Me.lang = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.Label()
        Me.createAccount = New System.Windows.Forms.Button()
        Me.guestplay = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.version = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.visitus = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bgwLogin = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nickname
        '
        Me.nickname.AutoSize = True
        Me.nickname.BackColor = System.Drawing.Color.Transparent
        Me.nickname.ForeColor = System.Drawing.Color.White
        Me.nickname.Location = New System.Drawing.Point(446, 24)
        Me.nickname.Name = "nickname"
        Me.nickname.Size = New System.Drawing.Size(59, 13)
        Me.nickname.TabIndex = 0
        Me.nickname.Text = "$nickname"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(449, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(323, 20)
        Me.TextBox1.TabIndex = 0
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(624, 420)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(148, 23)
        Me.quit.TabIndex = 2
        Me.quit.Text = "$quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ok.Location = New System.Drawing.Point(449, 420)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(159, 23)
        Me.ok.TabIndex = 2
        Me.ok.Text = "$ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'lang
        '
        Me.lang.AutoSize = True
        Me.lang.BackColor = System.Drawing.Color.Transparent
        Me.lang.ForeColor = System.Drawing.Color.White
        Me.lang.Location = New System.Drawing.Point(446, 158)
        Me.lang.Name = "lang"
        Me.lang.Size = New System.Drawing.Size(57, 13)
        Me.lang.TabIndex = 4
        Me.lang.Text = "$language"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(624, 155)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(449, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(323, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.Color.Transparent
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.Location = New System.Drawing.Point(446, 77)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(58, 13)
        Me.password.TabIndex = 7
        Me.password.Text = "$password"
        '
        'createAccount
        '
        Me.createAccount.Location = New System.Drawing.Point(624, 14)
        Me.createAccount.Name = "createAccount"
        Me.createAccount.Size = New System.Drawing.Size(148, 23)
        Me.createAccount.TabIndex = 8
        Me.createAccount.Text = "$createAccount"
        Me.createAccount.UseVisualStyleBackColor = True
        '
        'guestplay
        '
        Me.guestplay.BackColor = System.Drawing.Color.Transparent
        Me.guestplay.ForeColor = System.Drawing.Color.White
        Me.guestplay.Location = New System.Drawing.Point(446, 121)
        Me.guestplay.Name = "guestplay"
        Me.guestplay.Size = New System.Drawing.Size(326, 13)
        Me.guestplay.TabIndex = 9
        Me.guestplay.Text = "$guestplay"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(449, 212)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(323, 189)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.BackColor = System.Drawing.Color.Transparent
        Me.version.ForeColor = System.Drawing.Color.White
        Me.version.Location = New System.Drawing.Point(26, 409)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(44, 13)
        Me.version.TabIndex = 11
        Me.version.Text = "#.#.#.#"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(446, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Changelog"
        '
        'visitus
        '
        Me.visitus.AutoSize = True
        Me.visitus.BackColor = System.Drawing.Color.Transparent
        Me.visitus.LinkColor = System.Drawing.Color.White
        Me.visitus.Location = New System.Drawing.Point(26, 425)
        Me.visitus.Name = "visitus"
        Me.visitus.Size = New System.Drawing.Size(99, 13)
        Me.visitus.TabIndex = 13
        Me.visitus.TabStop = True
        Me.visitus.Text = "©2018 Gingolingoo"
        Me.visitus.VisitedLinkColor = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Thank you for using GRVL!"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(349, 79)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "In order to play with others online, just get yourself a Nickname. An Account is " &
    "only needed when you want to manage friends and modifications with GRVL."
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 65)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "You also can logon as a guest to play online without an account. To do that, just" &
    " get yourself a Nickname, select a language and click 'OK'."
        '
        'bgwLogin
        '
        Me.bgwLogin.WorkerReportsProgress = True
        Me.bgwLogin.WorkerSupportsCancellation = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Gingolingoo_ReVolt_Lobby.My.Resources.Resources.re_volt_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 100)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(274, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Visit GitHub Page"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(147, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Visit Project Page"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.visitus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.guestplay)
        Me.Controls.Add(Me.createAccount)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lang)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.nickname)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nickname As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents quit As Button
    Friend WithEvents ok As Button
    Friend WithEvents lang As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents password As Label
    Friend WithEvents createAccount As Button
    Friend WithEvents guestplay As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents version As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents visitus As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bgwLogin As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
