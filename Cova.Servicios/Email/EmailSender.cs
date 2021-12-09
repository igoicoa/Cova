using System;
using System.Net;
using System.Net.Mail;

namespace Cova.Servicios.Email
{
    public static class EmailSender
    {
        public static void SendEmail(string destinatarioMail, string destinatarioNombre, string asunto, string body)
        {
            var fromPassword = "2021sistemacova";
            var fromAddress = new MailAddress("sistemacova2021@outlook.com", "Sistema Cova");
            var toAddress = new MailAddress(destinatarioMail, destinatarioNombre);

            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.outlook.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = asunto,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
