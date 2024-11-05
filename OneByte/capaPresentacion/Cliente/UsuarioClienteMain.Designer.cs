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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_buscarEjercicio = new System.Windows.Forms.Button();
            this.txtIDEjercicioBuscar = new System.Windows.Forms.TextBox();
            this.tablaEjercicio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaRutina = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutina)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(1129, 62);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.AutoSize = false;
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(122, 50);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 60);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 60);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(609, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 31);
            this.label6.TabIndex = 208;
            this.label6.Text = "Buscar Ejercicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 206;
            this.label4.Text = "ID";
            // 
            // button_buscarEjercicio
            // 
            this.button_buscarEjercicio.BackColor = System.Drawing.Color.LightGreen;
            this.button_buscarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_buscarEjercicio.Location = new System.Drawing.Point(738, 138);
            this.button_buscarEjercicio.Name = "button_buscarEjercicio";
            this.button_buscarEjercicio.Size = new System.Drawing.Size(65, 23);
            this.button_buscarEjercicio.TabIndex = 205;
            this.button_buscarEjercicio.Text = "Buscar";
            this.button_buscarEjercicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_buscarEjercicio.UseVisualStyleBackColor = false;
            this.button_buscarEjercicio.Click += new System.EventHandler(this.button_buscarEjercicio_Click);
            // 
            // txtIDEjercicioBuscar
            // 
            this.txtIDEjercicioBuscar.BackColor = System.Drawing.Color.SlateGray;
            this.txtIDEjercicioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEjercicioBuscar.Location = new System.Drawing.Point(638, 139);
            this.txtIDEjercicioBuscar.Name = "txtIDEjercicioBuscar";
            this.txtIDEjercicioBuscar.Size = new System.Drawing.Size(94, 22);
            this.txtIDEjercicioBuscar.TabIndex = 204;
            // 
            // tablaEjercicio
            // 
            this.tablaEjercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEjercicio.Location = new System.Drawing.Point(606, 167);
            this.tablaEjercicio.Name = "tablaEjercicio";
            this.tablaEjercicio.Size = new System.Drawing.Size(468, 309);
            this.tablaEjercicio.TabIndex = 203;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(73, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 216;
            this.label1.Text = "Rutina";
            // 
            // tablaRutina
            // 
            this.tablaRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRutina.Location = new System.Drawing.Point(79, 169);
            this.tablaRutina.Name = "tablaRutina";
            this.tablaRutina.Size = new System.Drawing.Size(494, 309);
            this.tablaRutina.TabIndex = 215;
            this.tablaRutina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRutina_CellContentClick);
            // 
            // UsuarioClienteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1129, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaRutina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_buscarEjercicio);
            this.Controls.Add(this.txtIDEjercicioBuscar);
            this.Controls.Add(this.tablaEjercicio);
            this.Controls.Add(this.menuStrip2);
            this.Name = "UsuarioClienteMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioClienteMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UsuarioClienteMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRutina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_buscarEjercicio;
        private System.Windows.Forms.TextBox txtIDEjercicioBuscar;
        private System.Windows.Forms.DataGridView tablaEjercicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaRutina;
    }
}