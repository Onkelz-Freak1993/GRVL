Public Class createserver
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim addmplobby As New mplobby
        Dim str(4) As String
        Dim itm As ListViewItem
        If Not TextBox2.Text = "" Then
            str(0) = "🔒"
        Else
            str(0) = ""
        End If
        str(1) = TextBox1.Text
        str(2) = playercnt.Text.ToString
        str(3) = MainWindow.wanip.ToString
        itm = New ListViewItem(str)
        MainWindow.serverlist.Items.Add(itm)
        addmplobby.Show()
        addmplobby.Text = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub createserver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class