using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterEj.Interfaces;

namespace AdapterEj.Impresoras
{
    public class ImpresoraLaser : IImprimir
    {
        public void Imprimir(string texto)
        {
            Console.WriteLine($"[IMPRESORA LASER]: imprimiendo {texto}");
        }
    }
}
