using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad
{
    class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total
        {
            get; set;

        }

        public void calculartotal()
        {
            Total = Precio * Cantidad; 
        }
        //public static void sumatotal(Producto SumaTotal)
        //{
            
        //    decimal total = SumaTotal.Cantidad * SumaTotal.Precio;
        //    SumaTotal.Total = total;
        //}

    }
  
}
