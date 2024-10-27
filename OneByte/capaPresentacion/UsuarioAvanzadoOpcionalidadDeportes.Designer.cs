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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlAsist = new System.Windows.Forms.ToolStripMenuItem();
            this.dardeBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opcionalidad de Deportes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deportes});
            this.dataGridView1.Location = new System.Drawing.Point(228, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 279);
            this.dataGridView1.TabIndex = 1;
            // 
            // deportes
            // 
            this.deportes.HeaderText = "Deporte";
            this.deportes.Name = "deportes";
            this.deportes.Width = 410;
            // 
            // agregarDeporte
            // 
            this.agregarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarDeporte.Location = new System.Drawing.Point(434, 417);
            this.agregarDeporte.Name = "agregarDeporte";
            this.agregarDeporte.Size = new System.Drawing.Size(94, 32);
            this.agregarDeporte.TabIndex = 2;
            this.agregarDeporte.Text = "Agregar ";
            this.agregarDeporte.UseVisualStyleBackColor = true;
            // 
            // eliminarDeporte
            // 
            this.eliminarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarDeporte.Location = new System.Drawing.Point(334, 417);
            this.eliminarDeporte.Name = "eliminarDeporte";
            this.eliminarDeporte.Size = new System.Drawing.Size(94, 32);
            this.eliminarDeporte.TabIndex = 3;
            this.eliminarDeporte.Text = "Eliminar ";
            this.eliminarDeporte.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(686, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 4;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LightGreen;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(788, 417);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(84, 32);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Ingrese un deporte:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlAsist,
            this.dardeBaja,
            this.habilitarUsu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(219, 461);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlAsist
            // 
            this.controlAsist.AutoSize = false;
            this.controlAsist.BackColor = System.Drawing.Color.LightSlateGray;
            this.controlAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlAsist.Margin = new System.Windows.Forms.Padding(0, 60, 0, 60);
            this.controlAsist.Name = "controlAsist";
            this.controlAsist.Size = new System.Drawing.Size(195, 50);
            this.controlAsist.Text = "Gestión de empleados";
            // 
            // dardeBaja
            // 
            this.dardeBaja.AutoSize = false;
            this.dardeBaja.BackColor = System.Drawing.Color.LightSlateGray;
            this.dardeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dardeBaja.Margin = new System.Windows.Forms.Padding(0, -40, 0, -40);
            this.dardeBaja.Name = "dardeBaja";
            this.dardeBaja.Size = new System.Drawing.Size(195, 50);
            this.dardeBaja.Text = "Gestión de clientes";
            // 
            // habilitarUsu
            // 
            this.habilitarUsu.AutoSize = false;
            this.habilitarUsu.BackColor = System.Drawing.Color.LightSlateGray;
            this.habilitarUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilitarUsu.Margin = new System.Windows.Forms.Padding(0, 60, 0, 10);
            this.habilitarUsu.Name = "habilitarUsu";
            this.habilitarUsu.Size = new System.Drawing.Size(195, 50);
            this.habilitarUsu.Text = "Gestión de ejercicios";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(219, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(665, 62);
            this.menuStrip2.TabIndex = 139;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.AutoSize = false;
            this.cerrarSesionToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(530, 0, 0, 0);
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(120, 50);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 60);
            // 
            // UsuarioAvanzadoOpcionalidadDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.eliminarDeporte);
            this.Controls.Add(this.agregarDeporte);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UsuarioAvanzadoOpcionalidadDeportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAvanzadoOpcionalidadDeportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregarDeporte;
        private System.Windows.Forms.Button eliminarDeporte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn deportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlAsist;
        private System.Windows.Forms.ToolStripMenuItem dardeBaja;
        private System.Windows.Forms.ToolStripMenuItem habilitarUsu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}