using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace DigiMovie.Helper
{
    public enum EmailType { Empty,Info}
    public static class Email
    {
        public static MailAddress GetMailAddress(EmailType type)
        {
            if (type==EmailType.Empty)
                return new MailAddress("");
            else
            return new MailAddress("alirezaghorbani230@gmail.com", "دیجی مووی");
        }
        public static string GetMailName(EmailType type)
        {
            if (type==EmailType.Empty)
            return "";
            else
            return "alirezaghorbani230@gmail.com";
        }
        public static SmtpClient GetSmtp(EmailType type)
        {
            if (type==EmailType.Empty)
                return new SmtpClient();
            else
            return new SmtpClient
            {
                Host = "smpt.gmail.com",
                EnableSsl = true,
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential ( "alirezaghorbani230@gmail.com", "ghorbaniali67" )
            };
        }
    }
}