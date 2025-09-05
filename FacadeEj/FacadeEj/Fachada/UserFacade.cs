using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using FacadeEj.Clases;

namespace FacadeEj.Fachada
{
    public class UserFacade
    {
        private EmailValidator emailValid;
        private DBService dbServi;
        private EmailSender emailSen;

        public UserFacade()
        {
            this.emailValid = new EmailValidator();
            this.dbServi = new DBService();
            this.emailSen = new EmailSender();
        }
        public void RegistrarUsuario(string nombre, string email)
        {
            Console.WriteLine($"[VALIDATOR]: Validando el email '{email}'...");
            if (!emailValid.EsValido(email))
            {
                return;
            }
            dbServi.GuardarUsuario(nombre, email);
            emailSen.EnviarBienvenida(email);
        }
    }
}
