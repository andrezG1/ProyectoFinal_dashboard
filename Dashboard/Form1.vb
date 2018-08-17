Public Class Form1
    Dim strHostName As String

    Dim strIPAddress As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        strHostName = Net.Dns.GetHostName()

        strIPAddress = Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        computer_name.Text = "Host Name: " & strHostName
        nameip.Text = " IP Address: " & strIPAddress



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value = PerformanceCounter1.NextValue
        Lmen.Text = ProgressBar1.Value.ToString + "% " + " Consumida"


        ProgressBar2.Value = PerformanceCounter2.NextValue
        lcpu.Text = ProgressBar2.Value.ToString + "% " + " Consumido"

        ProgressBar3.Value = PerformanceCounter3.NextValue
        ldescar.Text = ProgressBar3.Value.ToString


        ProgressBar4.Value = PerformanceCounter4.NextValue
        lenvi.Text = ProgressBar4.Value.ToString





    End Sub
End Class
