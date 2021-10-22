namespace Clinica_SanPablo
{
    partial class NuevaReceta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacionM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.txtDosis = new System.Windows.Forms.TextBox();
            this.txtCodMedicamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(603, 12);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnAgregarM);
            this.groupBox2.Controls.Add(this.txtObservacionM);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCargar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDuracion);
            this.groupBox2.Controls.Add(this.txtMedicamento);
            this.groupBox2.Controls.Add(this.txtDosis);
            this.groupBox2.Controls.Add(this.txtCodMedicamento);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 285);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicamento";
            // 
            // txtObservacionM
            // 
            this.txtObservacionM.Location = new System.Drawing.Point(290, 55);
            this.txtObservacionM.Multiline = true;
            this.txtObservacionM.Name = "txtObservacionM";
            this.txtObservacionM.Size = new System.Drawing.Size(295, 163);
            this.txtObservacionM.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Observacion";
            // 
            // btnCargar
            // 
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(196, 25);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(32, 23);
            this.btnCargar.TabIndex = 41;
            this.btnCargar.Text = "...";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Duracion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "Dosis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Medicamento";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(116, 194);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(142, 24);
            this.txtDuracion.TabIndex = 4;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(117, 77);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(141, 24);
            this.txtMedicamento.TabIndex = 2;
            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(116, 134);
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(142, 24);
            this.txtDosis.TabIndex = 3;
            // 
            // txtCodMedicamento
            // 
            this.txtCodMedicamento.Enabled = false;
            this.txtCodMedicamento.Location = new System.Drawing.Point(116, 24);
            this.txtCodMedicamento.Name = "txtCodMedicamento";
            this.txtCodMedicamento.Size = new System.Drawing.Size(39, 24);
            this.txtCodMedicamento.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.BurlyWood;
            this.label11.Location = new System.Drawing.Point(228, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 33);
            this.label11.TabIndex = 49;
            this.label11.Text = "Agregar Recéta";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btnAgregarM.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarM.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnAgregarM.Location = new System.Drawing.Point(397, 250);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(170, 29);
            this.btnAgregarM.TabIndex = 50;
            this.btnAgregarM.Text = "Agregar Medicamento";
            this.btnAgregarM.UseVisualStyleBackColor = false;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // NuevaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaReceta";
            this.Load += new System.EventHandler(this.NuevaReceta_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMedicamento;
        public System.Windows.Forms.TextBox txtCodMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAgregarM;
        public System.Windows.Forms.TextBox txtDuracion;
        public System.Windows.Forms.TextBox txtDosis;
        public System.Windows.Forms.TextBox txtObservacionM;
    }
}