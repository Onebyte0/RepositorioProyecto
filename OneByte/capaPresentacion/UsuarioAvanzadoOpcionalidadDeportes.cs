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
    public partial class UsuarioAvanzadoOpcionalidadDeportes : Form
    {
        public UsuarioAvanzadoOpcionalidadDeportes()
        {
            InitializeComponent();
        }

        private void UsuarioAvanzadoOpcionalidadDeportes_Load(object sender, EventArgs e)
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
