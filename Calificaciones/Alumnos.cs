using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        
        private  void Alumnos_Load(object sender, EventArgs e)
        {
            gv_alumno.DataSource = Central.CargarAlumnos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarAlumnos _registrar = new RegistrarAlumnos();
            _registrar.Show();
        }
    }
}
