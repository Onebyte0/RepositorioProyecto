﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneByte
{
    public partial class UsuarioAvanzadoOpcionalidadDeportes : Form
    {
        public UsuarioAvanzadoOpcionalidadDeportes()
        {
            InitializeComponent();
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionEmpleados = new UsuarioAvanzadoGestionDeEmpleados();
            gestionEmpleados.Show();
            this.Hide();
        }

        private void gestiondeCli_Click(object sender, EventArgs e)
        {
            var gestiondeCli = new UsuarioAvanzadoMain();
            gestiondeCli.Show();
            this.Hide();
        }

        private void gestionDeEjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionEjer = new UsuarioAvanzadoIngresoEjercicios();
            gestionEjer.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Hide();
        }
    }
}
