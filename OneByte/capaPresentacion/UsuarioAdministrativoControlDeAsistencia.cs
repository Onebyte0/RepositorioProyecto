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
    public partial class UsuarioAdministrativoControlDeAsistencia : Form
    {
        public UsuarioAdministrativoControlDeAsistencia()
        {
            InitializeComponent();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoDarDeBaja usuDarDeBaja = new UsuarioAdministrativoDarDeBaja();
            usuDarDeBaja.Show();
            this.Close();
        }

        private void habilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UsuarioAdministrativoRegistroCliente usuRegistroCli = new UsuarioAdministrativoRegistroCliente();
            usuRegistroCli.Show();
            this.Close();

        }

        private void gestionDePagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoControlDePago usuControlPago = new UsuarioAdministrativoControlDePago();
            usuControlPago.Show();
            this.Close();
        }

        private void main_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoMain usuAdminMain = new UsuarioAdministrativoMain();
            usuAdminMain.Show();
            this.Close();
        }
    }
}
