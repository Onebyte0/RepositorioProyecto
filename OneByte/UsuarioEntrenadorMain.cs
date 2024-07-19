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
    public partial class UsuarioEntrenadorMain : Form
    {
        public UsuarioEntrenadorMain()
        {
            InitializeComponent();
        }
        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(120, 100, 2);
            p.Size = new Size(120, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40); 
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
        panel1.Controls.Remove(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!prutinas.Visible)
                prutinas.Visible = true;
            else
                prutinas.Visible = false;
        }

        private void atras_Click(object sender, EventArgs e)
        {
            var atras = new SeleccionUsuarios();
            atras.Show();
            this.Hide();
        }

        private void evolucion_Click(object sender, EventArgs e)
        {
            if (!pevolucion.Visible)
                pevolucion.Visible = true;
            else
                pevolucion.Visible = false;
        }

        private void agenda_Click(object sender, EventArgs e)
        {
            if (!pagenda.Visible)
                pagenda.Visible = true;
            else
                pagenda.Visible = false;
        }

        private void deportista_Click(object sender, EventArgs e)
        {
            if (!pdeportista.Visible)
                pdeportista.Visible = true;
            else
                pdeportista.Visible = false;
        }

        private void deporsanos_Click(object sender, EventArgs e)
        {
            var deporsanos = new UsuarioEntrenadorRutinasDeportistasSanos();
            deporsanos.Show();
            this.Hide();
        }

        private void deporlesionado_Click(object sender, EventArgs e)
        {
            var deporlesionado = new UsuarioEntrenadorRutinasDeportistasLesionados();
            deporlesionado.Show();
            this.Hide();

        }

        private void ejerarutinas_Click(object sender, EventArgs e)
        {
            var ejerarutinas = new UsuarioEntrenadorAsignarEjerciciosRutinas();
            ejerarutinas.Show();
            this.Hide();

        }

        private void descripejer_Click(object sender, EventArgs e)
        {
            var descripejer = new UsuarioEntrenadorDescripcionEjercicios();
            descripejer.Show();
            this.Hide();

        }

        private void grupomuscular_Click(object sender, EventArgs e)
        {
            var grupomuscular = new UsuarioEntrenadorGruposMusculares();
            grupomuscular.Show();
            this.Hide();
        }

        private void estadodeportista_Click(object sender, EventArgs e)
        {
            var estadodeportista = new UsuarioEntrenadorEstadoDeportistaSano();
            estadodeportista.Show();
            this.Hide();
        }

        private void estadolesionado_Click(object sender, EventArgs e)
        {
            var estadolesionado = new UsuarioEntrenadorEstadoDeportistaLesionado();
            estadolesionado.Show();
            this.Hide();
        }

        private void agendadispo_Click(object sender, EventArgs e)
        {
            var agendadispo = new UsuarioEntrenadorAgendaDisponibilidad();
            agendadispo.Show();
            this.Hide();
        }

        private void agendarutina_Click(object sender, EventArgs e)
        {
            var agendarutina = new UsuarioEntrenadorAgendaRutinasAsignadas();
            agendarutina.Show();
            this.Hide();
        }

        private void agrupardepor_Click(object sender, EventArgs e)
        {
            var agrupardepor = new UsuarioEntrenadorAgruparDeportistas();
            agrupardepor.Show();
            this.Hide();
        }

        private void infodepor_Click(object sender, EventArgs e)
        {
            var infodepor = new UsuarioEntrenadorInfoDeportista();
            infodepor.Show();
            this.Hide();
        }

        private void UsuarioEntrenadorMain_Load(object sender, EventArgs e)
        {

        }
    }
}
