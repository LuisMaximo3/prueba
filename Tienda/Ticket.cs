using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
     class Ticket
    {
        public List<Articulo> Lista { get; set; }
        public decimal Total { get; set; }

        public decimal Pagado { get; set; }

        public decimal Cambio { get; set; }

        public DateTime Fecha { get; set; }

        public int NumCompra { get; set; }

        public decimal IVA { get; set; }

        public void ImprimirTicket(int numeroCaja)
        {
            Console.Clear();
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Caja: {numeroCaja}");
            Console.WriteLine($"N Compra: {NumCompra}");

            // Imprimir cada artículo con su precio y cantidad
            foreach (Articulo articulo in Lista)
            {
                Console.WriteLine($"{articulo.Nombre} - ${articulo.Precio:F2} x {articulo.Cantidad} - ${(articulo.Precio * articulo.Cantidad):F2}");
            }

            // Imprimir los totales con dos decimales
            Console.WriteLine($"Sub total : ${(Total - IVA):F2}");
            Console.WriteLine($"I.V.A. : ${IVA:F2}");
            Console.WriteLine($"Total : ${Total:F2}");
            Console.WriteLine($"Pagado: ${Pagado:F2}");
            Console.WriteLine($"Cambio: ${Cambio:F2}");
        }
    }   


}
