namespace OneByte
{
    partial class UsuarioClienteMain
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
            this.guardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDelDeportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoPertenecienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consEvolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.rendimientoDelDeportistaPuntajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consRutinas = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaDeRutinasAsignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripEjerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoPago = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(18, 735);
            this.atras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(140, 54);
            this.atras.TabIndex = 14;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(1086, 735);
            this.guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(140, 54);
            this.guardar.TabIndex = 15;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.menuStrip1.Size = new System.Drawing.Size(1244, 57);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consEstado
            // 
            this.consEstado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDelDeportistaToolStripMenuItem,
            this.grupoPertenecienteToolStripMenuItem,
            this.verMisDatosToolStripMenuItem});
            this.consEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consEstado.Name = "consEstado";
            this.consEstado.Size = new System.Drawing.Size(224, 53);
            this.consEstado.Text = "Consultar Estado";
            // 
            // estadoDelDeportistaToolStripMenuItem
            // 
            this.estadoDelDeportistaToolStripMenuItem.Name = "estadoDelDeportistaToolStripMenuItem";
            this.estadoDelDeportistaToolStripMenuItem.Size = new System.Drawing.Size(366, 40);
            this.estadoDelDeportistaToolStripMenuItem.Text = "Estado del Deportista";
            this.estadoDelDeportistaToolStripMenuItem.Click += new System.EventHandler(this.estadoDelDeportistaToolStripMenuItem_Click);
            // 
            // grupoPertenecienteToolStripMenuItem
            // 
            this.grupoPertenecienteToolStripMenuItem.Name = "grupoPertenecienteToolStripMenuItem";
            this.grupoPertenecienteToolStripMenuItem.Size = new System.Drawing.Size(366, 40);
            this.grupoPertenecienteToolStripMenuItem.Text = "Grupo Perteneciente ";
            // 
            // verMisDatosToolStripMenuItem
            // 
            this.verMisDatosToolStripMenuItem.Name = "verMisDatosToolStripMenuItem";
            this.verMisDatosToolStripMenuItem.Size = new System.Drawing.Size(366, 40);
            this.verMisDatosToolStripMenuItem.Text = "Ver mis Datos";
            // 
            // consEvolucion
            // 
            this.consEvolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consEvolucion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendimientoDelDeportistaPuntajeToolStripMenuItem});
            this.consEvolucion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consEvolucion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consEvolucion.Name = "consEvolucion";
            this.consEvolucion.Size = new System.Drawing.Size(260, 53);
            this.consEvolucion.Text = "Consultar Evolucion";
            // 
            // rendimientoDelDeportistaPuntajeToolStripMenuItem
            // 
            this.rendimientoDelDeportistaPuntajeToolStripMenuItem.Name = "rendimientoDelDeportistaPuntajeToolStripMenuItem";
            this.rendimientoDelDeportistaPuntajeToolStripMenuItem.Size = new System.Drawing.Size(549, 40);
            this.rendimientoDelDeportistaPuntajeToolStripMenuItem.Text = "Rendimiento del Deportista (Puntaje)";
            // 
            // consRutinas
            // 
            this.consRutinas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaDeRutinasAsignadasToolStripMenuItem,
            this.descripEjerciciosToolStripMenuItem});
            this.consRutinas.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consRutinas.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.consRutinas.Name = "consRutinas";
            this.consRutinas.Size = new System.Drawing.Size(233, 53);
            this.consRutinas.Text = "Consultar Rutinas";
            // 
            // agendaDeRutinasAsignadasToolStripMenuItem
            // 
            this.agendaDeRutinasAsignadasToolStripMenuItem.Name = "agendaDeRutinasAsignadasToolStripMenuItem";
            this.agendaDeRutinasAsignadasToolStripMenuItem.Size = new System.Drawing.Size(460, 40);
            this.agendaDeRutinasAsignadasToolStripMenuItem.Text = "Agenda de Rutinas Asignadas";
            // 
            // descripEjerciciosToolStripMenuItem
            // 
            this.descripEjerciciosToolStripMenuItem.Name = "descripEjerciciosToolStripMenuItem";
            this.descripEjerciciosToolStripMenuItem.Size = new System.Drawing.Size(460, 40);
            this.descripEjerciciosToolStripMenuItem.Text = "Descrip. Ejercicios";
            // 
            // estadoPago
            // 
            this.estadoPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoPago.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.estadoPago.Name = "estadoPago";
            this.estadoPago.Size = new System.Drawing.Size(208, 53);
            this.estadoPago.Text = "Estado de Pago";
            // 
            // cerrarsesion
            // 
            this.cerrarsesion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrarsesion.Name = "cerrarsesion";
            this.cerrarsesion.Size = new System.Drawing.Size(184, 53);
            this.cerrarsesion.Text = "Cerrar Sesion";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 53);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(16, 53);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(116, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 534);
            this.dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agenda de Disponibilidad";
            // 
            // UsuarioClienteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 808);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsuarioClienteMain";
            this.Text = "UsuarioClienteMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consEstado;
        private System.Windows.Forms.ToolStripMenuItem consEvolucion;
        private System.Windows.Forms.ToolStripMenuItem consRutinas;
        private System.Windows.Forms.ToolStripMenuItem estadoPago;
        private System.Windows.Forms.ToolStripMenuItem cerrarsesion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem estadoDelDeportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoPertenecienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendimientoDelDeportistaPuntajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaDeRutinasAsignadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripEjerciciosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}