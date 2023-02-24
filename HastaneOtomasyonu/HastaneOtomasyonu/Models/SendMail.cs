using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace HastaneOtomasyonu.Models
{
    class SendMail
    {
        public void Microsoft(string GondericiAdSoyad, string GondericiMail, string GondericiPass, string AliciMail, string Baslik, string icerik, string ek)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.live.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, GondericiAdSoyad);
            mail.To.Add(AliciMail);
            mail.Subject = Baslik;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            if (ek != null)
            {
                mail.Attachments.Add(new Attachment(ek));
            }
            sc.Timeout = 100;
            sc.Send(mail);
        }
    }
}
