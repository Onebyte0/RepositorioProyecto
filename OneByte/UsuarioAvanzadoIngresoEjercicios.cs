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
    public partial class UsuarioAvanzadoIngresoEjercicios : Form
    {
        public UsuarioAvanzadoIngresoEjercicios()
        {
            InitializeComponent();
        }

        private void opcDeportes_Click(object sender, EventArgs e)
        {
            var opcDeportes = new UsuarioAvanzadoOpcionalidadDeportes();
            opcDeportes.Show();
            this.Hide();
        }

        private void gestiondeEmpleados_Click(object sender, EventArgs e)
        {
            var gestionEmpleados = new UsuarioAvanzadoGestionDeEmpleados();
            gestionEmpleados.Show();
            this.Hide();
        }

        private void gestionCli_Click(object sender, EventArgs e)
        {
            var gestionCli = new UsuarioAvanzadoMain();
            gestionCli.Show();
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
