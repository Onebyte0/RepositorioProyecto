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

        private void volver_Click(object sender, EventArgs e)
        {
            var volverUsuSeleccionador = new UsuarioSeleccionadorMain();
            volverUsuSeleccionador.Show();
            this.Close();
                }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
