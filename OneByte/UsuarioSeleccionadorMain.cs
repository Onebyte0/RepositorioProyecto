using System;
using System.Windows.Forms;

namespace OneByte
{
    public partial class UsuarioSeleccionadorMain : Form
    {
        public UsuarioSeleccionadorMain()
        {
            InitializeComponent();
        }
        

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();

        }

        private void consEvoDepor_Click(object sender, EventArgs e)
        {
            var consEvoDepor = new UsuarioSeleccionadorConsultaEvolucion();
            consEvoDepor.Show();
            this.Close();
        }

        private void agregarDepor_Click(object sender, EventArgs e)
        {
            var agregar = new UsuarioSeleccionadorEquipos();
            agregar.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false; // Desactivar CheckBox2
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false; // Desactivar CheckBox2
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false; // Desactivar CheckBox2
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false; // Desactivar CheckBox2
            }
        }
    }
}
