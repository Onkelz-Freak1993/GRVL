<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SuspendLayout()
        '
        'nickname
        '
        Me.nickname.AutoSize = True
        Me.nickname.Location = New System.Drawing.Point(9, 9)
        Me.nickname.Name = "nickname"
        Me.nickname.Size = New System.Drawing.Size(59, 13)
        Me.nickname.TabIndex = 0
        Me.nickname.Text = "$nickname"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(12, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 1
        '
        'quit
        '
        Me.quit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quit.Location = New System.Drawing.Point(287, 62)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(114, 23)
        Me.quit.TabIndex = 2
        Me.quit.Text = "$quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'ok
        '
        Me.ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok.Location = New System.Drawing.Point(176, 62)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(105, 23)
        Me.ok.TabIndex = 3
        Me.ok.Text = "$ok"
        Me.ok.UseVisualStyleBackColor = True
        '
        'lang
        '
        Me.lang.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lang.AutoSize = True
        Me.lang.Location = New System.Drawing.Point(173, 8)
        Me.lang.Name = "lang"
        Me.lang.Size = New System.Drawing.Size(57, 13)
        Me.lang.TabIndex = 4
        Me.lang.Text = "$language"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(176, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(158, 20)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(9, 48)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(58, 13)
        Me.password.TabIndex = 7
        Me.password.Text = "$password"
        '
        'createAccount
        '
        Me.createAccount.Location = New System.Drawing.Point(287, 22)
        Me.createAccount.Name = "createAccount"
        Me.createAccount.Size = New System.Drawing.Size(114, 23)
        Me.createAccount.TabIndex = 8
        Me.createAccount.Text = "$createAccount"
        Me.createAccount.UseVisualStyleBackColor = True
        '
        'guestplay
        '
        Me.guestplay.AutoSize = True
        Me.guestplay.Location = New System.Drawing.Point(12, 87)
        Me.guestplay.Name = "guestplay"
        Me.guestplay.Size = New System.Drawing.Size(58, 13)
        Me.guestplay.TabIndex = 9
        Me.guestplay.Text = "$guestplay"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 109)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
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
End Class
