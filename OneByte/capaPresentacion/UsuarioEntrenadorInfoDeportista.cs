﻿using System;
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
    public partial class UsuarioEntrenadorInfoDeportista : Form
    {
        public UsuarioEntrenadorInfoDeportista()
        {
            InitializeComponent();
            InitializeDataGridView();
            AddRowsToDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Configurar columnas
            dataGridView1.ColumnCount = 9;

            // Poner nombres de columnas
            dataGridView1.Columns[0].HeaderText = "Deportista";
            dataGridView1.Columns[1].HeaderText = "Documento";
            dataGridView1.Columns[2].HeaderText = "ID de cliente";
            dataGridView1.Columns[3].HeaderText = "Primer Nombre";
            dataGridView1.Columns[4].HeaderText = "Primer Apellido";
            dataGridView1.Columns[5].HeaderText = "Direccion";
            dataGridView1.Columns[6].HeaderText = "Telefono";
            dataGridView1.Columns[7].HeaderText = "Posicion";
            dataGridView1.Columns[8].HeaderText = "Deporte";

            // Configurar la propiedad ReadOnly de las columnas (deben ser false para permitir la edición)
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = false;
            dataGridView1.Columns[2].ReadOnly = false;
            dataGridView1.Columns[3].ReadOnly = false;
            dataGridView1.Columns[4].ReadOnly = false;
            dataGridView1.Columns[5].ReadOnly = false;
            dataGridView1.Columns[6].ReadOnly = false;
            dataGridView1.Columns[7].ReadOnly = false;
            dataGridView1.Columns[8].ReadOnly = false;

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

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();
        }

        private void UsuarioEntrenadorInfoDeportista_Load(object sender, EventArgs e)
        {

        }
    }
}
