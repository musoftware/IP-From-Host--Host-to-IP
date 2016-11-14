Imports System.Net.Sockets

Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBox4.Text = IPToDNS(TextBox3.Text)
        Catch
        End Try
    End Sub
    Public Shared Function DNSToIP(ByVal site As String) As String
        Dim siteentry As Net.IPHostEntry = Net.Dns.GetHostEntry(site)
        Dim AddressAny As Net.IPAddress() = siteentry.AddressList

        For Each Address In AddressAny
            If Address.AddressFamily = AddressFamily.InterNetwork Then
                Return Address.ToString
            End If
        Next
        Return ""
    End Function
    Public Shared Function IPToDNS(ByVal ip As String) As String
        Return System.Net.Dns.Resolve(ip).HostName
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TextBox2.Text = DNSToIP(TextBox1.Text)
        Catch
        End Try
    End Sub
End Class
