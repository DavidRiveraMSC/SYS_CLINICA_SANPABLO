using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clinica_SanPablo
{
    public partial class Expedientes : FormBase
    {
        MySqlDataAdapter adapter;
        MySqlCommand comand;
        DataTable table;
        ConexionSql C = new ConexionSql();
        public string fila;
        
        public Expedientes()
        {
            InitializeComponent();
            
        }
        public string nombre, apellidoP, apellidoM;
        public static int num_expediente;

        private void Expedientes_Load(object sender, EventArgs e)
        {
            NuevoPaciente n = new NuevoPaciente();
            n.llenarGrid(dgvBuscarPaciente);
            btnConsultas.Enabled = false;
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            NuevoPaciente n = new NuevoPaciente();
            try
            {
                DataView mifiltro = new DataView(n.MostrarPacienteActivo());
                mifiltro.RowFilter = string.Format("Nombres LIKE '%{0}%' OR Apellido_Paterno LIKE '%{0}%' OR Apellido_Materno LIKE '%{0}%'", txtBuscar.Text);
                dgvBuscarPaciente.DataSource = mifiltro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void realizarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamamos al formulario consulta y le pasamos los datos capturados del datagridview
            //hay que poner publicos los textbox del formulario al que le vamos a pasar los datos
            Consulta c = new Consulta();
            c.txtExpediente.Text = Convert.ToString(num_expediente);
            c.txtNombre.Text = nombre;
            c.txtApellidoP.Text = apellidoP;
            c.txtApellidoM.Text = apellidoM;
            c.ShowDialog();
        }

        private void dgvBuscarPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnConsultas.Enabled = true;
                fila = this.dgvBuscarPaciente.Rows[e.RowIndex].Cells["expediente"].Value.ToString();
                num_expediente = int.Parse(this.dgvBuscarPaciente.Rows[e.RowIndex].Cells["expediente"].Value.ToString());
                MostrarConsulta();
                MostrarProxConsulta();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReporteConsulta f = new frmReporteConsulta();
            f.expedienteToolStripTextBox.Text = Convert.ToString(num_expediente);
            f.ShowDialog();
        }

        private void dgvExpedientes_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            int rowSelected = e.RowIndex;
            Consulta c = new Consulta();

            dgvBuscarPaciente.CurrentCell = null;

            if (e.RowIndex >= 0)
            {
                contextMenuStrip1.Enabled = true;
                this.dgvBuscarPaciente.Rows[rowSelected].Selected = true;
                DataGridViewRow row = new DataGridViewRow();
                row =  this.dgvBuscarPaciente.Rows[e.RowIndex];

                //capturamos en variables publicas los datos del datagrid
                num_expediente = Convert.ToInt32(row.Cells["expediente"].Value.ToString());
                nombre = row.Cells["Nombres"].Value.ToString();
                apellidoP = row.Cells["Apellido_Paterno"].Value.ToString();
                apellidoM = row.Cells["Apellido_Materno"].Value.ToString();
                //txttelefono.Text = row.Cells["Telefono"].Value.ToString();
                //dtpFechaNac.Text = row.Cells["Fecha_Nac"].Value.ToString();

            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }

            e.ContextMenuStrip = contextMenuStrip1;
        }

        public DataTable MostrarConsulta()
        {
            C.AbrirConexion();
            try
            {
                comand = new MySqlCommand("Mostrar_Consultas", C.conect);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(fila.ToString());
                adapter = new MySqlDataAdapter(comand);
                table = new DataTable();
                adapter.Fill(table);
                dgvExpedientes.DataSource = table;
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }

        public DataTable MostrarProxConsulta()
        {
            C.AbrirConexion();
            try
            {
                comand = new MySqlCommand("Mostrar_ProxConsulta", C.conect);
                comand.CommandType = CommandType.StoredProcedure;
                comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(fila.ToString());
                adapter = new MySqlDataAdapter(comand);
                table = new DataTable();
                adapter.Fill(table);
                dgvProxConsulta.DataSource = table;
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
        }
    }
}
