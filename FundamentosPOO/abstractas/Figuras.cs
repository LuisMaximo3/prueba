using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.abstractas
{
    internal abstract class Figuras
    {
        protected double Area { get; set; }
        protected double Perimetro { get; set; }
        public string UnidadMedida {  get; set; }
        public double Apotema {  get; set; }
        public abstract void CacularArea();
        public abstract void CacularPerimetro();
        public void MuestraArea() 
        {
            Console.WriteLine($"El area es: { Area:F2} {UnidadMedida}^2");
        }
        public void MuestraPerimetro()
        {
            Console.WriteLine($"El perimetro es: {Perimetro:F2} {UnidadMedida}");
        }
    }
}

