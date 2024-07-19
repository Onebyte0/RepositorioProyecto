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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            string selectedValue = comboBox1.SelectedItem.ToString();
        }

        private void registro_Click(object sender, EventArgs e)
        {
            var menuForm = new Form2();
            menuForm.Show();

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("CI");
            comboBox1.Items.Add("PAS");
        }

        private void inicioSesion_Click(object sender, EventArgs e)
        {
            var inicioSesion = new SeleccionUsuarios();
            inicioSesion.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;
            string selectedValue = comboBox2.SelectedItem.ToString();
        }
    }
}
