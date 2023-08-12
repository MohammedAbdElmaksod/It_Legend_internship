using Castle.Core.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class EmailSender : IEmailSenderr
    {
        private readonly IEmailTempalte _emailTemplate;

        public EmailSender(IEmailTempalte emailTemplate)
        {
            _emailTemplate = emailTemplate;
        }

        public void SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromMail = "m0hamed771@outlook.com";
            var mailPass = "mido12345677";



            using (SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com"))
            {
                var message = new MailMessage(fromMail, email);
                message.From = new MailAddress(fromMail);
                message.To.Add(new MailAddress(email));
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                message.Body = _emailTemplate.CustomEmail();
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMail, mailPass);
                smtpClient.Send(message);
            }

        }
    }
}
