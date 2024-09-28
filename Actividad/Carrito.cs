using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Actividad
{
    class Carrito
    {
        public List<Producto> Lista { get; set; } = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {

            Lista.Add(producto);

        }
        public void MostrarCarrito() 
        {
            foreach (var producto in Lista)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, " +
                    $"Cantidad: {producto.Cantidad}, " +
                    $"Precio: ${producto.Precio}, " +
                    $"Total: ${producto.Total}");
            }
        }

    }
}
