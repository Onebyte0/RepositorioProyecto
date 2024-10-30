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
    public partial class UsuarioClienteMain : Form
    {
        public UsuarioClienteMain()
        {
            InitializeComponent();
        }

        private void UsuarioClienteMain_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioClienteEstadoDeportista usuClienteEstadoDep = new UsuarioClienteEstadoDeportista();
            usuClienteEstadoDep.Show();
            this.Close();
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioClienteRendimientoDeportista usuRendDeport = new UsuarioClienteRendimientoDeportista();
            usuRendDeport.Show();
            this.Close();
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioClienteAgendaRutinasAsignadas usuRutina = new UsuarioClienteAgendaRutinasAsignadas();
            usuRutina.Show();
            this.Close();
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioClienteEstadoPago usuEstPago = new UsuarioClienteEstadoPago();
            usuEstPago.Show();
            this.Close();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioClienteAgendaDisponibilidad usuDisp = new UsuarioClienteAgendaDisponibilidad();
            usuDisp.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
