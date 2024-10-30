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
                PrimerNom = nombreCliente.Text,
                PrimerApe = apellidoCliente.Text,
                Direccion = calleCliente.Text,
                NumCalle = int.Parse(numCalleCliente.Text),
                Departamento = departamentoCliente.Text,
                Fecha = DateTime.Parse(fechaNacCliente.Text),
                
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

    };
        }
    

