using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterEj.ClaseVieja;
using AdapterEj.Interfaces;

namespace AdapterEj.Adapter
{
    public class AdaptadorTermica : IImprimir
    {
        private ImpresoraTermicaVieja imprVieja;
        public AdaptadorTermica(ImpresoraTermicaVieja imprVieja_)
        {
            imprVieja = imprVieja_;
        }
        public void Imprimir(string texto)
        {
            if (texto.Length > 100)
            {
                Console.WriteLine("Texto muy largo! la impresa vieja no puede imprimir mas de 100 caracteres.");
                return;
            }
            else
            {
                imprVieja.PrintTicket(texto);
            }
                
        }

    }
}
