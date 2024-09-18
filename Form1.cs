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
            double numero1 = 5;
            double numero2 = 8;
            operaciones op=new operaciones();
            double resultado = op.Suma(numero1, numero2);
        }
        class operaciones
        { 
         public double Suma(double x, double y)
            {

                double resultado= x + y;
                return resultado;
            }
            public double Resta(double x, double y)
            {
                double resultado = x - y;
                return resultado;
            }
            public double Multp(double x, double y)
            {
                double num1=2;
                double num2 = 2;
                double resultado = x * y;
                do
                {
                    Console.Write(resultado);
                    resultado++;
                }
                while (num1 != 0 || num2 !=0);
                return resultado;
            }
            public int Div(int x, int y)
            {
                int resultado = x / y;
                return resultado;
            }
        }

      
    }
}
