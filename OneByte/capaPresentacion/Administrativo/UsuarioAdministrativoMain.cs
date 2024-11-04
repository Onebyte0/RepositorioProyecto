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

namespace OneByte.capaPresentacion
{
    public partial class UsuarioAdministrativoMain : Form
    {
        private ClienteControlador cc = new ClienteControlador();
        private usuarioControlador uc = new usuarioControlador();
        public UsuarioAdministrativoMain()
        {
            InitializeComponent();
            tablaCliente.MultiSelect = false;
            tablaCliente.ColumnCount = 4;
            tablaCliente.Columns[0].Name = "CI";
            tablaCliente.Columns[0].Width = 100;
            tablaCliente.Columns[1].Name = "Nombre";
            tablaCliente.Columns[1].Width = 130;
            tablaCliente.Columns[2].Name = "Apellido";
            tablaCliente.Columns[2].Width = 130;
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
                Form1 f1 = new Form1();
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
    }
 }
    

