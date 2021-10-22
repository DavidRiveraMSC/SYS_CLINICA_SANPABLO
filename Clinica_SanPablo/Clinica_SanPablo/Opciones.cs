using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace Clinica_SanPablo
{
    public partial class Opciones : FormBase
    {
        Validacion V = new Validacion();
        ConexionSql C = new ConexionSql();
        Funciones_Globales F = new Funciones_Globales();
        MySqlCommand comand;
        MySqlDataAdapter adapter;
        DataTable table;
        public int Cod_Usuario;

        public Opciones()
        {
            InitializeComponent();
            llenarGrid();
            llenarCombo();
        }

        private void txtguardar_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text.Length == 0 || txtcontraseña.Text.Length == 0 || cmbprivilegio.Text.Length == 0)
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
                        comand = new MySqlCommand("Registrar_Usuario", C.conect);
                        comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.Add("Cod_Usuariox", MySqlDbType.Int32).Value = null;
                        comand.Parameters.Add("Usuariox", MySqlDbType.String).Value = txtusuario.Text.ToString();
                        comand.Parameters.Add("Contraseñax", MySqlDbType.String).Value = txtcontraseña.Text.ToString();
                        if (cmbprivilegio.Text == "Administrador" || cmbprivilegio.Text == "Recepcionista")
                        {
                            comand.Parameters.Add("Privilegiox", MySqlDbType.String).Value = cmbprivilegio.Text.ToString();
                            comand.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado");
                            F.LimpiarCajas(groupBox2);
                            cmbprivilegio.SelectedValue = -1;
                            llenarGrid();
                            C.AbrirConexion();
                        }
                        else
                        {
                            MessageBox.Show("Campo Privilegio Incorrecto", "No Cambiar el tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                }
            }
        }

        public void llenarGrid()
        {
            C.AbrirConexion();
            try
            {
                adapter = new MySqlDataAdapter("Mostrar_Usuario", C.conect);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                table = new DataTable();

                adapter.Fill(table);
                dgvusuarios.DataSource = table;
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Llenar Grid " + ex.Message);
            }
        }

        public void llenarCombo()
        {
            cmbprivilegio.Items.Add("Administrador");
            cmbprivilegio.Items.Add("Recepcionista");
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
            btnmodificar.Enabled = false;
            btnguardar.Enabled = true;
            btneliminar.Enabled = false;
        }

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvusuarios.Rows[e.RowIndex];

                Cod_Usuario = Convert.ToInt32(row.Cells["ID_Usuario"].Value.ToString());
                txtusuario.Text = row.Cells["Usuario"].Value.ToString();
                txtcontraseña.Text = row.Cells["Contraseña"].Value.ToString();
                cmbprivilegio.Text = row.Cells["Privilegio"].Value.ToString();

                if (txtusuario.Text != null)
                {
                    btnmodificar.Enabled = true;
                    btnguardar.Enabled = false;
                    btneliminar.Enabled = true;
                }

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text.Length == 0 || txtcontraseña.Text.Length == 0 || cmbprivilegio.Text.Length == 0)
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
                            comand = new MySqlCommand("Modificar_Usuario", C.conect);
                            comand.CommandType = CommandType.StoredProcedure;


                            
                            comand.Parameters.Add("Usuariox", MySqlDbType.String).Value = txtusuario.Text.ToString();
                            comand.Parameters.Add("Contraseñax", MySqlDbType.String).Value = txtcontraseña.Text.ToString();
                            comand.Parameters.Add("Privilegiox", MySqlDbType.String).Value = cmbprivilegio.Text.ToString();
                            comand.Parameters.Add("ID_Usuariox", MySqlDbType.Int32).Value = Cod_Usuario;

                            comand.ExecuteNonQuery();
                            MessageBox.Show("Usuario Actualizado");
                            llenarGrid();
                            F.LimpiarCajas(groupBox2);
                            cmbprivilegio.SelectedValue = -1;
                            Opciones_Load(sender, e);
                            C.CerrarConexion();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

            }

        private void btnlimpiar_MouseMove(object sender, MouseEventArgs e)
        {
            btnlimpiar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnlimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnlimpiar.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontraseña.Clear();
            cmbprivilegio.SelectedValue = -1;
            Opciones_Load(sender,e);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
            {
                try
                {
                    C.AbrirConexion();
                    comand = new MySqlCommand("Borrar_Usuario", C.conect);
                    comand.CommandType = CommandType.StoredProcedure;

                    comand.Parameters.Add("ID_Usuariox", MySqlDbType.Int32).Value = Cod_Usuario;

                    comand.ExecuteNonQuery();
                    MessageBox.Show("Usuario Eliminado");
                    llenarGrid();
                    Opciones_Load(sender, e);
                    btnlimpiar_Click(sender,e);
                    C.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacientesDeBaja p = new PacientesDeBaja();
            p.ShowDialog();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {

            DatabaseBackup("C:/Program Files/MySQL/MySQL Server 5.7/bin/mysqldump.exe", "clinica_sanpablo");

        }

        public void DatabaseBackup(string ExeLocation, string DBName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            String files = "";
            sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*";
            sfd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                files = sfd.FileName;
            }
            try
            {
                string tmestr = "";
                tmestr = DBName + "-" + DateTime.Now.ToShortDateString() + ".sql";
                tmestr = tmestr.Replace("/", "-");
                //tmestr = "C:/Users/David Rivera/Desktop/" + tmestr;
                tmestr = "" + files+ "" + tmestr;
                StreamWriter file = new StreamWriter(tmestr);
                ProcessStartInfo proc = new ProcessStartInfo();
                string cmd = string.Format(@"-u{0} -p{1} -h{2} {3}", "root", "david", "localhost", DBName);
                proc.FileName = ExeLocation;
                proc.RedirectStandardInput = false;
                proc.RedirectStandardOutput = true;
                proc.Arguments = cmd;
                proc.UseShellExecute = false;
                Process p = Process.Start(proc);
                string res;
                res = p.StandardOutput.ReadToEnd();
                file.WriteLine(res);
                p.WaitForExit();
                file.Close();
                MessageBox.Show("Respaldo Realizado con Exito");
            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnRestauracion_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            string File = "";
            dlg.Filter = "SQL Files(*.sql)|*.sql|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File = dlg.FileName;
                
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.WorkingDirectory = "C:\\Program Files\\MySQL\\MySQL Server 5.7\\bin\\";
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.Start();
                StreamWriter myStreamWriter = myProcess.StandardInput;
                StreamReader mystreamreader = myProcess.StandardOutput;
                myStreamWriter.WriteLine(("mysql -u root --password="+C.clave+" -h localhost \"clinica_sanpablo\" < \""+ (File + "\" ")));
                myStreamWriter.Close();
                myProcess.WaitForExit();
                myProcess.Close();
                MessageBox.Show("Restauracion Realizada con exito");
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }
    }
}
