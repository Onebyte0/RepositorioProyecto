namespace OneByte
{
    partial class UsuarioAvanzadoGestionDeEmpleados
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
            this.nomEntrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoEntrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.calleEmpleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departEmpleado = new System.Windows.Forms.TextBox();
            this.numCalleEmpleado = new System.Windows.Forms.TextBox();
            this.fechaNacEmpleado = new System.Windows.Forms.TextBox();
            this.apellidoEntrenador = new System.Windows.Forms.TextBox();
            this.nombreEntrenador = new System.Windows.Forms.TextBox();
            this.docEmpleado = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE EMPLEADOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEntrenador,
            this.documentoEntrenador});
            this.dataGridView1.Location = new System.Drawing.Point(23, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // nomEntrenador
            // 
            this.nomEntrenador.HeaderText = "Nombre ";
            this.nomEntrenador.Name = "nomEntrenador";
            // 
            // documentoEntrenador
            // 
            this.documentoEntrenador.HeaderText = "Documento";
            this.documentoEntrenador.Name = "documentoEntrenador";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Empleado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(332, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Editar Empleado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(332, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar Empleado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(801, 483);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(130, 47);
            this.guardar.TabIndex = 44;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(781, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Calle";
            // 
            // calleEmpleado
            // 
            this.calleEmpleado.Location = new System.Drawing.Point(831, 250);
            this.calleEmpleado.Name = "calleEmpleado";
            this.calleEmpleado.Size = new System.Drawing.Size(100, 20);
            this.calleEmpleado.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(715, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fecha De Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Numero De Calle";
            // 
            // departEmpleado
            // 
            this.departEmpleado.Location = new System.Drawing.Point(831, 194);
            this.departEmpleado.Name = "departEmpleado";
            this.departEmpleado.Size = new System.Drawing.Size(100, 20);
            this.departEmpleado.TabIndex = 32;
            // 
            // numCalleEmpleado
            // 
            this.numCalleEmpleado.Location = new System.Drawing.Point(831, 124);
            this.numCalleEmpleado.Name = "numCalleEmpleado";
            this.numCalleEmpleado.Size = new System.Drawing.Size(100, 20);
            this.numCalleEmpleado.TabIndex = 31;
            // 
            // fechaNacEmpleado
            // 
            this.fechaNacEmpleado.Location = new System.Drawing.Point(831, 335);
            this.fechaNacEmpleado.Name = "fechaNacEmpleado";
            this.fechaNacEmpleado.Size = new System.Drawing.Size(100, 20);
            this.fechaNacEmpleado.TabIndex = 28;
            // 
            // apellidoEntrenador
            // 
            this.apellidoEntrenador.Location = new System.Drawing.Point(580, 265);
            this.apellidoEntrenador.Name = "apellidoEntrenador";
            this.apellidoEntrenador.Size = new System.Drawing.Size(100, 20);
            this.apellidoEntrenador.TabIndex = 27;
            // 
            // nombreEntrenador
            // 
            this.nombreEntrenador.Location = new System.Drawing.Point(580, 201);
            this.nombreEntrenador.Name = "nombreEntrenador";
            this.nombreEntrenador.Size = new System.Drawing.Size(100, 20);
            this.nombreEntrenador.TabIndex = 26;
            // 
            // docEmpleado
            // 
            this.docEmpleado.Location = new System.Drawing.Point(580, 121);
            this.docEmpleado.Name = "docEmpleado";
            this.docEmpleado.Size = new System.Drawing.Size(100, 20);
            this.docEmpleado.TabIndex = 25;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(831, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Pasaporte";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(621, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Cedula";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(34, 483);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(84, 47);
            this.volver.TabIndex = 45;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // UsuarioAvanzadoGestionDeEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 551);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.calleEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departEmpleado);
            this.Controls.Add(this.numCalleEmpleado);
            this.Controls.Add(this.fechaNacEmpleado);
            this.Controls.Add(this.apellidoEntrenador);
            this.Controls.Add(this.nombreEntrenador);
            this.Controls.Add(this.docEmpleado);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioAvanzadoGestionDeEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAvanzadoGestionDeEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEntrenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoEntrenador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox calleEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox departEmpleado;
        private System.Windows.Forms.TextBox numCalleEmpleado;
        private System.Windows.Forms.TextBox fechaNacEmpleado;
        private System.Windows.Forms.TextBox apellidoEntrenador;
        private System.Windows.Forms.TextBox nombreEntrenador;
        private System.Windows.Forms.TextBox docEmpleado;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button volver;
    }
}