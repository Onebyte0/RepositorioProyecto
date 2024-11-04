using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OneByte.capaLogica;
using MySql.Data.MySqlClient;


namespace OneByte
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;


            // Agregar opciones a la ComboBox
            comboBox1.Items.Add("Administrativo");
            comboBox1.Items.Add("Avanzado");
            comboBox1.Items.Add("Cliente");
            comboBox1.Items.Add("Entrenador");
            comboBox1.Items.Add("Seleccionador");

            // Asociar el evento Click del botón con el manejador
            iniciarsesion.Click -= iniciarsesion_Click;
            iniciarsesion.Click += iniciarsesion_Click;

            
        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
           
             




            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
    }

    }
}
