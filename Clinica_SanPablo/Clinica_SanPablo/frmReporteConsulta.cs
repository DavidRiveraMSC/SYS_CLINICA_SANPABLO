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
    public partial class frmReporteConsulta : Form
    {
        public frmReporteConsulta()
        {
            InitializeComponent();
        }

        public static int Expediente;

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTableConsultasTableAdapter.Fill(this.dataSetConsultas.DataTableConsultas, ((int)(System.Convert.ChangeType(expedienteToolStripTextBox.Text, typeof(int)))));
                if (string.IsNullOrEmpty(cod_ConsultaTextBox.Text))
                {

                    this.dataTableRecetasTableAdapter.Fill(this.dataSetRecetas.DataTableRecetas, 0);
                    this.lentesTableAdapter.Fill(this.dataSetLentes.lentes, 0);
                }
                else
                {
                    this.dataTableRecetasTableAdapter.Fill(this.dataSetRecetas.DataTableRecetas, ((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int)))));
                    this.lentesTableAdapter.Fill(this.dataSetLentes.lentes, new System.Nullable<int>(((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int))))));
                }
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }            
        }

        private void frmReporteConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataTableConsultasTableAdapter.Fill(this.dataSetConsultas.DataTableConsultas, Expedientes.num_expediente);
                if (string.IsNullOrEmpty(num_ExpedienteTextBox.Text))
                {

                }
                else
                {
                    this.proxima_consultaTableAdapter.Fill(this.dataSetCirugias.proxima_consulta, new System.Nullable<int>(((int)(System.Convert.ChangeType(num_ExpedienteTextBox.Text, typeof(int))))));
                }
                
                if (string.IsNullOrEmpty(cod_ConsultaTextBox.Text))
                {
                    
                }
                else
                {
                    this.dataTableRecetasTableAdapter.Fill(this.dataSetRecetas.DataTableRecetas, ((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int)))));
                    this.lentesTableAdapter.Fill(this.dataSetLentes.lentes, new System.Nullable<int>(((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int))))));
                   
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporteRecetas f = new frmReporteRecetas();
                if (string.IsNullOrEmpty(num_ExpedienteTextBox.Text))
                {
                    MessageBox.Show("No hay un pacientes seleccionado");
                }
                else
                {
                    if (string.IsNullOrEmpty(cod_ConsultaTextBox.Text))
                    {
                        MessageBox.Show("El Paciente no tiene Recetas");
                    }
                    else
                    {
                        Expediente = int.Parse(cod_ConsultaTextBox.Text.ToString());
                        f.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cod_ConsultaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cod_ConsultaTextBox.Text))
            {

            }
            else
            {
                try
                {
                    this.dataTableRecetasTableAdapter.Fill(this.dataSetRecetas.DataTableRecetas, ((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int)))));
                    this.lentesTableAdapter.Fill(this.dataSetLentes.lentes, new System.Nullable<int>(((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.proxima_consultaTableAdapter.Fill(this.dataSetCirugias.proxima_consulta, new System.Nullable<int>(((int)(System.Convert.ChangeType(num_ExpedienteTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
