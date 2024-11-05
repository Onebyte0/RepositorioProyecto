using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OneByte.capaLogica;
using OneByte.capaLogica.Cliente;
using OneByte.capaLogica.Rutinas;
using OneByte.capaPresentacion;

namespace OneByte
{
    public partial class UsuarioEntrenadorDescripcionEjercicios : Form
    {
        private EjercicioControlador ec = new EjercicioControlador();
        private ClienteControlador cc = new ClienteControlador(); 
        string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        public UsuarioEntrenadorDescripcionEjercicios()
        {
            InitializeComponent();
            tablaEjercicio.MultiSelect = false;
            tablaEjercicio.ColumnCount = 4;
            tablaEjercicio.Columns[0].Name = "ID";
            tablaEjercicio.Columns[1].Name = "Descripción";
            tablaEjercicio.Columns[2].Name = "Grupo Muscular";
            tablaEjercicio.Columns[3].Name = "Nombre";
            ec.bdcargarEjercicio();

            tablaCliente.MultiSelect = false;
            tablaCliente.ColumnCount = 4;
            tablaCliente.Columns[0].Name = "CI";
            tablaCliente.Columns[1].Name = "1° Nombre";
            tablaCliente.Columns[2].Name = "2° Apellido";
            tablaCliente.Columns[3].Name = "FechaIngreso";
            cc.bdcargarClientes();

        }
       
       
        private void asignarEjerLesio_Click(object sender, EventArgs e)
        {
            
        }

        private void gruposMusc_Click(object sender, EventArgs e)
        {
          
        }

       

        private void UsuarioEntrenadorDescripcionEjercicios_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
        }

        private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_buscarEjercicio_Click(object sender, EventArgs e)
        {
            Ejercicio ejer = ec.findEjercicio(txtIDEjercicioBuscar.Text);

            if (ejer != null)
            {
                tablaEjercicio.Rows.Add(ejer.toObject());
            }
            else
            {
                MessageBox.Show("No se ha encontrado el ejercicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button_buscarCliente_Click(object sender, EventArgs e)
        {
            cliente c = cc.findCliente(txtNumDocBuscar.Text);
            if (c != null)
            {
                tablaCliente.Rows.Add(c.toObject());
            }
            else
            {
                MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
