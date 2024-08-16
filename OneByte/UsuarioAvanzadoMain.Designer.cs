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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionCli = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionempleado = new System.Windows.Forms.ToolStripMenuItem();
            this.opcdeportes = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionejer = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.calleCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departCliente = new System.Windows.Forms.TextBox();
            this.numCalleCliente = new System.Windows.Forms.TextBox();
            this.posicionCliente = new System.Windows.Forms.TextBox();
            this.deporteCliente = new System.Windows.Forms.TextBox();
            this.fechaNacCliente = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.docCliente = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.eliminarCliente = new System.Windows.Forms.Button();
            this.editarCliente = new System.Windows.Forms.Button();
            this.agregarCliente = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(447, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion De Cliente";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionCli,
            this.gestionempleado,
            this.opcdeportes,
            this.gestionejer,
            this.cerrarsesion,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 57);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionCli
            // 
            this.gestionCli.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionCli.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gestionCli.Name = "gestionCli";
            this.gestionCli.Size = new System.Drawing.Size(350, 53);
            this.gestionCli.Text = "Gestion de cliente (estas aqui)";
           
            // 
            // gestionempleado
            // 
            this.gestionempleado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gestionempleado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionempleado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gestionempleado.Name = "gestionempleado";
            this.gestionempleado.Size = new System.Drawing.Size(269, 53);
            this.gestionempleado.Text = "Gestion de empleados";
            this.gestionempleado.Click += new System.EventHandler(this.gestionempleado_Click);
            // 
            // opcdeportes
            // 
            this.opcdeportes.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcdeportes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.opcdeportes.Name = "opcdeportes";
            this.opcdeportes.Size = new System.Drawing.Size(306, 53);
            this.opcdeportes.Text = "Opcionalidad de deportes";
            this.opcdeportes.Click += new System.EventHandler(this.opcdeportes_Click);
            // 
            // gestionejer
            // 
            this.gestionejer.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionejer.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gestionejer.Name = "gestionejer";
            this.gestionejer.Size = new System.Drawing.Size(250, 53);
            this.gestionejer.Text = "Gestion de ejercicios";
            this.gestionejer.Click += new System.EventHandler(this.gestionejer_Click);
            // 
            // cerrarsesion
            // 
            this.cerrarsesion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsesion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cerrarsesion.Name = "cerrarsesion";
            this.cerrarsesion.Size = new System.Drawing.Size(171, 53);
            this.cerrarsesion.Text = "Cerrar Sesion";
            this.cerrarsesion.Click += new System.EventHandler(this.cerrarsesion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 53);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(16, 53);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCliente,
            this.idCliente});
            this.dataGridView1.Location = new System.Drawing.Point(18, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(590, 505);
            this.dataGridView1.TabIndex = 12;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre Cliente";
            this.nombreCliente.MinimumWidth = 8;
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Width = 250;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "id Cliente";
            this.idCliente.MinimumWidth = 8;
            this.idCliente.Name = "idCliente";
            this.idCliente.Width = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1086, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Calle";
            // 
            // calleCliente
            // 
            this.calleCliente.Location = new System.Drawing.Point(1155, 422);
            this.calleCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calleCliente.Name = "calleCliente";
            this.calleCliente.Size = new System.Drawing.Size(148, 26);
            this.calleCliente.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 503);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Fecha De Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 426);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(711, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1035, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1016, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Numero De Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 586);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Posicion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 665);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Deporte";
            // 
            // departCliente
            // 
            this.departCliente.Location = new System.Drawing.Point(1155, 335);
            this.departCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departCliente.Name = "departCliente";
            this.departCliente.Size = new System.Drawing.Size(148, 26);
            this.departCliente.TabIndex = 55;
            // 
            // numCalleCliente
            // 
            this.numCalleCliente.Location = new System.Drawing.Point(1155, 249);
            this.numCalleCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCalleCliente.Name = "numCalleCliente";
            this.numCalleCliente.Size = new System.Drawing.Size(148, 26);
            this.numCalleCliente.TabIndex = 54;
            // 
            // posicionCliente
            // 
            this.posicionCliente.Location = new System.Drawing.Point(816, 582);
            this.posicionCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posicionCliente.Name = "posicionCliente";
            this.posicionCliente.Size = new System.Drawing.Size(148, 26);
            this.posicionCliente.TabIndex = 53;
            // 
            // deporteCliente
            // 
            this.deporteCliente.Location = new System.Drawing.Point(816, 665);
            this.deporteCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deporteCliente.Name = "deporteCliente";
            this.deporteCliente.Size = new System.Drawing.Size(148, 26);
            this.deporteCliente.TabIndex = 52;
            // 
            // fechaNacCliente
            // 
            this.fechaNacCliente.Location = new System.Drawing.Point(816, 498);
            this.fechaNacCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaNacCliente.Name = "fechaNacCliente";
            this.fechaNacCliente.Size = new System.Drawing.Size(148, 26);
            this.fechaNacCliente.TabIndex = 51;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(816, 422);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(816, 340);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 49;
            // 
            // docCliente
            // 
            this.docCliente.Location = new System.Drawing.Point(816, 249);
            this.docCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.docCliente.Name = "docCliente";
            this.docCliente.Size = new System.Drawing.Size(148, 26);
            this.docCliente.TabIndex = 48;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(915, 186);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 24);
            this.checkBox2.TabIndex = 47;
            this.checkBox2.Text = "Pasaporte";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(796, 186);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 24);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Cedula";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // eliminarCliente
            // 
            this.eliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCliente.Location = new System.Drawing.Point(182, 669);
            this.eliminarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarCliente.Name = "eliminarCliente";
            this.eliminarCliente.Size = new System.Drawing.Size(138, 51);
            this.eliminarCliente.TabIndex = 45;
            this.eliminarCliente.Text = "Eliminar Cliente";
            this.eliminarCliente.UseVisualStyleBackColor = true;
            // 
            // editarCliente
            // 
            this.editarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarCliente.Location = new System.Drawing.Point(328, 669);
            this.editarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editarCliente.Name = "editarCliente";
            this.editarCliente.Size = new System.Drawing.Size(120, 51);
            this.editarCliente.TabIndex = 44;
            this.editarCliente.Text = "Editar Cliente";
            this.editarCliente.UseVisualStyleBackColor = true;
            // 
            // agregarCliente
            // 
            this.agregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCliente.Location = new System.Drawing.Point(458, 669);
            this.agregarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregarCliente.Name = "agregarCliente";
            this.agregarCliente.Size = new System.Drawing.Size(150, 51);
            this.agregarCliente.TabIndex = 43;
            this.agregarCliente.Text = "Agregar Cliente";
            this.agregarCliente.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(1166, 669);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 52);
            this.button3.TabIndex = 68;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // UsuarioAvanzadoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.calleCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departCliente);
            this.Controls.Add(this.numCalleCliente);
            this.Controls.Add(this.posicionCliente);
            this.Controls.Add(this.deporteCliente);
            this.Controls.Add(this.fechaNacCliente);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.docCliente);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.eliminarCliente);
            this.Controls.Add(this.editarCliente);
            this.Controls.Add(this.agregarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UsuarioAvanzadoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioAvanzadoMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionCli;
        private System.Windows.Forms.ToolStripMenuItem gestionempleado;
        private System.Windows.Forms.ToolStripMenuItem opcdeportes;
        private System.Windows.Forms.ToolStripMenuItem gestionejer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox calleCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departCliente;
        private System.Windows.Forms.TextBox numCalleCliente;
        private System.Windows.Forms.TextBox posicionCliente;
        private System.Windows.Forms.TextBox deporteCliente;
        private System.Windows.Forms.TextBox fechaNacCliente;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox docCliente;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button eliminarCliente;
        private System.Windows.Forms.Button editarCliente;
        private System.Windows.Forms.Button agregarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cerrarsesion;
    }
}