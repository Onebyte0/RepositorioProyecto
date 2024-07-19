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
    public partial class UsuarioClienteMain : Form
    {
        public UsuarioClienteMain()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panel1.Controls.Add(p);
            p.BackColor = Color.FromArgb(120, 100, 2);
            p.Size = new Size(188, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            panel1.Controls.Remove(p);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!pestado.Visible)
                pestado.Visible = true;
            else
                pestado.Visible = false;
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

        private void consultarutina_Click(object sender, EventArgs e)
        {
            if (!prutinas1.Visible)
                prutinas1.Visible = true;
            else
                prutinas1.Visible = false;
        }

        private void estadodepor_Click(object sender, EventArgs e)
        {
            var estadodepor = new UsuarioClienteEstadoDeportista();
            estadodepor.Show();
            this.Hide();
        }

        private void grupo_Click(object sender, EventArgs e)
        {
            var grupo = new UsuarioClienteGrupoPerteneciente();
            grupo.Show();
            this.Hide();
        }

        private void verdatos_Click(object sender, EventArgs e)
        {
            var verdatos = new UsuarioClienteDatosDeportista();
            verdatos.Show();
            this.Hide();
        }

        private void rendimiento_Click(object sender, EventArgs e)
        {
            var rendimiento = new UsuarioClienteRendimientoDeportista();
            rendimiento.Show();
            this.Hide();

        }

        private void agendarutinas_Click(object sender, EventArgs e)
        {
            var agendarutinas = new UsuarioClienteAgendaRutinasAsignadas();
            agendarutinas.Show();
            this.Hide();
        }

        private void descripejerc_Click(object sender, EventArgs e)
        {
            var descripejer = new UsuarioClienteDescripcionEjercicios();
            descripejer.Show();
            this.Hide();
        }

        private void estadopago_Click(object sender, EventArgs e)
        {
            var estadopago = new UsuarioClienteEstadoPago();
            estadopago.Show();
            this.Hide();
        }
    }
}
