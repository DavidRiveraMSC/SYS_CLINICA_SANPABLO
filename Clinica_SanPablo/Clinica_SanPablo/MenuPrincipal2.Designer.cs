namespace Clinica_SanPablo
{
    partial class MenuPrincipal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnopciones = new System.Windows.Forms.PictureBox();
            this.btnacercade = new System.Windows.Forms.PictureBox();
            this.btnmedicamento = new System.Windows.Forms.PictureBox();
            this.btnPaciente = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConexion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.TimerActualizar = new System.Windows.Forms.Timer(this.components);
            this.TiempoOpacidad = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEventos = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnopciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnacercade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnopciones);
            this.panel2.Controls.Add(this.btnacercade);
            this.panel2.Controls.Add(this.btnmedicamento);
            this.panel2.Controls.Add(this.btnPaciente);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(119, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 110);
            this.panel2.TabIndex = 6;
            // 
            // btnopciones
            // 
            this.btnopciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnopciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnopciones.BackgroundImage")));
            this.btnopciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnopciones.Location = new System.Drawing.Point(771, 6);
            this.btnopciones.Name = "btnopciones";
            this.btnopciones.Size = new System.Drawing.Size(97, 87);
            this.btnopciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnopciones.TabIndex = 11;
            this.btnopciones.TabStop = false;
            this.btnopciones.Click += new System.EventHandler(this.btnopciones_Click);
            this.btnopciones.MouseLeave += new System.EventHandler(this.btnopciones_MouseLeave);
            this.btnopciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnopciones_MouseMove);
            // 
            // btnacercade
            // 
            this.btnacercade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnacercade.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.Ayuda;
            this.btnacercade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnacercade.Location = new System.Drawing.Point(613, 6);
            this.btnacercade.Name = "btnacercade";
            this.btnacercade.Size = new System.Drawing.Size(97, 87);
            this.btnacercade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnacercade.TabIndex = 9;
            this.btnacercade.TabStop = false;
            this.btnacercade.Click += new System.EventHandler(this.btnacercade_Click);
            this.btnacercade.MouseLeave += new System.EventHandler(this.btnacercade_MouseLeave);
            this.btnacercade.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnacercade_MouseMove);
            // 
            // btnmedicamento
            // 
            this.btnmedicamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmedicamento.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.botiquin;
            this.btnmedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmedicamento.Location = new System.Drawing.Point(424, 1);
            this.btnmedicamento.Name = "btnmedicamento";
            this.btnmedicamento.Size = new System.Drawing.Size(114, 107);
            this.btnmedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmedicamento.TabIndex = 8;
            this.btnmedicamento.TabStop = false;
            this.btnmedicamento.Click += new System.EventHandler(this.btnmedicamento_Click);
            this.btnmedicamento.MouseLeave += new System.EventHandler(this.btnbuscar_MouseLeave);
            this.btnmedicamento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnbuscar_MouseMove);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPaciente.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.Paciente;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaciente.Location = new System.Drawing.Point(251, 6);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(97, 87);
            this.btnPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPaciente.TabIndex = 7;
            this.btnPaciente.TabStop = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click_1);
            this.btnPaciente.MouseLeave += new System.EventHandler(this.btnPaciente_MouseLeave);
            this.btnPaciente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPaciente_MouseMove_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(147)))), ((int)(((byte)(157)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnConexion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.lblhora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 50);
            this.panel1.TabIndex = 7;
            // 
            // btnConexion
            // 
            this.btnConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConexion.BackColor = System.Drawing.Color.Transparent;
            this.btnConexion.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.Conexion2;
            this.btnConexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConexion.Location = new System.Drawing.Point(914, 10);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(30, 30);
            this.btnConexion.TabIndex = 6;
            this.btnConexion.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(202)))), ((int)(((byte)(188)))));
            this.btnminimizar.Location = new System.Drawing.Point(950, 5);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 35);
            this.btnminimizar.TabIndex = 11;
            this.btnminimizar.Text = "-";
            this.btnminimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnminimizar.UseVisualStyleBackColor = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click_1);
            // 
            // lblusuario
            // 
            this.lblusuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblusuario.Location = new System.Drawing.Point(493, 15);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(51, 20);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "label1";
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(202)))), ((int)(((byte)(188)))));
            this.btnsalir.Location = new System.Drawing.Point(986, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(30, 35);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(795, 15);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(51, 20);
            this.lblfecha.TabIndex = 3;
            this.lblfecha.Text = "label1";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(31, 15);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(51, 20);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "label1";
            // 
            // TimerActualizar
            // 
            this.TimerActualizar.Enabled = true;
            this.TimerActualizar.Interval = 1000;
            this.TimerActualizar.Tick += new System.EventHandler(this.TimerActualizar_Tick_1);
            // 
            // TiempoOpacidad
            // 
            this.TiempoOpacidad.Tick += new System.EventHandler(this.TiempoOpacidad_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 70;
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnEventos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEventos.BackgroundImage")));
            this.btnEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEventos.Location = new System.Drawing.Point(25, 339);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(218, 200);
            this.btnEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEventos.TabIndex = 8;
            this.btnEventos.TabStop = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            this.btnEventos.MouseLeave += new System.EventHandler(this.btnEventos_MouseLeave);
            this.btnEventos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEventos_MouseMove);
            // 
            // MenuPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Clinica_SanPablo.Properties.Resources.Fondo_Clinica_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 661);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal2";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnopciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnacercade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnopciones;
        private System.Windows.Forms.PictureBox btnacercade;
        private System.Windows.Forms.PictureBox btnmedicamento;
        private System.Windows.Forms.PictureBox btnPaciente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer TimerActualizar;
        private System.Windows.Forms.Timer TiempoOpacidad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnEventos;
    }
}