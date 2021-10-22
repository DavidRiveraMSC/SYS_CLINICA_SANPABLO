using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_SanPablo
{
    class Validacion
    {
        public string Mensaje()
        {
            string mensaje = "Esta seguro de realizar esta accion";
            string alerta = "Aviso";
            string resultado = Convert.ToString(MessageBox.Show(mensaje, alerta, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            return resultado;
        }

        public string Mensaje(string Mensaje, string Aviso)
        {
            string mensaje = Mensaje;
            string alerta = Aviso;
            string resultado = Convert.ToString(MessageBox.Show(mensaje, alerta, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            return resultado;
        }
        public string Mensaje(string Mensaje, string Aviso,MessageBoxIcon icono)
        {
            string mensaje = Mensaje;
            string alerta = Aviso;
            string resultado = Convert.ToString(MessageBox.Show(mensaje, alerta, MessageBoxButtons.YesNo,icono));
            return resultado;
        }
    }
}
