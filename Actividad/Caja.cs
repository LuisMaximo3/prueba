using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad
{
    class Caja
    {
        private decimal Pagando { get; set; }
        public decimal Cambio { get; set; }
        private Carrito Cart { get; set; }


        decimal Total = 0;
        public void IngresarCarrito(Carrito cart)
        {
            Cart = cart;
            foreach (Producto articulo in cart.Lista)
            {
                Total += articulo.Total;
            }
            Console.WriteLine($"El total a pagar es: ${Total}");
        }

        public void Cobrar()
        {
            Console.WriteLine("Ingrese cantidad a pagar: ");
            Pagando = Convert.ToDecimal(Console.ReadLine());
            Cambio = Pagando - Total;
            Console.WriteLine($"El cambio es: ${Cambio}");
        }

    
    } 
}

