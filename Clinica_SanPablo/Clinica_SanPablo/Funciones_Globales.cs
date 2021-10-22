using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Clinica_SanPablo
{
    class Funciones_Globales
    {
        ConexionSql C = new ConexionSql();
        MySqlCommand comand;
        MySqlDataReader Reader;
        
        public void LimpiarCajas(System.Windows.Forms.GroupBox Grupo)
        {
            TextBox caja = default(TextBox);
            foreach (Control ctrl in Grupo.Controls)
            {
                caja = ctrl as TextBox;
                if ((caja != null))
                {
                    caja.Clear();
                }
            }
        }

        public void ActivarBoton(TextBox caja, Button btn)
        {
            if (caja != null)
            {
                btn.Enabled = true;
            }
        }

        public void AlterTable()
        {
            try
            {
                 C.AbrirConexion();
                 comand = new MySqlCommand("Alter table paciente auto_increment = 1;", C.conect);
                 comand.ExecuteNonQuery();
                 MessageBox.Show("Tabla Alternada");
                 C.CerrarConexion();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        public int Validacion(int id)
        {
            int contador = 0;
            try
            {
                C.AbrirConexion();
                comand = new MySqlCommand("select * from paciente where Num_Expediente = '" + id + "'", C.conect);
                Reader = comand.ExecuteReader();
                while (Reader.Read())
                {
                    contador++;
                }
                Reader.Close();
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Pudo Consultar Bien" + ex.Message);
            }
            return contador;
        }

        public int Validacion(String tabla, String Parametro,int id)
        {
            int contador = 0;
            try
            {
                C.AbrirConexion();
                comand = new MySqlCommand("select * from "+tabla+" where "+Parametro+" = '" + id + "'", C.conect);
                Reader = comand.ExecuteReader();
                while (Reader.Read())
                {
                    contador++;
                }
                Reader.Close();
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Pudo Consultar Bien" + ex.Message);
            }
            return contador;
        }
        public int ValidacionMedicamentos(string id)
        {
            int contador = 0;
            try
            {
                C.AbrirConexion();
                comand = new MySqlCommand("select * from medicamentos where Cod_Medicamento = '" + id + "'", C.conect);
                Reader = comand.ExecuteReader();
                while (Reader.Read())
                {
                    contador++;
                }
                Reader.Close();
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Pudo Consultar Bien " + ex.Message);
            }
            return contador;
        }

        public void ValidacionLetras(object sender, KeyPressEventArgs e)
        {
                        //esto es para que el texbox solo reciba letras y no numeros
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        public void ValidacionNumeros(object sender, KeyPressEventArgs e)
        {
            //esto es para que el texbox solo reciba letras y no numeros
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }
    }
 }
