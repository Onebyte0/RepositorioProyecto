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

        private void opcdeportes_Click(object sender, EventArgs e)
        {
            var opcdeportes = new UsuarioAvanzadoOpcionalidadDeportes();
            opcdeportes.Show();
            this.Hide();
        }

        private void gestionejer_Click(object sender, EventArgs e)
        {
            var gestionejer = new UsuarioAvanzadoIngresoEjercicios();
            gestionejer.Show();
            this.Hide();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Hide();
        }

        
    }
}
