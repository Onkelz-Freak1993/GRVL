Imports System
Imports System.IO
Public Class modloader
    Private Function addDownload(titel As String, desc As String, url As String, img As String, exists As Boolean, count As String)
        Dim dPan As New Panel()
        dPan.Height = 220
        dPan.Width = 160
        dPan.BackColor = Color.Transparent
        dPan.BackgroundImage = My.Resources.dbg
        dPan.Tag = count
        Dim dBtn As New Button()
        Dim dProgress As New ProgressBar()
        dProgress.Location = New Point(5, 190)
        dProgress.Size = New Point(150, 25)
        dProgress.Name = "pbar" & count
        dProgress.Visible = False

        If exists Then
            dBtn.Text = "Remove"
            AddHandler dBtn.Click, AddressOf Me.Uninstall_Button_Click
        Else
            dBtn.Text = "Install"
            AddHandler dBtn.Click, AddressOf Me.Install_Button_Click
        End If
        dBtn.Location = New Point(5, 190)
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
        dTit.Font = New Font("Sans Serif", 8, FontStyle.Bold)
        dTit.AutoEllipsis = True
        dTit.ForeColor = ColorTranslator.FromHtml("#33b5e5")

        dPan.Controls.Add(dBtn)
        dPan.Controls.Add(dPic)
        dPan.Controls.Add(dTit)
        dPan.Controls.Add(dProgress)
        If exists Then
            FlowLayoutPanel2.Controls.Add(dPan)
        Else
            FlowLayoutPanel1.Controls.Add(dPan)
        End If

        Return True
    End Function

    Public Function getVehicleParameter(ByVal filename As String, ByVal param As String) As String
        If Not My.Computer.FileSystem.FileExists(filename) Then
            Return ""
        End If
        Dim auswahlListe As New List(Of String)
        For Each zeile As String In IO.File.ReadAllLines(filename)
            If zeile.Contains(param) Then
                Dim cn() = zeile.Split(Convert.ToChar(34))
                Return cn(1)
            End If
        Next
    End Function
    Dim modCount As Integer = 1
    Private Sub loadMods()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel2.Controls.Clear()
        Dim mods()
        Dim di As New System.IO.DirectoryInfo(Application.StartupPath & "\cars\")
        For Each fi As System.IO.DirectoryInfo In di.GetDirectories()

            Dim tImg As String = Application.StartupPath & "\" & getVehicleParameter(Application.StartupPath & "\cars\" & fi.Name & "\parameters.txt", "TCARBOX")
            If Not My.Computer.FileSystem.FileExists(tImg) Then
                tImg = Application.StartupPath & "\carbox_unknown.bmp"
            End If

            Dim cName As String = getVehicleParameter(Application.StartupPath & "\cars\" & fi.Name & "\parameters.txt", "Name")
            'Dim cName As String = ReadLine(Application.StartupPath & "\cars\" & fi.Name & "\parameters.txt", 8)

            addDownload(cName, "", "", tImg, True, modCount.ToString)
            modCount += 1
        Next

        Using wd As New System.Net.WebClient()
            Dim modData
            Try
                modData = wd.DownloadString("https://grvl.gingolingoo.de/api.php?action=getMods")
                mods = modData.Split(";")
                For Each mData As String In mods
                    If mData <> "" Then
                        Dim mdt() = mData.Split("|")
                        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\cars\" & mdt(4)) Then
                            'addDownload(mdt(0), mdt(1), mdt(2), mdt(3), True)
                        Else
                            addDownload(mdt(0), mdt(1), mdt(2), mdt(3), False, modCount.ToString)
                            modCount += 1
                        End If
                    End If
                Next
            Catch
                MsgBox("Loading mods failed!")
            End Try
        End Using

    End Sub

    Private Sub modloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMods()
    End Sub
    Public Sub DownloadFile(ByVal link As String, ByVal ziel As String, pbar As Control)
        pbar.Visible = False
        Dim prb As ProgressBar = pbar.Parent.Controls("pbar" + pbar.Parent.Tag.ToString)
        prb.Visible = True
        Dim _FileRequest As System.Net.WebRequest = System.Net.WebRequest.Create(link)
        Dim _FileResponse As System.Net.WebResponse = _FileRequest.GetResponse()
        Dim _myStream As System.IO.Stream = _FileResponse.GetResponseStream()
        Dim _myReader As New System.IO.BinaryReader(_myStream)
        Dim _myFile As New System.IO.FileStream(ziel, System.IO.FileMode.Create)
        Dim size As Long = _FileResponse.ContentLength()
        Dim i As Long
        For i = 1 To size
            _myFile.WriteByte(_myReader.ReadByte())
            prb.Value = ((i / size) * 100)
        Next i
        'Dim cu As New ClassUnzip(ziel, Path.Combine(Path.GetDirectoryName(Application.StartupPath & "/tempmod.zip"), "test_unzip_folder"))
        ' AddHandler cu.UnzipFinishd, AddressOf Unziped
        ' cu.UnzipNow()

        _myFile.Flush()
        _myFile.Close()
        loadMods()
    End Sub

    Private Sub Unziped()
        MessageBox.Show("Unzipping finished")
    End Sub

    Private Sub Uninstall_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Install_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DownloadFile(sender.tag, Application.StartupPath & "/tempmod.zip", sender)
    End Sub

    Private Sub InstallModFromFileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RefreshModsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        loadMods()
    End Sub
End Class