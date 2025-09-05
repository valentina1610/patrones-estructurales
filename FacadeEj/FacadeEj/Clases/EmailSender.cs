using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEj.Clases
{
    public class EmailSender
    {
        public void EnviarBienvenida(string email)
        {
            Console.WriteLine($"[EMAIL]: Correo de bienvenida enviado a email: {email}, bienvenido/a!");
        }
    }
}
