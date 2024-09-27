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
            Console.WriteLine("Selecciona el articulo");
            Catalogo.Mostrar_Catalogo();
            int artID=Convert.ToInt32(Console.ReadLine());

            Articulo articuloSeleccionado= Catalogo.BuscarArticuloPorID(artID);
           
            Catalogo.TomarArticulo(artID);
            Catalogo.MostrarCarrito();


            
            Console.ReadLine();
        }
    }
}
