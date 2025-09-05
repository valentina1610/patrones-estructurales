using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorEj.Interface;

namespace DecoratorEj.Decorator
{
    public class MensajeConEmoji : MensajeDecorator
    {
        public MensajeConEmoji(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string texto)
        {
            string emoji = $"{texto} :)";
            base.Enviar(emoji);
        }
    }
}
