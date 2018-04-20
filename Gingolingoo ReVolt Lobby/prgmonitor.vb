Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Diagnostics

Public Class prgmonitor
    Dim ipv4Stats As System.Net.NetworkInformation.IPv4InterfaceStatistics

    Private Sub prgmonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        If nics Is Nothing OrElse nics.Length < 1 Then
            ComboBox2.Items.Add("No network interfaces found.")
        End If
        For Each adapter As NetworkInterface In nics
            ComboBox2.Items.Add(adapter.Name)
        Next

        ComboBox2.SelectedIndex = 0
        Timer1.Start()
        osname.Text = My.Computer.Info.OSFullName
        osver.Text = My.Computer.Info.OSVersion
        totalphysmem.Text = Math.Round(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, 2, MidpointRounding.AwayFromZero) & " MB"
        totalvirtmem.Text = Math.Round(My.Computer.Info.TotalVirtualMemory / 1024 / 1024, 2, MidpointRounding.AwayFromZero) & " MB"
        ComboBox1.Text = "Slow (1s)"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Slow (1s)" Then
            Timer1.Interval = 1000
        ElseIf ComboBox1.Text = "Normal (0.5s)" Then
            Timer1.Interval = 500
        ElseIf ComboBox1.Text = "Fast (0.25s)" Then
            Timer1.Interval = 250
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        avphysmem.Text = Math.Round(My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024, 2, MidpointRounding.AwayFromZero) & " MB"
        avvirtmem.Text = Math.Round(My.Computer.Info.AvailableVirtualMemory / 1024 / 1024, 2, MidpointRounding.AwayFromZero) & " MB"
        If My.Computer.Network.IsAvailable = True Then
            ipv4Stats = NetworkInformation.NetworkInterface.GetAllNetworkInterfaces(0).GetIPv4Statistics
            netin.Text = ipv4Stats.BytesReceived.ToString & " bytes"
            intip.Text = GetIpV4(ComboBox2.SelectedIndex).ToString
        End If

        ' !! REVISION: This does not deliver what was wanted? - !!
        '    cpuload.Text = CPUUsage() & " %"
        '    cpuprgr.Value = CPUUsage()
        ' !! ---------------------------------------------------!!

        ramusg.Text = Math.Round((My.Computer.Info.AvailablePhysicalMemory / My.Computer.Info.TotalPhysicalMemory.ToString) * 100, 0, MidpointRounding.AwayFromZero) & "%"
        ramprgr.Value = Math.Round((My.Computer.Info.AvailablePhysicalMemory / My.Computer.Info.TotalPhysicalMemory.ToString) * 100, 0, MidpointRounding.AwayFromZero)
    End Sub

    Private Function CPUUsage() As Double
        Dim myCounter As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter With {
            .CategoryName = "Processor",
            .CounterName = "% Processor Time",
            .InstanceName = "_Total"
        }
        Return myCounter.NextValue
    End Function

    Public Function GetIpV4(ByVal nic As Int32) As String
        Dim myHost As String = Dns.GetHostName
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(myHost)
        Dim ip As String = ""
        Try
            For Each tmpIpAddress As IPAddress In ipEntry.AddressList
                If tmpIpAddress.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                    Dim ipAddress As String = tmpIpAddress.ToString
                    ip = ipAddress
                    Exit For
                End If
            Next

            If ip = "" Then
                Throw New Exception("No 10. IP found!")
            End If
        Catch
            Return "No IP Found."
        End Try
        Return ip
    End Function
End Class