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
    public partial class UsuarioAdministrativoControlDeAsistencia : Form
    {
        public UsuarioAdministrativoControlDeAsistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var volverUsuAdministrativo = new UsuarioAdministrativoMain();
            volverUsuAdministrativo.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UsuarioAdministrativoControlDeAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void controlAsistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void darDeBajaUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irDarDeBaja = new UsuarioAdministrativoDarDeBaja();
            irDarDeBaja.Show();
            this.Hide();
        }

        private void habilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volverUsuAdministrativo = new UsuarioAdministrativoMain();
            volverUsuAdministrativo.Show();
            this.Close();
        }

        private void gestionDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irControlDePago = new UsuarioAdministrativoControlDePago();
            irControlDePago.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volverInicioSesion = new Form1();
            volverInicioSesion.Show();
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}