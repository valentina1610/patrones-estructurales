using System;
using DecoratorEj.Base;
using DecoratorEj.Decorator;
using DecoratorEj.Interface;

namespace DecoratorEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMensaje msjSimple = new MensajeSimple();
            Console.WriteLine("Mensaje simple:");
            msjSimple.Enviar("Hola mundo!");

            IMensaje msjEmoji = new MensajeConEmoji(msjSimple);
            Console.WriteLine("Mensaje con emoji:");
            msjEmoji.Enviar("Hola mundo!");

            IMensaje msjEncriptado = new MensajeEncriptado(msjSimple);
            Console.WriteLine("Mensaje en mayusculas:");
            msjEncriptado.Enviar("Hola mundo!");

            IMensaje msjEncriptadoYEmoji = new MensajeEncriptado(new MensajeConEmoji(msjSimple));
            Console.WriteLine("Mensaje en mayusculas y con emoji:");
            msjEncriptadoYEmoji.Enviar("Hola mundo!");

        }
    }
}
