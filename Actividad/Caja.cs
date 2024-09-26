using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad
{
    class Caja
    { 
        decimal total = 0; 
     public void Cobrar(Carrito carrito) {

            foreach (Producto producto in carrito.Lista)
            { 
                total+= producto.Cantidad * producto.Precio;
            }
            Console.WriteLine(total);
       }
    }
}

