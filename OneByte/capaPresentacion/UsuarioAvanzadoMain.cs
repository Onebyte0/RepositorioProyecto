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

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoGestionDeEmpleados usuGestionEmpleados = new UsuarioAvanzadoGestionDeEmpleados();
            usuGestionEmpleados.Show();
            this.Close();
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoGestionDeCliente usuDarDeBaja = new UsuarioAvanzadoGestionDeCliente();
            usuDarDeBaja.Show();
            this.Close();
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoIngresoEjercicios usuEjercicios = new UsuarioAvanzadoIngresoEjercicios();
            usuEjercicios.Show();
            this.Close();
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoOpcionalidadDeportes usuOpcClientes = new UsuarioAvanzadoOpcionalidadDeportes();
            usuOpcClientes.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}