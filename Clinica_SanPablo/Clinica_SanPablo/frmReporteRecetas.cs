using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_SanPablo
{
    public partial class frmReporteRecetas : Form
    {
        public frmReporteRecetas()
        {
            InitializeComponent();
        }

        private void frmReporteRecetas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetRecetas.DataTableRecetas' Puede moverla o quitarla según sea necesario.

            this.DataTableRecetasTableAdapter.Fill(this.DataSetRecetas.DataTableRecetas,frmReporteConsulta.Expediente);
    

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
