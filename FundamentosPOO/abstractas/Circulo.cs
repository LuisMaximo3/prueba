using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FundamentosPOO.abstractas
{
    internal class Circulo : Figuras
    {
        public double Radio { get; set; }

        public override void CacularArea()
        {
            Area = Radio * Radio * Math.PI;
        }
        public override void CacularPerimetro()
        {
            Perimetro =  Radio * 2 * Math.PI;
        }
    }
}
