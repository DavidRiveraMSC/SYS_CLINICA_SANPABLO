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
    public partial class Medicamentos : Form
    {
        Validacion V = new Validacion();
        ConexionSql C = new ConexionSql();
        Funciones_Globales F = new Funciones_Globales();
        MySqlCommand comand;
        MySqlDataAdapter adapter;
        DataTable table;
        public int cont = 0;

        public Medicamentos()
        {
            InitializeComponent();
        }

        public void llenarTexbox()
        {
            C.AbrirConexion();
            try
            {
                //comand = new MySqlCommand("select ifnull(max(Cod_Consulta) + 1, 1) as Cod_Consulta from consulta;", C.conect);
                comand = new MySqlCommand("NuevoCodMedicamentos", C.conect);
                comand.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    txtCodigo.Text = Convert.ToString(reader["Cod_Medicamento"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Length == 0 || txtNombreMedicamento.Text.Length == 0 || txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("No Puede dejar Vacio ningun campo");
            }
            else if (txtDescripcion.Text.Length > 100)
            {
                MessageBox.Show("No puede Escribir mas de 100 letras", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
                {
                    if (F.ValidacionMedicamentos(txtCodigo.Text) > 0)
                    {
                        MessageBox.Show("Ya Existe un Registro con ese Codigo");
                    }
                    else
                    {
                        try
                        {

                            C.AbrirConexion();
                            comand = new MySqlCommand("Nuevo_Medicamento", C.conect);
                            comand.CommandType = CommandType.StoredProcedure;

                            comand.Parameters.Add("Cod_Medicamento", MySqlDbType.String, 20).Value = txtCodigo.Text.ToString();
                            comand.Parameters.Add("Nombre_Medicamento", MySqlDbType.String).Value = txtNombreMedicamento.Text.ToString();
                            comand.Parameters.Add("Descripcion", MySqlDbType.String).Value = txtDescripcion.Text.ToString();

                            comand.ExecuteNonQuery();
                            MessageBox.Show("Medicamento Registrado");
                            llenarGrid();
                            F.LimpiarCajas(groupBox2);
                            Medicamentos_Load(sender, e);
                            C.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }
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

        private void Medicamentos_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            llenarGrid();
            llenarTexbox();
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtCodigo.Enabled = true;
          
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtContador.Text = Convert.ToInt32(txtDescripcion.Text.Length).ToString();
            if (txtDescripcion.Text.Length > 100)
            {
                error.SetError(txtDescripcion, "No puede Escribir mas de 100 letras");
            }
            else
            {
                error.Clear();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text.Length == 0 || txtNombreMedicamento.Text.Length == 0 || txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("No Puede dejar Vacio ningun campo");
            }
            if (txtDescripcion.Text.Length > 100)
            {
                MessageBox.Show("No puede Escribir mas de 100 letras", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
                {
                        try
                        {

                            C.AbrirConexion();
                            comand = new MySqlCommand("Modificar_Medicamentos", C.conect);
                            comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.Add("Nombre_Medicamentox", MySqlDbType.String).Value = txtNombreMedicamento.Text.ToString();
                        comand.Parameters.Add("Descripcionx", MySqlDbType.String).Value = txtDescripcion.Text.ToString();
                        comand.Parameters.Add("Cod_Medicamentox", MySqlDbType.String).Value = txtCodigo.Text.ToString();


                        comand.ExecuteNonQuery();
                            MessageBox.Show("Medicamento Actualizado");
                            llenarGrid();
                            F.LimpiarCajas(groupBox2);
                            Medicamentos_Load(sender, e);
                            C.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                }

            }
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMedicamentos.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombreMedicamento.Text = row.Cells["Medicamento"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                txtCodigo.Enabled = false;
            }
        }

        private void btnlimpiar_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnlimpiar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnlimpiar_MouseLeave_1(object sender, EventArgs e)
        {
            btnlimpiar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            F.LimpiarCajas(groupBox2);
            Medicamentos_Load(sender, e);
        }
    }
}
