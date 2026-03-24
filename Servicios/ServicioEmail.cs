using Portafolio.Models;
using System.Net.Mail;

namespace Portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task EnviarEmail(ContactoViewModel contacto);
    }
    public class ServicioEmail : IServicioEmail
    {
        private readonly IConfiguration configuration;
        public ServicioEmail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task EnviarEmail(ContactoViewModel contacto)
        {
            var emailEmisor = configuration.GetValue<string>("CONFIGURACIONES_EMAIL:EMAIL");
            var emailContraseña = configuration.GetValue<string>("CONFIGURACIONES_EMAIL:CONTRASEÑA");
            var emailHost = configuration.GetValue<string>("CONFIGURACIONES_EMAIL:HOST");
            var emailPuerto = configuration.GetValue<int>("CONFIGURACIONES_EMAIL:PUERTO");

            var smtpClient = new SmtpClient(emailHost, emailPuerto);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential(emailEmisor, emailContraseña);
            var mensajeEmail = new MailMessage(emailEmisor, emailEmisor, 
                $"El cliente {contacto.Email}   {contacto.Nombre} quiere contactarte", contacto.Mensaje);

            await smtpClient.SendMailAsync(mensajeEmail);

        }
    }
}
