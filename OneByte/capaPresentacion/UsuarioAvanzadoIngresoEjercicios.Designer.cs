namespace OneByte
{
    partial class UsuarioAvanzadoIngresoEjercicios
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
            this.agregarEjercicio = new System.Windows.Forms.Button();
            this.editarEjercicio = new System.Windows.Forms.Button();
            this.eliminarEjercicio = new System.Windows.Forms.Button();
            this.nombreEjercicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripEjercicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEjerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Ejercicios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ejercicio,
            this.descEjercicio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // agregarEjercicio
            // 
            this.agregarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarEjercicio.Location = new System.Drawing.Point(378, 163);
            this.agregarEjercicio.Name = "agregarEjercicio";
            this.agregarEjercicio.Size = new System.Drawing.Size(115, 41);
            this.agregarEjercicio.TabIndex = 2;
            this.agregarEjercicio.Text = "Agregar Ejercicio";
            this.agregarEjercicio.UseVisualStyleBackColor = true;
            // 
            // editarEjercicio
            // 
            this.editarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarEjercicio.Location = new System.Drawing.Point(378, 233);
            this.editarEjercicio.Name = "editarEjercicio";
            this.editarEjercicio.Size = new System.Drawing.Size(115, 41);
            this.editarEjercicio.TabIndex = 3;
            this.editarEjercicio.Text = "Editar Ejercicio";
            this.editarEjercicio.UseVisualStyleBackColor = true;
            // 
            // eliminarEjercicio
            // 
            this.eliminarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarEjercicio.Location = new System.Drawing.Point(378, 308);
            this.eliminarEjercicio.Name = "eliminarEjercicio";
            this.eliminarEjercicio.Size = new System.Drawing.Size(115, 41);
            this.eliminarEjercicio.TabIndex = 4;
            this.eliminarEjercicio.Text = "Eliminar Ejercicio";
            this.eliminarEjercicio.UseVisualStyleBackColor = true;
            // 
            // nombreEjercicio
            // 
            this.nombreEjercicio.Location = new System.Drawing.Point(530, 175);
            this.nombreEjercicio.Name = "nombreEjercicio";
            this.nombreEjercicio.Size = new System.Drawing.Size(179, 20);
            this.nombreEjercicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del ejercicio";
            // 
            // descripEjercicio
            // 
            this.descripEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripEjercicio.Location = new System.Drawing.Point(530, 233);
            this.descripEjercicio.Name = "descripEjercicio";
            this.descripEjercicio.Size = new System.Drawing.Size(332, 116);
            this.descripEjercicio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción del ejercicio";
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LightGreen;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(771, 399);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(91, 35);
            this.guardar.TabIndex = 9;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.cToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(884, 60);
            this.menuStrip2.Stretch = false;
            this.menuStrip2.TabIndex = 97;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeEmpleadosToolStripMenuItem,
            this.gestiónDeEjerciciosToolStripMenuItem,
            this.gestiónDeClienteToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 56);
            this.toolStripMenuItem1.Text = "Gestiones";
            // 
            // gestiónDeEmpleadosToolStripMenuItem
            // 
            this.gestiónDeEmpleadosToolStripMenuItem.Name = "gestiónDeEmpleadosToolStripMenuItem";
            this.gestiónDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.gestiónDeEmpleadosToolStripMenuItem.Text = "Gestión de empleados";
            this.gestiónDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeEmpleadosToolStripMenuItem_Click);
            // 
            // gestiónDeEjerciciosToolStripMenuItem
            // 
            this.gestiónDeEjerciciosToolStripMenuItem.Name = "gestiónDeEjerciciosToolStripMenuItem";
            this.gestiónDeEjerciciosToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.gestiónDeEjerciciosToolStripMenuItem.Text = "Gestión de ejercicios (estás aquí)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 56);
            this.toolStripMenuItem2.Text = "Opcionalidad de deportes";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 56);
            this.toolStripMenuItem3.Text = "Cerrar Sesión";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(12, 56);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(12, 56);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(25, 56);
            this.cToolStripMenuItem.Text = "c";
            // 
            // gestiónDeClienteToolStripMenuItem
            // 
            this.gestiónDeClienteToolStripMenuItem.Name = "gestiónDeClienteToolStripMenuItem";
            this.gestiónDeClienteToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.gestiónDeClienteToolStripMenuItem.Text = "Gestión de cliente";
            this.gestiónDeClienteToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeClienteToolStripMenuItem_Click);
            // 
            // ejercicio
            // 
            this.ejercicio.HeaderText = "Ejercicio";
            this.ejercicio.Name = "ejercicio";
            this.ejercicio.Width = 200;
            // 
            // descEjercicio
            // 
            this.descEjercicio.HeaderText = "Descripción";
            this.descEjercicio.Name = "descEjercicio";
            // 
            // UsuarioAvanzadoIngresoEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descripEjercicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreEjercicio);
            this.Controls.Add(this.eliminarEjercicio);
            this.Controls.Add(this.editarEjercicio);
            this.Controls.Add(this.agregarEjercicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioAvanzadoIngresoEjercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAvanzadoIngresoEjercicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregarEjercicio;
        private System.Windows.Forms.Button editarEjercicio;
        private System.Windows.Forms.Button eliminarEjercicio;
        private System.Windows.Forms.TextBox nombreEjercicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripEjercicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeEjerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeClienteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descEjercicio;
    }
}