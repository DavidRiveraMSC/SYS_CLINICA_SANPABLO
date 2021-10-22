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
    public partial class NuevaReceta : FormBase
    {
        
        ConexionSql C = new ConexionSql();

        public NuevaReceta()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            AgregarMedicamento r = new AgregarMedicamento(); //creamos un objeto del formulario 2
            DialogResult res = r.ShowDialog(); //abrimos el formulario 2 como cuadro de dialogo modal
            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                //txtCodMedicamento.Text = r.cod_receta; //asignamos al texbox el dato de la variable
                txtMedicamento.Text = r.Medicamento;
                txtCodMedicamento.Text = r.Cod_Medicamento;
            }
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
           
            
        }

        private void NuevaReceta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
