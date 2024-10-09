using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.abstractas
{
    internal class Cuadrado : Figuras
    {
        public int MedidaLado { get; set; }
        public override void CacularArea()
        {
            Area = MedidaLado * MedidaLado;
        }
        public override void CacularPerimetro()
        {
            Perimetro = MedidaLado * 4;
        }
    }
}
