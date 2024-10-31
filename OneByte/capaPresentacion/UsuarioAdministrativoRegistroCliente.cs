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

namespace OneByte.capaPresentacion
{
    public partial class UsuarioAdministrativoRegistroCliente : Form
    {
        public UsuarioAdministrativoRegistroCliente()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente nuevoCliente = new cliente()
            {
               
                numDoc = docCliente.Text,
                primerNom = nombreCliente.Text,
                primerApe = apellidoCliente.Text,
                direccion = calleCliente.Text,
                numCalle = int.Parse(numCalleCliente.Text),
                departamento = departamentoCliente.Text,
                fecha = DateTime.Parse(fechaNacCliente.Text),
                
            };

            ClienteControlador clienteControlador = new ClienteControlador();
            bool success = clienteControlador.AgregarCliente(nuevoCliente);

            if (success)
            {
                MessageBox.Show("Cliente agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente.");
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void controlDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoControlDeAsistencia usuCntrolAsist = new UsuarioAdministrativoControlDeAsistencia();
            usuCntrolAsist.Show();
            this.Close();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoDarDeBaja usuDarDeBaja = new UsuarioAdministrativoDarDeBaja();
            usuDarDeBaja.Show();
            this.Close();
        }

        private void gestionDePagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoControlDePago usuControlPago = new UsuarioAdministrativoControlDePago();
            usuControlPago.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    };
        }
    

