Public Class modloader

    Private Function addDownload(titel As String, desc As String, url As String, img As String, exists As Boolean)
        Dim dPan As New Panel()
        dPan.Height = 380
        dPan.Width = 160
        dPan.BackColor = Color.Transparent
        dPan.BackgroundImage = My.Resources.dbg
        Dim dBtn As New Button()
        If exists Then
            dBtn.Text = "Remove"
            AddHandler dBtn.Click, AddressOf Me.Uninstall_Button_Click
        Else
            dBtn.Text = "Install"
            AddHandler dBtn.Click, AddressOf Me.Install_Button_Click
        End If
        dBtn.Location = New Point(5, 350)
        dBtn.Size = New Point(150, 25)
        dBtn.Tag = url
        Dim dPic As New PictureBox()
        dPic.Size = New Point(150, 150)
        dPic.Location = New Point(5, 5)
        dPic.SizeMode = PictureBoxSizeMode.Zoom
        dPic.ImageLocation = img
        Dim dTit As New Label()
        dTit.Text = titel
        dTit.Location = New Point(5, 160)
        dTit.Size = New Point(150, 20)
        dTit.TextAlign = ContentAlignment.MiddleCenter
        dTit.Font = New Font("Sans Serif", 10, FontStyle.Bold)
        dTit.ForeColor = ColorTranslator.FromHtml("#33b5e5")
        Dim aF As New Label()
        aF.Size = New Point(150, 15)
        aF.Location = New Point(27, 187)
        aF.Text = "Author:"
        aF.ForeColor = ColorTranslator.FromHtml("#33b5e5")
        Dim dl As New Label()
        dl.Size = New Point(63, 15)
        dl.Location = New Point(5, 201)
        dl.Text = "Downloads:"
        dl.ForeColor = ColorTranslator.FromHtml("#33b5e5")
        Dim rat As New Label()
        rat.Size = New Point(41, 15)
        rat.Location = New Point(27, 216)
        rat.Text = "Rating:"
        rat.ForeColor = ColorTranslator.FromHtml("#33b5e5")
        Dim descl As New Label()
        descl.Size = New Point(63, 15)
        descl.Location = New Point(5, 230)
        descl.Text = "Description:"
        '-----
        descl.ForeColor = ColorTranslator.FromHtml("#33b5e5")
        Dim aL As New Label()
        aL.Size = New Point(150, 15)
        aL.Location = New Point(66, 187)
        aL.Name = "modauthor"
        aL.Text = "DB Data"
        aL.ForeColor = ColorTranslator.FromHtml("#dadada")

        Dim dll As New Label()
        dll.Size = New Point(100, 15)
        dll.Location = New Point(66, 201)
        dll.Text = "3"
        dll.Name = "moddownloads"
        dll.ForeColor = ColorTranslator.FromHtml("#dadada")

        Dim rating As New Label()
        rating.Size = New Point(100, 15)
        rating.Location = New Point(66, 216)
        rating.Text = "5/5"
        rating.Name = "modrating"
        rating.ForeColor = ColorTranslator.FromHtml("#dadada")

        Dim dDesc As New Label()
        dDesc.Size = New Point(150, 100)
        dDesc.Location = New Point(5, 245)
        dDesc.Text = desc
        dDesc.Name = "moddescription"
        dDesc.ForeColor = ColorTranslator.FromHtml("#dadada")

        dPan.Controls.Add(dBtn)
        dPan.Controls.Add(dPic)
        dPan.Controls.Add(dTit)
        dPan.Controls.Add(dDesc)
        dPan.Controls.Add(descl)
        dPan.Controls.Add(aL)
        dPan.Controls.Add(aF)
        dPan.Controls.Add(dl)
        dPan.Controls.Add(dll)
        dPan.Controls.Add(rat)
        dPan.Controls.Add(rating)
        FlowLayoutPanel1.Controls.Add(dPan)
        Return True
    End Function

    Private Sub modloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mods()
        Using wd As New System.Net.WebClient()
            Dim modData
            Try
                modData = wd.DownloadString("https://grvl.gingolingoo.de/api.php?action=getMods")
                mods = modData.Split(";")
                For Each mData As String In mods
                    If mData <> "" Then
                        Dim mdt() = mData.Split("|")
                        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\cars\" & mdt(4)) Then
                            addDownload(mdt(0), mdt(1), mdt(2), mdt(3), True)
                        Else
                            addDownload(mdt(0), mdt(1), mdt(2), mdt(3), False)
                        End If
                    End If
                Next
            Catch
                MsgBox("Loading mods failed!")
            End Try
        End Using
    End Sub

    Private Sub Uninstall_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("Remove Mod!")
    End Sub
    Private Sub Install_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MsgBox("Install Mod!")
    End Sub
End Class