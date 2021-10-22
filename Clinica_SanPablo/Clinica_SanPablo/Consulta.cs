using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Clinica_SanPablo
{
    public partial class Consulta : FormBase
    {
        MySqlCommand comand;
        ConexionSql C = new ConexionSql();
        Validacion V = new Validacion();
        Funciones_Globales F = new Funciones_Globales();
        public int cont = 0;
        public string cod_medicamento;

        public Consulta()
        {
            InitializeComponent();
            txtDiagnostico.Focus();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

            txtExpediente.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidoP.Enabled = false;
            txtApellidoM.Enabled = false;
            llenarTexbox();
            NuevoCodLentes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void llenarTexbox()
        {
            C.AbrirConexion();
            try
            {
                //comand = new MySqlCommand("select ifnull(max(Cod_Consulta) + 1, 1) as Cod_Consulta from consulta;", C.conect);
                comand = new MySqlCommand("NuevoCodConsulta", C.conect);
                comand.CommandType = CommandType.StoredProcedure;
                
                MySqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    txtCodigoConsulta.Text = Convert.ToString(reader["Cod_Consulta"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NuevoCodLentes()
        {
            C.AbrirConexion();
            try
            {
                //comand = new MySqlCommand("select ifnull(max(Cod_Consulta) + 1, 1) as Cod_Consulta from consulta;", C.conect);
                comand = new MySqlCommand("NuevoCodLentes", C.conect);
                comand.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    txtCodigoLentes.Text = Convert.ToString(reader["Cod_Lentes"]);
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

        }

        public void GuardarRecetaMedicamento()
        {
            
            try
            {
                    C.AbrirConexion();
                    comand = new MySqlCommand("Nueva_RecetaMedicamento", C.conect);
                    comand.CommandType = CommandType.StoredProcedure;
                    
                    foreach (DataGridViewRow fila in dgvRecetaMedicamentos.Rows)
                    {
                   
                        if(fila.Cells["codigo"].Value != null)
                        {
                            comand.Parameters.Clear();
                            comand.Parameters.Add("Cod_Medicamentox", MySqlDbType.Int32).Value = fila.Cells[0].Value.ToString();
                            comand.Parameters.Add("Cod_Consultax", MySqlDbType.Int32).Value = int.Parse(txtCodigoConsulta.Text.ToString());
                            comand.Parameters.Add("Medicamentox", MySqlDbType.String).Value = fila.Cells[1].Value.ToString();
                            comand.Parameters.Add("Dosisx", MySqlDbType.String).Value = fila.Cells[2].Value.ToString();
                            comand.Parameters.Add("Duracionx", MySqlDbType.String).Value = fila.Cells[3].Value.ToString();
                            comand.Parameters.Add("Observacionx", MySqlDbType.String).Value = fila.Cells[4].Value.ToString();
                            

                            comand.ExecuteNonQuery();
                            MessageBox.Show("Receta Guardada");
                            C.CerrarConexion();
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GuardarRecetaLentes()
        {

            try
            {
                C.AbrirConexion();
                comand = new MySqlCommand("Nueva_RecetaLentes", C.conect);
                comand.CommandType = CommandType.StoredProcedure;

                comand.Parameters.Add("Cod_Lentex", MySqlDbType.Int32).Value = int.Parse(txtCodigoLentes.Text.ToString());
                comand.Parameters.Add("ODX", MySqlDbType.String).Value = txtOD.Text.ToString();
                comand.Parameters.Add("OIX", MySqlDbType.String).Value = txtOI.Text.ToString();
                comand.Parameters.Add("Observacionx", MySqlDbType.String).Value = txtObservacionL.Text.ToString();
                comand.Parameters.Add("Cod_Consultax", MySqlDbType.Int32).Value = int.Parse(txtCodigoConsulta.Text.ToString());


                comand.ExecuteNonQuery();
                MessageBox.Show("Lentes Guardados");
                F.LimpiarCajas(groupBox2);
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtDiagnostico_TextChanged(object sender, EventArgs e)
        {
            txtContador.Text = Convert.ToInt32(txtDiagnostico.Text.Length).ToString();
            if (txtDiagnostico.Text.Length > 500)
            {
                error.SetError(txtDiagnostico, "No puede Escribir mas de 500 letras");
            }
            else
            {
                error.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void txtDosis_KeyPress(object sender, KeyPressEventArgs e)
        {
            F.ValidacionNumeros(sender,e);
        }

        private void txtCodReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            F.ValidacionNumeros(sender,e);
        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            NuevaReceta nr = new NuevaReceta(); //creamos un objeto del formulario 2
            DialogResult res = nr.ShowDialog(); //abrimos el formulario 2 como cuadro de dialogo modal
            

            if (res == DialogResult.OK)
            {
               bool exist = dgvRecetaMedicamentos.Rows.Cast<DataGridViewRow>().Any(row =>Convert.ToString(row.Cells[0].Value) == nr.txtCodMedicamento.Text);
                if (nr.txtCodMedicamento.Text.Length != 0)
                {
                    if (!exist)
                    {
                        dgvRecetaMedicamentos.Rows.Add(nr.txtCodMedicamento.Text, nr.txtMedicamento.Text, nr.txtDosis.Text, nr.txtDuracion.Text, nr.txtObservacionM.Text);
                       
                    }
                    else
                    {
                        MessageBox.Show("Este Medicamento ya esta agregado");
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun medicamento");
                }
            }
        }

        public void GuardarConsulta()
        {
            if (F.Validacion("consulta", "Cod_Consulta", int.Parse(txtCodigoConsulta.Text.ToString())) > 0)
            {
                MessageBox.Show("Ya Existe un Registro con ese Codigo de Consulta");
            }
            else if (txtDiagnostico.Text.Length > 500)
            {
                MessageBox.Show("No puede Escribir mas de 500 letras", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {

                    C.AbrirConexion();
                    comand = new MySqlCommand("Nueva_Consulta", C.conect);
                    comand.CommandType = CommandType.StoredProcedure;

                    comand.Parameters.Add("Cod_Consultax", MySqlDbType.Int32).Value = int.Parse(txtCodigoConsulta.Text.ToString());
                    comand.Parameters.Add("Diagnosticox", MySqlDbType.String).Value = txtDiagnostico.Text.ToString();
                    comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(txtExpediente.Text.ToString());
                    comand.Parameters.Add("Fecha_Consultax", MySqlDbType.Date).Value = date.Value.ToString("yyyy/MM/dd");

                    comand.ExecuteNonQuery();
                    MessageBox.Show("Consulta Realizada");

                    if (chkbMedicamentos.Checked == true)
                    {
                         GuardarRecetaMedicamento();
                    }
                    if (chkbLentes.Checked == true)
                    {
                        GuardarRecetaLentes();
                    }

                    txtDiagnostico.Clear();
                    limpiarGrid();
                    C.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtExpediente.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellidoP.Text.Length == 0 || txtApellidoM.Text.Length == 0 || txtCodigoConsulta.Text.Length == 0 || txtDiagnostico.Text.Length == 0)
            {
                MessageBox.Show("No Puede dejar Vacio ningun campo");
            }
            else
            {

                if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
                {
                    if (chkbLentes.Checked == false && chkbMedicamentos.Checked == false)
                    {
                        if (V.Mensaje("No ha Seleccionado ninguna Receta, Esta Seguro de Continuar?", "Aviso") == Convert.ToString(DialogResult.Yes))
                        {
                            GuardarConsulta();
                            Consulta_Load(sender, e);
                        }
                    }
                    else
                    {
                        GuardarConsulta();
                        Consulta_Load(sender, e);
                    }
                    
                }
            }
        }

        public void limpiarGrid()
        {
            dgvRecetaMedicamentos.Rows.Clear();
            dgvRecetaMedicamentos.Refresh();
        }

        private void dgvRecetaMedicamentos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dgvRecetaMedicamentos.Rows[rowSelected].Selected = true;
                }
                // you now have the selected row with the context menu showing for the user to delete etc.
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvRecetaMedicamentos.CurrentRow;
            if (row != null) dgvRecetaMedicamentos.Rows.Remove(row);
        }
    }
}
