namespace OneByte
{
    partial class UsuarioClienteGrupoPerteneciente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDepor = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoPerte = new System.Windows.Forms.ToolStripMenuItem();
            this.verDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.consEvolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.rendiDepor = new System.Windows.Forms.ToolStripMenuItem();
            this.consRutinas = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaRutinas = new System.Windows.Forms.ToolStripMenuItem();
            this.descripEjer = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoPago = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consEstado,
            this.consEvolucion,
            this.consRutinas,
            this.estadoPago,
            this.cerrarsesion,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 37);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consEstado
            // 
            this.consEstado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDepor,
            this.grupoPerte,
            this.verDatos});
            this.consEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consEstado.Name = "consEstado";
            this.consEstado.Size = new System.Drawing.Size(155, 33);
            this.consEstado.Text = "Consultar Estado";
            // 
            // estadoDepor
            // 
            this.estadoDepor.Name = "estadoDepor";
            this.estadoDepor.Size = new System.Drawing.Size(337, 26);
            this.estadoDepor.Text = "Estado del Deportista";
            this.estadoDepor.Click += new System.EventHandler(this.estadoDepor_Click);
            // 
            // grupoPerte
            // 
            this.grupoPerte.Name = "grupoPerte";
            this.grupoPerte.Size = new System.Drawing.Size(337, 26);
            this.grupoPerte.Text = "Grupo Perteneciente (estas aqui)";
            // 
            // verDatos
            // 
            this.verDatos.Name = "verDatos";
            this.verDatos.Size = new System.Drawing.Size(337, 26);
            this.verDatos.Text = "Ver mis Datos";
            this.verDatos.Click += new System.EventHandler(this.verDatos_Click);
            // 
            // consEvolucion
            // 
            this.consEvolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consEvolucion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendiDepor});
            this.consEvolucion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consEvolucion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consEvolucion.Name = "consEvolucion";
            this.consEvolucion.Size = new System.Drawing.Size(179, 33);
            this.consEvolucion.Text = "Consultar Evolucion";
            // 
            // rendiDepor
            // 
            this.rendiDepor.Name = "rendiDepor";
            this.rendiDepor.Size = new System.Drawing.Size(372, 26);
            this.rendiDepor.Text = "Rendimiento del Deportista (Puntaje)";
            this.rendiDepor.Click += new System.EventHandler(this.rendiDepor_Click);
            // 
            // consRutinas
            // 
            this.consRutinas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaRutinas,
            this.descripEjer});
            this.consRutinas.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consRutinas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consRutinas.Name = "consRutinas";
            this.consRutinas.Size = new System.Drawing.Size(162, 33);
            this.consRutinas.Text = "Consultar Rutinas";
            // 
            // agendaRutinas
            // 
            this.agendaRutinas.Name = "agendaRutinas";
            this.agendaRutinas.Size = new System.Drawing.Size(312, 26);
            this.agendaRutinas.Text = "Agenda de Rutinas Asignadas";
            this.agendaRutinas.Click += new System.EventHandler(this.agendaRutinas_Click);
            // 
            // descripEjer
            // 
            this.descripEjer.Name = "descripEjer";
            this.descripEjer.Size = new System.Drawing.Size(312, 26);
            this.descripEjer.Text = "Descrip. Ejercicios";
            this.descripEjer.Click += new System.EventHandler(this.descripEjer_Click);
            // 
            // estadoPago
            // 
            this.estadoPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoPago.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.estadoPago.Name = "estadoPago";
            this.estadoPago.Size = new System.Drawing.Size(142, 33);
            this.estadoPago.Text = "Estado de Pago";
            this.estadoPago.Click += new System.EventHandler(this.estadoPago_Click);
            // 
            // cerrarsesion
            // 
            this.cerrarsesion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrarsesion.Name = "cerrarsesion";
            this.cerrarsesion.Size = new System.Drawing.Size(129, 33);
            this.cerrarsesion.Text = "Cerrar Sesion";
            this.cerrarsesion.Click += new System.EventHandler(this.cerrarsesion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 33);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 33);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Grupo Perteneciente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 127);
            this.dataGridView1.TabIndex = 20;
            // 
            // UsuarioClienteGrupoPerteneciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 336);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UsuarioClienteGrupoPerteneciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioClienteGrupoPerteneciente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consEstado;
        private System.Windows.Forms.ToolStripMenuItem estadoDepor;
        private System.Windows.Forms.ToolStripMenuItem grupoPerte;
        private System.Windows.Forms.ToolStripMenuItem verDatos;
        private System.Windows.Forms.ToolStripMenuItem consEvolucion;
        private System.Windows.Forms.ToolStripMenuItem rendiDepor;
        private System.Windows.Forms.ToolStripMenuItem consRutinas;
        private System.Windows.Forms.ToolStripMenuItem agendaRutinas;
        private System.Windows.Forms.ToolStripMenuItem descripEjer;
        private System.Windows.Forms.ToolStripMenuItem estadoPago;
        private System.Windows.Forms.ToolStripMenuItem cerrarsesion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}