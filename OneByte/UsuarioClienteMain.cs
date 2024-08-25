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
    public partial class UsuarioClienteMain : Form
    {
        public UsuarioClienteMain()
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
            dataGridView1.Columns[0].HeaderText = "Horarios";
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
            var grupoPerte = new UsuarioClienteGrupoPerteneciente();
            grupoPerte.Show();
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

        private void agendaRutinas_Click(object sender, EventArgs e)
        {
            var agendaRutinas = new UsuarioClienteAgendaRutinasAsignadas();
            agendaRutinas.Show();   
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
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();
        }
    }
}
