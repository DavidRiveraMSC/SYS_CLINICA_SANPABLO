namespace Clinica_SanPablo
{
    partial class NuevoPaciente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.PictureBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtapellidoM = new System.Windows.Forms.TextBox();
            this.txtapellidoP = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvregistro = new System.Windows.Forms.DataGridView();
            this.Num_Expediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_na = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imprimirRecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistro)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(603, 12);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtExpediente);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtapellidoM);
            this.groupBox1.Controls.Add(this.txtapellidoP);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(151, 142);
            this.txttelefono.Mask = "0000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(75, 24);
            this.txttelefono.TabIndex = 21;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttelefono.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txttelefono_MouseUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.radioA);
            this.groupBox4.Controls.Add(this.radioB);
            this.groupBox4.Location = new System.Drawing.Point(469, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 88);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado";
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(5, 48);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(35, 22);
            this.radioA.TabIndex = 13;
            this.radioA.TabStop = true;
            this.radioA.Text = "A";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(61, 49);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(36, 22);
            this.radioB.TabIndex = 14;
            this.radioB.TabStop = true;
            this.radioB.Text = "B";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radioM);
            this.groupBox3.Controls.Add(this.radioF);
            this.groupBox3.Location = new System.Drawing.Point(13, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 88);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(5, 48);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(39, 22);
            this.radioM.TabIndex = 13;
            this.radioM.TabStop = true;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(61, 49);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(35, 22);
            this.radioF.TabIndex = 14;
            this.radioF.TabStop = true;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nº Expediente";
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(36, 55);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(44, 24);
            this.txtExpediente.TabIndex = 0;
            this.txtExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpediente_KeyPress);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.limpiar;
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlimpiar.Location = new System.Drawing.Point(578, 113);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(41, 43);
            this.btnlimpiar.TabIndex = 15;
            this.btnlimpiar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnlimpiar, "Limpiar las Cajas");
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            this.btnlimpiar.MouseLeave += new System.EventHandler(this.btnlimpiar_MouseLeave);
            this.btnlimpiar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnlimpiar_MouseMove);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(297, 142);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(134, 24);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombres";
            // 
            // txtapellidoM
            // 
            this.txtapellidoM.Location = new System.Drawing.Point(467, 55);
            this.txtapellidoM.Name = "txtapellidoM";
            this.txtapellidoM.Size = new System.Drawing.Size(134, 24);
            this.txtapellidoM.TabIndex = 3;
            this.txtapellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidoM_KeyPress);
            // 
            // txtapellidoP
            // 
            this.txtapellidoP.Location = new System.Drawing.Point(297, 55);
            this.txtapellidoP.Name = "txtapellidoP";
            this.txtapellidoP.Size = new System.Drawing.Size(134, 24);
            this.txtapellidoP.TabIndex = 2;
            this.txtapellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidoP_KeyPress);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(124, 55);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(134, 24);
            this.txtnombres.TabIndex = 1;
            this.txtnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(200, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "Registro de Pacientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnregistrar.Location = new System.Drawing.Point(12, 263);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(80, 29);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnmodificar.Location = new System.Drawing.Point(127, 263);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(80, 29);
            this.btnmodificar.TabIndex = 8;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(301, 265);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(277, 24);
            this.txtbuscar.TabIndex = 6;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.Lupa;
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscar.Location = new System.Drawing.Point(584, 260);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 32);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnbuscar, "Buscar Pacientes");
            this.btnbuscar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.btnbuscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(240, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Buscar";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 70;
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
            this.dgvregistro.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvregistro.Location = new System.Drawing.Point(5, 12);
            this.dgvregistro.MultiSelect = false;
            this.dgvregistro.Name = "dgvregistro";
            this.dgvregistro.ReadOnly = true;
            this.dgvregistro.RowHeadersVisible = false;
            this.dgvregistro.RowHeadersWidth = 35;
            this.dgvregistro.Size = new System.Drawing.Size(614, 158);
            this.dgvregistro.TabIndex = 13;
            this.dgvregistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvregistro_CellClick);
            this.dgvregistro.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvregistro_CellContextMenuStripNeeded);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarRegistroToolStripMenuItem,
            this.imprimirRecetaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 70);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "Dar de Baja al Paciente";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvregistro);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 176);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // imprimirRecetaToolStripMenuItem
            // 
            this.imprimirRecetaToolStripMenuItem.Name = "imprimirRecetaToolStripMenuItem";
            this.imprimirRecetaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.imprimirRecetaToolStripMenuItem.Text = "Imprimir Receta";
            this.imprimirRecetaToolStripMenuItem.Click += new System.EventHandler(this.imprimirRecetaToolStripMenuItem_Click);
            // 
            // NuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevoPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoPaciente";
            this.Load += new System.EventHandler(this.NuevoPaciente_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnregistrar, 0);
            this.Controls.SetChildIndex(this.btnmodificar, 0);
            this.Controls.SetChildIndex(this.txtbuscar, 0);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvregistro)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtapellidoM;
        private System.Windows.Forms.TextBox txtapellidoP;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.PictureBox btnbuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnlimpiar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvregistro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Expediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_na;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        public System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.ToolStripMenuItem imprimirRecetaToolStripMenuItem;
    }
}