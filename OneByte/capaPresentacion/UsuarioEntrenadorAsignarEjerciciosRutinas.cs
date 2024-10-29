using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneByte
{
    public partial class UsuarioEntrenadorAsignarEjerciciosRutinas : Form
    {
       
        public UsuarioEntrenadorAsignarEjerciciosRutinas()
        {
            InitializeComponent();
           


        }
      



        private void rutinasDepor_Click(object sender, EventArgs e)
        {
            var rutinasDepor = new UsuarioEntrenadorRutinasDeportistasSanos();
            rutinasDepor.Show();
            this.Close();
        }

        private void rutinasDeporLesio_Click(object sender, EventArgs e)
        {
            var rutinasDeporLesio = new UsuarioEntrenadorRutinasDeportistasLesionados();
            rutinasDeporLesio.Show();
            this.Close();
        }

        private void asignarEjerLesio_Click(object sender, EventArgs e)
        {
           
        }

        private void descripEjer_Click(object sender, EventArgs e)
        {
            var descripEjer = new UsuarioEntrenadorDescripcionEjercicios();
            descripEjer.Show();
            this.Close();
        }

        private void grupoMusc_Click(object sender, EventArgs e)
        {
            
        }

        private void estadoDepor_Click(object sender, EventArgs e)
        {
            var estadoDepor = new UsuarioEntrenadorEstadoDeportistaSano();
            estadoDepor.Show();
            this.Close();
        }

        private void estadoDeporLesio_Click(object sender, EventArgs e)
        {
            var estadoDeporLesio = new UsuarioEntrenadorEstadoDeportistaLesionado();
            estadoDeporLesio.Show();
            this.Close();
        }

        private void agenda_Click(object sender, EventArgs e)
        {
            var agenda =  new UsuarioEntrenadorAgendaDisponibilidad();
            agenda.Show();
            this.Close();
        }

        private void agendaRutinas_Click(object sender, EventArgs e)
        {
            var agendaRutinas = new UsuarioEntrenadorAgendaRutinasAsignadas();
            agendaRutinas.Show();
            this.Close();
        }

        private void agruparDepor_Click(object sender, EventArgs e)
        {
            var agruparDepor = new UsuarioEntrenadorAgruparDeportistas();
            agruparDepor.Show();
            this.Close();
        }

        private void infoDepor_Click(object sender, EventArgs e)
        {
            var infoDepor = new UsuarioEntrenadorInfoDeportista();
            infoDepor.Show();
            this.Close();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();
        }

        private void UsuarioEntrenadorAsignarEjerciciosRutinas_Load(object sender, EventArgs e)
        {

        }
    }
}
