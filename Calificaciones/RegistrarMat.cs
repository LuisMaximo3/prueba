using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class RegistrarMat : Form
    {
        public RegistrarMat()
        {
            InitializeComponent();
        }

        private void RegistrarMateria(object sender, EventArgs e)
        {
            Materia materias = new Materia()
            {
                Nombre = tbnombre.Text,
                Codigo = tbcodigo.Text
            };
            Response resp= Central.RegistrarMaterias(materias);
            if (resp.Codigo == 1) { MessageBox.Show(resp.Mensaje); }
            else if (resp.Codigo == 2) { MessageBox.Show(resp.Mensaje, "Error"); }

        }
    }   
}
