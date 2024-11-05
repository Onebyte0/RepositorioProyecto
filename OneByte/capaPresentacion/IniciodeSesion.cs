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
using OneByte.capaPresentacion;


namespace OneByte
{
    public partial class IniciodeSesion : Form
    {
        ConexionBD con = new ConexionBD();
        public IniciodeSesion()
        {
            InitializeComponent();

            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;

            // Agregar opciones a la ComboBox
            cmbRol.Items.Add("Administrativo");
            cmbRol.Items.Add("Avanzado");
            cmbRol.Items.Add("Cliente");
            cmbRol.Items.Add("Entrenador");
            cmbRol.Items.Add("Seleccionador");

            // Asociar el evento Click del botón con el manejador
            iniciarsesion.Click -= iniciarsesion_Click;
            iniciarsesion.Click += iniciarsesion_Click;

            
        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            string nroDoc = documento.Text;
            string contraseña = contraseñaUsuario.Text;
            string rol = cmbRol.SelectedItem.ToString();

            // Verificamos las credenciales
            if (con.User(nroDoc, contraseña, rol))
            {
                IniciarSesionPorRol(rol, nroDoc); // Llamamos a la función para abrir el form según el rol
            }
            else
            {
                MessageBox.Show("Usuario, contraseña o rol incorrectos." + MessageBoxButtons.OK);
            }

        }
        private void IniciarSesionPorRol(string rol, string nroDoc)
        {
            Form formulario = null;

            // Verificamos el rol
            switch (rol)
            {
                case "Administrativo":
                    formulario = new UsuarioAdministrativoMain();
                    break;
                case "Avanzado":
                    formulario = new UsuarioAvanzadoMain();
                    break;
                case "Cliente":
                    formulario = new UsuarioClienteMain();
                    break;
                case "Entrenador":
                    formulario = new UsuarioEntrenadorMain();
                    break;
                case "Seleccionador":
                    formulario = new UsuarioSeleccionadorMain();
                    break;
                default:
                    MessageBox.Show("Usuario no reconocido");
                    break;
            }

            // Si existe un formulario asociado al rol, lo mostramos
            if (formulario != null)
            {
                this.Hide(); // Ocultamos el formulario de login
                formulario.ShowDialog(); // Mostramos el formulario
                this.Show(); // Mostramos nuevamente el formulario de login cuando se cierre el form del rol
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
