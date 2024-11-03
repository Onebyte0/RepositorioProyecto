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

namespace OneByte.capaPresentacion
{
    public partial class UsuarioSeleccionadorConsultaDeportista : Form
    {
        public UsuarioSeleccionadorConsultaDeportista()
        {
            InitializeComponent();
        }

        private void consultaEvolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionadorConsultaEvolucion usuEntrenadorInfoEvolucion = new UsuarioSeleccionadorConsultaEvolucion();
            usuEntrenadorInfoEvolucion.Show();
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
