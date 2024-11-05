using OneByte.capaPresentacion;
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
    public partial class UsuarioClienteAgendaRutinasAsignadas : Form
    {
        public UsuarioClienteAgendaRutinasAsignadas()
        {
            InitializeComponent();
            InitializeDataGridView();
            AddRowsToDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Configurar columnas
            dataGridView1.ColumnCount = 6;

            // Poner nombres de columnas
            dataGridView1.Columns[0].HeaderText = "Rutinas";
            dataGridView1.Columns[1].HeaderText = "Lunes";
            dataGridView1.Columns[2].HeaderText = "Martes";
            dataGridView1.Columns[3].HeaderText = "Miércoles";
            dataGridView1.Columns[4].HeaderText = "Jueves";
            dataGridView1.Columns[5].HeaderText = "Viernes";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void AddRowsToDataGridView()
        {
            // Altura de fila por defecto
            int rowHeight = dataGridView1.RowTemplate.Height;

            // Cantidad de filas hasta que complete el tamaño el dataGridView
            int rows = dataGridView1.Height / rowHeight;

            // Agregar filas
            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void estadoDepor_Click(object sender, EventArgs e)
        {
            var estadoDepor = new UsuarioClienteEstadoDeportista();
            estadoDepor.Show();
            this.Close();
        }

        private void grupoPerte_Click(object sender, EventArgs e)
        {
            var estadoPerte = new UsuarioClienteGrupoPerteneciente();
            estadoPerte.Show();
            this.Close();
        }

        private void verDatos_Click(object sender, EventArgs e)
        {
            var verDatos = new UsuarioClienteDatosDeportista();
            verDatos.Show();
            this.Close();
        }

        private void rendiDepor_Click(object sender, EventArgs e)
        {
            var rendiDepor = new UsuarioClienteRendimientoDeportista();
            rendiDepor.Show();
            this.Close();
        }

        private void descripEjer_Click(object sender, EventArgs e)
        {
            var descripEjer = new UsuarioClienteDescripcionEjercicios();
            descripEjer.Show();
            this.Close();   
        }

        private void estadoPago_Click(object sender, EventArgs e)
        {
            var estadoPago = new UsuarioClienteEstadoPago();
            estadoPago.Show();
            this.Close();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new IniciodeSesion();
            cerrarsesion.Show();
            this.Close();
        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioClienteEstadoDeportista usuClienteEstadoDep = new UsuarioClienteEstadoDeportista();
            usuClienteEstadoDep.Show();
            this.Close();
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioClienteRendimientoDeportista usuRendDeport = new UsuarioClienteRendimientoDeportista();
            usuRendDeport.Show();
            this.Close();
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioClienteAgendaRutinasAsignadas usuRutina = new UsuarioClienteAgendaRutinasAsignadas();
            usuRutina.Show();
            this.Close();
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioClienteEstadoPago usuEstPago = new UsuarioClienteEstadoPago();
            usuEstPago.Show();
            this.Close();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioClienteAgendaDisponibilidad usuDisp = new UsuarioClienteAgendaDisponibilidad();
            usuDisp.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

       
    }

