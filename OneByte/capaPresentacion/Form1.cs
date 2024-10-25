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

namespace OneByte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Agregar opciones a la ComboBox
            comboBox1.Items.Add("Administrativo");
            comboBox1.Items.Add("Avanzado");
            comboBox1.Items.Add("Cliente");
            comboBox1.Items.Add("Entrenador");
            comboBox1.Items.Add("Seleccionador");

            // Asociar el evento Click del botón con el manejador
            iniciarsesion.Click -= iniciarsesion_Click;
            iniciarsesion.Click += iniciarsesion_Click;

            comboBox2.Items.Add("CI");
            comboBox2.Items.Add("PAS");
        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una opción en la ComboBox
            if (comboBox1.SelectedItem != null)
            {
                conexionBD con = new conexionBD();
                if (con.AbrirConexion()) {
                    Console.WriteLine("Conexion exitosa");

                }else
                {
                    Console.WriteLine("Error");
                }

                // Obtener la opción seleccionada
                string selectedOption = comboBox1.SelectedItem.ToString();

                // Abrir la ventana correspondiente según la opción seleccionada
                switch (selectedOption)
                {
                    case "Administrativo":
                        UsuarioAdministrativoMain Usuadmin = new UsuarioAdministrativoMain(); // Ventana para "Administrativo"
                        Usuadmin.Show();
                        break;
                    case "Avanzado":
                        UsuarioAvanzadoMain Usuavanzado = new UsuarioAvanzadoMain(); // Ventana para "Avanzado"
                        Usuavanzado.Show();
                        break;
                    case "Cliente":
                        UsuarioClienteMain Usucliente = new UsuarioClienteMain(); // Ventana para "Cliente"
                        Usucliente.Show();
                        break;
                    case "Entrenador":
                        UsuarioEntrenadorMain Usuentrenador = new UsuarioEntrenadorMain(); // Ventana para "Entrenador"
                        Usuentrenador.Show();
                        break;
                    case "Seleccionador":
                        UsuarioSeleccionadorMain Ususeleccionador = new UsuarioSeleccionadorMain(); // Ventana para "Seleccionador"
                        Ususeleccionador.Show();
                        break;
                    default:
                        MessageBox.Show("Seleccione una opción válida.");
                        break;
                }

                // Si deseas cerrar la ventana actual al abrir la nueva
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción antes de iniciar sesión.");
            }
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
