using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad
{
    class Carrito
    {
        public List<Producto> Lista { get; set; }

        public void AgregarProducto(Producto producto)
        {

            Lista.Add(producto);

        }
    }
}
