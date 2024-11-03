using OneByte.capaPresentacion;
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
        


      

        private void UsuarioSeleccionadorMain_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionadorEquipos usuEntrenadorInfoDeportista = new UsuarioSeleccionadorEquipos();
            usuEntrenadorInfoDeportista.Show();
            this.Close();
        }

        private void consultaEvolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionadorConsultaEvolucion usuEntrenadorInfoEvolucion = new UsuarioSeleccionadorConsultaEvolucion();
            usuEntrenadorInfoEvolucion.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultaDelDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionadorConsultaDeportista usuSeleccionadorConsultaDeportista = new UsuarioSeleccionadorConsultaDeportista();
            usuSeleccionadorConsultaDeportista.Show();
            this.Close();
        }
    }
}
