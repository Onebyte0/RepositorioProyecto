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
            this.ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarEjercicio = new System.Windows.Forms.Button();
            this.editarEjercicio = new System.Windows.Forms.Button();
            this.eliminarEjercicio = new System.Windows.Forms.Button();
            this.nombreEjercicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripEjercicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionEjer = new System.Windows.Forms.ToolStripMenuItem();
            this.opcDeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiondeEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCli = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarsesion = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO Y GESTION DE EJERCICIOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ejercicio,
            this.descEjercicio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // ejercicio
            // 
            this.ejercicio.HeaderText = "Ejercicio";
            this.ejercicio.Name = "ejercicio";
            this.ejercicio.Width = 200;
            // 
            // descEjercicio
            // 
            this.descEjercicio.HeaderText = "Descripcion";
            this.descEjercicio.Name = "descEjercicio";
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
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Del Ejercicio";
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
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion Del Ejercicio";
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(803, 419);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(91, 35);
            this.guardar.TabIndex = 9;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEjer,
            this.opcDeportes,
            this.gestiondeEmpleados,
            this.gestionCli,
            this.cerrarsesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 37);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionEjer
            // 
            this.gestionEjer.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionEjer.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gestionEjer.Name = "gestionEjer";
            this.gestionEjer.Size = new System.Drawing.Size(247, 33);
            this.gestionEjer.Text = "Gestion de ejercicios (estas aqui)";
            // 
            // opcDeportes
            // 
            this.opcDeportes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcDeportes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.opcDeportes.Name = "opcDeportes";
            this.opcDeportes.Size = new System.Drawing.Size(200, 33);
            this.opcDeportes.Text = "Opcionalidad de deportes";
            this.opcDeportes.Click += new System.EventHandler(this.opcDeportes_Click);
            // 
            // gestiondeEmpleados
            // 
            this.gestiondeEmpleados.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestiondeEmpleados.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gestiondeEmpleados.Name = "gestiondeEmpleados";
            this.gestiondeEmpleados.Size = new System.Drawing.Size(176, 33);
            this.gestiondeEmpleados.Text = "Gestion de empleados";
            this.gestiondeEmpleados.Click += new System.EventHandler(this.gestiondeEmpleados_Click);
            // 
            // gestionCli
            // 
            this.gestionCli.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionCli.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gestionCli.Name = "gestionCli";
            this.gestionCli.Size = new System.Drawing.Size(152, 33);
            this.gestionCli.Text = "Gestion de clientes";
            this.gestionCli.Click += new System.EventHandler(this.gestionCli_Click);
            // 
            // cerrarsesion
            // 
            this.cerrarsesion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrarsesion.Name = "cerrarsesion";
            this.cerrarsesion.Size = new System.Drawing.Size(116, 33);
            this.cerrarsesion.Text = "Cerrar Sesion";
            this.cerrarsesion.Click += new System.EventHandler(this.cerrarsesion_Click);
            // 
            // UsuarioAvanzadoIngresoEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 466);
            this.Controls.Add(this.menuStrip1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionEjer;
        private System.Windows.Forms.ToolStripMenuItem opcDeportes;
        private System.Windows.Forms.ToolStripMenuItem gestiondeEmpleados;
        private System.Windows.Forms.ToolStripMenuItem gestionCli;
        private System.Windows.Forms.ToolStripMenuItem cerrarsesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descEjercicio;
    }
}