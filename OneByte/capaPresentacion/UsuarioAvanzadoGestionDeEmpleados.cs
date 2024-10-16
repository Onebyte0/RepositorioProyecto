using OneByte.capaPresentacion;
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
    public partial class UsuarioAvanzadoGestionDeEmpleados : Form
    {
        public UsuarioAvanzadoGestionDeEmpleados()
        {
            InitializeComponent();
        }

        
        private void gestionClient_Click(object sender, EventArgs e)
        {
           
        }

        private void opcDeportes_Click(object sender, EventArgs e)
        {
            var opcDeportes = new UsuarioAvanzadoOpcionalidadDeportes();
            opcDeportes.Show();
            this.Hide();
        }

        private void gestionEjer_Click(object sender, EventArgs e)
        {
          
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionClient = new UsuarioAvanzadoGestionDeCliente();
            gestionClient.Show();
            this.Hide();
        }

        private void gestiónDeEjerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionEjer = new UsuarioAvanzadoIngresoEjercicios();
            gestionEjer.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
