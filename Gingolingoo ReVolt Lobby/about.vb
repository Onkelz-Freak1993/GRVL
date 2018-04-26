Public Class aboutus
    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckBox1.Checked Then
            My.Computer.Audio.Play(My.Resources.credits, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
        WebBrowser1.Navigate(Application.StartupPath & "\credits.html")

    End Sub

    Private docComplete As Boolean = False
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        docComplete = True
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If docComplete Then
            ' Process.Start(e.Url.ToString)
            Process.Start(e.Url.ToString) 'start process by a default browser
            e.Cancel = True
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            My.Computer.Audio.Play(My.Resources.credits, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub aboutus_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        'PictureBox1.BackgroundImage = Nothing
        PictureBox1.Image = My.Resources.parrot
        My.Computer.Audio.Play(My.Resources.egg, AudioPlayMode.BackgroundLoop)
    End Sub
End Class