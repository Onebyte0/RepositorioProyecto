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
    public partial class UsuarioSeleccionadorConsultaEvolucion : Form
    {
        public UsuarioSeleccionadorConsultaEvolucion()
        {
            InitializeComponent();
        }

        private void consDepor_Click(object sender, EventArgs e)
        {
            var consDepor = new UsuarioSeleccionadorMain();
            consDepor.Show();
            this.Close();
        }

        private void equipos_Click(object sender, EventArgs e)
        {
            var equipos = new UsuarioSeleccionadorEquipos();
            equipos.Show(); 
            this.Close();
        }
    }
}
