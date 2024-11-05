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
using OneByte.capaPresentacion;
using OneByte.capaLogica.Rutinas;
using MySql.Data.MySqlClient;

namespace OneByte
{
    public partial class UsuarioAvanzadoOpcionalidadDeportes : Form
    {
        DeporteControlador depc = new DeporteControlador();
        private MySqlConnection connection;
        string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        public UsuarioAvanzadoOpcionalidadDeportes()
        {
            InitializeComponent();
            tablaDeporte.MultiSelect = false;
            tablaDeporte.ColumnCount = 2;
            tablaDeporte.Columns[0].Name = "ID Deporte";
            tablaDeporte.Columns[1].Name = "Nombre";
            depc.bdcargarDeporte();
        }

       


        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoMain usuEjercicios = new UsuarioAvanzadoMain();
            usuEjercicios.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button_guardarDeporte_Click(object sender, EventArgs e)
        {
            string idDeporte = txtIDDeporte.Text;
            string nombre = txtNombreDeporte.Text;

            DeporteControlador controlador = new DeporteControlador();
            controlador.addDeporte(idDeporte, nombre);
        }

        private void button_buscarDeporte_Click(object sender, EventArgs e)
        {
            Deporte deporte = depc.findDeporte(txtNombreDeporte.Text);

            if (deporte != null)
            {
                tablaDeporte.Rows.Add(deporte.toObject());
            }
            else
            {
                MessageBox.Show("No se ha encontrado el deporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_eliminarDeporte_Click(object sender, EventArgs e)
        {
            if (tablaDeporte.SelectedRows.Count > 0)
            {
                string idDeporte = tablaDeporte.SelectedRows[0].Cells["ID Deporte"].Value.ToString();

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este deporte?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    EliminarDeporte(idDeporte);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un deporte para eliminar.");
            }
        }
        private void EliminarDeporte(string id_deporte)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string consulta = "DELETE FROM DEPORTE WHERE IDDEPORTE = @IDDEP";
                    using (MySqlCommand comando = new MySqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@IDDEP", id_deporte);
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Deporte eliminado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El sistema falló al eliminar el deporte: " + ex.Message);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            IniciodeSesion IniciodeSesion = new IniciodeSesion();
            IniciodeSesion.Show();
            this.Close();
        }
    }
}
 