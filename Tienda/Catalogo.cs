using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda;

namespace Tienda
{
    class Catalogo
    {
        private static List<Articulo> Invertario { get; set; }
        private static List<Articulo> Carrito {get;set;}=new List<Articulo>();


        private static void LlenarCatalogo()
        {
            Invertario = new List<Articulo>
            {
                new Articulo { Nombre = "Jabon", Precio = 23.9f, ID = 1 },
                new Articulo { Nombre = "Mayonesa", Precio = 37.70f, ID = 2 },
                new Articulo { Nombre = "Tomate", Precio = 50.00f, ID = 3 },
                new Articulo { Nombre = "Carne", Precio = 90f, ID = 4 },
                new Articulo { Nombre = "Huevo", Precio = 23f, ID = 5 },
            };
        }

        public static void Mostrar_Catalogo()
        {
            LlenarCatalogo();
            foreach (Articulo art in Invertario)
            {
                Console.WriteLine($"{art.ID} - {art.Nombre} - {art.Precio}\n");
            }
        }
        public static Articulo BuscarArticuloPorID(int artID) 
        {
           return Invertario.Find(x => x.ID.Equals(artID)); 
           
        }

        public static void TomarArticulo(int artID)
        {
            Articulo articulo = BuscarArticuloPorID(artID);
            if (articulo != null) 
            {
                Carrito.Add(articulo);
                Console.WriteLine($"Se ha agregado {articulo.Nombre} al carrito.");
            }
            else
            {
                Console.WriteLine("El artículo con el ID ingresado no existe.");            
            }

        }
        public static void MostrarCarrito()
        {
            Console.WriteLine("\nContenido del Carrito:");
            if (Carrito.Count > 0)
            {
                foreach (Articulo art in Carrito)
                {
                    Console.WriteLine($"{art.ID} - {art.Nombre} - {art.Precio:C}\n");
                }
            }
            else
            {
                Console.WriteLine("El carrito está vacío.");
            }
        }

    }
}