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
    public partial class SeleccionUsuarios : Form
    {
        public SeleccionUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var administrativo = new UsuarioAdministrativoMain();
            administrativo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var avanzado = new UsuarioAvanzadoMain();
            avanzado.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var seleccion = new SeleccionUsuarios();
            seleccion.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var usuSeleccionador = new UsuarioSeleccionadorMain();
            usuSeleccionador.Show();
            this.Hide();
        }

        private void entrenador_Click(object sender, EventArgs e)
        {
            var entrenador = new UsuarioEntrenadorMain();
            entrenador.Show();
            this.Hide();
        }

        private void deportista_Click(object sender, EventArgs e)
        {
            var deportista = new UsuarioClienteMain();
            deportista.Show();
            this.Hide();

        }
    }
}
