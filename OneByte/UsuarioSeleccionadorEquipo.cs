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
    public partial class UsuarioSeleccionadorEquipos : Form
    {
        public UsuarioSeleccionadorEquipos()
        {
            InitializeComponent();
        }

        private void consDepor_Click(object sender, EventArgs e)
        {
            var consDepor = new UsuarioSeleccionadorMain();
            consDepor.Show();
            this.Close();
        }

        private void consEvoDepor_Click(object sender, EventArgs e)
        {
            var consEvoDepor = new UsuarioSeleccionadorConsultaEvolucion();
            consEvoDepor.Show();
            this.Close();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();
        }
    }
}
