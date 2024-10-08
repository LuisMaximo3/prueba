using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Interfaces
{
    internal class Cliente : IUsuario
    {
        public string nombre { get; set; }
        public string email { get; set; }

        public bool ActualizaPerfil(string nombre, string email)
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }
    }
}
