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
    public partial class PacientesActivos : Form
    {
        ConexionSql C = new ConexionSql();
        MySqlDataAdapter adapter;
        MySqlCommand comand;
        DataTable table;

        public PacientesActivos()
        {
            InitializeComponent();
        }

        public void llenarGrid(DataGridView data)
        {
            C.AbrirConexion();
            try
            {
                adapter = new MySqlDataAdapter("Mostrar_PacienteActivo", C.conect);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                table = new DataTable();

                adapter.Fill(table);
                data.DataSource = table;
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Llenar Grid " + ex.Message);
            }
        }

        public DataTable MostrarPacienteActivo()
        {
            C.AbrirConexion();
            comand = new MySqlCommand("Mostrar_PacienteActivo", C.conect);
            comand.CommandType = CommandType.StoredProcedure;
            adapter = new MySqlDataAdapter(comand);
            table = new DataTable();
            adapter.Fill(table);
            C.CerrarConexion();
            return table;
        }

        private void PacientesActivos_Load(object sender, EventArgs e)
        {
            llenarGrid(dgvregistro);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView mifiltro = new DataView(MostrarPacienteActivo());
                mifiltro.RowFilter = string.Format("Nombres LIKE '%{0}%' OR Apellido_Paterno LIKE '%{0}%' OR Apellido_Materno LIKE '%{0}%'", txtbuscar.Text);
                dgvregistro.DataSource = mifiltro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvregistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtNum_Expediente.Text = dgvregistro.Rows[e.RowIndex].Cells["Num_Expediente"].Value.ToString();
                txtNombres.Text = dgvregistro.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
                txtApellidoP.Text = dgvregistro.Rows[e.RowIndex].Cells["Apellido_Paterno"].Value.ToString();
                txtApellidoM.Text = dgvregistro.Rows[e.RowIndex].Cells["Apellido_Materno"].Value.ToString();
            }
        }
    }
}
