using System;
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
    public partial class UsuarioAdministrativoDarDeBaja : Form
    {
        public UsuarioAdministrativoDarDeBaja()
        {
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            var volverUsuAdministrativo = new UsuarioAdministrativoMain();
            volverUsuAdministrativo.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void darDeAltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var irControlDeAsistencia = new UsuarioAdministrativoControlDeAsistencia();
            irControlDeAsistencia.Show();
            this.Hide();
        }

        private void darDeBahaUToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gestionDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irGestionDePagos = new UsuarioAdministrativoControlDePago();
            irGestionDePagos.Show();
            this.Hide();
        }

        private void cerrrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volverInicioSesion = new Form1();
            volverInicioSesion.Show();
            this.Close();
        }

        private void habilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volverUsuAdministrativo = new UsuarioAdministrativoMain();
            volverUsuAdministrativo.Show();
            this.Close();
        }
    }
}
