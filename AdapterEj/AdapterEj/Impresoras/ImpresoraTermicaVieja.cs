using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterEj.Interfaces;

namespace AdapterEj.ClaseVieja
{
    public class ImpresoraTermicaVieja
    {
        public void PrintTicket(string data)
        {
            Console.WriteLine($"[TICKET]: {data} imprimiendo...");
        }
    }
}
