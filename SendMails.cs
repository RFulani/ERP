using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INV.Code
{
    class SendMails
    {
        public void sendingEmail(string address, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("mail.hinox.sa.com"/*your mail server here*/);

                mail.From = new MailAddress("hr@hinox.sa.com");
                mail.To.Add(address);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("hr@hinox.sa.com", "Hinox0126380863@");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
