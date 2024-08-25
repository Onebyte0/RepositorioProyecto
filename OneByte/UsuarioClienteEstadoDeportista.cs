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
    public partial class UsuarioClienteEstadoDeportista : Form
    {
        public UsuarioClienteEstadoDeportista()
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
            dataGridView1.Columns[0].HeaderText = "Estado";
            dataGridView1.Columns[1].HeaderText = "Cliente N";
            

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void AddRowsToDataGridView()
        {
            // Altura de fila por defecto
            int rowHeight = dataGridView1.RowTemplate.Height;

            // Cantidad de filas hasta que complete el tamaño el dataGridView
            int rows = dataGridView1.Height / rowHeight;

            // Agregar filas
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Rows.Add();
            }
        }
        private void atras_Click(object sender, EventArgs e)
        {
            var atras = new UsuarioClienteMain();
            atras.Show();
            this.Hide();
        }
    }
}
