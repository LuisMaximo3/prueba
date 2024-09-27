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

        public static void MostrarCatalogo()
        {
            LlenarCatalogo();
            foreach (Articulo art in Invertario)
            {
                Console.WriteLine($"{art.ID} - {art.Nombre} - {art.Precio}\n");
            }
        }
        public static Articulo BuscarArticuloPorID(int artID)
        {
            return Invertario.Find(articulo => articulo.ID.Equals(artID));
        }
    }
}