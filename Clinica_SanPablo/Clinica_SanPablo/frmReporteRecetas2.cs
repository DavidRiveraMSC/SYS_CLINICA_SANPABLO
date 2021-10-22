using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_SanPablo
{
    public partial class frmReporteRecetas2 : Form
    {
        public frmReporteRecetas2()
        {
            InitializeComponent();
        }

        private void frmReporteRecetas2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetRecetas.DataTableRecetas' Puede moverla o quitarla según sea necesario.
            this.DataTableRecetasTableAdapter.Fill(this.DataSetRecetas.DataTableRecetas, frmImprimirRecetas.Expediente);

            this.reportViewer1.RefreshReport();
        }
    }
}
