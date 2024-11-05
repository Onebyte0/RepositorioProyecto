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
using OneByte.capaLogica.Rutinas;
using OneByte.capaPresentacion;

namespace OneByte
{
    public partial class UsuarioClienteMain : Form
    {
        private EjercicioControlador ec = new EjercicioControlador();
        private RutinaControlador rutc = new RutinaControlador();

        private MySqlConnection con;
        string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        public UsuarioClienteMain()
        {
            InitializeComponent(); 
            tablaEjercicio.MultiSelect = false;
            tablaEjercicio.ColumnCount = 4;
            tablaEjercicio.Columns[0].Name = "ID";
            tablaEjercicio.Columns[1].Name = "Descripción";
            tablaEjercicio.Columns[2].Name = "Grupo Muscular";
            tablaEjercicio.Columns[3].Name = "Nombre";
            ec.bdcargarEjercicio();

            tablaRutina.ColumnCount = 7;
            tablaRutina.Columns[0].Name = "ID";
            tablaRutina.Columns[1].Name = "CI";
            tablaRutina.Columns[2].Name = "DIA";
            tablaRutina.Columns[3].Name = "SERIE";
            tablaRutina.Columns[4].Name = "REPS";
            tablaRutina.Columns[5].Name = "DESCANSO";
            tablaRutina.Columns[6].Name = "EJERCICIO";
            rutc.bdcargarRutinas();
        }

        private void UsuarioClienteMain_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void tablaRutina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IniciodeSesion IniciodeSesion = new IniciodeSesion();
            IniciodeSesion.Show();
            this.Close();
        }
    }
}
