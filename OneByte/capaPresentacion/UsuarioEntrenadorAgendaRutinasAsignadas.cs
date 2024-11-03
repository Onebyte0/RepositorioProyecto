using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneByte.capaPresentacion;

namespace OneByte
{
    public partial class UsuarioEntrenadorAgendaRutinasAsignadas : Form
    {
        public UsuarioEntrenadorAgendaRutinasAsignadas()
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
            dataGridView1.Columns[0].HeaderText = "Horarios";
            dataGridView1.Columns[1].HeaderText = "Rutina";
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
           

            // Configurar la propiedad ReadOnly de las columnas (deben ser false para permitir la edición)
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = false;
            dataGridView1.Columns[2].ReadOnly = false;
            dataGridView1.Columns[3].ReadOnly = false;
            dataGridView1.Columns[4].ReadOnly = false;
            dataGridView1.Columns[5].ReadOnly = false;
            

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

       

        private void asignarEjerLesio_Click(object sender, EventArgs e)
        {
           
        }

       

        private void gruposMusc_Click(object sender, EventArgs e)
        {
            
        }

       
        private void UsuarioEntrenadorAgendaRutinasAsignadas_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorAgendaRutinasAsignadas usuEntrenadorRutinas = new UsuarioEntrenadorAgendaRutinasAsignadas();
            usuEntrenadorRutinas.Show();
            this.Close();
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorAgendaDisponibilidad usuEntrenadorAgenda = new UsuarioEntrenadorAgendaDisponibilidad();
            usuEntrenadorAgenda.Show();
            this.Close();
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorEstadoDeportistaSano usuEntrenadorDeportista = new UsuarioEntrenadorEstadoDeportistaSano();
            usuEntrenadorDeportista.Show();
            this.Close();
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorEstadoDeportistaLesionado usuEntrenadorDeportistaLesionado = new UsuarioEntrenadorEstadoDeportistaLesionado();
            usuEntrenadorDeportistaLesionado.Show();
            this.Close();
        }

        private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorInfoDeportista usuEntrenadorInfoDeportista = new UsuarioEntrenadorInfoDeportista();
            usuEntrenadorInfoDeportista.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
