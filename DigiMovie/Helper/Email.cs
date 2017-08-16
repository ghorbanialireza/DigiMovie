using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace DigiMovie.Helper
{
    public enum EmailType { Mailer,Info}
    public static class Email
    {
        public static MailAddress GetMailAddress(EmailType type)
        {
            if (type==EmailType.Mailer)
                return new MailAddress("alirezaghorbani230@gmail.com");
            else
            return new MailAddress("Mailer@gmail.com");
        }
        public static string GetMailName(EmailType type)
        {
            if (type==EmailType.Mailer)
            return "alirezaghorbani230@gmail.com";
            else
            return "Mailer@gmail.com";
        }
        public static SmtpClient GetSmtp(EmailType type)
        {
            if (type==EmailType.Mailer)
                return new SmtpClient
                {
                    Host = "smpt.gmail.com",
                    EnableSsl = true,
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential { UserName = "alirezaghorbani230@gmail.com", Password = "ghorbaniali67" }
                };
            else
            return new SmtpClient
            {
                Host = "smpt.gmail.com",
                EnableSsl = true,
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential { UserName = "alirezaghorbani230@gmail.com", Password = "ghorbaniali67" }
            };
        }
    }
}