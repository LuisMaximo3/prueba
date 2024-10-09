using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.abstractas
{
    internal class Triangulo : Figuras
    {
        public int MedidasLados { get; set; }
        public int Base { get; set; }
        public int Altura { get; set; }
        public override void CacularArea()
        {
            Area = (Base * Altura)/2;
        }
        public override void CacularPerimetro()
        {
            Perimetro = MedidasLados * 3;
        }
    }
}
