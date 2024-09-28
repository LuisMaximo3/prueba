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
            bool continuar = true;
            Carrito carrito = new Carrito();

            while (continuar)
            {
                Console.WriteLine("ingresa el nombre del producto");
                nombre = Console.ReadLine();
                Console.WriteLine("ingresa la cantidad");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingresa precio");
                precio = Convert.ToDecimal(Console.ReadLine());
                Producto prod = new Producto
                {
                    Nombre = nombre,
                    Precio = precio,
                    Cantidad = cantidad,
                    Total = cantidad * precio  // Calcular el total del producto
                };
                carrito.AgregarProducto(prod);

                Console.WriteLine("Quieres agregar otro producto?");
                Console.WriteLine("S- Si");
                Console.WriteLine("N- No");
                continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                
                Console.Clear();
            }

            

            carrito.MostrarCarrito();
            Console.ReadLine();

            Caja caja = new Caja();
            caja.IngresarCarrito(carrito);  // Ingresar carrito a la caja
            Console.ReadLine();

            caja.Cobrar();
            Console.ReadLine();

        }
       
    }
}
