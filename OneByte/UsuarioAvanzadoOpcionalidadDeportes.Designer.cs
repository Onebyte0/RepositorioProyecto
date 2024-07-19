namespace OneByte
{
    partial class UsuarioAvanzadoOpcionalidadDeportes
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
            this.deportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarDeporte = new System.Windows.Forms.Button();
            this.eliminarDeporte = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPCIONALIDAD DE DEPORTES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deportes});
            this.dataGridView1.Location = new System.Drawing.Point(22, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(143, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // deportes
            // 
            this.deportes.HeaderText = "Deporte";
            this.deportes.Name = "deportes";
            // 
            // agregarDeporte
            // 
            this.agregarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarDeporte.Location = new System.Drawing.Point(260, 75);
            this.agregarDeporte.Name = "agregarDeporte";
            this.agregarDeporte.Size = new System.Drawing.Size(142, 49);
            this.agregarDeporte.TabIndex = 2;
            this.agregarDeporte.Text = "Agregar Deporte";
            this.agregarDeporte.UseVisualStyleBackColor = true;
            // 
            // eliminarDeporte
            // 
            this.eliminarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarDeporte.Location = new System.Drawing.Point(260, 152);
            this.eliminarDeporte.Name = "eliminarDeporte";
            this.eliminarDeporte.Size = new System.Drawing.Size(142, 48);
            this.eliminarDeporte.TabIndex = 3;
            this.eliminarDeporte.Text = "Eliminar Deporte";
            this.eliminarDeporte.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 4;
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(562, 397);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(117, 37);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(39, 404);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(93, 30);
            this.volver.TabIndex = 6;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // UsuarioAvanzadoOpcionalidadDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 457);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.eliminarDeporte);
            this.Controls.Add(this.agregarDeporte);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioAvanzadoOpcionalidadDeportes";
            this.Text = "UsuarioAvanzadoOpcionalidadDeportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deportes;
        private System.Windows.Forms.Button agregarDeporte;
        private System.Windows.Forms.Button eliminarDeporte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button volver;
    }
}