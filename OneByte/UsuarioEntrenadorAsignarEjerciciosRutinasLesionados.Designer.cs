namespace OneByte
{
    partial class UsuarioEntrenadorAsignarEjerciciosRutinasLesionados
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinasSanos = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinasLesio = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEjerSanos = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEjerLesio = new System.Windows.Forms.ToolStripMenuItem();
            this.descripEjer = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposMusc = new System.Windows.Forms.ToolStripMenuItem();
            this.consEvolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDepor = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeporLesio = new System.Windows.Forms.ToolStripMenuItem();
            this.consRutinas = new System.Windows.Forms.ToolStripMenuItem();
            this.agenda = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaRutinas = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoPago = new System.Windows.Forms.ToolStripMenuItem();
            this.agruparDepor = new System.Windows.Forms.ToolStripMenuItem();
            this.infoDepor = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.toolStripMenuItem2,
            this.consEvolucion,
            this.consRutinas,
            this.estadoPago,
            this.cerrarsesion,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 37);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutinasSanos,
            this.rutinasLesio,
            this.asignarEjerSanos,
            this.asignarEjerLesio,
            this.descripEjer,
            this.gruposMusc});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 33);
            this.toolStripMenuItem2.Text = "Rutinas";
            // 
            // rutinasSanos
            // 
            this.rutinasSanos.Name = "rutinasSanos";
            this.rutinasSanos.Size = new System.Drawing.Size(533, 26);
            this.rutinasSanos.Text = "Rutinas a deportistas sanos";
            this.rutinasSanos.Click += new System.EventHandler(this.rutinasSanos_Click);
            // 
            // rutinasLesio
            // 
            this.rutinasLesio.Name = "rutinasLesio";
            this.rutinasLesio.Size = new System.Drawing.Size(533, 26);
            this.rutinasLesio.Text = "Rutinas a deportistas lesionados";
            this.rutinasLesio.Click += new System.EventHandler(this.rutinasLesio_Click);
            // 
            // asignarEjerSanos
            // 
            this.asignarEjerSanos.Name = "asignarEjerSanos";
            this.asignarEjerSanos.Size = new System.Drawing.Size(533, 26);
            this.asignarEjerSanos.Text = "Asignar ejercicios a rutinas depor. sanos";
            this.asignarEjerSanos.Click += new System.EventHandler(this.asignarEjerSanos_Click);
            // 
            // asignarEjerLesio
            // 
            this.asignarEjerLesio.Name = "asignarEjerLesio";
            this.asignarEjerLesio.Size = new System.Drawing.Size(533, 26);
            this.asignarEjerLesio.Text = "Asignar ejercicios a rutinas depor. lesionados (estas aqui)";
            // 
            // descripEjer
            // 
            this.descripEjer.Name = "descripEjer";
            this.descripEjer.Size = new System.Drawing.Size(533, 26);
            this.descripEjer.Text = "Descripcion de ejercicios";
            this.descripEjer.Click += new System.EventHandler(this.descripEjer_Click);
            // 
            // gruposMusc
            // 
            this.gruposMusc.Name = "gruposMusc";
            this.gruposMusc.Size = new System.Drawing.Size(533, 26);
            this.gruposMusc.Text = "Grupos Musculares";
            this.gruposMusc.Click += new System.EventHandler(this.gruposMusc_Click);
            // 
            // consEvolucion
            // 
            this.consEvolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consEvolucion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDepor,
            this.estadoDeporLesio});
            this.consEvolucion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consEvolucion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consEvolucion.Name = "consEvolucion";
            this.consEvolucion.Size = new System.Drawing.Size(98, 33);
            this.consEvolucion.Text = "Evolucion";
            // 
            // estadoDepor
            // 
            this.estadoDepor.Name = "estadoDepor";
            this.estadoDepor.Size = new System.Drawing.Size(327, 26);
            this.estadoDepor.Text = "Estado del deportista sano";
            this.estadoDepor.Click += new System.EventHandler(this.estadoDepor_Click);
            // 
            // estadoDeporLesio
            // 
            this.estadoDeporLesio.Name = "estadoDeporLesio";
            this.estadoDeporLesio.Size = new System.Drawing.Size(327, 26);
            this.estadoDeporLesio.Text = "Estado del deportista lesionado";
            this.estadoDeporLesio.Click += new System.EventHandler(this.estadoDeporLesio_Click);
            // 
            // consRutinas
            // 
            this.consRutinas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agenda,
            this.agendaRutinas});
            this.consRutinas.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consRutinas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consRutinas.Name = "consRutinas";
            this.consRutinas.Size = new System.Drawing.Size(81, 33);
            this.consRutinas.Text = "Agenda";
            // 
            // agenda
            // 
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(223, 26);
            this.agenda.Text = "Agenda";
            this.agenda.Click += new System.EventHandler(this.agenda_Click);
            // 
            // agendaRutinas
            // 
            this.agendaRutinas.Name = "agendaRutinas";
            this.agendaRutinas.Size = new System.Drawing.Size(223, 26);
            this.agendaRutinas.Text = "Agenda de rutinas";
            this.agendaRutinas.Click += new System.EventHandler(this.agendaRutinas_Click);
            // 
            // estadoPago
            // 
            this.estadoPago.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agruparDepor,
            this.infoDepor});
            this.estadoPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoPago.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.estadoPago.Name = "estadoPago";
            this.estadoPago.Size = new System.Drawing.Size(104, 33);
            this.estadoPago.Text = "Deportista";
            // 
            // agruparDepor
            // 
            this.agruparDepor.Name = "agruparDepor";
            this.agruparDepor.Size = new System.Drawing.Size(229, 26);
            this.agruparDepor.Text = "Agrupar deportista";
            this.agruparDepor.Click += new System.EventHandler(this.agruparDepor_Click);
            // 
            // infoDepor
            // 
            this.infoDepor.Name = "infoDepor";
            this.infoDepor.Size = new System.Drawing.Size(229, 26);
            this.infoDepor.Text = "Info. del deportista";
            this.infoDepor.Click += new System.EventHandler(this.infoDepor_Click);
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 33);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 337);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Asignar ejercicios a rutinas para deportistas lesionados";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(765, 450);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 31);
            this.button6.TabIndex = 23;
            this.button6.Text = "Guardar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(665, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 31);
            this.button5.TabIndex = 22;
            this.button5.Text = "Modificar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(565, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 21;
            this.button4.Text = "Dar de baja";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // UsuarioEntrenadorAsignarEjerciciosRutinasLesionados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UsuarioEntrenadorAsignarEjerciciosRutinasLesionados";
            this.Text = "UsuarioEntrenadorAsignarEjerciciosRutinasLesionados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rutinasSanos;
        private System.Windows.Forms.ToolStripMenuItem rutinasLesio;
        private System.Windows.Forms.ToolStripMenuItem asignarEjerSanos;
        private System.Windows.Forms.ToolStripMenuItem asignarEjerLesio;
        private System.Windows.Forms.ToolStripMenuItem descripEjer;
        private System.Windows.Forms.ToolStripMenuItem gruposMusc;
        private System.Windows.Forms.ToolStripMenuItem consEvolucion;
        private System.Windows.Forms.ToolStripMenuItem estadoDepor;
        private System.Windows.Forms.ToolStripMenuItem estadoDeporLesio;
        private System.Windows.Forms.ToolStripMenuItem consRutinas;
        private System.Windows.Forms.ToolStripMenuItem agenda;
        private System.Windows.Forms.ToolStripMenuItem agendaRutinas;
        private System.Windows.Forms.ToolStripMenuItem estadoPago;
        private System.Windows.Forms.ToolStripMenuItem agruparDepor;
        private System.Windows.Forms.ToolStripMenuItem infoDepor;
        private System.Windows.Forms.ToolStripMenuItem cerrarsesion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}