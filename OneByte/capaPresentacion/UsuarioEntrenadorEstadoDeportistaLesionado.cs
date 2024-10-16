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
    public partial class UsuarioEntrenadorEstadoDeportistaLesionado : Form
    {
        public UsuarioEntrenadorEstadoDeportistaLesionado()
        {
            InitializeComponent();
            InitializeDataGridView();
            AddRowsToDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Configurar columnas
            dataGridView1.ColumnCount = 5;

            // Poner nombres de columnas
            dataGridView1.Columns[0].HeaderText = "Estados";
            dataGridView1.Columns[1].HeaderText = "";
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].HeaderText = "";

            // Configurar la propiedad ReadOnly de las columnas (deben ser false para permitir la edición)
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].ReadOnly = false;
            }

            // Ajustar el modo de tamaño de las columnas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configurar la propiedad ReadOnly del DataGridView como false para permitir edición
            dataGridView1.ReadOnly = false;

            // Configurar el modo de selección para seleccionar celdas individuales
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Configurar la propiedad EditMode para permitir la edición inmediata
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            // Llamar a la función que agrega las filas con texto predeterminado
            AddRowsToDataGridView();
        }

        private void AddRowsToDataGridView()
        {
            // Limpiar filas existentes
            dataGridView1.Rows.Clear();

            // Calcular la altura que debería tener cada fila para ocupar todo el espacio disponible
            int totalRows = 5; // Número total de filas que necesitas
            int availableHeight = dataGridView1.ClientSize.Height;
            int rowHeight = availableHeight / totalRows; // Dividir el espacio entre las filas

            // Definir textos específicos para cada fila en la columna "Estados"
            string[] estadosTextos = new string[]
            {
                        "Inicio",
                        "Sin evolucion",
                        "En evolucion",
                        "Satisfactorio",
                        "Calificacion"
            };

            // Crear y agregar filas con la altura ajustada
            for (int i = 0; i < totalRows; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = rowHeight;

                // Agregar la fila al DataGridView
                dataGridView1.Rows.Add(row);

                // Establecer el texto específico en la columna "Estados" para la fila recién agregada
                dataGridView1.Rows[i].Cells[0].Value = estadosTextos[i];
            }

            // Si es necesario, ajustar las propiedades de ScrollBars 
            dataGridView1.ScrollBars = ScrollBars.Vertical;
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
            this.Show();
        }

        private void asignarEjerLesio_Click(object sender, EventArgs e)
        {
          
        }

        private void descripEjer_Click(object sender, EventArgs e)
        {
            var descripEjer = new UsuarioEntrenadorDescripcionEjercicios();
            descripEjer.Show();
            this.Close();
        }

        private void gruposMusc_Click(object sender, EventArgs e)
        {
           
        }

        private void estadoDepor_Click(object sender, EventArgs e)
        {
            var estadoDepor = new UsuarioEntrenadorEstadoDeportistaSano();
            estadoDepor.Show();
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

        private void UsuarioEntrenadorEstadoDeportistaLesionado_Load(object sender, EventArgs e)
        {

        }
    }
}
