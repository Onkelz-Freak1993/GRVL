<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rvglupdater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rvglupdater))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.installedrvglver = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updatervglver = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "$installed_rvgl:"
        '
        'installedrvglver
        '
        Me.installedrvglver.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.installedrvglver.AutoSize = True
        Me.installedrvglver.Location = New System.Drawing.Point(99, 60)
        Me.installedrvglver.Name = "installedrvglver"
        Me.installedrvglver.Size = New System.Drawing.Size(47, 13)
        Me.installedrvglver.TabIndex = 1
        Me.installedrvglver.Text = "$version"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "$uptodate_rvgl:"
        '
        'updatervglver
        '
        Me.updatervglver.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.updatervglver.AutoSize = True
        Me.updatervglver.Location = New System.Drawing.Point(99, 73)
        Me.updatervglver.Name = "updatervglver"
        Me.updatervglver.Size = New System.Drawing.Size(59, 13)
        Me.updatervglver.TabIndex = 3
        Me.updatervglver.Text = "$version_2"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(275, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "$cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Location = New System.Drawing.Point(194, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "$update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "$updated_rvgl_is_available"
        '
        'rvglupdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 95)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.updatervglver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.installedrvglver)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rvglupdater"
        Me.Text = "$rvgl_updater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents installedrvglver As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents updatervglver As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
End Class
