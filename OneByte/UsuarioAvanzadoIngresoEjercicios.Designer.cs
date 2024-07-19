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
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO Y GESTION DE EJERCICIOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ejercicio,
            this.descEjercicio});
            this.dataGridView1.Location = new System.Drawing.Point(22, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 358);
            this.dataGridView1.TabIndex = 1;
            // 
            // ejercicio
            // 
            this.ejercicio.HeaderText = "Ejercicio";
            this.ejercicio.Name = "ejercicio";
            // 
            // descEjercicio
            // 
            this.descEjercicio.HeaderText = "Descripcion";
            this.descEjercicio.Name = "descEjercicio";
            // 
            // agregarEjercicio
            // 
            this.agregarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarEjercicio.Location = new System.Drawing.Point(366, 76);
            this.agregarEjercicio.Name = "agregarEjercicio";
            this.agregarEjercicio.Size = new System.Drawing.Size(139, 43);
            this.agregarEjercicio.TabIndex = 2;
            this.agregarEjercicio.Text = "Agregar Ejercicio";
            this.agregarEjercicio.UseVisualStyleBackColor = true;
            // 
            // editarEjercicio
            // 
            this.editarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarEjercicio.Location = new System.Drawing.Point(366, 157);
            this.editarEjercicio.Name = "editarEjercicio";
            this.editarEjercicio.Size = new System.Drawing.Size(139, 41);
            this.editarEjercicio.TabIndex = 3;
            this.editarEjercicio.Text = "Editar Ejercicio";
            this.editarEjercicio.UseVisualStyleBackColor = true;
            // 
            // eliminarEjercicio
            // 
            this.eliminarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarEjercicio.Location = new System.Drawing.Point(366, 227);
            this.eliminarEjercicio.Name = "eliminarEjercicio";
            this.eliminarEjercicio.Size = new System.Drawing.Size(139, 37);
            this.eliminarEjercicio.TabIndex = 4;
            this.eliminarEjercicio.Text = "Eliminar Ejercicio";
            this.eliminarEjercicio.UseVisualStyleBackColor = true;
            // 
            // nombreEjercicio
            // 
            this.nombreEjercicio.Location = new System.Drawing.Point(582, 99);
            this.nombreEjercicio.Name = "nombreEjercicio";
            this.nombreEjercicio.Size = new System.Drawing.Size(179, 20);
            this.nombreEjercicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Del Ejercicio";
            // 
            // descripEjercicio
            // 
            this.descripEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripEjercicio.Location = new System.Drawing.Point(582, 157);
            this.descripEjercicio.Name = "descripEjercicio";
            this.descripEjercicio.Size = new System.Drawing.Size(179, 116);
            this.descripEjercicio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion Del Ejercicio";
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(651, 419);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(91, 35);
            this.guardar.TabIndex = 9;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(22, 419);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(91, 35);
            this.volver.TabIndex = 10;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsuarioAvanzadoIngresoEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 466);
            this.Controls.Add(this.volver);
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
            this.Text = "UsuarioAvanzadoIngresoEjercicios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descEjercicio;
        private System.Windows.Forms.Button agregarEjercicio;
        private System.Windows.Forms.Button editarEjercicio;
        private System.Windows.Forms.Button eliminarEjercicio;
        private System.Windows.Forms.TextBox nombreEjercicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripEjercicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button volver;
    }
}