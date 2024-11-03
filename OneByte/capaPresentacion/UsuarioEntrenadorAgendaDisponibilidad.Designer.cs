namespace OneByte
{
    partial class UsuarioEntrenadorAgendaDisponibilidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlAsist = new System.Windows.Forms.ToolStripMenuItem();
            this.dardeBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.gestPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Agenda ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(607, 293);
            this.dataGridView1.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlAsist,
            this.dardeBaja,
            this.habilitarUsu,
            this.gestPagos,
            this.datosDelClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(219, 461);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlAsist
            // 
            this.controlAsist.AutoSize = false;
            this.controlAsist.BackColor = System.Drawing.Color.LightSlateGray;
            this.controlAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.controlAsist.Margin = new System.Windows.Forms.Padding(0, 60, 0, 60);
            this.controlAsist.Name = "controlAsist";
            this.controlAsist.Size = new System.Drawing.Size(195, 50);
            this.controlAsist.Text = "Rutinas";
            this.controlAsist.Click += new System.EventHandler(this.controlAsist_Click);
            // 
            // dardeBaja
            // 
            this.dardeBaja.AutoSize = false;
            this.dardeBaja.BackColor = System.Drawing.Color.LightSlateGray;
            this.dardeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dardeBaja.Margin = new System.Windows.Forms.Padding(0, -40, 0, -40);
            this.dardeBaja.Name = "dardeBaja";
            this.dardeBaja.Size = new System.Drawing.Size(195, 50);
            this.dardeBaja.Text = "Agenda";
            this.dardeBaja.Click += new System.EventHandler(this.dardeBaja_Click);
            // 
            // habilitarUsu
            // 
            this.habilitarUsu.AutoSize = false;
            this.habilitarUsu.BackColor = System.Drawing.Color.LightSlateGray;
            this.habilitarUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.habilitarUsu.Margin = new System.Windows.Forms.Padding(0, 60, 0, 10);
            this.habilitarUsu.Name = "habilitarUsu";
            this.habilitarUsu.Size = new System.Drawing.Size(195, 50);
            this.habilitarUsu.Text = "Deportista";
            this.habilitarUsu.Click += new System.EventHandler(this.habilitarUsu_Click);
            // 
            // gestPagos
            // 
            this.gestPagos.AutoSize = false;
            this.gestPagos.BackColor = System.Drawing.Color.LightSlateGray;
            this.gestPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gestPagos.Margin = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.gestPagos.Name = "gestPagos";
            this.gestPagos.Size = new System.Drawing.Size(195, 50);
            this.gestPagos.Text = "Evolucion";
            this.gestPagos.Click += new System.EventHandler(this.gestPagos_Click);
            // 
            // datosDelClienteToolStripMenuItem
            // 
            this.datosDelClienteToolStripMenuItem.AutoSize = false;
            this.datosDelClienteToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.datosDelClienteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.datosDelClienteToolStripMenuItem.Name = "datosDelClienteToolStripMenuItem";
            this.datosDelClienteToolStripMenuItem.Size = new System.Drawing.Size(195, 50);
            this.datosDelClienteToolStripMenuItem.Text = "Datos del cliente";
            this.datosDelClienteToolStripMenuItem.Click += new System.EventHandler(this.datosDelClienteToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(219, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(666, 62);
            this.menuStrip2.TabIndex = 25;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.AutoSize = false;
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cerrarSesionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(530, 0, 0, 0);
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(120, 50);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 60);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 60);
            // 
            // UsuarioEntrenadorAgendaDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioEntrenadorAgendaDisponibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioEntrenadorAgendaDisponibilidad";
            this.Load += new System.EventHandler(this.UsuarioEntrenadorAgendaDisponibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlAsist;
        private System.Windows.Forms.ToolStripMenuItem dardeBaja;
        private System.Windows.Forms.ToolStripMenuItem habilitarUsu;
        private System.Windows.Forms.ToolStripMenuItem gestPagos;
        private System.Windows.Forms.ToolStripMenuItem datosDelClienteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}