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
using OneByte.capaPresentacion;

namespace OneByte
{
    public partial class UsuarioAvanzadoMain : Form
    {
        public UsuarioAvanzadoMain()
        {
            InitializeComponent();
        }

        private void UsuarioAvanzadoMain_Load(object sender, EventArgs e)
        {

        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoOpcionalidadDeportes usuOpcClientes = new UsuarioAvanzadoOpcionalidadDeportes();
            usuOpcClientes.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciodeSesion form = new IniciodeSesion();
            form.Show();
            this.Close();
        }

        private void toolStripVentanaPrincial_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoMain usuEjercicios = new UsuarioAvanzadoMain();
            usuEjercicios.Show();
            this.Close();
        }
    }
}