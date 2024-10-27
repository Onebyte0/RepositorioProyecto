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
            this.nombreEjercicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripEjercicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlAsist = new System.Windows.Forms.ToolStripMenuItem();
            this.dardeBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.gestPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCliente = new System.Windows.Forms.Button();
            this.editarCliente = new System.Windows.Forms.Button();
            this.agregarCliente = new System.Windows.Forms.Button();
            this.ejercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(386, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Ejercicios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ejercicio,
            this.descEjercicio});
            this.dataGridView1.Location = new System.Drawing.Point(233, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 282);
            this.dataGridView1.TabIndex = 1;
            // 
            // nombreEjercicio
            // 
            this.nombreEjercicio.Location = new System.Drawing.Point(553, 139);
            this.nombreEjercicio.Name = "nombreEjercicio";
            this.nombreEjercicio.Size = new System.Drawing.Size(179, 20);
            this.nombreEjercicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del ejercicio";
            // 
            // descripEjercicio
            // 
            this.descripEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripEjercicio.Location = new System.Drawing.Point(553, 197);
            this.descripEjercicio.Name = "descripEjercicio";
            this.descripEjercicio.Size = new System.Drawing.Size(235, 116);
            this.descripEjercicio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción del ejercicio";
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LightGreen;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(781, 414);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(91, 35);
            this.guardar.TabIndex = 9;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
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
            this.gestPagos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(219, 461);
            this.menuStrip1.TabIndex = 21;
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
            // gestPagos
            // 
            this.gestPagos.AutoSize = false;
            this.gestPagos.BackColor = System.Drawing.Color.LightSlateGray;
            this.gestPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestPagos.Margin = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.gestPagos.Name = "gestPagos";
            this.gestPagos.Size = new System.Drawing.Size(195, 50);
            this.gestPagos.Text = "Gestión de deportes";
            // 
            // eliminarCliente
            // 
            this.eliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCliente.Location = new System.Drawing.Point(240, 414);
            this.eliminarCliente.Name = "eliminarCliente";
            this.eliminarCliente.Size = new System.Drawing.Size(70, 33);
            this.eliminarCliente.TabIndex = 137;
            this.eliminarCliente.Text = "Eliminar ";
            this.eliminarCliente.UseVisualStyleBackColor = true;
            // 
            // editarCliente
            // 
            this.editarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarCliente.Location = new System.Drawing.Point(316, 414);
            this.editarCliente.Name = "editarCliente";
            this.editarCliente.Size = new System.Drawing.Size(70, 33);
            this.editarCliente.TabIndex = 136;
            this.editarCliente.Text = "Editar ";
            this.editarCliente.UseVisualStyleBackColor = true;
            // 
            // agregarCliente
            // 
            this.agregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCliente.Location = new System.Drawing.Point(392, 414);
            this.agregarCliente.Name = "agregarCliente";
            this.agregarCliente.Size = new System.Drawing.Size(70, 33);
            this.agregarCliente.TabIndex = 135;
            this.agregarCliente.Text = "Agregar ";
            this.agregarCliente.UseVisualStyleBackColor = true;
            // 
            // ejercicio
            // 
            this.ejercicio.HeaderText = "Ejercicio";
            this.ejercicio.Name = "ejercicio";
            // 
            // descEjercicio
            // 
            this.descEjercicio.HeaderText = "Descripción";
            this.descEjercicio.Name = "descEjercicio";
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
            this.menuStrip2.TabIndex = 138;
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
            // UsuarioAvanzadoIngresoEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.eliminarCliente);
            this.Controls.Add(this.editarCliente);
            this.Controls.Add(this.agregarCliente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descripEjercicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreEjercicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioAvanzadoIngresoEjercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAvanzadoIngresoEjercicios";
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
        private System.Windows.Forms.TextBox nombreEjercicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripEjercicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlAsist;
        private System.Windows.Forms.ToolStripMenuItem dardeBaja;
        private System.Windows.Forms.ToolStripMenuItem gestPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descEjercicio;
        private System.Windows.Forms.Button eliminarCliente;
        private System.Windows.Forms.Button editarCliente;
        private System.Windows.Forms.Button agregarCliente;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}