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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }
        private void Materias_Load(object sender, EventArgs e)
        {

        }
        private void Agregarmateria(object sender, EventArgs e)
        {
             RegistrarMat _agregarmat = new RegistrarMat();
            _agregarmat.Show();
        }
        private void materias_Load(object sender, EventArgs e)
        {
            dg_cagarmat.DataSource = Central.CargarAlumnos();
        }

    }
}
