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
    public partial class UsuarioEntrenadorGruposMusculares : Form
    {
        public UsuarioEntrenadorGruposMusculares()
        {
            InitializeComponent();
            InitializeDataGridView();
            AddRowsToDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Configurar columnas
            dataGridView1.ColumnCount = 8;

            // Poner nombres de columnas
            dataGridView1.Columns[0].HeaderText = "Grupo muscular";
            dataGridView1.Columns[1].HeaderText = "";
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            // Configurar la propiedad ReadOnly de las columnas (deben ser false para permitir la edición)
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = false;
            dataGridView1.Columns[2].ReadOnly = false;
            dataGridView1.Columns[3].ReadOnly = false;
            dataGridView1.Columns[4].ReadOnly = false;
            dataGridView1.Columns[5].ReadOnly = false;
            dataGridView1.Columns[6].ReadOnly = false;
            dataGridView1.Columns[7].ReadOnly = false;

            // Ajustar el modo de tamaño de las columnas a ninguna para permitir el scroll horizontal
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Ajustar el ancho de las columnas si es necesario
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 150; // Ancho de columna fijo
            }

            // Configurar la propiedad ReadOnly del DataGridView como false para permitir edición
            dataGridView1.ReadOnly = false;

            // Configurar el modo de selección para seleccionar celdas individuales
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Configurar la propiedad EditMode para permitir la edición inmediata
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            // Activar la barra de desplazamiento horizontal
            dataGridView1.ScrollBars = ScrollBars.Horizontal;

            // Llamar a la función que agrega las filas con texto predeterminado
            AddRowsToDataGridView();
        }
        private void AddRowsToDataGridView()
        {
            // Limpiar filas existentes
            dataGridView1.Rows.Clear();

            // Calcular la altura que debería tener cada fila para ocupar todo el espacio disponible
            int availableHeight = dataGridView1.Height;
            int rowHeight = availableHeight / 4; // Dividir el espacio entre 4 filas

            // Crear y agregar 4 filas con la altura ajustada
            for (int i = 0; i < 4; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = rowHeight;
                dataGridView1.Rows.Add(row);
            }
        }


        private void rutinasSanos_Click(object sender, EventArgs e)
        {
            var rutinasSanos = new UsuarioEntrenadorRutinasDeportistasSanos();
            rutinasSanos.Show();
            this.Close();
        }

        private void rutinasLesio_Click(object sender, EventArgs e)
        {
            var rutinasLesio = new UsuarioEntrenadorRutinasDeportistasLesionados();
            rutinasLesio.Show();
            this.Close();
        }

        private void asignarEjerSanos_Click(object sender, EventArgs e)
        {
            var asignarEjerSanos = new UsuarioEntrenadorAsignarEjerciciosRutinas();
            asignarEjerSanos.Show();
            this.Close();
        }

        private void asignarEjerLesio_Click(object sender, EventArgs e)
        {
            var asignarEjerLesio = new UsuarioEntrenadorAsignarEjerciciosRutinasLesionados();
            asignarEjerLesio.Show();
            this.Close();
        }

        private void descripEjer_Click(object sender, EventArgs e)
        {
            var descripEjer = new UsuarioEntrenadorDescripcionEjercicios();
            descripEjer.Show();
            this.Close();
        }

        private void estadoDepor_Click(object sender, EventArgs e)
        {
            var estadoDepor = new UsuarioEntrenadorEstadoDeportistaSano();
            estadoDepor.Show();
            this.Close();
        }

        private void estadoDeporLesio_Click(object sender, EventArgs e)
        {
            var estadoDeporLesio = new UsuarioEntrenadorEstadoDeportistaLesionado();
            estadoDeporLesio.Show();
            this.Close();
        }

        private void agenda_Click(object sender, EventArgs e)
        {
            var agenda = new UsuarioEntrenadorAgendaDisponibilidad();
            agenda.Show();
            this.Close();
        }

        private void agendaRutinas_Click(object sender, EventArgs e)
        {
            var agendaRutinas = new UsuarioEntrenadorAgendaRutinasAsignadas();
            agendaRutinas.Show();
            this.Close();
        }

        private void agruparDepor_Click(object sender, EventArgs e)
        {
            var agruparDepor = new UsuarioEntrenadorAgruparDeportistas();
            agruparDepor.Show();
            this.Close();
        }

        private void infoDepor_Click(object sender, EventArgs e)
        {
            var infoDepor = new UsuarioEntrenadorInfoDeportista();
            infoDepor.Show();
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
