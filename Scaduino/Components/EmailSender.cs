using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace Scaduino.Components
{
    public class EmailSender
    {

        /// <summary>
        /// Smtp Host of sender e-mail
        /// </summary>
        [Description("Smtp Host of sender e-mail")]
        public string SmtpHost { get; set; } = "smtp.gmail.com";

        /// <summary>
        /// Smtp Port of sender e-mail
        /// </summary>
        [Description("Smtp Port of sender e-mail")]
        public int SmtpPort { get; set; } = 587;

        /// <summary>
        /// Smtp user account (e-mail) of sender
        /// </summary>
        [Description("Smtp user account (e-mail) of sender")]
        public string SmtpUser { get; set; }

        /// <summary>
        /// Smtp user pass (e-mail) of sender
        /// </summary>
        [Description("Smtp user account (e-mail) of sender")]
        public string SmtpPass { get; set; }

        /// <summary>
        /// Destination e-mail
        /// </summary>
        [Description("Destination e-mail")]
        public string DestinationMail { get; set; }

        /// <summary>
        /// Destination name
        /// </summary>
        [Description("Destination name")]
        public string DestinationName { get; set; }

        public void SendEmail(string subject, string body)
        {
            SmtpClient client = new SmtpClient();
            client.Host = SmtpHost;
            client.Port = SmtpPort;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(SmtpUser, SmtpPass);
            MailMessage mail = new MailMessage();
            mail.Sender = new MailAddress(SmtpUser, "Scaduino");
            mail.From = new MailAddress(SmtpUser, "Scaduino");
            mail.To.Add(new MailAddress(DestinationMail, DestinationName));
            mail.Subject = subject;
            mail.Body = body;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
