using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Interfaces
{
    internal class Admin : IUsuario
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public int Nivel { get; set; }    
        public bool ActualizaPerfil(string nombre, string email)
        {
            return true;
        }

        public void Login()
        {
            Console.WriteLine("Usuario logeado");
        }
    }
}
