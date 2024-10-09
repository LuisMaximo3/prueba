using FundamentosPOO.abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona2 persona2 = new Persona2("Juan", "juan@correo.com", 1);
            //Console.ReadLine();
            //persona2.Nombre = "Juan Luis";
            //persona2.Email = "juan@email.com";
            //persona2.ImprimirnNombre();
            //persona2.ImprimirEmail();
            //persona2.CambiarFecha(DateTime.Now);
            //persona2.ImprimirFecha();
            //Console.ReadLine();
            Console.WriteLine("Cuadrado");
            Cuadrado cuadrado = new Cuadrado()
            {
                MedidaLado = 5,
                UnidadMedida = "metros"
            };
            cuadrado.CacularArea();
            cuadrado.MuestraArea(); 
            cuadrado.CacularPerimetro();
            cuadrado.MuestraPerimetro();

            Console.WriteLine("Triangulo");
            Triangulo triangulo = new Triangulo()
            {
                Base = 4,
                Altura = 5,
                MedidasLados = 4,
                UnidadMedida="metros"

            };
            triangulo.CacularArea();
            triangulo.CacularPerimetro();
            triangulo.MuestraArea();
            triangulo.MuestraPerimetro();

            Console.WriteLine("Rectangulo");
            Rectangulo rectangulo = new Rectangulo()
            {
                MedidaLado1 = 3,
                MedidaLado2 = 5,
                UnidadMedida = "metros"
            };
            rectangulo.CacularArea();
            rectangulo.MuestraArea();
            rectangulo.CacularPerimetro();
            rectangulo.MuestraPerimetro();

            Console.WriteLine("Circulo");
            Circulo circulo = new Circulo()
            {
                Radio = 5,
                UnidadMedida = "metros"
            };
            circulo.CacularArea();
            circulo.MuestraArea();
            circulo.CacularPerimetro();
            circulo.MuestraPerimetro();
            Console.ReadLine();
        }
    }
}
