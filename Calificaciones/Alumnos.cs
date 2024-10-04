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
        private void AgragarAlumno(object sender, EventArgs e)
        {
            RegistrarAlumnos _registrar= new RegistrarAlumnos();
            _registrar.Show();
        }
        private void Registrar(object sender, EventArgs e)
        {
            Alumno _alumno = new Alumno()
            {

            };
            Central.CargarAlumnos(_alumno);

        }
    }
}
