using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.abstractas
{
    internal class Poligono : Figuras
    {
        public int NumLados { get; set; }
        public int lado { get; set; }

        public void calcularApotema() 
        {
            Apotema = lado / (2 * Math.Tan(Math.PI / NumLados));
        }
        public override void CacularArea()
        {
            calcularApotema();
            CacularPerimetro();
            Area = (Perimetro * Apotema) / 2;
        }
        public override void CacularPerimetro()
        {

            Perimetro = NumLados * lado;
        }
    }
}
