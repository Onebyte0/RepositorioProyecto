using System;
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
    public partial class UsuarioEntrenadorInfoDeportista : Form
    {
        public UsuarioEntrenadorInfoDeportista()
        {
            InitializeComponent();
           
        }
       
        private void rutinasSanos_Click(object sender, EventArgs e)
        {
            var rutinasSanos = new UsuarioEntrenadorRutinasDeportistasSanos();
            rutinasSanos.Show();
            this.Close();
        }

        private void rutinasLesio_Click(object sender, EventArgs e)
        {
            var rutinasLesio = new UsuarioEntrenadorRutinasDeportistasLesionados();
            rutinasLesio.Show();
            this.Close();
        }

        private void asignarEjerSanos_Click(object sender, EventArgs e)
        {
            var asignarEjerSanos = new UsuarioEntrenadorAsignarEjerciciosRutinas();
            asignarEjerSanos.Show();
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

        private void gruposMusc_Click(object sender, EventArgs e)
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
            var agenda = new UsuarioEntrenadorAgendaDisponibilidad();
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

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            var cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Close();
        }

        private void UsuarioEntrenadorInfoDeportista_Load(object sender, EventArgs e)
        {

        }
    }
}
