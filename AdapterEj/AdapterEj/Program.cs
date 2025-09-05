using System;
using AdapterEj.Adapter;
using AdapterEj.ClaseVieja;
using AdapterEj.Impresoras;
using AdapterEj.Interfaces;

namespace AdapterEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente
            ImpresoraTermicaVieja imprVieja = new ImpresoraTermicaVieja();
            IImprimir impresoraVieja = new AdaptadorTermica(imprVieja);
            impresoraVieja.Imprimir("Este es un texto de prueba bastante largo que supera los cien caracteres para que puedas probar la validación en el adaptador y ver qué pasa.");

            IImprimir imprLaser = new ImpresoraLaser();
            imprLaser.Imprimir("'texto de la laser'");
        }
    }
}
