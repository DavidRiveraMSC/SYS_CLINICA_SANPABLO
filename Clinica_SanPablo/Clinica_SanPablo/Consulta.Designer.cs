namespace Clinica_SanPablo
{
    partial class Consulta
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
            this.components = new System.ComponentModel.Container();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoConsulta = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtContador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRecetaMedicamentos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigoLentes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacionL = new System.Windows.Forms.TextBox();
            this.txtLentes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkbMedicamentos = new System.Windows.Forms.CheckBox();
            this.chkbLentes = new System.Windows.Forms.CheckBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaMedicamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(603, 9);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(23, 40);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(61, 24);
            this.txtExpediente.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 24);
            this.txtNombre.TabIndex = 26;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(265, 40);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(155, 24);
            this.txtApellidoP.TabIndex = 27;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(440, 40);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(149, 24);
            this.txtApellidoM.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtApellidoP);
            this.groupBox1.Controls.Add(this.txtApellidoM);
            this.groupBox1.Controls.Add(this.txtExpediente);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 83);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Paciente";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(12, 160);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(610, 102);
            this.txtDiagnostico.TabIndex = 0;
            this.txtDiagnostico.TextChanged += new System.EventHandler(this.txtDiagnostico_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Diagnostico:";
            // 
            // txtCodigoConsulta
            // 
            this.txtCodigoConsulta.Enabled = false;
            this.txtCodigoConsulta.Location = new System.Drawing.Point(12, 27);
            this.txtCodigoConsulta.Name = "txtCodigoConsulta";
            this.txtCodigoConsulta.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoConsulta.TabIndex = 32;
            this.txtCodigoConsulta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(438, 340);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(489, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fecha Consulta";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtContador
            // 
            this.txtContador.Enabled = false;
            this.txtContador.Location = new System.Drawing.Point(583, 268);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(39, 20);
            this.txtContador.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BurlyWood;
            this.label8.Location = new System.Drawing.Point(279, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 33);
            this.label8.TabIndex = 40;
            this.label8.Text = "Consulta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btnAgregarReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReceta.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnAgregarReceta.Location = new System.Drawing.Point(418, 491);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(104, 29);
            this.btnAgregarReceta.TabIndex = 41;
            this.btnAgregarReceta.Text = "Agregar Recetas";
            this.btnAgregarReceta.UseVisualStyleBackColor = false;
            this.btnAgregarReceta.Click += new System.EventHandler(this.btnAgregarReceta_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnGuardar.Location = new System.Drawing.Point(534, 491);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 29);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // dgvRecetaMedicamentos
            // 
            this.dgvRecetaMedicamentos.AllowUserToAddRows = false;
            this.dgvRecetaMedicamentos.AllowUserToDeleteRows = false;
            this.dgvRecetaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetaMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.medicamento,
            this.dosis,
            this.duracion,
            this.observacion});
            this.dgvRecetaMedicamentos.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRecetaMedicamentos.Location = new System.Drawing.Point(12, 452);
            this.dgvRecetaMedicamentos.MultiSelect = false;
            this.dgvRecetaMedicamentos.Name = "dgvRecetaMedicamentos";
            this.dgvRecetaMedicamentos.ReadOnly = true;
            this.dgvRecetaMedicamentos.RowHeadersVisible = false;
            this.dgvRecetaMedicamentos.Size = new System.Drawing.Size(400, 85);
            this.dgvRecetaMedicamentos.TabIndex = 43;
            this.dgvRecetaMedicamentos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecetaMedicamentos_CellMouseDown);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // medicamento
            // 
            this.medicamento.HeaderText = "Medicamento";
            this.medicamento.Name = "medicamento";
            this.medicamento.ReadOnly = true;
            // 
            // dosis
            // 
            this.dosis.HeaderText = "Dosis";
            this.dosis.Name = "dosis";
            this.dosis.ReadOnly = true;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCodigoLentes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOI);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtOD);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtObservacionL);
            this.groupBox2.Controls.Add(this.txtLentes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 178);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lentes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 52;
            this.label12.Text = "Codigo";
            // 
            // txtCodigoLentes
            // 
            this.txtCodigoLentes.Enabled = false;
            this.txtCodigoLentes.Location = new System.Drawing.Point(105, 23);
            this.txtCodigoLentes.Name = "txtCodigoLentes";
            this.txtCodigoLentes.Size = new System.Drawing.Size(38, 24);
            this.txtCodigoLentes.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "OI";
            // 
            // txtOI
            // 
            this.txtOI.Location = new System.Drawing.Point(135, 116);
            this.txtOI.Name = "txtOI";
            this.txtOI.Size = new System.Drawing.Size(112, 24);
            this.txtOI.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 48;
            this.label4.Text = "OD";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(3, 116);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(112, 24);
            this.txtOD.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Lentes";
            // 
            // txtObservacionL
            // 
            this.txtObservacionL.Location = new System.Drawing.Point(258, 44);
            this.txtObservacionL.Multiline = true;
            this.txtObservacionL.Name = "txtObservacionL";
            this.txtObservacionL.Size = new System.Drawing.Size(137, 127);
            this.txtObservacionL.TabIndex = 36;
            // 
            // txtLentes
            // 
            this.txtLentes.Location = new System.Drawing.Point(105, 53);
            this.txtLentes.Name = "txtLentes";
            this.txtLentes.Size = new System.Drawing.Size(143, 24);
            this.txtLentes.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Observacion";
            // 
            // chkbMedicamentos
            // 
            this.chkbMedicamentos.AutoSize = true;
            this.chkbMedicamentos.BackColor = System.Drawing.Color.Transparent;
            this.chkbMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbMedicamentos.ForeColor = System.Drawing.Color.White;
            this.chkbMedicamentos.Location = new System.Drawing.Point(418, 424);
            this.chkbMedicamentos.Name = "chkbMedicamentos";
            this.chkbMedicamentos.Size = new System.Drawing.Size(125, 22);
            this.chkbMedicamentos.TabIndex = 45;
            this.chkbMedicamentos.Text = "Medicamentos";
            this.chkbMedicamentos.UseVisualStyleBackColor = false;
            // 
            // chkbLentes
            // 
            this.chkbLentes.AutoSize = true;
            this.chkbLentes.BackColor = System.Drawing.Color.Transparent;
            this.chkbLentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbLentes.ForeColor = System.Drawing.Color.White;
            this.chkbLentes.Location = new System.Drawing.Point(418, 386);
            this.chkbLentes.Name = "chkbLentes";
            this.chkbLentes.Size = new System.Drawing.Size(71, 22);
            this.chkbLentes.TabIndex = 46;
            this.chkbLentes.Text = "Lentes";
            this.chkbLentes.UseVisualStyleBackColor = false;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btnAgregarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImg.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnAgregarImg.Location = new System.Drawing.Point(418, 452);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(104, 29);
            this.btnAgregarImg.TabIndex = 47;
            this.btnAgregarImg.Text = "Agregar Imagenes";
            this.btnAgregarImg.UseVisualStyleBackColor = false;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 545);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.chkbLentes);
            this.Controls.Add(this.chkbMedicamentos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvRecetaMedicamentos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarReceta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.txtCodigoConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.txtDiagnostico, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodigoConsulta, 0);
            this.Controls.SetChildIndex(this.date, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtContador, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnAgregarReceta, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.dgvRecetaMedicamentos, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.chkbMedicamentos, 0);
            this.Controls.SetChildIndex(this.chkbLentes, 0);
            this.Controls.SetChildIndex(this.btnAgregarImg, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetaMedicamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtExpediente;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellidoP;
        public System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoConsulta;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarReceta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRecetaMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtCodigoLentes;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtOI;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtObservacionL;
        public System.Windows.Forms.TextBox txtLentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkbMedicamentos;
        private System.Windows.Forms.CheckBox chkbLentes;
        private System.Windows.Forms.Button btnAgregarImg;
    }
}