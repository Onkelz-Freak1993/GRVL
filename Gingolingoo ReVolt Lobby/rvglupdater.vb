Imports System.IO
Imports System.Text
Imports System.Net

Public Class rvglupdater

    Dim rvglver As String = "https://distribute.re-volt.io/releases/rvgl_version.txt"
    Dim client As WebClient = New WebClient()
    Dim reader As StreamReader = New StreamReader(client.OpenRead(rvglver))

    Private Sub rvglupdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strText As String = GetFileVersionInfo(My.Settings.revolt_path).ToString
        installedrvglver.Text = strText.Substring(4)
        updatervglver.Text = reader.ReadToEnd
    End Sub

    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function

End Class