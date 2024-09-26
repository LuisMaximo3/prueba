using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad
{
    internal class Program
    {
           
        static void Main(string[] args)
        {
            string nombre = "";
            int cantidad = 0;
            decimal precio = 0;
            decimal total = 0;
            bool continuar = true;
            Carrito carrito = new Carrito();

            while (continuar)
            {
                Console.WriteLine("ingresa el nombre del producto");
                nombre = Console.ReadLine();
                Console.WriteLine("ingresa la cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingresa precio");
                precio = Convert.ToInt32(Console.ReadLine());
                
                Producto prod = new Producto();
                prod.Nombre = nombre;
                prod.Precio = precio;
                prod.Cantidad = cantidad;
                prod.Total=total;
                carrito.AgregarProducto(prod);

                Console.WriteLine("Quieres agregar otro producto?");
                Console.WriteLine("S- Si");
                Console.WriteLine("N- No");
                continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                
                Console.Clear();
            }

            



            Caja caja = new Caja();
            caja.Cobrar(carrito);

            carrito.MostrarCarrito();
            Console.ReadLine();
            /**
                   MiniTienda prod2 =new MiniTienda()
                  {

                      prod.Precio = precio;
                      prod.Nombre = precio;
                  
                  }
                   */        }
        private static void productos(Carrito carrito) 
        {
            // string nombre = "";
            // int cantidad = 0;
            // decimal precio = 0;

            // Console.WriteLine("ingresa el nombre del producto");
            // nombre = Console.ReadLine();
            // Console.WriteLine("ingresa la cantidad");
            // cantidad = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("ingresa precio");
            // precio = Convert.ToInt32(Console.ReadLine());

            // Producto prod =new Producto();
            // prod.Nombre = nombre;
            // prod.Precio = precio;
            // prod.Cantidad = cantidad;
            // carrito.AgregarProducto(prod);

            // Caja caja=new Caja();
            // caja.Cobrar(carrito);

            //carrito.MostrarCarrito();
            //Console.WriteLine();
        }
    }
}
