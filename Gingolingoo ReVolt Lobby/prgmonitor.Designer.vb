<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class prgmonitor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.intip = New System.Windows.Forms.Label()
        Me.extip = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.netout = New System.Windows.Forms.Label()
        Me.netin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.netinlbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.netoutlbl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.avvirtmem = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.avphysmem = New System.Windows.Forms.Label()
        Me.totalvirtmem = New System.Windows.Forms.Label()
        Me.totalphysmem = New System.Windows.Forms.Label()
        Me.osver = New System.Windows.Forms.Label()
        Me.osname = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ramprgr = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ramusg = New System.Windows.Forms.Label()
        Me.cpuload = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cpuprgr = New System.Windows.Forms.ProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.regrevoltpath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ramprgr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ramusg)
        Me.GroupBox1.Controls.Add(Me.cpuload)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cpuprgr)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.intip)
        Me.GroupBox3.Controls.Add(Me.extip)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.netout)
        Me.GroupBox3.Controls.Add(Me.netin)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.netinlbl)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.netoutlbl)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 120)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Network"
        '
        'intip
        '
        Me.intip.Location = New System.Drawing.Point(198, 97)
        Me.intip.Name = "intip"
        Me.intip.Size = New System.Drawing.Size(100, 16)
        Me.intip.TabIndex = 11
        Me.intip.Text = "###.###.###.###"
        Me.intip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'extip
        '
        Me.extip.Location = New System.Drawing.Point(52, 97)
        Me.extip.Name = "extip"
        Me.extip.Size = New System.Drawing.Size(100, 16)
        Me.extip.TabIndex = 11
        Me.extip.Text = "###.###.###.###"
        Me.extip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(40, 18)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(258, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'netout
        '
        Me.netout.Location = New System.Drawing.Point(45, 67)
        Me.netout.Name = "netout"
        Me.netout.Size = New System.Drawing.Size(253, 23)
        Me.netout.TabIndex = 9
        Me.netout.Text = "-"
        Me.netout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'netin
        '
        Me.netin.Location = New System.Drawing.Point(33, 42)
        Me.netin.Name = "netin"
        Me.netin.Size = New System.Drawing.Size(265, 23)
        Me.netin.TabIndex = 10
        Me.netin.Text = "-"
        Me.netin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NIC:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'netinlbl
        '
        Me.netinlbl.AutoSize = True
        Me.netinlbl.Location = New System.Drawing.Point(6, 47)
        Me.netinlbl.Name = "netinlbl"
        Me.netinlbl.Size = New System.Drawing.Size(21, 13)
        Me.netinlbl.TabIndex = 5
        Me.netinlbl.Text = "IN:"
        Me.netinlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(158, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "int. IP:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ext. IP:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'netoutlbl
        '
        Me.netoutlbl.AutoSize = True
        Me.netoutlbl.Location = New System.Drawing.Point(6, 72)
        Me.netoutlbl.Name = "netoutlbl"
        Me.netoutlbl.Size = New System.Drawing.Size(33, 13)
        Me.netoutlbl.TabIndex = 8
        Me.netoutlbl.Text = "OUT:"
        Me.netoutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.avvirtmem)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.avphysmem)
        Me.GroupBox2.Controls.Add(Me.totalvirtmem)
        Me.GroupBox2.Controls.Add(Me.totalphysmem)
        Me.GroupBox2.Controls.Add(Me.osver)
        Me.GroupBox2.Controls.Add(Me.osname)
        Me.GroupBox2.Location = New System.Drawing.Point(319, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 183)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OS Information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Avail. Virtual Memory:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Virtual Memory:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Avail. Physical Memory:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Physical Memory:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "OS Version:"
        '
        'avvirtmem
        '
        Me.avvirtmem.Location = New System.Drawing.Point(121, 131)
        Me.avvirtmem.Name = "avvirtmem"
        Me.avvirtmem.Size = New System.Drawing.Size(171, 23)
        Me.avvirtmem.TabIndex = 2
        Me.avvirtmem.Text = "-"
        Me.avvirtmem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "OS:"
        '
        'avphysmem
        '
        Me.avphysmem.Location = New System.Drawing.Point(130, 108)
        Me.avphysmem.Name = "avphysmem"
        Me.avphysmem.Size = New System.Drawing.Size(162, 23)
        Me.avphysmem.TabIndex = 2
        Me.avphysmem.Text = "-"
        Me.avphysmem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalvirtmem
        '
        Me.totalvirtmem.Location = New System.Drawing.Point(118, 85)
        Me.totalvirtmem.Name = "totalvirtmem"
        Me.totalvirtmem.Size = New System.Drawing.Size(174, 23)
        Me.totalvirtmem.TabIndex = 2
        Me.totalvirtmem.Text = "-"
        Me.totalvirtmem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalphysmem
        '
        Me.totalphysmem.Location = New System.Drawing.Point(128, 62)
        Me.totalphysmem.Name = "totalphysmem"
        Me.totalphysmem.Size = New System.Drawing.Size(164, 23)
        Me.totalphysmem.TabIndex = 2
        Me.totalphysmem.Text = "-"
        Me.totalphysmem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'osver
        '
        Me.osver.Location = New System.Drawing.Point(75, 39)
        Me.osver.Name = "osver"
        Me.osver.Size = New System.Drawing.Size(217, 23)
        Me.osver.TabIndex = 1
        Me.osver.Text = "-"
        Me.osver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'osname
        '
        Me.osname.Location = New System.Drawing.Point(37, 16)
        Me.osname.Name = "osname"
        Me.osname.Size = New System.Drawing.Size(255, 23)
        Me.osname.TabIndex = 0
        Me.osname.Text = "-"
        Me.osname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Refresh speed:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Slow (1s)", "Normal (0.5s)", "Fast (0.25s)"})
        Me.ComboBox1.Location = New System.Drawing.Point(496, 205)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'ramprgr
        '
        Me.ramprgr.Location = New System.Drawing.Point(9, 74)
        Me.ramprgr.Name = "ramprgr"
        Me.ramprgr.Size = New System.Drawing.Size(304, 23)
        Me.ramprgr.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RAM Usage:"
        '
        'ramusg
        '
        Me.ramusg.Location = New System.Drawing.Point(80, 58)
        Me.ramusg.Name = "ramusg"
        Me.ramusg.Size = New System.Drawing.Size(233, 13)
        Me.ramusg.TabIndex = 2
        Me.ramusg.Text = "-%"
        Me.ramusg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cpuload
        '
        Me.cpuload.Location = New System.Drawing.Point(71, 16)
        Me.cpuload.Name = "cpuload"
        Me.cpuload.Size = New System.Drawing.Size(242, 13)
        Me.cpuload.TabIndex = 2
        Me.cpuload.Text = "-%"
        Me.cpuload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPU Load:"
        '
        'cpuprgr
        '
        Me.cpuprgr.Location = New System.Drawing.Point(9, 32)
        Me.cpuprgr.Name = "cpuprgr"
        Me.cpuprgr.Size = New System.Drawing.Size(304, 23)
        Me.cpuprgr.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 580)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(639, 554)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "System Monitor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(639, 554)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Program Monitor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(623, 232)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "System Usage"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Re-Volt Path"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.regrevoltpath)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 244)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(623, 190)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Registry Entries"
        '
        'regrevoltpath
        '
        Me.regrevoltpath.Location = New System.Drawing.Point(9, 32)
        Me.regrevoltpath.Name = "regrevoltpath"
        Me.regrevoltpath.Size = New System.Drawing.Size(506, 20)
        Me.regrevoltpath.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(521, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Open in RegEdit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'prgmonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 580)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "prgmonitor"
        Me.Text = "Monitor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cpuprgr As ProgressBar
    Friend WithEvents netinlbl As Label
    Friend WithEvents ramprgr As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents cpuload As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents netoutlbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ramusg As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents osname As Label
    Friend WithEvents osver As Label
    Friend WithEvents totalphysmem As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents totalvirtmem As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents avvirtmem As Label
    Friend WithEvents avphysmem As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents netout As Label
    Friend WithEvents netin As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents intip As Label
    Friend WithEvents extip As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents regrevoltpath As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class
