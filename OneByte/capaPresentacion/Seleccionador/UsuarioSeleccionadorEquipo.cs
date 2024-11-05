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
    public partial class UsuarioSeleccionadorEquipos : Form
    {
        public UsuarioSeleccionadorEquipos()
        {
            InitializeComponent();
        }

    
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void controlAsist_Click(object sender, EventArgs e)
        {

        }

        private void consultaEvolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionadorConsultaEvolucion usuSeleccionadorConsultaEvolucion = new UsuarioSeleccionadorConsultaEvolucion();
            usuSeleccionadorConsultaEvolucion.Show();
            this.Close();
        }
    }
}
