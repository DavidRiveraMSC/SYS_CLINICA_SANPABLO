using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using MySql.Data.Types;

namespace Clinica_SanPablo
{
    public partial class NuevoPaciente : FormBase
    {

        ConexionSql C = new ConexionSql();
        Validacion V = new Validacion();
        Funciones_Globales F = new Funciones_Globales();
        MySqlCommand comand;
        MySqlDataAdapter adapter;
        DataTable table;

        public static int Expediente;

        public NuevoPaciente()
        {
            InitializeComponent();
            llenarGrid(dgvregistro);
        }

        private void NuevoPaciente_Load(object sender, EventArgs e)
        {

            btnmodificar.Enabled = false;
            btnregistrar.Enabled = true;
            radioA.Checked = true;
            radioF.Checked = false;
            radioM.Checked = false;
            txtExpediente.Enabled = true;
            llenarTexbox();
            txtExpediente.Focus();

        }

        public void llenarTexbox()
        {
            C.AbrirConexion();
            try
            {
                //comand = new MySqlCommand("select ifnull(max(Cod_Consulta) + 1, 1) as Cod_Consulta from consulta;", C.conect);
                comand = new MySqlCommand("NuevoCodPaciente", C.conect);
                comand.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    txtExpediente.Text = Convert.ToString(reader["Num_Expediente"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            btnbuscar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnbuscar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnlimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            btnlimpiar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnlimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnlimpiar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string genero = string.Empty;
            string estado = string.Empty;

            if (txtExpediente.Text.Length == 0 || txtnombres.Text.Length == 0 || txtapellidoP.Text.Length == 0 || txtapellidoM.Text.Length == 0 || txttelefono.Text.Length == 0)
            {
                MessageBox.Show("No Puede dejar Vacio ningun campo");
            }
            if (radioM.Checked == false && radioF.Checked == false)
            {

                MessageBox.Show("Selecciona un Sexo");
            }
            if (radioA.Checked == false && radioB.Checked == false)
            {
                MessageBox.Show("Selecciona un Estado");
            }
            else
            {


                if (radioM.Checked)
                {
                    genero = "M";
                }
                else
                {
                    if (radioF.Checked)
                    {
                        genero = "F";
                    }
                }

                if (radioA.Checked)
                {
                    estado = "Activo";
                }
                else
                {
                    if (radioB.Checked)
                    {
                        estado = "Baja";
                    }
                }

                if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
                    {
                        if (F.Validacion(int.Parse(txtExpediente.Text.ToString())) > 0)
                        {
                            MessageBox.Show("Ya Existe un Registro con ese Numero de Expediente");
                        }
                        else
                        {
                            try
                            {

                                C.AbrirConexion();
                                comand = new MySqlCommand("Registrar_Paciente", C.conect);
                                comand.CommandType = CommandType.StoredProcedure;

                                comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(txtExpediente.Text.ToString());
                                comand.Parameters.Add("Nombresx", MySqlDbType.String).Value = txtnombres.Text.ToString();
                                comand.Parameters.Add("Apellido_Paternox", MySqlDbType.String).Value = txtapellidoP.Text.ToString();
                                comand.Parameters.Add("Apellido_Maternox", MySqlDbType.String).Value = txtapellidoM.Text.ToString();
                                comand.Parameters.Add("Sexox", MySqlDbType.String).Value = genero.ToString();
                                comand.Parameters.Add("Telefonox", MySqlDbType.String).Value = txttelefono.Text.ToString();

                                comand.Parameters.Add("Fecha_Nacx", MySqlDbType.Date).Value = dtpFechaNac.Value.ToString("yyyy/MM/dd");
                                comand.Parameters.Add("Estadox", MySqlDbType.String).Value = estado;

                                comand.ExecuteNonQuery();
                                MessageBox.Show("Paciente Registrado");
                                llenarGrid(dgvregistro);
                                F.LimpiarCajas(groupBox1);
                            txttelefono.Clear();
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            F.LimpiarCajas(groupBox1);
            NuevoPaciente_Load(sender, e);
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string genero = string.Empty;
            string estado = string.Empty;

            if (txtExpediente.Text.Length == 0 || txtnombres.Text.Length == 0 || txtapellidoP.Text.Length == 0 || txtapellidoM.Text.Length == 0 || txttelefono.Text.Length == 0)
            {
                MessageBox.Show("No Puede dejar Vacio ningun campo");
            }
            if (radioM.Checked == false && radioF.Checked == false)
            {

                MessageBox.Show("Selecciona un Sexo");
            }
            if (radioA.Checked == false && radioB.Checked == false)
            {
                MessageBox.Show("Selecciona un Estado");
            }
            else
            {
              
                
                    if (radioM.Checked)
                    {
                        genero = "M";
                    }
                    else
                    {
                        if (radioF.Checked)
                        {
                            genero = "F";
                        }
                    }  
              
                    if (radioA.Checked)
                    {
                         estado = "Activo";
                    }
                    else
                    {
                         if (radioB.Checked)
                         {
                            estado = "Baja";
                         }
                    }
                
                    if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
                    {
                        try
                        {
                            C.AbrirConexion();
                            comand = new MySqlCommand("Actualizar_Paciente", C.conect);
                            comand.CommandType = CommandType.StoredProcedure;


                            comand.Parameters.Add("Nombresx", MySqlDbType.String).Value = txtnombres.Text.ToString();
                            comand.Parameters.Add("Apellido_Paternox", MySqlDbType.String).Value = txtapellidoP.Text.ToString();
                            comand.Parameters.Add("Apellido_Maternox", MySqlDbType.String).Value = txtapellidoM.Text.ToString();
                            comand.Parameters.Add("Sexox", MySqlDbType.String).Value = genero.ToString();
                            comand.Parameters.Add("Telefonox", MySqlDbType.String).Value = txttelefono.Text.ToString();
                            comand.Parameters.Add("Fecha_Nacx", MySqlDbType.Date).Value = dtpFechaNac.Value.ToString("yyyy/MM/dd");
                            comand.Parameters.Add("Estadox", MySqlDbType.String).Value = estado;
                            comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(txtExpediente.Text.ToString());
                            

                            comand.ExecuteNonQuery();
                            MessageBox.Show("Paciente Actualizado");
                            llenarGrid(dgvregistro);
                            F.LimpiarCajas(groupBox1);
                            txttelefono.Clear();
                            NuevoPaciente_Load(sender, e);
                            C.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string estado = "Baja";

            if (Mensaje() == Convert.ToString(DialogResult.Yes))
            {
                if (radioA.Checked == false && radioB.Checked == false)
                {

                    MessageBox.Show("Selecciona un Estado");
                }
                else
                {
                   
                    try
                    {

                        C.AbrirConexion();
                        comand = new MySqlCommand("Baja_Paciente", C.conect);
                        comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.Add("Estadox", MySqlDbType.String).Value = estado;
                        comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(txtExpediente.Text).ToString();

                        comand.ExecuteNonQuery();
                        MessageBox.Show("Paciente de Baja");
                        llenarGrid(dgvregistro);
                        F.LimpiarCajas(groupBox1);
                        NuevoPaciente_Load(sender, e);
                        C.CerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }



            //int togMove;
            //int MValx;
            //int MValY;                        ESTO ES PARA PODER MOVER EL FORMULARIO

            //private void NuevoPaciente_MouseDown(object sender, MouseEventArgs e)
            //{
            //    togMove = 1;
            //    MValx = e.X;
            //    MValY = e.Y;
            //}

            //private void NuevoPaciente_MouseUp(object sender, MouseEventArgs e)
            //{
            //    togMove = 0;
            //}

            //private void NuevoPaciente_MouseMove(object sender, MouseEventArgs e)
            //{
            //    if (togMove == 1)
            //    {
            //        this.SetDesktopLocation(MousePosition.X - MValx, MousePosition.Y - MValY);
            //    }
            //}


        public string Mensaje()
        {
            string mensaje = "Esta seguro de realizar esta accion, al aceptar se dara de Baja al paciente y a todo registro que tenga que ver con el";
            string alerta = "Aviso";
            string resultado = Convert.ToString(MessageBox.Show(mensaje, alerta, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            return resultado;
        }

        private void dgvregistro_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            int rowSelected = e.RowIndex;

            dgvregistro.CurrentCell = null;

            if (e.RowIndex >= 0)
            {
                contextMenuStrip1.Enabled = true;
                this.dgvregistro.Rows[rowSelected].Selected = true;
                DataGridViewRow row = this.dgvregistro.Rows[e.RowIndex];

                txtExpediente.Text = row.Cells["Num_Expediente"].Value.ToString();
                txtnombres.Text = row.Cells["Nombres"].Value.ToString();
                txtapellidoP.Text = row.Cells["Apellido_Paterno"].Value.ToString();
                txtapellidoM.Text = row.Cells["Apellido_Materno"].Value.ToString();
                txttelefono.Text = row.Cells["telefono"].Value.ToString();
                dtpFechaNac.Text = row.Cells["fecha_na"].Value.ToString();

                Expediente = int.Parse(txtExpediente.Text.ToString());

                if (dgvregistro.Rows[e.RowIndex].Cells["Sexo"].Value.ToString() == "M")
                {
                    radioM.Checked = true;
                }
                else
                {
                    radioF.Checked = true;
                }
                if (dgvregistro.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Activo")
                {
                    radioA.Checked = true;
                }
                else
                {
                    radioB.Checked = true;
                }
                txtExpediente.Enabled = false;

                if (txtExpediente.Text != null)
                {
                    btnmodificar.Enabled = true;
                    btnregistrar.Enabled = false;
                }

                e.ContextMenuStrip = contextMenuStrip1;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void dgvregistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvregistro.Rows[e.RowIndex];

                txtExpediente.Text = row.Cells["Num_Expediente"].Value.ToString();
                txtnombres.Text = row.Cells["Nombres"].Value.ToString();
                txtapellidoP.Text = row.Cells["Apellido_Paterno"].Value.ToString();
                txtapellidoM.Text = row.Cells["Apellido_Materno"].Value.ToString();
                txttelefono.Text = row.Cells["telefono"].Value.ToString();
                dtpFechaNac.Text = row.Cells["fecha_na"].Value.ToString();

                if (dgvregistro.Rows[e.RowIndex].Cells["sexo"].Value.ToString() == "M")
                {
                    radioM.Checked = true;
                }
                else
                {
                    radioF.Checked = true;
                }
                if (dgvregistro.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "Activo")
                {
                    radioA.Checked = true;
                }
                else
                {
                    if (dgvregistro.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "Baja")
                    {
                        radioB.Checked = true;
                    }
                    else
                    {
                        if (dgvregistro.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "")
                        {
                            radioA.Checked = false;
                            radioB.Checked = false;
                        }
                    }
                }

                txtExpediente.Enabled = false;

                if (txtExpediente.Text != null)
                {
                    btnmodificar.Enabled = true;
                    btnregistrar.Enabled = false;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void txtExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            F.ValidacionNumeros(sender,e);
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            F.ValidacionLetras(sender,e);
        }

        private void txtapellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            F.ValidacionLetras(sender,e);
        }

        private void txtapellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            F.ValidacionLetras(sender,e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            F.ValidacionNumeros(sender,e);
        }

        private void txttelefono_MouseUp(object sender, MouseEventArgs e)
        {
            if (txttelefono.SelectionStart > 0)
            {
                txttelefono.Select(0, 0);
            }     
        }

        private void imprimirRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImprimirRecetas f = new frmImprimirRecetas();
            f.expedienteToolStripTextBox.Text = Convert.ToString(Expediente);
            f.ShowDialog();
        }
    }
}
