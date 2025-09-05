using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorEj.Interface;

namespace DecoratorEj.Decorator
{
    public class MensajeEncriptado : MensajeDecorator
    {
        public MensajeEncriptado(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string texto)
        {
            string mayusculas = texto.ToUpper();
            base.Enviar(mayusculas);
        }
    }
}