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
    public partial class UsuarioAdministrativoDarDeBaja : Form
    {
        public UsuarioAdministrativoDarDeBaja()
        {
            InitializeComponent();
        }

        private void controlDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoControlDeAsistencia usuCntrolAsist = new UsuarioAdministrativoControlDeAsistencia();
            usuCntrolAsist.Show();
            this.Close();
        }

        private void UsuarioAdministrativoDarDeBaja_Load(object sender, EventArgs e)
        {

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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
