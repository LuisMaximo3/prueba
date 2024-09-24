using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrito carrito = new Carrito();


            string nombre = "";
            int cantidad = 0;
            decimal precio = 0;
            Console.WriteLine("ingresa el nombre del producto");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa la cantidad");
            cantidad=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa precio");
            precio = Convert.ToInt32(Console.ReadLine()); 

            Producto prod =new Producto();
            prod.Nombre = nombre;
            prod.Precio = precio;
            prod.Cantidad = cantidad;
            carrito.AgregarProducto(prod);

            Caja caja=new Caja();
            caja.Cobrar(carrito);            /**
             MiniTienda prod2 =new MiniTienda()
            {

                prod.Precio = precio;
                prod.Nombre = precio;
            
            }
             */
            Console.WriteLine();
        }
    }
}
