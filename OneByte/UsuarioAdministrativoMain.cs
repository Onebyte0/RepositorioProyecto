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
    public partial class UsuarioAdministrativoMain : Form
    {
        public UsuarioAdministrativoMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void darDeAltaUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadoDelPagoDelDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darDeAltaUnClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void darDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volverInicioSesion = new Form1();
            volverInicioSesion.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void controlDeAsistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var irControlDeAsistencia = new UsuarioAdministrativoControlDeAsistencia();
            irControlDeAsistencia.Show();
            this.Hide();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irDarDeBaja = new UsuarioAdministrativoDarDeBaja();
            irDarDeBaja.Show();
            this.Hide();
        }

        private void gestionDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irGestionDePagos = new UsuarioAdministrativoControlDePago();
            irGestionDePagos.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsuarioAdministrativoMain_Load(object sender, EventArgs e)
        {

        }
    }
}
