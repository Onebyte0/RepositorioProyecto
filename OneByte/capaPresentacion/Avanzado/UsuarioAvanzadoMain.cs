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
using OneByte.capaLogica;

namespace OneByte
{
    public partial class UsuarioAvanzadoMain : Form
    {
        private EjercicioControlador ec = new EjercicioControlador();

        private MySqlConnection con;
        string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";
        public UsuarioAvanzadoMain()
        {
            InitializeComponent();
            tablaEjercicio.MultiSelect = false;
            tablaEjercicio.ColumnCount = 4;
            tablaEjercicio.Columns[0].Name = "ID";
            tablaEjercicio.Columns[1].Name = "Descripción";
            tablaEjercicio.Columns[2].Name = "Grupo Muscular";
            tablaEjercicio.Columns[3].Name = "Nombre";
            ec.bdcargarEjercicio();
        }

        

        

       

        

        private void button_buscarEjercicio_Click(object sender, EventArgs e)
        {
            Ejercicio ejer = ec.findEjercicio(txtIDEjercicio.Text);

            if (ejer != null)
            {
                tablaEjercicio.Rows.Add(ejer.toObject());
            }
            else
            {
                MessageBox.Show("No se ha encontrado el ejercicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ObtenerGrupoMuscularSeleccionado()
        {
            List<string> ejercicios = new List<string>();
            foreach (object item in ListBox_GrupoMuscular.CheckedItems)
            {
                ejercicios.Add(item.ToString());
            }
            return string.Join(", ", ejercicios);
        }
        private void button_guardarEjercicio_Click(object sender, EventArgs e)
        {
            string id_ejercicio = txtIDEjercicio.Text;
            string grupo_muscular = ObtenerGrupoMuscularSeleccionado();
            string nombre = txtNombreEjercicio.Text;
            string descripcion = textBox_descripcionEjercicio.Text;

            EjercicioControlador controlador4 = new EjercicioControlador();
            controlador4.addEjercicio(id_ejercicio, descripcion, grupo_muscular, nombre);
        }

        private void button_eliminarEjercicio_Click(object sender, EventArgs e)
        {
            if (tablaEjercicio.SelectedRows.Count > 0)
            {
                string idEjercicio = tablaEjercicio.SelectedRows[0].Cells["ID Deporte"].Value.ToString();

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este ejercicio?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    EliminarEjercicio(idEjercicio);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ejercicio para eliminar.");
            }
        }
        private void EliminarEjercicio(string idEjercicio)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string consulta = "DELETE FROM EJERCICIO WHERE IDEJERCICIO = @IDEJER";
                    using (MySqlCommand comando = new MySqlCommand(consulta, connection))
                    {
                        comando.Parameters.AddWithValue("@IDEJER", idEjercicio);
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Deporte eliminado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El sistema falló al eliminar el ejercicio: " + ex.Message);
                }
            }
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoOpcionalidadDeportes opcionalidadDeportes = new UsuarioAvanzadoOpcionalidadDeportes();
            opcionalidadDeportes.Show();
            this.Close();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            IniciodeSesion IniciodeSesion = new IniciodeSesion();
            IniciodeSesion.Show();
            this.Close();
        }
    }
}