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
        public List<Producto> Lista { get; set; }= new List<Producto>();

        public void AgregarProducto(Producto producto)
        {

            Lista.Add(producto);

        }
        public void MostrarCarrito() 
        {
            Producto a = new Producto();
            a.calculartotal();
            decimal total = 0;
            total = a.Cantidad * a.Precio;

            for (int p = 0; p < Lista.Count; p++)
            {
                Console.WriteLine($"Nombre: {Lista[p].Nombre}, " +
                    $"Cantidad: {Lista[p].Cantidad}, " +
                    $"Precio: {Lista[p].Precio}, " +
                    $"Total: {Lista[p].Total}" + total);
            }
        }
        public void Pagar() 
        {

            
        }
    }
}
