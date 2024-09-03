namespace OneByte
{
    partial class UsuarioAdministrativoControlDeAsistencia
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.docCliente = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlDePago = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.darDeAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlAsistenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitarUsuarioUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 68;
            this.button2.Text = "Reiniciar ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(667, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 67;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(488, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 94;
            this.dateTimePicker1.Value = new System.DateTime(2024, 7, 14, 19, 58, 44, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "Fecha a comprobar:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(19, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(94, 21);
            this.label25.TabIndex = 69;
            this.label25.Text = "Documento:";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // docCliente
            // 
            this.docCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docCliente.Location = new System.Drawing.Point(22, 35);
            this.docCliente.Name = "docCliente";
            this.docCliente.Size = new System.Drawing.Size(118, 24);
            this.docCliente.TabIndex = 68;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(154, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 25);
            this.radioButton3.TabIndex = 70;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pasaporte";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(154, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 25);
            this.radioButton4.TabIndex = 71;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Cédula";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(19, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 21);
            this.label26.TabIndex = 72;
            this.label26.Text = "Nombre Completo:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(49, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 21);
            this.label27.TabIndex = 73;
            this.label27.Text = "label27";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(172, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 97;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.docCliente);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 293);
            this.panel1.TabIndex = 93;
            // 
            // controlDePago
            // 
            this.controlDePago.AutoSize = true;
            this.controlDePago.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlDePago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.controlDePago.Location = new System.Drawing.Point(252, 46);
            this.controlDePago.Name = "controlDePago";
            this.controlDePago.Size = new System.Drawing.Size(223, 30);
            this.controlDePago.TabIndex = 97;
            this.controlDePago.Text = "Control De Asistencia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaToolStripMenuItem,
            this.gestionDePagosToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(784, 37);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 98;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // darDeAltaToolStripMenuItem
            // 
            this.darDeAltaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlAsistenciaToolStripMenuItem1,
            this.deshabilitarUsuarioUToolStripMenuItem,
            this.habilitarUsuarioToolStripMenuItem});
            this.darDeAltaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.darDeAltaToolStripMenuItem.Name = "darDeAltaToolStripMenuItem";
            this.darDeAltaToolStripMenuItem.Size = new System.Drawing.Size(167, 33);
            this.darDeAltaToolStripMenuItem.Text = "Gestión de Usuarios";
            this.darDeAltaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // controlAsistenciaToolStripMenuItem1
            // 
            this.controlAsistenciaToolStripMenuItem1.Name = "controlAsistenciaToolStripMenuItem1";
            this.controlAsistenciaToolStripMenuItem1.Size = new System.Drawing.Size(318, 26);
            this.controlAsistenciaToolStripMenuItem1.Text = "Control de asistencia (estas aquí)";
            this.controlAsistenciaToolStripMenuItem1.Click += new System.EventHandler(this.controlAsistenciaToolStripMenuItem1_Click);
            // 
            // deshabilitarUsuarioUToolStripMenuItem
            // 
            this.deshabilitarUsuarioUToolStripMenuItem.Name = "deshabilitarUsuarioUToolStripMenuItem";
            this.deshabilitarUsuarioUToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.deshabilitarUsuarioUToolStripMenuItem.Text = "Deshabilitar usuario";
            this.deshabilitarUsuarioUToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaUToolStripMenuItem_Click);
            // 
            // habilitarUsuarioToolStripMenuItem
            // 
            this.habilitarUsuarioToolStripMenuItem.Name = "habilitarUsuarioToolStripMenuItem";
            this.habilitarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.habilitarUsuarioToolStripMenuItem.Text = "Habilitar usuario";
            this.habilitarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.habilitarUsuarioToolStripMenuItem_Click);
            // 
            // gestionDePagosToolStripMenuItem
            // 
            this.gestionDePagosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gestionDePagosToolStripMenuItem.Name = "gestionDePagosToolStripMenuItem";
            this.gestionDePagosToolStripMenuItem.Size = new System.Drawing.Size(153, 33);
            this.gestionDePagosToolStripMenuItem.Text = "Gestión de Pagos ";
            this.gestionDePagosToolStripMenuItem.Click += new System.EventHandler(this.gestionDePagosToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(119, 33);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(551, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 99;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // UsuarioAdministrativoControlDeAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.controlDePago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "UsuarioAdministrativoControlDeAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAdministrativoControlDeAsistencia";
            this.Load += new System.EventHandler(this.UsuarioAdministrativoControlDeAsistencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox docCliente;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label controlDePago;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlAsistenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarUsuarioUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Button button4;
    }
}