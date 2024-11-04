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

namespace OneByte.capaPresentacion
{
    public partial class UsuarioAvanzadoGestionDeCliente : Form
    {
        public UsuarioAvanzadoGestionDeCliente()
        {
            InitializeComponent();
        }

        private void UsuarioAvanzadoGestionDeCliente_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoGestionDeEmpleados usuGestionEmpleados = new UsuarioAvanzadoGestionDeEmpleados();
            usuGestionEmpleados.Show();
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
            
        }
    }
    
}
