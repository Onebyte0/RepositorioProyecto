namespace OneByte
{
    partial class UsuarioAvanzadoMain
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
            this.gestionDeClientes = new System.Windows.Forms.Button();
            this.gestionDeEmpleados = new System.Windows.Forms.Button();
            this.opcionalidadDeportes = new System.Windows.Forms.Button();
            this.ingresoYgestionDeEjercicios = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO AVANZADO";
            // 
            // gestionDeClientes
            // 
            this.gestionDeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeClientes.Location = new System.Drawing.Point(138, 105);
            this.gestionDeClientes.Name = "gestionDeClientes";
            this.gestionDeClientes.Size = new System.Drawing.Size(216, 59);
            this.gestionDeClientes.TabIndex = 1;
            this.gestionDeClientes.Text = "Gestion de clientes";
            this.gestionDeClientes.UseVisualStyleBackColor = true;
            this.gestionDeClientes.Click += new System.EventHandler(this.gestionDeClientes_Click);
            // 
            // gestionDeEmpleados
            // 
            this.gestionDeEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionDeEmpleados.Location = new System.Drawing.Point(446, 105);
            this.gestionDeEmpleados.Name = "gestionDeEmpleados";
            this.gestionDeEmpleados.Size = new System.Drawing.Size(216, 59);
            this.gestionDeEmpleados.TabIndex = 2;
            this.gestionDeEmpleados.Text = "Gestion de empleados";
            this.gestionDeEmpleados.UseVisualStyleBackColor = true;
            this.gestionDeEmpleados.Click += new System.EventHandler(this.gestionDeEmpleados_Click);
            // 
            // opcionalidadDeportes
            // 
            this.opcionalidadDeportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionalidadDeportes.Location = new System.Drawing.Point(138, 208);
            this.opcionalidadDeportes.Name = "opcionalidadDeportes";
            this.opcionalidadDeportes.Size = new System.Drawing.Size(216, 61);
            this.opcionalidadDeportes.TabIndex = 3;
            this.opcionalidadDeportes.Text = "Opcionalidad de deportes ";
            this.opcionalidadDeportes.UseVisualStyleBackColor = true;
            this.opcionalidadDeportes.Click += new System.EventHandler(this.opcionalidadDeportes_Click);
            // 
            // ingresoYgestionDeEjercicios
            // 
            this.ingresoYgestionDeEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoYgestionDeEjercicios.Location = new System.Drawing.Point(446, 208);
            this.ingresoYgestionDeEjercicios.Name = "ingresoYgestionDeEjercicios";
            this.ingresoYgestionDeEjercicios.Size = new System.Drawing.Size(216, 61);
            this.ingresoYgestionDeEjercicios.TabIndex = 4;
            this.ingresoYgestionDeEjercicios.Text = "Ingreso y gestion de ejercicios ";
            this.ingresoYgestionDeEjercicios.UseVisualStyleBackColor = true;
            this.ingresoYgestionDeEjercicios.Click += new System.EventHandler(this.ingresoYgestionDeEjercicios_Click);
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(34, 335);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(143, 35);
            this.volver.TabIndex = 10;
            this.volver.Text = "Cerrar sesiòn";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // UsuarioAvanzadoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 401);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.ingresoYgestionDeEjercicios);
            this.Controls.Add(this.opcionalidadDeportes);
            this.Controls.Add(this.gestionDeEmpleados);
            this.Controls.Add(this.gestionDeClientes);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioAvanzadoMain";
            this.Text = "UsuarioAvanzadoMain";
            this.Load += new System.EventHandler(this.UsuarioAvanzadoMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gestionDeClientes;
        private System.Windows.Forms.Button gestionDeEmpleados;
        private System.Windows.Forms.Button opcionalidadDeportes;
        private System.Windows.Forms.Button ingresoYgestionDeEjercicios;
        private System.Windows.Forms.Button volver;
    }
}