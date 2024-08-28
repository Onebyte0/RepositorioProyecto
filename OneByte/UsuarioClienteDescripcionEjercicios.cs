using System;
using System.CodeDom;
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
    public partial class UsuarioClienteDescripcionEjercicios : Form
    {
        public UsuarioClienteDescripcionEjercicios()
        {
            InitializeComponent();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            var atras = new UsuarioClienteMain();
            atras.Show();
            this.Close();
        }

        private void estadoDepor_Click(object sender, EventArgs e)
        {
            var estadoDepor = new UsuarioClienteEstadoDeportista();
            estadoDepor.Show();
            this.Close();
        }

        private void grupoPerte_Click(object sender, EventArgs e)
        {
            var grupoPerte = new UsuarioClienteGrupoPerteneciente(); 
            grupoPerte.Show();
            this.Close();
        }

        private void verDatos_Click(object sender, EventArgs e)
        {
            var verDatos = new UsuarioClienteDatosDeportista();
            verDatos.Show();
            this.Close();
        }

        private void rendiDepor_Click(object sender, EventArgs e)
        {
            var rendiDepor = new UsuarioClienteRendimientoDeportista();
            rendiDepor.Show();
            this.Close();
        }

        private void agendaRutinas_Click(object sender, EventArgs e)
        {
            var agendaRutinas = new UsuarioClienteAgendaRutinasAsignadas();
            agendaRutinas.Show();
            this.Close();
        }

        private void estadoPago_Click(object sender, EventArgs e)
        {
            var estadoPago = new UsuarioClienteEstadoPago();
            estadoPago.Show();
            this.Close();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();
        }
    }
}
