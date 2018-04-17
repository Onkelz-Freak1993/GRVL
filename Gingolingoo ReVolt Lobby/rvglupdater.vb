﻿Imports System.IO
Imports System.Text
Imports System.Net

Public Class rvglupdater

    Dim rvglver As String = "https://distribute.re-volt.io/releases/rvgl_version.txt"
    Dim client As WebClient = New WebClient()
    Dim reader As StreamReader = New StreamReader(client.OpenRead(rvglver))

    Private Function getInstalledVersion()
        Dim rvglversion As String
        Dim a As String
        rvglversion = GetFileVersionInfo(My.Settings.revolt_path).ToString
        Try
            a = rvglversion.Substring(rvglversion.Length - 4)
        Catch exc As Exception
            console.RichTextBox1.AppendText(exc.ToString & vbNewLine)
        End Try

        If a.StartsWith(".") Then
            rvglversion.Insert(7, "0")
            Return rvglversion.Substring(4)
        Else
            Return rvglversion.Substring(4)
        End If
    End Function

    Private Sub rvglupdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installedrvglver.Text = getInstalledVersion()
        updatervglver.Text = reader.ReadToEnd
    End Sub

    Private Function GetFileVersionInfo(ByVal filename As String) As Version
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
    End Function

End Class