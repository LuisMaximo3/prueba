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
        int resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int numero1 = 5; 
            int numero2 = 8;
            int resultado = Suma(numero1, numero2);
        }
        private int Suma(int x, int y)
        {
            resultado= x + y;
            return resultado;
        }
    }
}
