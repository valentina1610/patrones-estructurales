using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEj.Clases
{
    public class EmailValidator
    {
        public bool EsValido(string email)
        {
            if (!string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".com")) 
            {
                Console.WriteLine($"[VALIDATOR]: El Email '{email}' es válido.");
                return true;
            }
            else
            {
                Console.WriteLine($"[VALIDATOR]: El Email '{email}' NO es válido.");
                return false;
            }
        }
    }
}
