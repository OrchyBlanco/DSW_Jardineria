using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DSW_JARDINERIA.Servicios
{
    public class EnviarEmail : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (var mensaje = new MailMessage())
            {
                mensaje.To.Add(new MailAddress(email, email));
                mensaje.From = new MailAddress("2dawa.cesarmanrique@gmail.com", "Net-GMail");
                mensaje.Subject = subject;
                mensaje.Body = htmlMessage;
                mensaje.IsBodyHtml = true;
                using (var cliente = new SmtpClient("smtp.gmail.com", 587))
                {
                    cliente.Port = 587;
                    cliente.UseDefaultCredentials = false;
                    cliente.Credentials = new NetworkCredential("2dawa.cesarmanrique@gmail.com", "dsw.2dawa");
                    cliente.EnableSsl = true;
                    cliente.Send(mensaje);
                }
            }
            return Task.CompletedTask;
        }

    }
}
