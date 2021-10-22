using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Data.Types;
using System.Windows.Forms;

namespace Clinica_SanPablo
{
    class ConexionSql
    {
        protected static string cadena = "server=LaptopDavid; port= 3306;Database= clinica_sanpablo;Uid= root;Pwd= david";
        public MySqlConnection conect = new MySqlConnection(cadena);
        protected static string contraseña = "david";
        public string clave = contraseña;
        
        public void AbrirConexion()
        {
            conect = new MySqlConnection(cadena);
            conect.Open();
        }

        public void CerrarConexion()
        {
            conect = new MySqlConnection(cadena);
            conect.Close();
        }

    }
}
