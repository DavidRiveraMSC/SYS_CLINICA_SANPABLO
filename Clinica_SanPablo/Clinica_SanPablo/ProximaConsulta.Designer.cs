namespace Clinica_SanPablo
{
    partial class ProximaConsulta
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
            System.Windows.Forms.Label num_ExpedienteLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellido_PaternoLabel;
            System.Windows.Forms.Label apellido_MaternoLabel;
            System.Windows.Forms.Label cod_ProxConsultaLabel;
            System.Windows.Forms.Label notaLabel;
            System.Windows.Forms.Label fecha_ProxConsultaLabel1;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProximaConsulta));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.dataTableEventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEventos = new Clinica_SanPablo.DataSetEventos();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.fecha_ProxConsultaLabel2 = new System.Windows.Forms.Label();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.cod_ProxConsultaTextBox = new System.Windows.Forms.TextBox();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.radioV = new System.Windows.Forms.RadioButton();
            this.fecha_ProxConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.apellido_MaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellido_PaternoTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.num_ExpedienteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTableEventosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataTableEventosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataTableEventosTableAdapter = new Clinica_SanPablo.DataSetEventosTableAdapters.DataTableEventosTableAdapter();
            this.tableAdapterManager = new Clinica_SanPablo.DataSetEventosTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            num_ExpedienteLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellido_PaternoLabel = new System.Windows.Forms.Label();
            apellido_MaternoLabel = new System.Windows.Forms.Label();
            cod_ProxConsultaLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            fecha_ProxConsultaLabel1 = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEventosBindingNavigator)).BeginInit();
            this.dataTableEventosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_ExpedienteLabel
            // 
            num_ExpedienteLabel.AutoSize = true;
            num_ExpedienteLabel.Location = new System.Drawing.Point(5, 43);
            num_ExpedienteLabel.Name = "num_ExpedienteLabel";
            num_ExpedienteLabel.Size = new System.Drawing.Size(120, 18);
            num_ExpedienteLabel.TabIndex = 0;
            num_ExpedienteLabel.Text = "Num Expediente:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(41, 79);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(74, 18);
            nombresLabel.TabIndex = 2;
            nombresLabel.Text = "Nombres:";
            // 
            // apellido_PaternoLabel
            // 
            apellido_PaternoLabel.AutoSize = true;
            apellido_PaternoLabel.Location = new System.Drawing.Point(6, 115);
            apellido_PaternoLabel.Name = "apellido_PaternoLabel";
            apellido_PaternoLabel.Size = new System.Drawing.Size(119, 18);
            apellido_PaternoLabel.TabIndex = 4;
            apellido_PaternoLabel.Text = "Apellido Paterno:";
            // 
            // apellido_MaternoLabel
            // 
            apellido_MaternoLabel.AutoSize = true;
            apellido_MaternoLabel.Location = new System.Drawing.Point(4, 151);
            apellido_MaternoLabel.Name = "apellido_MaternoLabel";
            apellido_MaternoLabel.Size = new System.Drawing.Size(122, 18);
            apellido_MaternoLabel.TabIndex = 6;
            apellido_MaternoLabel.Text = "Apellido Materno:";
            // 
            // cod_ProxConsultaLabel
            // 
            cod_ProxConsultaLabel.AutoSize = true;
            cod_ProxConsultaLabel.Location = new System.Drawing.Point(16, 26);
            cod_ProxConsultaLabel.Name = "cod_ProxConsultaLabel";
            cod_ProxConsultaLabel.Size = new System.Drawing.Size(138, 18);
            cod_ProxConsultaLabel.TabIndex = 0;
            cod_ProxConsultaLabel.Text = "Cod Prox Consulta:";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(110, 141);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(44, 18);
            notaLabel.TabIndex = 6;
            notaLabel.Text = "Nota:";
            // 
            // fecha_ProxConsultaLabel1
            // 
            fecha_ProxConsultaLabel1.AutoSize = true;
            fecha_ProxConsultaLabel1.Location = new System.Drawing.Point(5, 114);
            fecha_ProxConsultaLabel1.Name = "fecha_ProxConsultaLabel1";
            fecha_ProxConsultaLabel1.Size = new System.Drawing.Size(151, 18);
            fecha_ProxConsultaLabel1.TabIndex = 8;
            fecha_ProxConsultaLabel1.Text = "Fecha Prox Consulta:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(113, 56);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(41, 18);
            tipoLabel.TabIndex = 9;
            tipoLabel.Text = "Tipo:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(95, 88);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(59, 18);
            estadoLabel.TabIndex = 10;
            estadoLabel.Text = "Estado:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 49);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(tipoLabel);
            this.groupBox1.Controls.Add(this.tipoComboBox);
            this.groupBox1.Controls.Add(fecha_ProxConsultaLabel1);
            this.groupBox1.Controls.Add(this.fecha_ProxConsultaLabel2);
            this.groupBox1.Controls.Add(notaLabel);
            this.groupBox1.Controls.Add(this.notaTextBox);
            this.groupBox1.Controls.Add(cod_ProxConsultaLabel);
            this.groupBox1.Controls.Add(this.cod_ProxConsultaTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(311, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Activa",
            "Cancelada"});
            this.estadoComboBox.Location = new System.Drawing.Point(166, 85);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 26);
            this.estadoComboBox.TabIndex = 11;
            // 
            // dataTableEventosBindingSource
            // 
            this.dataTableEventosBindingSource.DataMember = "DataTableEventos";
            this.dataTableEventosBindingSource.DataSource = this.dataSetEventos;
            // 
            // dataSetEventos
            // 
            this.dataSetEventos.DataSetName = "DataSetEventos";
            this.dataSetEventos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Tipo", true));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "Normal",
            "Cirugia"});
            this.tipoComboBox.Location = new System.Drawing.Point(166, 53);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(121, 26);
            this.tipoComboBox.TabIndex = 10;
            // 
            // fecha_ProxConsultaLabel2
            // 
            this.fecha_ProxConsultaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Fecha_ProxConsulta", true));
            this.fecha_ProxConsultaLabel2.Location = new System.Drawing.Point(166, 114);
            this.fecha_ProxConsultaLabel2.Name = "fecha_ProxConsultaLabel2";
            this.fecha_ProxConsultaLabel2.Size = new System.Drawing.Size(100, 23);
            this.fecha_ProxConsultaLabel2.TabIndex = 9;
            this.fecha_ProxConsultaLabel2.Text = "label1";
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Nota", true));
            this.notaTextBox.Location = new System.Drawing.Point(166, 141);
            this.notaTextBox.Multiline = true;
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(168, 62);
            this.notaTextBox.TabIndex = 7;
            // 
            // cod_ProxConsultaTextBox
            // 
            this.cod_ProxConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Cod_ProxConsulta", true));
            this.cod_ProxConsultaTextBox.Location = new System.Drawing.Point(166, 23);
            this.cod_ProxConsultaTextBox.Name = "cod_ProxConsultaTextBox";
            this.cod_ProxConsultaTextBox.ReadOnly = true;
            this.cod_ProxConsultaTextBox.Size = new System.Drawing.Size(100, 24);
            this.cod_ProxConsultaTextBox.TabIndex = 1;
            // 
            // radioN
            // 
            this.radioN.AutoSize = true;
            this.radioN.Location = new System.Drawing.Point(14, 215);
            this.radioN.Name = "radioN";
            this.radioN.Size = new System.Drawing.Size(57, 17);
            this.radioN.TabIndex = 12;
            this.radioN.TabStop = true;
            this.radioN.Text = "Nuevo";
            this.radioN.UseVisualStyleBackColor = true;
            this.radioN.CheckedChanged += new System.EventHandler(this.radioN_CheckedChanged);
            // 
            // radioV
            // 
            this.radioV.AutoSize = true;
            this.radioV.Location = new System.Drawing.Point(198, 215);
            this.radioV.Name = "radioV";
            this.radioV.Size = new System.Drawing.Size(64, 17);
            this.radioV.TabIndex = 14;
            this.radioV.TabStop = true;
            this.radioV.Text = "Eventos";
            this.radioV.UseVisualStyleBackColor = true;
            // 
            // fecha_ProxConsultaDateTimePicker
            // 
            this.fecha_ProxConsultaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_ProxConsultaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_ProxConsultaDateTimePicker.Location = new System.Drawing.Point(70, 330);
            this.fecha_ProxConsultaDateTimePicker.Name = "fecha_ProxConsultaDateTimePicker";
            this.fecha_ProxConsultaDateTimePicker.Size = new System.Drawing.Size(111, 24);
            this.fecha_ProxConsultaDateTimePicker.TabIndex = 8;
            this.fecha_ProxConsultaDateTimePicker.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 45);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(6, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(168, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(87, 16);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPacientes);
            this.groupBox2.Controls.Add(apellido_MaternoLabel);
            this.groupBox2.Controls.Add(this.apellido_MaternoTextBox);
            this.groupBox2.Controls.Add(apellido_PaternoLabel);
            this.groupBox2.Controls.Add(this.apellido_PaternoTextBox);
            this.groupBox2.Controls.Add(nombresLabel);
            this.groupBox2.Controls.Add(this.nombresTextBox);
            this.groupBox2.Controls.Add(num_ExpedienteLabel);
            this.groupBox2.Controls.Add(this.num_ExpedienteTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(313, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 176);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // btnPacientes
            // 
            this.btnPacientes.Enabled = false;
            this.btnPacientes.Location = new System.Drawing.Point(284, 43);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(30, 23);
            this.btnPacientes.TabIndex = 8;
            this.btnPacientes.Text = "...";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // apellido_MaternoTextBox
            // 
            this.apellido_MaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Apellido_Materno", true));
            this.apellido_MaternoTextBox.Location = new System.Drawing.Point(134, 151);
            this.apellido_MaternoTextBox.Name = "apellido_MaternoTextBox";
            this.apellido_MaternoTextBox.ReadOnly = true;
            this.apellido_MaternoTextBox.Size = new System.Drawing.Size(180, 24);
            this.apellido_MaternoTextBox.TabIndex = 7;
            // 
            // apellido_PaternoTextBox
            // 
            this.apellido_PaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Apellido_Paterno", true));
            this.apellido_PaternoTextBox.Location = new System.Drawing.Point(134, 115);
            this.apellido_PaternoTextBox.Name = "apellido_PaternoTextBox";
            this.apellido_PaternoTextBox.ReadOnly = true;
            this.apellido_PaternoTextBox.Size = new System.Drawing.Size(180, 24);
            this.apellido_PaternoTextBox.TabIndex = 5;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(134, 79);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.ReadOnly = true;
            this.nombresTextBox.Size = new System.Drawing.Size(180, 24);
            this.nombresTextBox.TabIndex = 3;
            // 
            // num_ExpedienteTextBox
            // 
            this.num_ExpedienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableEventosBindingSource, "Num_Expediente", true));
            this.num_ExpedienteTextBox.Location = new System.Drawing.Point(134, 43);
            this.num_ExpedienteTextBox.Name = "num_ExpedienteTextBox";
            this.num_ExpedienteTextBox.ReadOnly = true;
            this.num_ExpedienteTextBox.Size = new System.Drawing.Size(100, 24);
            this.num_ExpedienteTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datos del Paciente";
            // 
            // dataTableEventosBindingNavigator
            // 
            this.dataTableEventosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTableEventosBindingNavigator.BindingSource = this.dataTableEventosBindingSource;
            this.dataTableEventosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTableEventosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTableEventosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dataTableEventosBindingNavigatorSaveItem});
            this.dataTableEventosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTableEventosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTableEventosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTableEventosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTableEventosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTableEventosBindingNavigator.Name = "dataTableEventosBindingNavigator";
            this.dataTableEventosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTableEventosBindingNavigator.Size = new System.Drawing.Size(665, 25);
            this.dataTableEventosBindingNavigator.TabIndex = 18;
            this.dataTableEventosBindingNavigator.Text = "bindingNavigator1";
            this.dataTableEventosBindingNavigator.RefreshItems += new System.EventHandler(this.dataTableEventosBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataTableEventosBindingNavigatorSaveItem
            // 
            this.dataTableEventosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTableEventosBindingNavigatorSaveItem.Enabled = false;
            this.dataTableEventosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTableEventosBindingNavigatorSaveItem.Image")));
            this.dataTableEventosBindingNavigatorSaveItem.Name = "dataTableEventosBindingNavigatorSaveItem";
            this.dataTableEventosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataTableEventosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.dataTableEventosBindingNavigatorSaveItem.Visible = false;
            // 
            // dataTableEventosTableAdapter
            // 
            this.dataTableEventosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Clinica_SanPablo.DataSetEventosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Proxima Consulta";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Normal",
            "Cirugia"});
            this.cmbTipo.Location = new System.Drawing.Point(70, 360);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 26);
            this.cmbTipo.TabIndex = 20;
            this.cmbTipo.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activa",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(70, 389);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 26);
            this.cmbEstado.TabIndex = 21;
            this.cmbEstado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 40);
            this.label2.TabIndex = 23;
            this.label2.Text = "...";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // ProximaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha_ProxConsultaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dataTableEventosBindingNavigator);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioN);
            this.Controls.Add(this.radioV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProximaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEventosBindingNavigator)).EndInit();
            this.dataTableEventosBindingNavigator.ResumeLayout(false);
            this.dataTableEventosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.RadioButton radioV;
        private System.Windows.Forms.DateTimePicker fecha_ProxConsultaDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private DataSetEventos dataSetEventos;
        private System.Windows.Forms.BindingSource dataTableEventosBindingSource;
        private DataSetEventosTableAdapters.DataTableEventosTableAdapter dataTableEventosTableAdapter;
        private DataSetEventosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTableEventosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dataTableEventosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox apellido_MaternoTextBox;
        private System.Windows.Forms.TextBox apellido_PaternoTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox num_ExpedienteTextBox;
        private System.Windows.Forms.TextBox notaTextBox;
        private System.Windows.Forms.TextBox cod_ProxConsultaTextBox;
        private System.Windows.Forms.Label fecha_ProxConsultaLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}