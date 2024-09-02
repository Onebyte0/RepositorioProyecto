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
        

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();

        }

        private void consEvoDepor_Click(object sender, EventArgs e)
        {
            var consEvoDepor = new UsuarioSeleccionadorConsultaEvolucion();
            consEvoDepor.Show();
            this.Close();
        }
    }
}
