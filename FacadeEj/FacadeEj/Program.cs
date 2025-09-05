using System;
using FacadeEj.Fachada;

namespace FacadeEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserFacade userFacade = new UserFacade();
            userFacade.RegistrarUsuario("valentina", "valentinaolmos@gmail.com");
            Console.WriteLine();

            userFacade.RegistrarUsuario("valentina", "valentinaolmos@gmail.con");
        }
    }
}
