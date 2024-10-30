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
    public partial class UsuarioAdministrativoMain : Form
    {
        public UsuarioAdministrativoMain()
        {
            InitializeComponent();
        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoControlDeAsistencia usuCntrolAsist = new UsuarioAdministrativoControlDeAsistencia();
            usuCntrolAsist.Show();
            this.Close();
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoRegistroCliente usuRegistroCli = new UsuarioAdministrativoRegistroCliente();
            usuRegistroCli.Show();
            this.Close();
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoDarDeBaja usuDarDeBaja = new UsuarioAdministrativoDarDeBaja();
            usuDarDeBaja.Show();
            this.Close();
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoControlDePago usuControlPago = new UsuarioAdministrativoControlDePago();
            usuControlPago.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
