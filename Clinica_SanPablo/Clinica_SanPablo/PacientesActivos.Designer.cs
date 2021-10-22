namespace Clinica_SanPablo
{
    partial class PacientesActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesActivos));
            this.label8 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.PictureBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvregistro = new System.Windows.Forms.DataGridView();
            this.Num_Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_na = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNum_Expediente = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(134, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Buscar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.Lupa;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscar.Location = new System.Drawing.Point(478, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 32);
            this.btnbuscar.TabIndex = 16;
            this.btnbuscar.TabStop = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(194, 14);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(277, 20);
            this.txtbuscar.TabIndex = 15;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dgvregistro
            // 
            this.dgvregistro.AllowUserToAddRows = false;
            this.dgvregistro.AllowUserToResizeColumns = false;
            this.dgvregistro.AllowUserToResizeRows = false;
            this.dgvregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvregistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Expediente,
            this.Nombres,
            this.Apellido_Paterno,
            this.Apellido_Materno,
            this.sexo,
            this.telefono,
            this.fecha_na,
            this.estado});
            this.dgvregistro.Location = new System.Drawing.Point(11, 47);
            this.dgvregistro.MultiSelect = false;
            this.dgvregistro.Name = "dgvregistro";
            this.dgvregistro.ReadOnly = true;
            this.dgvregistro.RowHeadersVisible = false;
            this.dgvregistro.RowHeadersWidth = 35;
            this.dgvregistro.Size = new System.Drawing.Size(614, 158);
            this.dgvregistro.TabIndex = 18;
            this.dgvregistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvregistro_CellClick);
            // 
            // Num_Expediente
            // 
            this.Num_Expediente.DataPropertyName = "Num_Expediente";
            this.Num_Expediente.HeaderText = "N° EX";
            this.Num_Expediente.Name = "Num_Expediente";
            this.Num_Expediente.ReadOnly = true;
            this.Num_Expediente.Width = 50;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 140;
            // 
            // Apellido_Paterno
            // 
            this.Apellido_Paterno.DataPropertyName = "Apellido_Paterno";
            this.Apellido_Paterno.HeaderText = "Primer Apellido";
            this.Apellido_Paterno.Name = "Apellido_Paterno";
            this.Apellido_Paterno.ReadOnly = true;
            this.Apellido_Paterno.Width = 150;
            // 
            // Apellido_Materno
            // 
            this.Apellido_Materno.DataPropertyName = "Apellido_Materno";
            this.Apellido_Materno.HeaderText = "Segundo Apellido";
            this.Apellido_Materno.Name = "Apellido_Materno";
            this.Apellido_Materno.ReadOnly = true;
            this.Apellido_Materno.Width = 150;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "Sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fecha_na
            // 
            this.fecha_na.DataPropertyName = "Fecha_Nac";
            this.fecha_na.HeaderText = "Fecha Nac";
            this.fecha_na.Name = "fecha_na";
            this.fecha_na.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "Estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // txtNum_Expediente
            // 
            this.txtNum_Expediente.Location = new System.Drawing.Point(11, 211);
            this.txtNum_Expediente.Name = "txtNum_Expediente";
            this.txtNum_Expediente.Size = new System.Drawing.Size(48, 20);
            this.txtNum_Expediente.TabIndex = 19;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(65, 211);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(167, 20);
            this.txtNombres.TabIndex = 20;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(237, 211);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(167, 20);
            this.txtApellidoP.TabIndex = 21;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(410, 211);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(167, 20);
            this.txtApellidoM.TabIndex = 22;
            // 
            // btnCargar
            // 
            this.btnCargar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCargar.Location = new System.Drawing.Point(550, 237);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 23;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // PacientesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(637, 267);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtNum_Expediente);
            this.Controls.Add(this.dgvregistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PacientesActivos";
            this.Text = "PacientesActivos";
            this.Load += new System.EventHandler(this.PacientesActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvregistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_na;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnCargar;
        public System.Windows.Forms.TextBox txtNum_Expediente;
        public System.Windows.Forms.TextBox txtNombres;
        public System.Windows.Forms.TextBox txtApellidoP;
        public System.Windows.Forms.TextBox txtApellidoM;
    }
}