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
    public partial class UsuarioEntrenadorRutinasDeportistasLesionados : Form
    {
        public UsuarioEntrenadorRutinasDeportistasLesionados()
        {
            InitializeComponent();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            var atras = new UsuarioEntrenadorMain();
            atras.Show();
            this.Hide();
        }
    }
}
