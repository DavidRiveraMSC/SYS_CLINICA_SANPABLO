namespace Clinica_SanPablo
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btniniciar = new System.Windows.Forms.PictureBox();
            this.btnapagar = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btniniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnapagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(189, 81);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(148, 15);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña.Location = new System.Drawing.Point(189, 139);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(148, 14);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.Tag = "1";
            this.txtcontraseña.UseSystemPasswordChar = true;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            this.txtcontraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontraseña_KeyDown);
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.Transparent;
            this.btniniciar.Image = global::Clinica_SanPablo.Properties.Resources.Encendido;
            this.btniniciar.Location = new System.Drawing.Point(367, 66);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(41, 35);
            this.btniniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btniniciar.TabIndex = 3;
            this.btniniciar.TabStop = false;
            this.toolTip1.SetToolTip(this.btniniciar, "Ingresar");
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            this.btniniciar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.btniniciar.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnapagar
            // 
            this.btnapagar.BackColor = System.Drawing.Color.Transparent;
            this.btnapagar.Image = global::Clinica_SanPablo.Properties.Resources.Apagado;
            this.btnapagar.Location = new System.Drawing.Point(367, 133);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(41, 35);
            this.btnapagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnapagar.TabIndex = 4;
            this.btnapagar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnapagar, "Salir");
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            this.btnapagar.MouseLeave += new System.EventHandler(this.btnapagar_MouseLeave);
            this.btnapagar.MouseHover += new System.EventHandler(this.btnapagar_MouseHover);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.LoguinBueno;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.btniniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnapagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.PictureBox btniniciar;
        private System.Windows.Forms.PictureBox btnapagar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}