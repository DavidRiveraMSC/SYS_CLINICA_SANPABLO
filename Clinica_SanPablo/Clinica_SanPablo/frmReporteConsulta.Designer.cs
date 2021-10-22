namespace Clinica_SanPablo
{
    partial class frmReporteConsulta
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
            System.Windows.Forms.Label cod_ConsultaLabel;
            System.Windows.Forms.Label fecha_ConsultaLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteConsulta));
            this.dataTableConsultasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dataTableConsultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultas = new Clinica_SanPablo.DataSetConsultas();
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
            this.dataTableConsultasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.expedienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.expedienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.num_ExpedienteTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellido_PaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellido_MaternoTextBox = new System.Windows.Forms.TextBox();
            this.cod_ConsultaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_ConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dataTableConsultasTableAdapter = new Clinica_SanPablo.DataSetConsultasTableAdapters.DataTableConsultasTableAdapter();
            this.tableAdapterManager = new Clinica_SanPablo.DataSetConsultasTableAdapters.TableAdapterManager();
            this.lentesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLentes = new Clinica_SanPablo.DataSetLentes();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.lentesTableAdapter = new Clinica_SanPablo.DataSetLentesTableAdapters.lentesTableAdapter();
            this.tableAdapterManager2 = new Clinica_SanPablo.DataSetLentesTableAdapters.TableAdapterManager();
            this.dataSetRecetas = new Clinica_SanPablo.DataSetRecetas();
            this.dataTableRecetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableRecetasTableAdapter = new Clinica_SanPablo.DataSetRecetasTableAdapters.DataTableRecetasTableAdapter();
            this.tableAdapterManager1 = new Clinica_SanPablo.DataSetRecetasTableAdapters.TableAdapterManager();
            this.dataTableRecetasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_consultaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCirugias = new Clinica_SanPablo.DataSetCirugias();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.proxima_consultaTableAdapter = new Clinica_SanPablo.DataSetCirugiasTableAdapters.proxima_consultaTableAdapter();
            this.tableAdapterManager3 = new Clinica_SanPablo.DataSetCirugiasTableAdapters.TableAdapterManager();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.button1 = new System.Windows.Forms.Button();
            num_ExpedienteLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellido_PaternoLabel = new System.Windows.Forms.Label();
            apellido_MaternoLabel = new System.Windows.Forms.Label();
            cod_ConsultaLabel = new System.Windows.Forms.Label();
            fecha_ConsultaLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConsultasBindingNavigator)).BeginInit();
            this.dataTableConsultasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConsultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lentesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRecetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRecetasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxima_consultaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxima_consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCirugias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_ExpedienteLabel
            // 
            num_ExpedienteLabel.AutoSize = true;
            num_ExpedienteLabel.Location = new System.Drawing.Point(11, 57);
            num_ExpedienteLabel.Name = "num_ExpedienteLabel";
            num_ExpedienteLabel.Size = new System.Drawing.Size(88, 13);
            num_ExpedienteLabel.TabIndex = 2;
            num_ExpedienteLabel.Text = "Num Expediente:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(12, 83);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 4;
            nombresLabel.Text = "Nombres:";
            // 
            // apellido_PaternoLabel
            // 
            apellido_PaternoLabel.AutoSize = true;
            apellido_PaternoLabel.Location = new System.Drawing.Point(11, 109);
            apellido_PaternoLabel.Name = "apellido_PaternoLabel";
            apellido_PaternoLabel.Size = new System.Drawing.Size(87, 13);
            apellido_PaternoLabel.TabIndex = 6;
            apellido_PaternoLabel.Text = "Apellido Paterno:";
            // 
            // apellido_MaternoLabel
            // 
            apellido_MaternoLabel.AutoSize = true;
            apellido_MaternoLabel.Location = new System.Drawing.Point(11, 135);
            apellido_MaternoLabel.Name = "apellido_MaternoLabel";
            apellido_MaternoLabel.Size = new System.Drawing.Size(89, 13);
            apellido_MaternoLabel.TabIndex = 8;
            apellido_MaternoLabel.Text = "Apellido Materno:";
            // 
            // cod_ConsultaLabel
            // 
            cod_ConsultaLabel.AutoSize = true;
            cod_ConsultaLabel.Location = new System.Drawing.Point(331, 83);
            cod_ConsultaLabel.Name = "cod_ConsultaLabel";
            cod_ConsultaLabel.Size = new System.Drawing.Size(73, 13);
            cod_ConsultaLabel.TabIndex = 10;
            cod_ConsultaLabel.Text = "Cod Consulta:";
            // 
            // fecha_ConsultaLabel
            // 
            fecha_ConsultaLabel.AutoSize = true;
            fecha_ConsultaLabel.Location = new System.Drawing.Point(331, 110);
            fecha_ConsultaLabel.Name = "fecha_ConsultaLabel";
            fecha_ConsultaLabel.Size = new System.Drawing.Size(84, 13);
            fecha_ConsultaLabel.TabIndex = 12;
            fecha_ConsultaLabel.Text = "Fecha Consulta:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(11, 161);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(66, 13);
            diagnosticoLabel.TabIndex = 14;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // dataTableConsultasBindingNavigator
            // 
            this.dataTableConsultasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTableConsultasBindingNavigator.BindingSource = this.dataTableConsultasBindingSource;
            this.dataTableConsultasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTableConsultasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTableConsultasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dataTableConsultasBindingNavigatorSaveItem});
            this.dataTableConsultasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTableConsultasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTableConsultasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTableConsultasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTableConsultasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTableConsultasBindingNavigator.Name = "dataTableConsultasBindingNavigator";
            this.dataTableConsultasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTableConsultasBindingNavigator.Size = new System.Drawing.Size(676, 25);
            this.dataTableConsultasBindingNavigator.TabIndex = 0;
            this.dataTableConsultasBindingNavigator.Text = "bindingNavigator1";
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
            // dataTableConsultasBindingSource
            // 
            this.dataTableConsultasBindingSource.DataMember = "DataTableConsultas";
            this.dataTableConsultasBindingSource.DataSource = this.dataSetConsultas;
            // 
            // dataSetConsultas
            // 
            this.dataSetConsultas.DataSetName = "DataSetConsultas";
            this.dataSetConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataTableConsultasBindingNavigatorSaveItem
            // 
            this.dataTableConsultasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTableConsultasBindingNavigatorSaveItem.Enabled = false;
            this.dataTableConsultasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTableConsultasBindingNavigatorSaveItem.Image")));
            this.dataTableConsultasBindingNavigatorSaveItem.Name = "dataTableConsultasBindingNavigatorSaveItem";
            this.dataTableConsultasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dataTableConsultasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.dataTableConsultasBindingNavigatorSaveItem.Visible = false;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expedienteToolStripLabel,
            this.expedienteToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(426, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(244, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // expedienteToolStripLabel
            // 
            this.expedienteToolStripLabel.Name = "expedienteToolStripLabel";
            this.expedienteToolStripLabel.Size = new System.Drawing.Size(84, 22);
            this.expedienteToolStripLabel.Text = "N° expediente:";
            // 
            // expedienteToolStripTextBox
            // 
            this.expedienteToolStripTextBox.Name = "expedienteToolStripTextBox";
            this.expedienteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillToolStripButton.Text = "Cargar";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // num_ExpedienteTextBox
            // 
            this.num_ExpedienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableConsultasBindingSource, "Num_Expediente", true));
            this.num_ExpedienteTextBox.Location = new System.Drawing.Point(106, 54);
            this.num_ExpedienteTextBox.Name = "num_ExpedienteTextBox";
            this.num_ExpedienteTextBox.ReadOnly = true;
            this.num_ExpedienteTextBox.Size = new System.Drawing.Size(64, 20);
            this.num_ExpedienteTextBox.TabIndex = 3;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableConsultasBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(106, 80);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.ReadOnly = true;
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 5;
            // 
            // apellido_PaternoTextBox
            // 
            this.apellido_PaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableConsultasBindingSource, "Apellido_Paterno", true));
            this.apellido_PaternoTextBox.Location = new System.Drawing.Point(106, 106);
            this.apellido_PaternoTextBox.Name = "apellido_PaternoTextBox";
            this.apellido_PaternoTextBox.ReadOnly = true;
            this.apellido_PaternoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellido_PaternoTextBox.TabIndex = 7;
            // 
            // apellido_MaternoTextBox
            // 
            this.apellido_MaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableConsultasBindingSource, "Apellido_Materno", true));
            this.apellido_MaternoTextBox.Location = new System.Drawing.Point(106, 132);
            this.apellido_MaternoTextBox.Name = "apellido_MaternoTextBox";
            this.apellido_MaternoTextBox.ReadOnly = true;
            this.apellido_MaternoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellido_MaternoTextBox.TabIndex = 9;
            // 
            // cod_ConsultaTextBox
            // 
            this.cod_ConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableConsultasBindingSource, "Cod_Consulta", true));
            this.cod_ConsultaTextBox.Location = new System.Drawing.Point(426, 80);
            this.cod_ConsultaTextBox.Name = "cod_ConsultaTextBox";
            this.cod_ConsultaTextBox.ReadOnly = true;
            this.cod_ConsultaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cod_ConsultaTextBox.TabIndex = 11;
            this.cod_ConsultaTextBox.TextChanged += new System.EventHandler(this.cod_ConsultaTextBox_TextChanged);
            // 
            // fecha_ConsultaDateTimePicker
            // 
            this.fecha_ConsultaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataTableConsultasBindingSource, "Fecha_Consulta", true));
            this.fecha_ConsultaDateTimePicker.Enabled = false;
            this.fecha_ConsultaDateTimePicker.Location = new System.Drawing.Point(426, 106);
            this.fecha_ConsultaDateTimePicker.Name = "fecha_ConsultaDateTimePicker";
            this.fecha_ConsultaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_ConsultaDateTimePicker.TabIndex = 13;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableConsultasBindingSource, "Diagnostico", true));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(106, 158);
            this.diagnosticoTextBox.Multiline = true;
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.ReadOnly = true;
            this.diagnosticoTextBox.Size = new System.Drawing.Size(527, 77);
            this.diagnosticoTextBox.TabIndex = 15;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(512, 594);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 28);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir Receta";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dataTableConsultasTableAdapter
            // 
            this.dataTableConsultasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Clinica_SanPablo.DataSetConsultasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lentesDataGridView
            // 
            this.lentesDataGridView.AllowUserToAddRows = false;
            this.lentesDataGridView.AllowUserToDeleteRows = false;
            this.lentesDataGridView.AutoGenerateColumns = false;
            this.lentesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lentesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.lentesDataGridView.DataSource = this.lentesBindingSource;
            this.lentesDataGridView.Location = new System.Drawing.Point(18, 383);
            this.lentesDataGridView.Name = "lentesDataGridView";
            this.lentesDataGridView.ReadOnly = true;
            this.lentesDataGridView.Size = new System.Drawing.Size(615, 86);
            this.lentesDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Lentes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OD";
            this.dataGridViewTextBoxColumn7.HeaderText = "OD";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OI";
            this.dataGridViewTextBoxColumn8.HeaderText = "OI";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Observacion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Observacion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 170;
            // 
            // lentesBindingSource
            // 
            this.lentesBindingSource.DataMember = "lentes";
            this.lentesBindingSource.DataSource = this.dataSetLentes;
            // 
            // dataSetLentes
            // 
            this.dataSetLentes.DataSetName = "DataSetLentes";
            this.dataSetLentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medicamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lentes";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator2.BindingSource = this.lentesBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator2.Location = new System.Drawing.Point(18, 355);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator2.Size = new System.Drawing.Size(211, 25);
            this.bindingNavigator2.TabIndex = 23;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            this.bindingNavigatorAddNewItem2.Visible = false;
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem2.Text = "de {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            this.bindingNavigatorDeleteItem2.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // lentesTableAdapter
            // 
            this.lentesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.lentesTableAdapter = this.lentesTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Clinica_SanPablo.DataSetLentesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataSetRecetas
            // 
            this.dataSetRecetas.DataSetName = "DataSetRecetas";
            this.dataSetRecetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableRecetasBindingSource
            // 
            this.dataTableRecetasBindingSource.DataMember = "DataTableRecetas";
            this.dataTableRecetasBindingSource.DataSource = this.dataSetRecetas;
            // 
            // dataTableRecetasTableAdapter
            // 
            this.dataTableRecetasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Clinica_SanPablo.DataSetRecetasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTableRecetasDataGridView
            // 
            this.dataTableRecetasDataGridView.AllowUserToAddRows = false;
            this.dataTableRecetasDataGridView.AllowUserToDeleteRows = false;
            this.dataTableRecetasDataGridView.AutoGenerateColumns = false;
            this.dataTableRecetasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableRecetasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataTableRecetasDataGridView.DataSource = this.dataTableRecetasBindingSource;
            this.dataTableRecetasDataGridView.Location = new System.Drawing.Point(18, 265);
            this.dataTableRecetasDataGridView.Name = "dataTableRecetasDataGridView";
            this.dataTableRecetasDataGridView.ReadOnly = true;
            this.dataTableRecetasDataGridView.Size = new System.Drawing.Size(615, 86);
            this.dataTableRecetasDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_Medicamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod_Medicamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Medicamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Medicamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dosis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dosis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Observacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Observacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 170;
            // 
            // proxima_consultaDataGridView
            // 
            this.proxima_consultaDataGridView.AllowUserToAddRows = false;
            this.proxima_consultaDataGridView.AllowUserToDeleteRows = false;
            this.proxima_consultaDataGridView.AutoGenerateColumns = false;
            this.proxima_consultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proxima_consultaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.proxima_consultaDataGridView.DataSource = this.proxima_consultaBindingSource;
            this.proxima_consultaDataGridView.Location = new System.Drawing.Point(18, 502);
            this.proxima_consultaDataGridView.Name = "proxima_consultaDataGridView";
            this.proxima_consultaDataGridView.ReadOnly = true;
            this.proxima_consultaDataGridView.Size = new System.Drawing.Size(615, 86);
            this.proxima_consultaDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cod_ProxConsulta";
            this.dataGridViewTextBoxColumn11.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Fecha_ProxConsulta";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn14.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Nota";
            this.dataGridViewTextBoxColumn15.HeaderText = "Nota";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 190;
            // 
            // proxima_consultaBindingSource
            // 
            this.proxima_consultaBindingSource.DataMember = "proxima_consulta";
            this.proxima_consultaBindingSource.DataSource = this.dataSetCirugias;
            // 
            // dataSetCirugias
            // 
            this.dataSetCirugias.DataSetName = "DataSetCirugias";
            this.dataSetCirugias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.proxima_consultaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(18, 474);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(211, 25);
            this.bindingNavigator1.TabIndex = 26;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem1.Visible = false;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Eliminar";
            this.bindingNavigatorDeleteItem1.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // proxima_consultaTableAdapter
            // 
            this.proxima_consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = Clinica_SanPablo.DataSetCirugiasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator3.BindingSource = this.dataTableRecetasBindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator3.Location = new System.Drawing.Point(18, 237);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator3.Size = new System.Drawing.Size(211, 25);
            this.bindingNavigator3.TabIndex = 27;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem3.Visible = false;
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem3.Text = "de {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Eliminar";
            this.bindingNavigatorDeleteItem3.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Mover último";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Imagenes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmReporteConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(676, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.proxima_consultaDataGridView);
            this.Controls.Add(this.dataTableRecetasDataGridView);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lentesDataGridView);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(num_ExpedienteLabel);
            this.Controls.Add(this.num_ExpedienteTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(apellido_PaternoLabel);
            this.Controls.Add(this.apellido_PaternoTextBox);
            this.Controls.Add(apellido_MaternoLabel);
            this.Controls.Add(this.apellido_MaternoTextBox);
            this.Controls.Add(cod_ConsultaLabel);
            this.Controls.Add(this.cod_ConsultaTextBox);
            this.Controls.Add(fecha_ConsultaLabel);
            this.Controls.Add(this.fecha_ConsultaDateTimePicker);
            this.Controls.Add(diagnosticoLabel);
            this.Controls.Add(this.diagnosticoTextBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dataTableConsultasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmReporteConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConsultasBindingNavigator)).EndInit();
            this.dataTableConsultasBindingNavigator.ResumeLayout(false);
            this.dataTableConsultasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableConsultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultas)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lentesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRecetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRecetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRecetasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxima_consultaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxima_consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCirugias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetConsultas dataSetConsultas;
        private System.Windows.Forms.BindingSource dataTableConsultasBindingSource;
        private DataSetConsultasTableAdapters.DataTableConsultasTableAdapter dataTableConsultasTableAdapter;
        private DataSetConsultasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTableConsultasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dataTableConsultasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel expedienteToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox num_ExpedienteTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellido_PaternoTextBox;
        private System.Windows.Forms.TextBox apellido_MaternoTextBox;
        private System.Windows.Forms.TextBox cod_ConsultaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_ConsultaDateTimePicker;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        public System.Windows.Forms.ToolStripTextBox expedienteToolStripTextBox;
        private System.Windows.Forms.Button btnImprimir;
        private DataSetLentes dataSetLentes;
        private System.Windows.Forms.BindingSource lentesBindingSource;
        private DataSetLentesTableAdapters.lentesTableAdapter lentesTableAdapter;
        private DataSetLentesTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView lentesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private DataSetRecetas dataSetRecetas;
        private System.Windows.Forms.BindingSource dataTableRecetasBindingSource;
        private DataSetRecetasTableAdapters.DataTableRecetasTableAdapter dataTableRecetasTableAdapter;
        private DataSetRecetasTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataTableRecetasDataGridView;
        private DataSetCirugias dataSetCirugias;
        private System.Windows.Forms.BindingSource proxima_consultaBindingSource;
        private DataSetCirugiasTableAdapters.proxima_consultaTableAdapter proxima_consultaTableAdapter;
        private DataSetCirugiasTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.DataGridView proxima_consultaDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}