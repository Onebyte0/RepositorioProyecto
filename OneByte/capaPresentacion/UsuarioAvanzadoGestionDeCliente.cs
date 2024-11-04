using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OneByte.capaPresentacion;

namespace OneByte.capaPresentacion
{
    public partial class UsuarioAvanzadoGestionDeCliente : Form
    {

        private MySqlConnection con;
        string connectionString = "server=localhost;database=onebye;uid=root;pwd=;";
        public UsuarioAvanzadoGestionDeCliente()
        {
            InitializeComponent();
        }

        private void UsuarioAvanzadoGestionDeCliente_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoGestionDeEmpleados usuGestionEmpleados = new UsuarioAvanzadoGestionDeEmpleados();
            usuGestionEmpleados.Show();
            this.Close();
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoIngresoEjercicios usuEjercicios = new UsuarioAvanzadoIngresoEjercicios();
            usuEjercicios.Show();
            this.Close();
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioAvanzadoOpcionalidadDeportes usuOpcClientes = new UsuarioAvanzadoOpcionalidadDeportes();
            usuOpcClientes.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guardarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void eliminarCliente_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                // Obtener el CI o ID del usuario seleccionado
                string idCliente = tabla.SelectedRows[0].Cells["CI"].Value.ToString();

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    EliminarCliente(idCliente); // Llamar al método para eliminar el usuario
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }
        private void EliminarCliente(string idEjercicio)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string consulta = "DELETE FROM EJERCICIO WHERE ID_EJERCICIO = @ID";
                    using (MySqlCommand comando = new MySqlCommand(consulta, con))
                    {
                        comando.Parameters.AddWithValue("@ID", idEjercicio);
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Ejercicio eliminado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar el ejercicio: " + ex.Message);
                }
            }
        }

        private void calleCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
