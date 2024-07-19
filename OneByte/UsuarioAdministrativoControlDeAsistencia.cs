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
    public partial class UsuarioAdministrativoControlDeAsistencia : Form
    {
        public UsuarioAdministrativoControlDeAsistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var volverUsuAdministrativo = new UsuarioAdministrativoMain();
            volverUsuAdministrativo.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
