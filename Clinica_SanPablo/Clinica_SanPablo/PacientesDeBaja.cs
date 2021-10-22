using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Clinica_SanPablo
{
    public partial class PacientesDeBaja : FormBase
    {
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlCommand comand;
        ConexionSql C = new ConexionSql();

        public PacientesDeBaja()
        {
            InitializeComponent();
        }

        public void llenarGrid()
        {
            C.AbrirConexion();
            try
            {    
                dgvPacientesBaja.DataSource = MostrarPacienteBaja();
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Llenar Grid " + ex.Message);
            }
        }

        public DataTable MostrarPacienteBaja()
        {
            C.AbrirConexion();
            comand = new MySqlCommand("Mostrar_PacienteBaja", C.conect);
            comand.CommandType = CommandType.StoredProcedure;
            adapter = new MySqlDataAdapter(comand);
            table = new DataTable();
            adapter.Fill(table);
            C.CerrarConexion();
            return table;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView mifiltro = new DataView(MostrarPacienteBaja());
                mifiltro.RowFilter = string.Format("Nombres LIKE '%{0}%' OR Apellido_Paterno LIKE '%{0}%' OR Apellido_Materno LIKE '%{0}%'", txtBuscar.Text);
                dgvPacientesBaja.DataSource = mifiltro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string Mensaje()
        {
            string mensaje = "Esta seguro de realizar esta accion, al aceptar se Habilitará al paciente y a todo registro que tenga que ver con el";
            string alerta = "Aviso";
            string resultado = Convert.ToString(MessageBox.Show(mensaje, alerta, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            return resultado;
        }

        private void reactivarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mensaje() == Convert.ToString(DialogResult.Yes))
            {

                C.AbrirConexion();
                try
                {
                    comand = new MySqlCommand("Activar_Paciente", C.conect);
                    comand.CommandType = CommandType.StoredProcedure;

                    comand.Parameters.Add("Num_Expedientex",MySqlDbType.Int32).Value = int.Parse(dgvPacientesBaja.SelectedRows[0].Cells["Num_Expediente"].Value.ToString());

                    comand.ExecuteNonQuery();
                    MessageBox.Show("Paciente Reactivado");
                    PacientesDeBaja_Load(sender,e);                  
                    C.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvPacientesBaja_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            int rowSelected = e.RowIndex;

            dgvPacientesBaja.CurrentCell = null;

            if (e.RowIndex >= 0)
            {
                contextMenuStrip1.Enabled = true;
                this.dgvPacientesBaja.Rows[rowSelected].Selected = true;
                e.ContextMenuStrip = contextMenuStrip1;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void PacientesDeBaja_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
