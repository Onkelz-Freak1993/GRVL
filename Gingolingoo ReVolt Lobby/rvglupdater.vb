Imports System.IO
Imports System.Text
Imports System.Net
Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class rvglupdater

    Dim rvglas As String = "a"
    Dim rvglarch As String
    Dim rvglfilesize As Double

    Dim rvglver As String = "https://distribute.re-volt.io/releases/rvgl_version.txt"
    Dim client As WebClient = New WebClient()
    Dim reader As StreamReader = New StreamReader(client.OpenRead(rvglver))

    Dim changelogad As String = "http://rvgl.re-volt.io/downloads/rvgl_changelog.txt"
    Dim changelogcl As WebClient = New WebClient()
    Dim changelocrd As StreamReader = New StreamReader(client.OpenRead(changelogad))

    Private Sub rvglupdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Alpha"
        OpenFileDialog1.FileName = My.Settings.revolt_path
try_again:
        Try
            Dim fs As Stream = OpenFileDialog1.OpenFile()
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim mz As UInt16 = br.ReadUInt16()
            If mz = 23117 Then
                fs.Position = 60
                Dim peoffset As UInt32 = br.ReadUInt32()
                fs.Position = peoffset + 4
                Dim machine As UInt16 = br.ReadUInt16()
                If machine = 34404 Then
                    architecture.Text = "x64"
                    rvglarch = "win64"
                ElseIf machine = 332 Then
                    architecture.Text = "x86"
                    rvglarch = "win32"
                ElseIf machine = 512 Then
                    architecture.Text = "IA64_x64"
                    rvglarch = "win32"
                Else
                    architecture.Text = "Unknown"
                End If
            Else
                architecture.Text = "Invalid image"
            End If
            br.Close()
            RichTextBox1.Text = changelocrd.ReadToEnd
            installedrvglver.Text = GetFileVersionInfo(My.Settings.revolt_path).ToString.Substring(4)
            updatervglver.Text = reader.ReadToEnd.ToString.Normalize
        Catch exc As Exception
            MsgBox("No valid RVGL-Path found. If needed, install RVGL first and try again.", vbInformation)
            settings.Show()
            settings.gamesettings.Show()
            settings.browsebtn.PerformClick()
            Me.Close()
            'GoTo try_again
        End Try
        Dim downloadpath As String = "http://rvgl.re-volt.io/downloads/rvgl_" & updatervglver.Text & rvglas & "_setup_" & rvglarch & ".exe"
        Try
            rvglfilesize = GetDownloadSize(Regex.Replace(downloadpath, "[^a-zA-Z0-9-/:._]", ""))
            rvglsize.Text = Math.Round(rvglfilesize / 1024 / 1024, 2, MidpointRounding.AwayFromZero) & " MB"
        Catch ex As Exception
            If My.Settings.devtools = True Then
                MsgBox(ex.ToString)
                MsgBox(Regex.Replace(downloadpath, "[^a-zA-Z0-9-/:._]", ""))
            End If
        End Try
    End Sub

    Private Function GetFileVersionInfo(ByVal filename As String) As String
        Return FileVersionInfo.GetVersionInfo(filename).FileVersion
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Text = ""
        Button2.Image = My.Resources.scp_ajax_loader
        If ComboBox1.Text = "Alpha" Then
            rvglas = "a"
        ElseIf ComboBox1.Text = "Shader" Then
            rvglas = "s"
        End If
        If architecture.Text = "x86" Then
            rvglarch = "win32"
        ElseIf architecture.Text = "x64" Then
            rvglarch = "win64"
        ElseIf architecture.Text = "IA64_x64" Then
            rvglarch = "win32"
        Else
            'error?
        End If
        Try
            downloadrvglbgw.RunWorkerAsync()
        Catch exc As Exception
            MsgBox("Keep calm, the updater is currently working in the background.")
        End Try

    End Sub

    Public Function GetDownloadSize(ByVal URL As String) As Long
        Dim r As Net.WebRequest = Net.WebRequest.Create(URL)
        r.Method = Net.WebRequestMethods.Http.Head
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function

    Public WithEvents downloader As WebClient


    Private Sub downloadrvglbgw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles downloadrvglbgw.DoWork
        Dim downloadpath As String = "http://rvgl.re-volt.io/downloads/rvgl_" & updatervglver.Text & rvglas & "_setup_" & rvglarch & ".exe"
        Dim localpath As String = Application.StartupPath & "/rvgl-installer/rvgl_setup_" & rvglarch & ".exe"
        Dim client As WebClient = New WebClient
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\rvgl-installer\") = False Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\rvgl-installer\")
        End If
        'MsgBox(Regex.Replace(downloadpath, "[^a-zA-Z0-9-/:._]", ""))
        If My.Computer.FileSystem.FileExists(localpath) Then
            Try
                My.Computer.FileSystem.DeleteFile(localpath)
            Catch
                downloadrvglbgw.CancelAsync()
                MsgBox("Could not overwrite file. Is the file in use?")
            End Try
        Else
            Try
                ''  My.Computer.Network.DownloadFile(New Uri(Regex.Replace(downloadpath, "[^a-zA-Z0-9-/:._]", "")), localpath)
                Dim time As Integer = 0
                Dim _FileRequest As System.Net.WebRequest = System.Net.WebRequest.Create(New Uri(Regex.Replace(downloadpath, "[^a-zA-Z0-9-/:._]", "")))
                Dim _FileResponse As System.Net.WebResponse = _FileRequest.GetResponse()
                Dim _myStream As System.IO.Stream = _FileResponse.GetResponseStream()
                Dim _myReader As New System.IO.BinaryReader(_myStream)
                Dim _myFile As New System.IO.FileStream(localpath, System.IO.FileMode.Create)
                Dim size As Long = _FileResponse.ContentLength()
                Dim i As Long
                For i = 1 To size
                    _myFile.WriteByte(_myReader.ReadByte())
                    Invoke(Sub() ProgressBar1.Value = ((i / size) * 100))
                Next i
                _myFile.Flush()
                _myFile.Close()
            Catch ex As Exception
                downloadrvglbgw.CancelAsync()
                MsgBox("File not found. Try another Version of " & updatervglver.Text)
            End Try
        End If
    End Sub




    Private Sub downloadrvglbgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles downloadrvglbgw.RunWorkerCompleted
        Dim localpath As String = Application.StartupPath & "/rvgl-installer/rvgl_setup_" & rvglarch & ".exe"
        Try
            If My.Computer.FileSystem.FileExists(localpath) Then
                Process.Start(localpath)
            Else
                Try
                    downloadrvglbgw.RunWorkerAsync()
                Catch ex As Exception
                    downloadrvglbgw.CancelAsync()
                    MsgBox("File not found. Try another Version of " & updatervglver.Text)
                End Try
            End If

        Catch
        End Try
        Button2.Text = "Update"
        Button2.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        downloadrvglbgw.CancelAsync()
    End Sub
End Class