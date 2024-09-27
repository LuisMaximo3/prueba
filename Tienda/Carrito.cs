using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Carrito
    {
        public List<Articulo> Lista { get; set; }

        public void AgregarProducto(Articulo producto)
        {

            Lista.Add(producto);

        }
        public void MostrarCarrito()
        {
           
            
        }
        public void Pagar()
        {


        }
    }
}
