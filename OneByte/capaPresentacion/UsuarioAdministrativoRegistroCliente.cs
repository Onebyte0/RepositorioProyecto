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
        private ClienteControlador cc = new ClienteControlador();
        private usuarioControlador uc = new usuarioControlador();
        public UsuarioAdministrativoRegistroCliente()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idCliente = txtIDCliente.Text;
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
            controlador.addCliente(idCliente, tipoDoc, numDoc, primerNom, segundoNom, primerApe, segundoApe, Direccion, numCalle, Departamento, Fecha, estPago, Deporte, Contraseña);

            usuarioControlador controlador1 = new usuarioControlador();
            controlador1.addUsuario(numDoc, contraseña, rol);
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

        private void main_Click(object sender, EventArgs e)
        {
            UsuarioAdministrativoMain usuAdminMain = new UsuarioAdministrativoMain();
            usuAdminMain.Show();
            this.Close();
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
    }
 }
    

