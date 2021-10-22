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
    public partial class ProximaConsulta : Form
    {
        ConexionSql C = new ConexionSql();
        MySqlCommand comand;
        Validacion V = new Validacion();
        Funciones_Globales F = new Funciones_Globales();

        public ProximaConsulta()
        {
            InitializeComponent();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            radioV.Checked = true;
            BotonesNoActivos();

            try
            {
                this.dataTableEventosTableAdapter.Fill(this.dataSetEventos.DataTableEventos, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(monthCalendar1.SelectionRange.Start.ToShortDateString().ToString(), typeof(System.DateTime))))));
                Imagen();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
     
            try
            {
                this.dataTableEventosTableAdapter.Fill(this.dataSetEventos.DataTableEventos, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(monthCalendar1.SelectionRange.Start.ToShortDateString().ToString(), typeof(System.DateTime))))));
                Imagen();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void Imagen()
        {
            if (estadoComboBox.Text == "Activa")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Check;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                label2.Text = "Activa";
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.SetBounds(10, 340, 0, 0, BoundsSpecified.Location);
                label2.SetBounds(100, 340, 0, 0, BoundsSpecified.Location);
            }
            else if (estadoComboBox.Text == "Cancelada")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Cancelado;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                label2.Text = "Cancelada";
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.SetBounds(10, 340, 0, 0, BoundsSpecified.Location);
                label2.SetBounds(100, 340, 0, 0, BoundsSpecified.Location);
            }
            else
            {
                pictureBox1.Visible = false;
                label2.Visible = false;
            }
        }
        public void ImagenNuevaConsulta()
        {
            pictureBox1.BackgroundImage = Properties.Resources.guardar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            label2.Text = "Nuevo";
            pictureBox1.Visible = true;
            label2.Visible = true;
            pictureBox1.SetBounds(10, 340, 0, 0, BoundsSpecified.Location);
            label2.SetBounds(100, 340, 0, 0, BoundsSpecified.Location);
        }
        public void BotonesActivos()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        public void BotonesNoActivos()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void radioN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioN.Checked)
            {
                label1.Text = "Nuevo Evento";
                fecha_ProxConsultaLabel2.Visible = false;
                fecha_ProxConsultaDateTimePicker.Visible = true;
                tipoComboBox.Visible = false;
                estadoComboBox.Visible = false;
                monthCalendar1.Enabled = false;
                btnPacientes.Enabled = true;
                cmbEstado.Visible = true;
                cmbTipo.Visible = true;
                fecha_ProxConsultaDateTimePicker.SetBounds(476, 147, 0, 0, BoundsSpecified.Location);
                cmbTipo.SetBounds(476, 90, 0, 0, BoundsSpecified.Location);
                cmbEstado.SetBounds(476, 118, 0, 0, BoundsSpecified.Location);
                Funciones_Globales f = new Funciones_Globales();
                f.LimpiarCajas(groupBox2);
                f.LimpiarCajas(groupBox1);
                BotonesActivos();
                NuevoCodEventos();
                ImagenNuevaConsulta();
                dataTableEventosBindingNavigator.Enabled = false;
            }
            else if (radioV.Checked)
            {
                label1.Text = "Eventos";
                fecha_ProxConsultaLabel2.Visible = true;
                fecha_ProxConsultaDateTimePicker.Visible = false;
                monthCalendar1.Enabled = true;
                btnPacientes.Enabled = false;
                tipoComboBox.Visible = true;
                estadoComboBox.Visible = true;
                cmbTipo.Visible = false;
                cmbEstado.Visible = false;
                Eventos_Load(sender, e);
                dataTableEventosBindingNavigator.Enabled = true;
            }
        }

        public void NuevoCodEventos()
        {
            C.AbrirConexion();
            try
            {
                //comand = new MySqlCommand("select ifnull(max(Cod_Consulta) + 1, 1) as Cod_Consulta from consulta;", C.conect);
                comand = new MySqlCommand("NuevoCodProxConsulta", C.conect);
                comand.CommandType = CommandType.StoredProcedure;

                MySqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    cod_ProxConsultaTextBox.Text = Convert.ToString(reader["Cod_ProxConsulta"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            PacientesActivos p = new PacientesActivos(); //creamos un objeto del formulario 2
            DialogResult res = p.ShowDialog(); //abrimos el formulario 2 como cuadro de dialogo modal


            if (res == DialogResult.OK)
            {

                if (p.txtNum_Expediente.Text.Length != 0)
                {
                    num_ExpedienteTextBox.Text = p.txtNum_Expediente.Text;
                    nombresTextBox.Text = p.txtNombres.Text;
                    apellido_PaternoTextBox.Text = p.txtApellidoP.Text;
                    apellido_MaternoTextBox.Text = p.txtApellidoM.Text;
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun Paciente");
                }
            }
        }

        public void GuardarEvento()
        {

            if (num_ExpedienteTextBox.Text.Length == 0 || string.IsNullOrEmpty(cmbTipo.Text) || string.IsNullOrEmpty(cmbEstado.Text))
            {
                MessageBox.Show("No Puede dejar Vacio ningun campo");
            }
            else
            {
                if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
                {
                    if (F.Validacion("proxima_consulta", "Cod_ProxConsulta", int.Parse(cod_ProxConsultaTextBox.Text.ToString())) > 0)
                    {
                        MessageBox.Show("Ya Existe un Registro con ese Codigo");
                    }
                    else
                    {
                        try
                        {

                            C.AbrirConexion();
                            comand = new MySqlCommand("Nueva_ProximaConsulta", C.conect);
                            comand.CommandType = CommandType.StoredProcedure;

                            comand.Parameters.Add("Cod_ProxConsultax", MySqlDbType.Int32).Value = int.Parse(cod_ProxConsultaTextBox.Text.ToString());
                            comand.Parameters.Add("Fecha_ProxConsultax", MySqlDbType.Date).Value = fecha_ProxConsultaDateTimePicker.Value.ToString("yyyy/MM/dd");
                            comand.Parameters.Add("Tipox", MySqlDbType.String).Value = cmbTipo.Text.ToString();
                            comand.Parameters.Add("Estadox", MySqlDbType.String).Value = cmbEstado.Text.ToString();
                            comand.Parameters.Add("Notax", MySqlDbType.String).Value = notaTextBox.Text.ToString();
                            comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(num_ExpedienteTextBox.Text.ToString());

                            comand.ExecuteNonQuery();
                            MessageBox.Show("Evento Registrado");
                            F.LimpiarCajas(groupBox1);
                            F.LimpiarCajas(groupBox2);
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

        public void Modificar_Evento()
        {
            if (num_ExpedienteTextBox.Text.Length == 0 || string.IsNullOrEmpty(tipoComboBox.Text) || string.IsNullOrEmpty(estadoComboBox.Text))
            {
                MessageBox.Show("No Puede dejar Vacio ningun campo");
            }
            else
            {
                if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
                {
                    try
                    {

                        C.AbrirConexion();
                        comand = new MySqlCommand("Modificar_ProxConsulta", C.conect);
                        comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.Add("Fecha_ProxConsultax", MySqlDbType.Date).Value = fecha_ProxConsultaDateTimePicker.Value.ToString("yyyy/MM/dd");
                        comand.Parameters.Add("Tipox", MySqlDbType.String).Value = tipoComboBox.Text.ToString();
                        comand.Parameters.Add("Estadox", MySqlDbType.String).Value = estadoComboBox.Text.ToString();
                        comand.Parameters.Add("Notax", MySqlDbType.String).Value = notaTextBox.Text.ToString();
                        comand.Parameters.Add("Num_Expedientex", MySqlDbType.Int32).Value = int.Parse(num_ExpedienteTextBox.Text.ToString());
                        comand.Parameters.Add("Cod_ProxConsultax", MySqlDbType.Int32).Value = int.Parse(cod_ProxConsultaTextBox.Text.ToString());

                        comand.ExecuteNonQuery();
                        MessageBox.Show("Evento Modificado");
                        F.LimpiarCajas(groupBox1);
                        F.LimpiarCajas(groupBox2);
                        C.CerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void Eliminar_Evento()
        {
            if (cod_ProxConsultaTextBox.Text.Length == 0)
            {
                MessageBox.Show("No ha Seleccionado un Evento");
            }
            else
            {
                if (V.Mensaje("Esta Seguro de Eliminar este Evento?", "Alerta", MessageBoxIcon.Warning) == Convert.ToString(DialogResult.Yes))
                {
                    try
                    {

                        C.AbrirConexion();
                        comand = new MySqlCommand("Borrar_ProxConsulta", C.conect);
                        comand.CommandType = CommandType.StoredProcedure;

                       comand.Parameters.Add("Cod_ProxConsultax", MySqlDbType.Int32).Value = int.Parse(cod_ProxConsultaTextBox.Text.ToString());

                        comand.ExecuteNonQuery();
                        MessageBox.Show("Evento Eliminado");
                        F.LimpiarCajas(groupBox1);
                        F.LimpiarCajas(groupBox2);
                        C.CerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GuardarEvento();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Modificar_Evento();
            Eventos_Load(sender,e);
        }

        private void dataTableEventosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            Imagen();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Evento();
            Eventos_Load(sender, e);
        }
    }
}
