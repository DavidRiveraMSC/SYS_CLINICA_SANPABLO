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
    public partial class Login : Form
    {
        ConexionSql C = new ConexionSql();
        MySqlCommand comand;
        MySqlDataReader reader;
        public static string ID;
        public int cont;

        public Login()
        {
            InitializeComponent();
        }

        Validacion V = new Validacion();
        MenuPrincipal M = new MenuPrincipal();

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            btniniciar.Size = new Size(50,43); 
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btniniciar.Size = new Size(41, 35);
        }

        private void btnapagar_MouseHover(object sender, EventArgs e)
        {
            btnapagar.Size = new Size(50, 43); 
        }

        private void btnapagar_MouseLeave(object sender, EventArgs e)
        {
            btnapagar.Size = new Size(41, 35);
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            if (V.Mensaje() == Convert.ToString(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            Program.usuario = txtusuario.Text;

            C.AbrirConexion();
            int contador = 0;

            if (txtusuario.Text.Length == 0 || txtcontraseña.Text.Length == 0)
            {
                error.SetError(txtusuario, "No Puede haber campo Vacio");
                error.SetError(txtcontraseña, "No Puede haber campo Vacio");
            }
             
            else
            {
                
                comand = new MySqlCommand("select * from usuarios where Usuario = '" + this.txtusuario.Text + "' and Contrasenia = '" + this.txtcontraseña.Text + "'", C.conect);
                try
                {
                    reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        contador++;

                    }

                    if (contador == 1)
                    {
                        MessageBox.Show("Bienvenido(a) '" + txtusuario.Text + "'");
                        ID = Convert.ToString(reader["ID_Usuario"]);

                        if (Convert.ToString(reader["Privilegio"]) == "Administrador")
                        {
                            MenuPrincipal m = new MenuPrincipal();
                            this.Hide();
                            m.ShowDialog();
                        }

                        if (Convert.ToString(reader["Privilegio"]) == "Recepcionista")
                        {
                            MenuPrincipal2 i = new MenuPrincipal2(); 
                            this.Hide();
                            i.ShowDialog();
                        }
                    }
                    else
                    {
                        if(cont == 2)
                        {
                            MessageBox.Show("Ha llegado al limite de intentos", "Lo Sentimos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                        else
                        {
                            cont = cont + 1;
                            MessageBox.Show("Datos Incorrectos", "Verifique Bien sus Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }

                    reader.Close();
                    C.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbprivilegio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btniniciar_Click(sender,e);
            }

        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btniniciar_Click(sender, e);
            }
        }

        private void txtcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btniniciar_Click(sender, e);
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            error.Clear();
        }
    }
}
