﻿namespace OneByte
{
    partial class UsuarioEntrenadorMain
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
            this.atras = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinasDepor = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinasDeporLesio = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEjer = new System.Windows.Forms.ToolStripMenuItem();
            this.descripEjer = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoMusc = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(13, 487);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(93, 35);
            this.atras.TabIndex = 2;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // modificar
            // 
            this.modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(535, 487);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(138, 35);
            this.modificar.TabIndex = 3;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(687, 487);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(131, 35);
            this.guardar.TabIndex = 4;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calificacion de items a cumplir por el deportista o lesionado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 37);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consEstado
            // 
            this.consEstado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutinasDepor,
            this.rutinasDeporLesio,
            this.asignarEjer,
            this.descripEjer,
            this.grupoMusc});
            this.consEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consEstado.Name = "consEstado";
            this.consEstado.Size = new System.Drawing.Size(81, 33);
            this.consEstado.Text = "Rutinas";
            // 
            // rutinasDepor
            // 
            this.rutinasDepor.Name = "rutinasDepor";
            this.rutinasDepor.Size = new System.Drawing.Size(335, 26);
            this.rutinasDepor.Text = "Rutinas a deportistas";
            this.rutinasDepor.Click += new System.EventHandler(this.rutinasDepor_Click);
            // 
            // rutinasDeporLesio
            // 
            this.rutinasDeporLesio.Name = "rutinasDeporLesio";
            this.rutinasDeporLesio.Size = new System.Drawing.Size(335, 26);
            this.rutinasDeporLesio.Text = "Rutinas a deportistas lesionados";
            this.rutinasDeporLesio.Click += new System.EventHandler(this.rutinasDeporLesio_Click);
            // 
            // asignarEjer
            // 
            this.asignarEjer.Name = "asignarEjer";
            this.asignarEjer.Size = new System.Drawing.Size(335, 26);
            this.asignarEjer.Text = "Asignar ejercicios a rutinas";
            this.asignarEjer.Click += new System.EventHandler(this.asignarEjer_Click);
            // 
            // descripEjer
            // 
            this.descripEjer.Name = "descripEjer";
            this.descripEjer.Size = new System.Drawing.Size(335, 26);
            this.descripEjer.Text = "Descrip. Ejercicios";
            this.descripEjer.Click += new System.EventHandler(this.descripEjer_Click);
            // 
            // grupoMusc
            // 
            this.grupoMusc.Name = "grupoMusc";
            this.grupoMusc.Size = new System.Drawing.Size(335, 26);
            this.grupoMusc.Text = "Grupos Musculares";
            this.grupoMusc.Click += new System.EventHandler(this.grupoMusc_Click);
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
            this.estadoDepor.Text = "Estado del deportista";
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 33);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 33);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 347);
            this.dataGridView1.TabIndex = 18;
            // 
            // UsuarioEntrenadorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.atras);
            this.Name = "UsuarioEntrenadorMain";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consEstado;
        private System.Windows.Forms.ToolStripMenuItem rutinasDepor;
        private System.Windows.Forms.ToolStripMenuItem rutinasDeporLesio;
        private System.Windows.Forms.ToolStripMenuItem asignarEjer;
        private System.Windows.Forms.ToolStripMenuItem consEvolucion;
        private System.Windows.Forms.ToolStripMenuItem estadoDepor;
        private System.Windows.Forms.ToolStripMenuItem consRutinas;
        private System.Windows.Forms.ToolStripMenuItem agenda;
        private System.Windows.Forms.ToolStripMenuItem agendaRutinas;
        private System.Windows.Forms.ToolStripMenuItem estadoPago;
        private System.Windows.Forms.ToolStripMenuItem cerrarsesion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem descripEjer;
        private System.Windows.Forms.ToolStripMenuItem grupoMusc;
        private System.Windows.Forms.ToolStripMenuItem estadoDeporLesio;
        private System.Windows.Forms.ToolStripMenuItem agruparDepor;
        private System.Windows.Forms.ToolStripMenuItem infoDepor;
    }
}