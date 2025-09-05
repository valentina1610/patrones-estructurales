using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorEj.Interface;

namespace DecoratorEj.Decorator
{
    abstract public class MensajeDecorator : IMensaje
    {
        protected IMensaje mensaje;
        public MensajeDecorator(IMensaje mensaje)
        {
            this.mensaje = mensaje;
        }
        virtual public void Enviar(string texto)
        {
            mensaje.Enviar(texto);
        }

    }
}
