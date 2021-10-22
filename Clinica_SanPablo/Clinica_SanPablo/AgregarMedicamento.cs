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
    public partial class AgregarMedicamento : FormBase
    {
        public AgregarMedicamento()
        {
            InitializeComponent();
        }

        Validacion V = new Validacion();
        ConexionSql C = new ConexionSql();
        Funciones_Globales F = new Funciones_Globales();
        MySqlCommand comand;
        MySqlDataAdapter adapter;
        DataTable table;
        public string Cod_Medicamento = "";
        public string Medicamento = "";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }

        public void llenarGrid()
        {
            C.AbrirConexion();
            try
            {
                adapter = new MySqlDataAdapter("Mostrar_Medicamentos", C.conect);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                table = new DataTable();

                adapter.Fill(table);
                dgvMedicamentos.DataSource = table;
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Llenar Grid " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView mifiltro = new DataView(MostrarMedicamentos());
                mifiltro.RowFilter = string.Format("Nombre_Medicamento LIKE '%{0}%' OR Descripcion LIKE '%{0}%'", txtBuscar.Text);
                dgvMedicamentos.DataSource = mifiltro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarMedicamentos()
        {
            C.AbrirConexion();
            comand = new MySqlCommand("Mostrar_Medicamentos", C.conect);
            comand.CommandType = CommandType.StoredProcedure;
            adapter = new MySqlDataAdapter(comand);
            table = new DataTable();
            adapter.Fill(table);
            C.CerrarConexion();
            return table;
        }

        private void Receta_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Cod_Medicamento = txtCodigo.Text;
                Medicamento = txtNombreMedicamento.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMedicamentos.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombreMedicamento.Text = row.Cells["Medicamento"].Value.ToString();
            }
        }
    }
}
