using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneByte.capaPresentacion
{
    public partial class UsuarioAvanzadoGestionDeCliente : Form
    {
        public UsuarioAvanzadoGestionDeCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gestionejer_Click(object sender, EventArgs e)
        {

        }

        private void gestionCli_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ñPPÑªºToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionempleado = new UsuarioAvanzadoGestionDeEmpleados();
            gestionempleado.Show();
            this.Hide();
        }

        private void gestiónDeEjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionejer = new UsuarioAvanzadoIngresoEjercicios();
            gestionejer.Show();
            this.Hide();
        }

        private void opcdeportes_Click(object sender, EventArgs e)
        {
            var opcdeportes = new UsuarioAvanzadoOpcionalidadDeportes();
            opcdeportes.Show();
            this.Hide();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Hide();
        }
    }
    
}
