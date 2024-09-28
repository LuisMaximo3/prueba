using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool otrocarrito = true;
            int numeroCompra = 1;
            while (otrocarrito) 
            {
                Carrito cart = new Carrito();

                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("Selecciona el articulo");
                    Catalogo.MostrarCatalogo();
                    int artID = Convert.ToInt32(Console.ReadLine());

                    Articulo articuloSeleccionado = Catalogo.BuscarArticuloPorID(artID);
                    Console.WriteLine("Cuantos va a comprar?");
                    articuloSeleccionado.Cantidad = Convert.ToInt32(Console.ReadLine());

                    cart.AgregarArticulo(articuloSeleccionado);

                    Console.WriteLine("Quieres agregar otro producto?");
                    Console.WriteLine("S- Si");
                    Console.WriteLine("N- No");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                    Console.Clear();




                    Console.ReadLine();
                }
                Caja caja = new Caja(numeroCompra);
                //Mostrar total
                caja.IngresarCarrito(cart);
                //Cobrar y Pagar
                //devolver cambio
                //imprmir ticket

                caja.Cobrar();

                Console.WriteLine("Quieres agregar otro carrito?");
                Console.WriteLine("S- Si");
                Console.WriteLine("N- No");
                otrocarrito = char.ToUpper(Console.ReadKey().KeyChar) == 'S';
                Console.Clear();
            }
                Console.ReadLine() ;

        }
    }
}
