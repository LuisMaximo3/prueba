using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona2 persona2 = new Persona2("Juan", "juan@correo.com", 1);
            Console.ReadLine();
            persona2.Nombre = "Juan Luis";
            persona2.Email = "juan@email.com";
            persona2.ImprimirnNombre();
            persona2.ImprimirEmail();
            persona2.CambiarFecha(DateTime.Now);
            persona2.ImprimirFecha();
            Console.ReadLine();
        }
    }
}
