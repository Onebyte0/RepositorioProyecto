namespace OneByte
{
    partial class SeleccionUsuarios
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
            this.usuAdmin = new System.Windows.Forms.Button();
            this.usuAvanzado = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.usuSeleccionador = new System.Windows.Forms.Button();
            this.entrenador = new System.Windows.Forms.Button();
            this.deportista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuAdmin
            // 
            this.usuAdmin.Location = new System.Drawing.Point(154, 98);
            this.usuAdmin.Name = "usuAdmin";
            this.usuAdmin.Size = new System.Drawing.Size(143, 50);
            this.usuAdmin.TabIndex = 0;
            this.usuAdmin.Text = "Usuario Administrativo";
            this.usuAdmin.UseVisualStyleBackColor = true;
            this.usuAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuAvanzado
            // 
            this.usuAvanzado.Location = new System.Drawing.Point(480, 98);
            this.usuAvanzado.Name = "usuAvanzado";
            this.usuAvanzado.Size = new System.Drawing.Size(143, 50);
            this.usuAvanzado.TabIndex = 1;
            this.usuAvanzado.Text = "Usuario Avanzado";
            this.usuAvanzado.UseVisualStyleBackColor = true;
            this.usuAvanzado.Click += new System.EventHandler(this.button2_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(56, 358);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.button3_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(649, 358);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button4_Click);
            // 
            // usuSeleccionador
            // 
            this.usuSeleccionador.Location = new System.Drawing.Point(154, 204);
            this.usuSeleccionador.Name = "usuSeleccionador";
            this.usuSeleccionador.Size = new System.Drawing.Size(143, 50);
            this.usuSeleccionador.TabIndex = 4;
            this.usuSeleccionador.Text = "Usuario Seleccionador";
            this.usuSeleccionador.UseVisualStyleBackColor = true;
            this.usuSeleccionador.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // entrenador
            // 
            this.entrenador.Location = new System.Drawing.Point(480, 204);
            this.entrenador.Name = "entrenador";
            this.entrenador.Size = new System.Drawing.Size(143, 50);
            this.entrenador.TabIndex = 5;
            this.entrenador.Text = "Usuario Entrenador";
            this.entrenador.UseVisualStyleBackColor = true;
            this.entrenador.Click += new System.EventHandler(this.entrenador_Click);
            // 
            // deportista
            // 
            this.deportista.Location = new System.Drawing.Point(154, 291);
            this.deportista.Name = "deportista";
            this.deportista.Size = new System.Drawing.Size(143, 50);
            this.deportista.TabIndex = 6;
            this.deportista.Text = "Deportista";
            this.deportista.UseVisualStyleBackColor = true;
            this.deportista.Click += new System.EventHandler(this.deportista_Click);
            // 
            // SeleccionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deportista);
            this.Controls.Add(this.entrenador);
            this.Controls.Add(this.usuSeleccionador);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.usuAvanzado);
            this.Controls.Add(this.usuAdmin);
            this.Name = "SeleccionUsuarios";
            this.Text = "SeleccionUsuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usuAdmin;
        private System.Windows.Forms.Button usuAvanzado;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button usuSeleccionador;
        private System.Windows.Forms.Button entrenador;
        private System.Windows.Forms.Button deportista;
    }
}