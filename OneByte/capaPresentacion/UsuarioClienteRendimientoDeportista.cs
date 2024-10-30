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
    public partial class UsuarioClienteRendimientoDeportista : Form
    {
        public UsuarioClienteRendimientoDeportista()
        {
            InitializeComponent();
            InitializeDataGridView();
            AddRowsToDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Configurar columnas
            dataGridView1.ColumnCount = 2;

            // Poner nombres de columnas
            dataGridView1.Columns[0].HeaderText = "Items a cumplir";
            dataGridView1.Columns[1].HeaderText = "Cliente";

            // Configurar la propiedad ReadOnly de las columnas (deben ser false para permitir la edición)
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = false;

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
            // Eliminar todas las filas existentes
            dataGridView1.Rows.Clear();

            // Lista de textos predeterminados para la columna "Estado"
            string[] estados = { "Cumplimiento con la agenda", "Resistencia anaeróbica", "Fuerza muscular", "Resistencia muscular", "Flexibilidad", "Resistencia a la monotonía", "Resiliencia" };

            // Agregar filas con texto predeterminado en la columna "Estado" y vacío en la columna "Cliente N"
            foreach (string estado in estados)
            {
                dataGridView1.Rows.Add(estado, string.Empty);
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
       
        }

        private void verDatos_Click(object sender, EventArgs e)
        {
            
        }

        private void agendaRutinas_Click(object sender, EventArgs e)
        {
            
        }

        private void descripEjer_Click(object sender, EventArgs e)
        {
            
        }

        private void estadoPago_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            
        }

        private void UsuarioClienteRendimientoDeportista_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioClienteEstadoDeportista usuClienteEstadoDep = new UsuarioClienteEstadoDeportista();
            usuClienteEstadoDep.Show();
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
    }
}
