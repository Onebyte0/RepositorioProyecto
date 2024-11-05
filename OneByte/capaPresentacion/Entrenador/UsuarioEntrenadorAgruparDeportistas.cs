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
using OneByte.capaPresentacion;

namespace OneByte
{
    public partial class UsuarioEntrenadorAgruparDeportistas : Form
    {
        public UsuarioEntrenadorAgruparDeportistas()
        {
            InitializeComponent();
       
        }
        


    
        private void gruposMusc_Click(object sender, EventArgs e)
        {
         
        }

      

        private void UsuarioEntrenadorAgruparDeportistas_Load(object sender, EventArgs e)
        {

        }

        private void controlAsist_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorAgendaRutinasAsignadas usuEntrenadorRutinas = new UsuarioEntrenadorAgendaRutinasAsignadas();
            usuEntrenadorRutinas.Show();
            this.Close();
        }

        private void dardeBaja_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorAgendaDisponibilidad usuEntrenadorAgenda = new UsuarioEntrenadorAgendaDisponibilidad();
            usuEntrenadorAgenda.Show();
            this.Close();
        }

        private void habilitarUsu_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorEstadoDeportistaSano usuEntrenadorDeportista = new UsuarioEntrenadorEstadoDeportistaSano();
            usuEntrenadorDeportista.Show();
            this.Close();
        }

        private void gestPagos_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorEstadoDeportistaLesionado usuEntrenadorDeportistaLesionado = new UsuarioEntrenadorEstadoDeportistaLesionado();
            usuEntrenadorDeportistaLesionado.Show();
            this.Close();
        }

        private void datosDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioEntrenadorInfoDeportista usuEntrenadorInfoDeportista = new UsuarioEntrenadorInfoDeportista();
            usuEntrenadorInfoDeportista.Show();
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
