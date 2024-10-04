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
    public partial class DarAltaMateria : Form
    {
        public DarAltaMateria()
        {
            InitializeComponent();
        }

        private void DarAlta(object sender, EventArgs e)
        {
            DarAltaMateria _profe = new DarAltaMateria()
            {

            };
            Central.DarALTAmateria(_profe);

        }
    }
}
