using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Interfaces
{
    internal interface IUsuario
    {
        string nombre { get; set; }
        string email { get; set; }
        void Login();
        bool ActualizaPerfil(string nombre, string email);
    }
}
