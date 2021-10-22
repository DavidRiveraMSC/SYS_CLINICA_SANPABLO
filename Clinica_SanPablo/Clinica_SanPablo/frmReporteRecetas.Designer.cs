namespace Clinica_SanPablo
{
    partial class frmReporteRecetas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteRecetas));
            this.DataTableRecetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRecetas = new Clinica_SanPablo.DataSetRecetas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableRecetasTableAdapter = new Clinica_SanPablo.DataSetRecetasTableAdapters.DataTableRecetasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableRecetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableRecetasBindingSource
            // 
            this.DataTableRecetasBindingSource.DataMember = "DataTableRecetas";
            this.DataTableRecetasBindingSource.DataSource = this.DataSetRecetas;
            // 
            // DataSetRecetas
            // 
            this.DataSetRecetas.DataSetName = "DataSetRecetas";
            this.DataSetRecetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableRecetasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clinica_SanPablo.Diseño_Reportes.ReporteRecetas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTableRecetasTableAdapter
            // 
            this.DataTableRecetasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 466);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteRecetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes de Recetas";
            this.Load += new System.EventHandler(this.frmReporteRecetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableRecetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRecetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableRecetasBindingSource;
        private DataSetRecetas DataSetRecetas;
        private DataSetRecetasTableAdapters.DataTableRecetasTableAdapter DataTableRecetasTableAdapter;
    }
}