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
    public partial class Opciones2 : FormBase
    {
        ConexionSql C = new ConexionSql();
        MySqlCommand comand;
        MySqlDataAdapter adapter;
        DataTable table;
        Validacion V = new Validacion();
       
        public Opciones2()
        {
            InitializeComponent();
            llenarGrid(Login.ID);
            btnmodificar.Enabled = false;
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
                        comand.Parameters.Add("ID_Usuariox", MySqlDbType.Int32).Value = Login.ID;

                        comand.ExecuteNonQuery();
                        MessageBox.Show("Usuario Actualizado");
                        llenarGrid(Login.ID);
                        C.CerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void llenarGrid(string ID_Usuario)
        {
            C.AbrirConexion();

            try
            {
                adapter = new MySqlDataAdapter("select * from usuarios where ID_Usuario = '" + ID_Usuario + "';", C.conect);
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

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvusuarios.Rows[e.RowIndex];

                txtusuario.Text = row.Cells["Usuario"].Value.ToString();
                txtcontraseña.Text = row.Cells["Contrasenia"].Value.ToString();
                cmbprivilegio.Text = row.Cells["Privilegio"].Value.ToString();

                btnmodificar.Enabled = true;

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
            Funciones_Globales F = new Funciones_Globales();
            F.LimpiarCajas(groupBox2);
            cmbprivilegio.SelectedValue = -1;
            btnmodificar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacientesDeBaja p = new PacientesDeBaja();
            p.ShowDialog();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            Opciones O = new Opciones();
            O.DatabaseBackup("C:/Program Files/MySQL/MySQL Server 5.7/bin/mysqldump.exe", "clinica_sanpablo");
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
                myStreamWriter.WriteLine(("mysql -u root --password="+C.clave+" -h localhost \"clinica_sanpablo\" < \"" + (File + "\" ")));
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
