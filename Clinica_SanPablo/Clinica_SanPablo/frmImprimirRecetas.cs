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
    public partial class frmImprimirRecetas : Form
    {
        public frmImprimirRecetas()
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
                }
                else
                {
                    this.dataTableConsultasTableAdapter.Fill(this.dataSetConsultas.DataTableConsultas, ((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int)))));
                    this.dataTableRecetasTableAdapter.Fill(this.dataSetRecetas.DataTableRecetas, ((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int)))));
                }
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frmImprimirRecetas_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataTableConsultasTableAdapter.Fill(this.dataSetConsultas.DataTableConsultas, NuevoPaciente.Expediente);
                if (string.IsNullOrEmpty(cod_ConsultaTextBox.Text))
                {

                }
                else
                {
                    this.dataTableRecetasTableAdapter.Fill(this.dataSetRecetas.DataTableRecetas, ((int)(System.Convert.ChangeType(cod_ConsultaTextBox.Text, typeof(int)))));
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporteRecetas2 f = new frmReporteRecetas2();
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
    }
}
