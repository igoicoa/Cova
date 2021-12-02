using System;
using System.Net;
using System.Net.Mail;
using Cova.Servicios.Bitacora;
using Cova.BE.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.Servicios.Email
{
    public static class EmailSender
    {
        public static void SendEmail(string destinatarioMail, string destinatarioNombre, string asunto, string body)
        {
            var fromPassword = "2021sistemacova";
            var fromAddress = new MailAddress("sistemacova2021@gmail.com", "Sistema Cova");
            var toAddress = new MailAddress(destinatarioMail, destinatarioNombre);

            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
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
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al enviar el email a " + destinatarioMail + " - " + destinatarioNombre + " - " + ex.Message, "Enviar Email"));
                throw ex;
            }
        }
    }
}
