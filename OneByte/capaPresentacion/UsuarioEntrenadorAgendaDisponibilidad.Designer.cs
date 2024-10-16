﻿namespace OneByte
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
            this.toolStripMenuItem2,
            this.consEvolucion,
            this.consRutinas,
            this.estadoPago,
            this.cerrarsesion,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(884, 60);
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
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(82, 56);
            this.toolStripMenuItem2.Text = "Rutinas";
            // 
            // rutinasSanos
            // 
            this.rutinasSanos.Name = "rutinasSanos";
            this.rutinasSanos.Size = new System.Drawing.Size(433, 26);
            this.rutinasSanos.Text = "Rutinas a deportistas sanos";
            this.rutinasSanos.Click += new System.EventHandler(this.rutinasSanos_Click);
            // 
            // rutinasLesio
            // 
            this.rutinasLesio.Name = "rutinasLesio";
            this.rutinasLesio.Size = new System.Drawing.Size(433, 26);
            this.rutinasLesio.Text = "Rutinas a deportistas lesionados";
            this.rutinasLesio.Click += new System.EventHandler(this.rutinasLesio_Click);
            // 
            // asignarEjerSanos
            // 
            this.asignarEjerSanos.Name = "asignarEjerSanos";
            this.asignarEjerSanos.Size = new System.Drawing.Size(433, 26);
            this.asignarEjerSanos.Text = "Asignar ejercicios a rutinas depor. sanos";
            this.asignarEjerSanos.Click += new System.EventHandler(this.asignarEjerSanos_Click);
            // 
            // asignarEjerLesio
            // 
            this.asignarEjerLesio.Name = "asignarEjerLesio";
            this.asignarEjerLesio.Size = new System.Drawing.Size(433, 26);
            this.asignarEjerLesio.Text = "Asignar ejercicios a rutinas depor. lesionados";
            this.asignarEjerLesio.Click += new System.EventHandler(this.asignarEjerLesio_Click);
            // 
            // descripEjer
            // 
            this.descripEjer.Name = "descripEjer";
            this.descripEjer.Size = new System.Drawing.Size(433, 26);
            this.descripEjer.Text = "Descripcion de ejercicios";
            this.descripEjer.Click += new System.EventHandler(this.descripEjer_Click);
            // 
            // gruposMusc
            // 
            this.gruposMusc.Name = "gruposMusc";
            this.gruposMusc.Size = new System.Drawing.Size(433, 26);
            this.gruposMusc.Text = "Grupos Musculares";
            this.gruposMusc.Click += new System.EventHandler(this.gruposMusc_Click);
            // 
            // consEvolucion
            // 
            this.consEvolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consEvolucion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDepor,
            this.estadoDeporLesio});
            this.consEvolucion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consEvolucion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consEvolucion.Name = "consEvolucion";
            this.consEvolucion.Size = new System.Drawing.Size(96, 56);
            this.consEvolucion.Text = "Evolucion";
            // 
            // estadoDepor
            // 
            this.estadoDepor.Name = "estadoDepor";
            this.estadoDepor.Size = new System.Drawing.Size(326, 26);
            this.estadoDepor.Text = "Estado del deportista sano";
            this.estadoDepor.Click += new System.EventHandler(this.estadoDepor_Click);
            // 
            // estadoDeporLesio
            // 
            this.estadoDeporLesio.Name = "estadoDeporLesio";
            this.estadoDeporLesio.Size = new System.Drawing.Size(326, 26);
            this.estadoDeporLesio.Text = "Estado del deportista lesionado";
            this.estadoDeporLesio.Click += new System.EventHandler(this.estadoDeporLesio_Click);
            // 
            // consRutinas
            // 
            this.consRutinas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agenda,
            this.agendaRutinas});
            this.consRutinas.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consRutinas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consRutinas.Name = "consRutinas";
            this.consRutinas.Size = new System.Drawing.Size(81, 56);
            this.consRutinas.Text = "Agenda";
            // 
            // agenda
            // 
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(237, 26);
            this.agenda.Text = "Agenda (estas aqui)";
            // 
            // agendaRutinas
            // 
            this.agendaRutinas.Name = "agendaRutinas";
            this.agendaRutinas.Size = new System.Drawing.Size(237, 26);
            this.agendaRutinas.Text = "Agenda de rutinas";
            this.agendaRutinas.Click += new System.EventHandler(this.agendaRutinas_Click);
            // 
            // estadoPago
            // 
            this.estadoPago.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agruparDepor,
            this.infoDepor});
            this.estadoPago.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoPago.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.estadoPago.Name = "estadoPago";
            this.estadoPago.Size = new System.Drawing.Size(102, 56);
            this.estadoPago.Text = "Deportista";
            // 
            // agruparDepor
            // 
            this.agruparDepor.Name = "agruparDepor";
            this.agruparDepor.Size = new System.Drawing.Size(228, 26);
            this.agruparDepor.Text = "Agrupar deportista";
            this.agruparDepor.Click += new System.EventHandler(this.agruparDepor_Click);
            // 
            // infoDepor
            // 
            this.infoDepor.Name = "infoDepor";
            this.infoDepor.Size = new System.Drawing.Size(228, 26);
            this.infoDepor.Text = "Info. del deportista";
            this.infoDepor.Click += new System.EventHandler(this.infoDepor_Click);
            // 
            // cerrarsesion
            // 
            this.cerrarsesion.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrarsesion.Name = "cerrarsesion";
            this.cerrarsesion.Size = new System.Drawing.Size(125, 56);
            this.cerrarsesion.Text = "Cerrar Sesion";
            this.cerrarsesion.Click += new System.EventHandler(this.cerrarsesion_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 56);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Agenda de disponibilidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(515, 237);
            this.dataGridView1.TabIndex = 20;
            // 
            // UsuarioEntrenadorAgendaDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UsuarioEntrenadorAgendaDisponibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioEntrenadorAgendaDisponibilidad";
            this.Load += new System.EventHandler(this.UsuarioEntrenadorAgendaDisponibilidad_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}