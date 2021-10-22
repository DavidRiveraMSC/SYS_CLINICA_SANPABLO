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
    public partial class Imagenes : Form
    {
        public Imagenes()
        {
            InitializeComponent();
        }

        ConexionSql C = new ConexionSql();
        DataSet NumDatos = new DataSet();
        MySqlCommand comand;
        string imagen;
        string ID;
        string TituloMsBox;
        string sentenciaSql;


        public void Guardar(string id,string imagen,string descripcion)
        {
            try
            {
                C.AbrirConexion();
                comand = new MySqlCommand("insert into imagenes values('"+id+"','"+imagen+"','"+descripcion+"');",C.conect);
                comand.ExecuteNonQuery();
                MessageBox.Show("Imagen Guardada con Exito");
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar(txtID.Text,imagen,txtDescripcion.Text);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Abrir";
            open.Filter = "Jpg files (*.jpg)|*.jpg|Gif files(*.gif)|*.gif|Bitmap files(*.Bmp)|*.bmp|PNG files (*.png)|*.png*";

            if(open.ShowDialog() == DialogResult.OK)
            {
                imagen = open.FileName;
                Bitmap picture = new Bitmap(imagen);
                pictureBox1.Image = (Image)picture;
                ID = open.SafeFileName;
                txtID.Text = ID;
            }

        }
    }
}
