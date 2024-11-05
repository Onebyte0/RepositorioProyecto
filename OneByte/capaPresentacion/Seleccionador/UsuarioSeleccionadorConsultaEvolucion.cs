using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneByte.capaPresentacion;
namespace OneByte
{
    public partial class UsuarioSeleccionadorConsultaEvolucion : Form
    {
        public UsuarioSeleccionadorConsultaEvolucion()
        {
            InitializeComponent();
        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionadorConsultaDeportista usuSeleccionadorConsultaDeportista = new UsuarioSeleccionadorConsultaDeportista();
            usuSeleccionadorConsultaDeportista.Show();
            this.Close();
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionadorEquipos usuEntrenadorInfoDeportista = new UsuarioSeleccionadorEquipos();
            usuEntrenadorInfoDeportista.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
