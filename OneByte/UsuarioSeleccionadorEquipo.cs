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


        private void UsuarioSeleccionadorEquipos_Load(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            var volverSeleccionador = new UsuarioSeleccionadorMain();
            volverSeleccionador.Show();
            this.Close();
        }
    }
}
