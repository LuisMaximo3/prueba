using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Persona
    {
        protected int ID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        private DateTime Crear { get; set; }

        public void ImprimirnNombre() 
        {
            Console.WriteLine(Nombre); 
        }
        public void ImprimirID()
        {
            Console.WriteLine(ID);
        }
        public void ImprimirFecha()
        {
            Console.WriteLine(Crear);
        }
        public void CambiarFecha(DateTime nuevaFecha) 
        {
            Crear = nuevaFecha;
        }
    }
}
