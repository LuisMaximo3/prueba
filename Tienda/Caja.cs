﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.WriteLine($"Sub total : ${Subtotal}");
            Console.WriteLine($"I.V.A. : ${Subtotal * .16}");
            Console.WriteLine($"Total : ${Total}");
        }


        public void Cobrar()
        {
            Console.WriteLine("Ingrese cantidad a pagar");
            Pagando = Convert.ToDecimal(Console.ReadLine());
            Cambio = (float)Pagando - Total;
            ImprimirTicket();

        }
        private void ImprimirTicket()
        {
            Console.Clear();
            NumCompra++;
            //Fecha
            DateTime fecha = DateTime.Now;
            Console.WriteLine($"Fecha: {fecha}");

            //NUm.caja
            Console.WriteLine($"Caja: {Numero}");

            //Num.Compra
            Console.WriteLine($"N Compra: {NumCompra}");


            //Lsita de articulos
            foreach (Articulo articulo in Cart.Lista)
            {
                Console.WriteLine($"{articulo.Nombre} - ${articulo.Precio} x {articulo.Cantidad} - ${articulo.Precio * articulo.Cantidad}");
            }

            //IVA
            MostrarTotales();
            Console.WriteLine($"Pagado: ${Pagando} ");
            Console.WriteLine($"Cambio: ${Cambio} ");

        }
    }
}
