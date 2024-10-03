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

        private void TipoDeMateria(object sender, EventArgs e)
        {
            TipoDeMateria _tipomat = new TipoDeMateria();
            _tipomat.Show();
        }

        private void Materias_Load(object sender, EventArgs e)
        {

        }
    }
}
