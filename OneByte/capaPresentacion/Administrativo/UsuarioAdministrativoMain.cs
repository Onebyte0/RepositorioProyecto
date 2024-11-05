using OneByte.capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using OneByte.capaLogica.Cliente;
using OneByte.capaPresentacion;
using MySql.Data.MySqlClient.Memcached;
using MySql.Data.MySqlClient;

namespace OneByte.capaPresentacion
{
    public partial class UsuarioAdministrativoMain : Form
    {
        private ClienteControlador cc = new ClienteControlador();
        private usuarioControlador uc = new usuarioControlador();
        private MySqlConnection connection;
        string connectionString = "server=localhost;database=onebyte;uid=root;pwd=;";

        public UsuarioAdministrativoMain()
        {
            InitializeComponent();
            tablaCliente.MultiSelect = false;
            tablaCliente.ColumnCount = 4;
            tablaCliente.Columns[0].Name = "CI";
            tablaCliente.Columns[1].Name = "1° Nombre";
            tablaCliente.Columns[2].Name = "2° Apellido";
            tablaCliente.Columns[3].Name = "FechaIngreso";
            cc.bdcargarClientes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCliente = int.TryParse(txtIDCliente.Text, out int ic) ? ic : 0;
            string numDoc = docCliente.Text;
            string tipoDoc = cmbTipoDoc.SelectedItem.ToString();
            string primerNom = txtPrimerNombre.Text;
            string segundoNom = txtSegundoNombre.Text;
            string primerApe = txtPrimerApellido.Text;
            string segundoApe = txtSegundoApellido.Text;
            string Direccion = txtCalle.Text;
            int numCalle = int.TryParse(txtNroCalle.Text, out int n) ? n : 0;
            string Departamento = cmbDepartamento.SelectedItem?.ToString();
            string Deporte = deporteCliente.Text; 
            DateTime? Fecha = fechaNacimiento.Value;
            string estPago = txtCalle.Text;
            string contraseña = txtContraseña.Text;
            string rol = cmbRol.SelectedItem?.ToString();

            ClienteControlador controlador = new ClienteControlador();
            controlador.addCliente(idCliente, tipoDoc, numDoc, primerNom, segundoNom, primerApe, segundoApe, Direccion, numCalle, Departamento, Fecha, estPago, Deporte, contraseña);

            usuarioControlador controlador1 = new usuarioControlador();
            controlador1.addUsuario(numDoc, contraseña, rol);
        }


        private void UsuarioAdministrativoRegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void docCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas saliendo del SIGEN!", "Cierre de Sesión!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                IniciodeSesion f1 = new IniciodeSesion();
                f1.Show();
            }
        }

        private void button_buscarCliente_Click(object sender, EventArgs e)
        {
            cliente c = cc.findCliente(txtNumDocBuscar.Text);
            if (c != null)
            {
                tablaCliente.Rows.Add(c.toObject());
            }
            else
            {
                MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_eliminarUsuario_Click(object sender, EventArgs e)
        {
            if (tablaCliente.SelectedRows.Count > 0)
            {
                // Obtener el CI o ID del usuario seleccionado
                string idUsuario = tablaCliente.SelectedRows[0].Cells["CI"].Value.ToString();

                var confirmResult = MessageBox.Show("¿Queres eliminar este usuario??", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    EliminarCliente(idUsuario); // Llamar al método para eliminar el usuario
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }
        private void EliminarCliente(string idCliente)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlTransaction trans = con.BeginTransaction())
                    {
                        string consultaCliente = "DELETE FROM CLIENTE WHERE NUMDOC = @ID";
                        string consultaUsuario = "DELETE FROM USUARIO WHERE NUMDOC = @ID";

                        using (MySqlCommand comandoCliente = new MySqlCommand(consultaCliente, con, trans))
                        {
                            comandoCliente.Parameters.AddWithValue("@ID", idCliente);
                            comandoCliente.ExecuteNonQuery();
                        }
                        using (MySqlCommand comandoUsuario = new MySqlCommand(consultaUsuario, con, trans))
                        {
                            comandoUsuario.Parameters.AddWithValue("@ID", idCliente);
                            comandoUsuario.ExecuteNonQuery();
                        }
                        

                        trans.Commit(); 
                    }
                    MessageBox.Show("Cliente borrado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El sistema ha fallado!: " + ex.Message);
                }
            }
        }
    }
 }
    

