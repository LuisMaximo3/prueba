using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max
{
    public partial class Form1 : Form
    {

        double resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización de los números
            double num1 = 5;
            double num2 = 8;

            // Instancia de la clase operaciones
            operaciones op =new operaciones();
            double resultado = op.Suma(num1, num2);
            double res = op.Multp(num1, num2);
            double resul = op.Div(num1, num2);
            double resultad = op.Resta(num1, num2);
        }

        // Clase para realizar operaciones matemáticas básicas.
        class operaciones
        {

            // Método para sumar dos números.
            public double Suma(double x, double y)
            {

                double resultado= x + y;
                return resultado;
            }

            // Método para restar dos números.
            public double Resta(double x, double y)
            {
                double resultado = x - y;
                return resultado;
            }

            // Método para multiplicar dos números.
            public double Multp(double x, double y)
            {
                // Calcula el producto de x e y.
                double resultado = x * y;

                // Si alguno de los números es 0, el resultado es 0.
                if (x != 0 && y != 0) 
                {
                    Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Uno de las variables es 0, por lo que el resultado sera 0");
                }
                return resultado;
            }

            // Método para dividir dos números.
            public double Div(double x, double y)
            {

                // Calcula la division de x e y.
                double resultado = x / y;

                // Verifica si el numerador es diferente de 0.
                if (x != 0)
                {
                    Console.WriteLine("El resultado de la division es: " + resultado);
                    return resultado;
                }
                else 
                {
                    Console.WriteLine("El numerador es 0, por lo que no se puede hacer tal operacion.");
                }
                return resultado;
            
            }
        }
        
        // Evento para mostrar los resultados en el cuadro de texto al hacer clic en un botón.
        private void button1_Click(object sender, EventArgs e)
        {
            double x = 20;
            double y = 8;

            // Instancia de la clase operaciones
            operaciones op = new operaciones();
            double suma= op.Suma(x, y);
            double resta= op.Resta(x, y);
            double multiplicacion=op.Multp(x, y);
            double division= op.Div(x, y);

            // Muestra el resultado de todas las operaciones en el cuadro de texto
            tb_suma.Text = suma.ToString();
            tb_resta.Text = resta.ToString();
            tb_multip.Text = multiplicacion.ToString();
            tb_div.Text = division.ToString();
        }


    }
}







































































































































































































































































































































































































































































































































































































































































































































































































































































