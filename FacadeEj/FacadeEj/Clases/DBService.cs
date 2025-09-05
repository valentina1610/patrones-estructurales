using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEj.Clases
{
    public class DBService
    {
        public void GuardarUsuario(string nombre, string email)
        {
            Console.WriteLine($"[DBSERVICE]: Usuario de NOMBRE: {nombre} y  EMAIL: {email} ha sido guardado correctamente.");
        }
    }
}
