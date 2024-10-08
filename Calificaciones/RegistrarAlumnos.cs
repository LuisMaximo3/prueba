﻿using Calificaciones.Entidades;
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
    public partial class RegistrarAlumnos : Form
    {
        public RegistrarAlumnos()
        {
            InitializeComponent();
        }

        private void Registrar(object sender, EventArgs e) 
        {
            Alumno __alumno = new Alumno()
            {
                Nombre = tb_Nombre.Text,
                Apellido = tb_Apellido.Text,
                Matricula = tb_Matricula.Text
            };


            Response resp = Central.RegistrarAlumno(__alumno);
            if (resp.Codigo == 1) { MessageBox.Show(resp.Mensaje); }
            else if (resp.Codigo == 2) { MessageBox.Show(resp.Mensaje, "Error"); }
        }


    }
}
