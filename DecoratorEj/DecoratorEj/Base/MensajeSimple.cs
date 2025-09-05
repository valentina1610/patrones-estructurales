using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorEj.Interface;

namespace DecoratorEj.Base
{
    public class MensajeSimple : IMensaje
    {
        public void Enviar(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
