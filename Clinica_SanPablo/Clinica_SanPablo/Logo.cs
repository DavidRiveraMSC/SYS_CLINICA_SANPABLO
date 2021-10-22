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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
            
        }

        Login L = new Login();

        private void Logo_Load(object sender, EventArgs e)
        {
            TiempoOpacidad.Start();
        }

        private void TiempoOpacidad_Tick(object sender, EventArgs e)
        {
            double x = 0.02;
            if (this.Opacity <= 0.95)
            {
                this.Opacity += x;
            }
            else if (this.Opacity + x > 0.95)
            {
                TiempoOpacidad.Stop();
                TiempoLoad.Enabled = true;
                TiempoLoad.Start();
            }
        }

        private void TiempoLoad_Tick(object sender, EventArgs e)
        {

            TiempoLoad.Stop();
            this.Hide();
            L.ShowDialog();
        }

    }
}
