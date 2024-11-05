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
            this.tablaDeporte = new System.Windows.Forms.DataGridView();
            this.txtIDDeporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEjercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.txtIDDeporteBuscar = new System.Windows.Forms.TextBox();
            this.button_buscarDeporte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_eliminarDeporte = new System.Windows.Forms.Button();
            this.button_guardarDeporte = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeporte)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Deportes";
            // 
            // tablaDeporte
            // 
            this.tablaDeporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeporte.Location = new System.Drawing.Point(260, 184);
            this.tablaDeporte.Name = "tablaDeporte";
            this.tablaDeporte.Size = new System.Drawing.Size(454, 225);
            this.tablaDeporte.TabIndex = 1;
            // 
            // txtIDDeporte
            // 
            this.txtIDDeporte.BackColor = System.Drawing.Color.SlateGray;
            this.txtIDDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDeporte.Location = new System.Drawing.Point(755, 239);
            this.txtIDDeporte.Name = "txtIDDeporte";
            this.txtIDDeporte.Size = new System.Drawing.Size(173, 22);
            this.txtIDDeporte.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(757, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "ID del deporte";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.gestionarEjercicios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(219, 512);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Salmon;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 60, 0, 10);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 50);
            this.toolStripMenuItem2.Text = "Cerrar Sesion";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // gestionarEjercicios
            // 
            this.gestionarEjercicios.AutoSize = false;
            this.gestionarEjercicios.BackColor = System.Drawing.Color.LightSlateGray;
            this.gestionarEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionarEjercicios.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.gestionarEjercicios.Name = "gestionarEjercicios";
            this.gestionarEjercicios.Size = new System.Drawing.Size(195, 50);
            this.gestionarEjercicios.Text = "Gestión de ejercicios";
            this.gestionarEjercicios.Click += new System.EventHandler(this.habilitarUsu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 141;
            this.label3.Text = "Nombre:";
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.BackColor = System.Drawing.Color.SlateGray;
            this.txtNombreDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeporte.Location = new System.Drawing.Point(755, 284);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(173, 22);
            this.txtNombreDeporte.TabIndex = 140;
            // 
            // txtIDDeporteBuscar
            // 
            this.txtIDDeporteBuscar.BackColor = System.Drawing.Color.SlateGray;
            this.txtIDDeporteBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDeporteBuscar.Location = new System.Drawing.Point(283, 157);
            this.txtIDDeporteBuscar.Name = "txtIDDeporteBuscar";
            this.txtIDDeporteBuscar.Size = new System.Drawing.Size(94, 22);
            this.txtIDDeporteBuscar.TabIndex = 142;
            // 
            // button_buscarDeporte
            // 
            this.button_buscarDeporte.BackColor = System.Drawing.Color.LightGreen;
            this.button_buscarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_buscarDeporte.Location = new System.Drawing.Point(383, 156);
            this.button_buscarDeporte.Name = "button_buscarDeporte";
            this.button_buscarDeporte.Size = new System.Drawing.Size(65, 23);
            this.button_buscarDeporte.TabIndex = 175;
            this.button_buscarDeporte.Text = "Buscar";
            this.button_buscarDeporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_buscarDeporte.UseVisualStyleBackColor = false;
            this.button_buscarDeporte.Click += new System.EventHandler(this.button_buscarDeporte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 176;
            this.label4.Text = "ID";
            // 
            // button_eliminarDeporte
            // 
            this.button_eliminarDeporte.BackColor = System.Drawing.Color.Silver;
            this.button_eliminarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_eliminarDeporte.Location = new System.Drawing.Point(260, 415);
            this.button_eliminarDeporte.Name = "button_eliminarDeporte";
            this.button_eliminarDeporte.Size = new System.Drawing.Size(65, 23);
            this.button_eliminarDeporte.TabIndex = 177;
            this.button_eliminarDeporte.Text = "Eliminar";
            this.button_eliminarDeporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_eliminarDeporte.UseVisualStyleBackColor = false;
            this.button_eliminarDeporte.Click += new System.EventHandler(this.button_eliminarDeporte_Click);
            // 
            // button_guardarDeporte
            // 
            this.button_guardarDeporte.BackColor = System.Drawing.Color.LightGreen;
            this.button_guardarDeporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guardarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_guardarDeporte.Location = new System.Drawing.Point(863, 312);
            this.button_guardarDeporte.Name = "button_guardarDeporte";
            this.button_guardarDeporte.Size = new System.Drawing.Size(65, 23);
            this.button_guardarDeporte.TabIndex = 178;
            this.button_guardarDeporte.Text = "Guardar";
            this.button_guardarDeporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_guardarDeporte.UseVisualStyleBackColor = false;
            this.button_guardarDeporte.Click += new System.EventHandler(this.button_guardarDeporte_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(755, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 20);
            this.label18.TabIndex = 179;
            this.label18.Text = "Crear Deporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(254, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 31);
            this.label6.TabIndex = 186;
            this.label6.Text = "Buscar Deporte";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 60);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(219, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(755, 62);
            this.menuStrip2.TabIndex = 139;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // UsuarioAvanzadoOpcionalidadDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(974, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button_guardarDeporte);
            this.Controls.Add(this.button_eliminarDeporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_buscarDeporte);
            this.Controls.Add(this.txtIDDeporteBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDDeporte);
            this.Controls.Add(this.tablaDeporte);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UsuarioAvanzadoOpcionalidadDeportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAvanzadoOpcionalidadDeportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeporte)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaDeporte;
        private System.Windows.Forms.TextBox txtIDDeporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionarEjercicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.TextBox txtIDDeporteBuscar;
        private System.Windows.Forms.Button button_buscarDeporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_eliminarDeporte;
        private System.Windows.Forms.Button button_guardarDeporte;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}