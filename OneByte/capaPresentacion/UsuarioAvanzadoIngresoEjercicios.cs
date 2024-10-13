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
    public partial class UsuarioAvanzadoIngresoEjercicios : Form
    {
        public UsuarioAvanzadoIngresoEjercicios()
        {
            InitializeComponent();
        }

 
        private void gestionCli_Click(object sender, EventArgs e)
        {
            var gestionCli = new UsuarioAvanzadoMain();
            gestionCli.Show();
            this.Hide();
        }

    
        private void gestiónDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionEmpleados = new UsuarioAvanzadoGestionDeEmpleados();
            gestionEmpleados.Show();
            this.Hide();
        }

   
        private void gestiónDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionClientes = new UsuarioAvanzadoGestionDeCliente();
            gestionClientes.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var opcDeportes = new UsuarioAvanzadoOpcionalidadDeportes();
            opcDeportes.Show();
            this.Hide();
        }
    }
}
