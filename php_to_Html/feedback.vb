Imports System.Net.Mail

Public Class feedback

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendSMTP("auk.junk@live.com", "devorg.bd@gmail.com", "sub", "test", "cc@auk.com", "")

    End Sub


    Public Sub SendSMTP(ByVal strFrom As String, ByVal strTo As String, ByVal strSubject As String, ByVal strBody As String, ByVal strCC As String, ByVal strAttachments As String)
        Dim insMail As New MailMessage(New MailAddress(strFrom), New MailAddress(strTo))
        With insMail
            .Subject = strSubject
            .Body = strBody
            .CC.Add(New MailAddress(strCC))
            If Not strAttachments.Equals(String.Empty) Then
                Dim strFile As String
                Dim strAttach() As String = strAttachments.Split(";"c)
                For Each strFile In strAttach
                    .Attachments.Add(New Attachment(strFile.Trim()))
                Next
            End If
        End With
        Dim smtp As New System.Net.Mail.SmtpClient
        smtp.Host = "192.168.0.1"
        smtp.Port = 25
        smtp.Send(insMail)


        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        SmtpServer.Credentials = New  _
Net.NetworkCredential("username@gmail.com", "password")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        mail = New MailMessage()
        mail.From = New MailAddress("YOURusername@gmail.com")
        mail.To.Add("TOADDRESS")
        mail.Subject = "Test Mail"
        mail.Body = "This is for testing SMTP mail from GMAIL"
        SmtpServer.Send(mail)
        MsgBox("mail send")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class
