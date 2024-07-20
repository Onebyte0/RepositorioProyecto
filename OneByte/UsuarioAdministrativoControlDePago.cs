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
    public partial class UsuarioAdministrativoControlDePago : Form
    {
        public UsuarioAdministrativoControlDePago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var volverUsuAdministrativo = new UsuarioAdministrativoMain();
            volverUsuAdministrativo.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void darDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
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
            var irDarDeBaja= new UsuarioAdministrativoDarDeBaja();
            irDarDeBaja.Show();
            this.Hide();
        }

        private void gestionDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
