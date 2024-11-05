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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_eliminarEjercicio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_buscarEjercicio = new System.Windows.Forms.Button();
            this.txtIDEjercicioBuscar = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripVentanaPrincial = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaEjercicio = new System.Windows.Forms.DataGridView();
            this.ListBox_GrupoMuscular = new System.Windows.Forms.CheckedListBox();
            this.textBox_descripcionEjercicio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button_guardarEjercicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEjercicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDEjercicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(254, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 31);
            this.label6.TabIndex = 202;
            this.label6.Text = "Buscar Ejercicio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 33);
            this.label1.TabIndex = 188;
            this.label1.Text = "Gestionar Ejercicios";
            // 
            // button_eliminarEjercicio
            // 
            this.button_eliminarEjercicio.BackColor = System.Drawing.Color.Silver;
            this.button_eliminarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_eliminarEjercicio.Location = new System.Drawing.Point(260, 442);
            this.button_eliminarEjercicio.Name = "button_eliminarEjercicio";
            this.button_eliminarEjercicio.Size = new System.Drawing.Size(65, 23);
            this.button_eliminarEjercicio.TabIndex = 199;
            this.button_eliminarEjercicio.Text = "Eliminar";
            this.button_eliminarEjercicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_eliminarEjercicio.UseVisualStyleBackColor = false;
            this.button_eliminarEjercicio.Click += new System.EventHandler(this.button_eliminarEjercicio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 198;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button_buscarEjercicio
            // 
            this.button_buscarEjercicio.BackColor = System.Drawing.Color.LightGreen;
            this.button_buscarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buscarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_buscarEjercicio.Location = new System.Drawing.Point(383, 156);
            this.button_buscarEjercicio.Name = "button_buscarEjercicio";
            this.button_buscarEjercicio.Size = new System.Drawing.Size(65, 23);
            this.button_buscarEjercicio.TabIndex = 197;
            this.button_buscarEjercicio.Text = "Buscar";
            this.button_buscarEjercicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_buscarEjercicio.UseVisualStyleBackColor = false;
            this.button_buscarEjercicio.Click += new System.EventHandler(this.button_buscarEjercicio_Click);
            // 
            // txtIDEjercicioBuscar
            // 
            this.txtIDEjercicioBuscar.BackColor = System.Drawing.Color.SlateGray;
            this.txtIDEjercicioBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEjercicioBuscar.Location = new System.Drawing.Point(283, 157);
            this.txtIDEjercicioBuscar.Name = "txtIDEjercicioBuscar";
            this.txtIDEjercicioBuscar.Size = new System.Drawing.Size(94, 22);
            this.txtIDEjercicioBuscar.TabIndex = 196;
            this.txtIDEjercicioBuscar.TextChanged += new System.EventHandler(this.txtIDEjercicioBuscar_TextChanged);
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
            this.menuStrip2.Size = new System.Drawing.Size(845, 62);
            this.menuStrip2.TabIndex = 193;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 60);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripVentanaPrincial,
            this.habilitarUsu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(219, 504);
            this.menuStrip1.TabIndex = 192;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripVentanaPrincial
            // 
            this.toolStripVentanaPrincial.AutoSize = false;
            this.toolStripVentanaPrincial.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripVentanaPrincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripVentanaPrincial.Margin = new System.Windows.Forms.Padding(0, 60, 0, 10);
            this.toolStripVentanaPrincial.Name = "toolStripVentanaPrincial";
            this.toolStripVentanaPrincial.Size = new System.Drawing.Size(195, 50);
            this.toolStripVentanaPrincial.Text = "Ventana Principal";
            this.toolStripVentanaPrincial.Click += new System.EventHandler(this.toolStripVentanaPrincial_Click);
            // 
            // habilitarUsu
            // 
            this.habilitarUsu.AutoSize = false;
            this.habilitarUsu.BackColor = System.Drawing.Color.LightSlateGray;
            this.habilitarUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilitarUsu.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.habilitarUsu.Name = "habilitarUsu";
            this.habilitarUsu.Size = new System.Drawing.Size(195, 50);
            this.habilitarUsu.Text = "Gestión de ejercicios";
            // 
            // tablaEjercicio
            // 
            this.tablaEjercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEjercicio.Location = new System.Drawing.Point(260, 184);
            this.tablaEjercicio.Name = "tablaEjercicio";
            this.tablaEjercicio.Size = new System.Drawing.Size(454, 252);
            this.tablaEjercicio.TabIndex = 189;
            this.tablaEjercicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEjercicio_CellContentClick);
            // 
            // ListBox_GrupoMuscular
            // 
            this.ListBox_GrupoMuscular.BackColor = System.Drawing.Color.SlateGray;
            this.ListBox_GrupoMuscular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_GrupoMuscular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_GrupoMuscular.ForeColor = System.Drawing.Color.Black;
            this.ListBox_GrupoMuscular.FormattingEnabled = true;
            this.ListBox_GrupoMuscular.Items.AddRange(new object[] {
            "Hombro",
            "Brazo",
            "Pierna",
            "Espalda",
            "Pectorales"});
            this.ListBox_GrupoMuscular.Location = new System.Drawing.Point(929, 273);
            this.ListBox_GrupoMuscular.Name = "ListBox_GrupoMuscular";
            this.ListBox_GrupoMuscular.Size = new System.Drawing.Size(98, 102);
            this.ListBox_GrupoMuscular.TabIndex = 212;
            // 
            // textBox_descripcionEjercicio
            // 
            this.textBox_descripcionEjercicio.BackColor = System.Drawing.Color.SlateGray;
            this.textBox_descripcionEjercicio.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descripcionEjercicio.ForeColor = System.Drawing.Color.Black;
            this.textBox_descripcionEjercicio.Location = new System.Drawing.Point(734, 273);
            this.textBox_descripcionEjercicio.Multiline = true;
            this.textBox_descripcionEjercicio.Name = "textBox_descripcionEjercicio";
            this.textBox_descripcionEjercicio.Size = new System.Drawing.Size(189, 163);
            this.textBox_descripcionEjercicio.TabIndex = 211;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(735, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 20);
            this.label18.TabIndex = 210;
            this.label18.Text = "Crear Ejercicio";
            // 
            // button_guardarEjercicio
            // 
            this.button_guardarEjercicio.BackColor = System.Drawing.Color.LightGreen;
            this.button_guardarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guardarEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_guardarEjercicio.Location = new System.Drawing.Point(962, 413);
            this.button_guardarEjercicio.Name = "button_guardarEjercicio";
            this.button_guardarEjercicio.Size = new System.Drawing.Size(65, 23);
            this.button_guardarEjercicio.TabIndex = 209;
            this.button_guardarEjercicio.Text = "Guardar";
            this.button_guardarEjercicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_guardarEjercicio.UseVisualStyleBackColor = false;
            this.button_guardarEjercicio.Click += new System.EventHandler(this.button_guardarEjercicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(839, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 208;
            this.label3.Text = "Nombre:";
            // 
            // txtNombreEjercicio
            // 
            this.txtNombreEjercicio.BackColor = System.Drawing.Color.SlateGray;
            this.txtNombreEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEjercicio.Location = new System.Drawing.Point(837, 217);
            this.txtNombreEjercicio.Name = "txtNombreEjercicio";
            this.txtNombreEjercicio.Size = new System.Drawing.Size(110, 22);
            this.txtNombreEjercicio.TabIndex = 207;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(731, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 206;
            this.label2.Text = "ID del ejercicio";
            // 
            // txtIDEjercicio
            // 
            this.txtIDEjercicio.BackColor = System.Drawing.Color.SlateGray;
            this.txtIDEjercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEjercicio.Location = new System.Drawing.Point(735, 217);
            this.txtIDEjercicio.Name = "txtIDEjercicio";
            this.txtIDEjercicio.Size = new System.Drawing.Size(94, 22);
            this.txtIDEjercicio.TabIndex = 205;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(733, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 213;
            this.label5.Text = "ID del ejercicio";
            // 
            // UsuarioAvanzadoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1064, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListBox_GrupoMuscular);
            this.Controls.Add(this.textBox_descripcionEjercicio);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button_guardarEjercicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreEjercicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDEjercicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_eliminarEjercicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_buscarEjercicio);
            this.Controls.Add(this.txtIDEjercicioBuscar);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tablaEjercicio);
            this.Name = "UsuarioAvanzadoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAvanzadoMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UsuarioAvanzadoMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEjercicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_eliminarEjercicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_buscarEjercicio;
        private System.Windows.Forms.TextBox txtIDEjercicioBuscar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripVentanaPrincial;
        private System.Windows.Forms.ToolStripMenuItem habilitarUsu;
        private System.Windows.Forms.DataGridView tablaEjercicio;
        private System.Windows.Forms.CheckedListBox ListBox_GrupoMuscular;
        private System.Windows.Forms.TextBox textBox_descripcionEjercicio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button_guardarEjercicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEjercicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDEjercicio;
        private System.Windows.Forms.Label label5;
    }
}