using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Caja
    {
        private static int NumCompra = 0;
        public int Numero { get; set; }
        private decimal Pagando { get; set; }
        public float Cambio { get; set; }
        private Carrito Cart { get; set; }
       
        private float Subtotal = 0;

        private float Total = 0;
        public Caja(int numero)
        {
            Numero = numero;
        }

        public void IngresarCarrito(Carrito cart)
        {
            Cart = cart;
            foreach (Articulo articulo in cart.Lista)
            {
                Subtotal += articulo.Precio * articulo.Cantidad;
            }
            MostrarTotales();

        }

        public void MostrarTotales()
        {
            float iva = Subtotal * .16f;
            Total = Subtotal + iva;

            Console.WriteLine($"Sub total : ${Subtotal:F2}");
            Console.WriteLine($"I.V.A. : ${iva:F2}");
            Console.WriteLine($"Total : ${Total:F2}");
        }


        public void Cobrar()
        {
            Console.WriteLine("Ingrese cantidad a pagar");
            Pagando = Convert.ToDecimal(Console.ReadLine());
            Cambio = (float)Pagando - Total;
            Ticket ticket = new Ticket();
            ticket.Lista = Cart.Lista;
            ticket.Total = (decimal)Total;
            ticket.Pagado = Pagando;
            ticket.Cambio = (decimal)Cambio;
            ticket.Fecha = DateTime.Now;
            ticket.NumCompra = ++NumCompra;
            ticket.IVA = (decimal)(Subtotal * 0.16f);


            // Imprimir el ticket utilizando el método de la clase Ticket
            ticket.ImprimirTicket(Numero);

        }
        
    }
}