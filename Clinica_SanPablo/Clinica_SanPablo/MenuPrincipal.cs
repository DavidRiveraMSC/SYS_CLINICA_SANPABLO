using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_SanPablo
{
    public partial class MenuPrincipal : Form
    {
        ConexionSql C = new ConexionSql();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            TiempoOpacidad.Start();
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //captura el tamaño del monitor
            Int32 Ancho = (this.Width - panel2.Width) / 2;
            Int32 Alto = (desktopSize.Height) / 2;
            panel2.Location = new Point(Ancho, panel2.Location.Y);
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lblusuario.Text = Program.usuario;
            lblfecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToLongTimeString();

            btnEventos.SetBounds(Ancho + 970,Alto + 75, 0, 0, BoundsSpecified.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.ShowDialog();
        }


        private void btnexpediente_MouseMove(object sender, MouseEventArgs e)
        {
            //btnexpediente.Size = new Size(108, 105);
            btnexpediente.BackgroundImageLayout = ImageLayout.Stretch;
            btnexpediente.BackgroundImage = Properties.Resources.Expediente_2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            //btnexpediente.Size = new Size(100, 97);
            btnexpediente.BackgroundImageLayout = ImageLayout.Zoom;
            btnexpediente.BackgroundImage = Properties.Resources.Expediente;
        }

        private void btnPaciente_MouseMove(object sender, MouseEventArgs e)
        {
            btnPaciente.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnPaciente_MouseLeave(object sender, EventArgs e)
        {
            btnPaciente.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private void btnbuscar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMedicamentos.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void btnbuscar_MouseLeave(object sender, EventArgs e)
        {
            btnMedicamentos.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnacercade_MouseMove(object sender, MouseEventArgs e)
        {
            btnacercade.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnacercade_MouseLeave(object sender, EventArgs e)
        {
            btnacercade.BackgroundImageLayout = ImageLayout.Zoom;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            btnConexion.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnConexion.BackgroundImageLayout = ImageLayout.Zoom;
        }


        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            NuevoPaciente N = new NuevoPaciente();
            N.ShowDialog();
        }

        private void TimerActualizar_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnexpediente_Click(object sender, EventArgs e)
        {
            Expedientes ex = new Expedientes();
            ex.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TiempoOpacidad_Tick(object sender, EventArgs e)
        {
            double x = 0.05;
            if (this.Opacity <= 100)
            {
                this.Opacity += x;
            }
            else if (this.Opacity + x > 100)
            {
                TiempoOpacidad.Stop();
            }
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                C.AbrirConexion();
                MessageBox.Show("Conectado a la Base de Datos", "Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                C.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Opciones O = new Opciones();
            O.ShowDialog();
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            btnopciones.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            btnopciones.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Medicamentos m = new Medicamentos();
            m.ShowDialog();
        }

        private void btnacercade_Click(object sender, EventArgs e)
        {
            AcercaDe a = new AcercaDe();
            a.ShowDialog();
        }

        private void pictureBox1_MouseMove_2(object sender, MouseEventArgs e)
        {
            btnEventos.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pictureBox1_MouseLeave_2(object sender, EventArgs e)
        {
            btnEventos.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            ProximaConsulta p = new ProximaConsulta();
            p.ShowDialog();
        }
    }
}
