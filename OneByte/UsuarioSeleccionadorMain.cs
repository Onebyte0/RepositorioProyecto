using System;
using System.Windows.Forms;

namespace OneByte
{
    public partial class UsuarioSeleccionadorMain : Form
    {
        public UsuarioSeleccionadorMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void darDeAltaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void darDeBahaUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irConsultaEvolucion = new UsuarioSeleccionadorConsultaEvolucion();
            irConsultaEvolucion.Show();
            this.Hide();
        }

        private void gestionDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irSelEquipos = new UsuarioSeleccionadorEquipos();
            irSelEquipos.Show();
            this.Hide();
        }

        private void cerrrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var volverInicioSesion = new SeleccionUsuarios();
            volverInicioSesion.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var volverSeleccioandorMain= new UsuarioSeleccionadorMain();
            volverSeleccioandorMain.Show();
            this.Close();
        }

        private void darDeAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
