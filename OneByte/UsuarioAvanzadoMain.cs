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
    public partial class UsuarioAvanzadoMain : Form
    {
        public UsuarioAvanzadoMain()
        {
            InitializeComponent();
        }

        private void gestionempleado_Click(object sender, EventArgs e)
        {
            var gestionempleado = new UsuarioAvanzadoGestionDeEmpleados();
            gestionempleado.Show();
            this.Hide();
        }
    }
}
