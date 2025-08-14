namespace Ejercicio2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Pnl_BtnCerrar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Pbx_Restaurar = new System.Windows.Forms.PictureBox();
            this.Pbx_Maximizar = new System.Windows.Forms.PictureBox();
            this.Pbx_Minimizar = new System.Windows.Forms.PictureBox();
            this.Pbx_Cerrar = new System.Windows.Forms.PictureBox();
            this.Btn_IniciarViaje = new BotónPastilla.Models.Class.BtnPastilla();
            this.Btn_IngresarParada = new BotónPastilla.Models.Class.BtnPastilla();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Hora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_Minutos = new System.Windows.Forms.TextBox();
            this.Btn_FinViaje = new BotónPastilla.Models.Class.BtnPastilla();
            this.Pnl_BtnCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Cerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_BtnCerrar
            // 
            this.Pnl_BtnCerrar.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnl_BtnCerrar.Controls.Add(this.pictureBox1);
            this.Pnl_BtnCerrar.Controls.Add(this.label7);
            this.Pnl_BtnCerrar.Controls.Add(this.Pbx_Restaurar);
            this.Pnl_BtnCerrar.Controls.Add(this.Pbx_Maximizar);
            this.Pnl_BtnCerrar.Controls.Add(this.Pbx_Minimizar);
            this.Pnl_BtnCerrar.Controls.Add(this.Pbx_Cerrar);
            this.Pnl_BtnCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_BtnCerrar.Location = new System.Drawing.Point(0, 0);
            this.Pnl_BtnCerrar.Name = "Pnl_BtnCerrar";
            this.Pnl_BtnCerrar.Size = new System.Drawing.Size(474, 40);
            this.Pnl_BtnCerrar.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Empresa de Viajes";
            // 
            // Pbx_Restaurar
            // 
            this.Pbx_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Restaurar.Image")));
            this.Pbx_Restaurar.Location = new System.Drawing.Point(405, 6);
            this.Pbx_Restaurar.Name = "Pbx_Restaurar";
            this.Pbx_Restaurar.Size = new System.Drawing.Size(28, 28);
            this.Pbx_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Restaurar.TabIndex = 3;
            this.Pbx_Restaurar.TabStop = false;
            this.Pbx_Restaurar.Visible = false;
            this.Pbx_Restaurar.Click += new System.EventHandler(this.Pbx_Restaurar_Click);
            // 
            // Pbx_Maximizar
            // 
            this.Pbx_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Maximizar.Image")));
            this.Pbx_Maximizar.Location = new System.Drawing.Point(406, 6);
            this.Pbx_Maximizar.Name = "Pbx_Maximizar";
            this.Pbx_Maximizar.Size = new System.Drawing.Size(28, 28);
            this.Pbx_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Maximizar.TabIndex = 2;
            this.Pbx_Maximizar.TabStop = false;
            this.Pbx_Maximizar.Click += new System.EventHandler(this.Pbx_Maximizar_Click);
            // 
            // Pbx_Minimizar
            // 
            this.Pbx_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Minimizar.Image")));
            this.Pbx_Minimizar.Location = new System.Drawing.Point(371, 6);
            this.Pbx_Minimizar.Name = "Pbx_Minimizar";
            this.Pbx_Minimizar.Size = new System.Drawing.Size(28, 28);
            this.Pbx_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Minimizar.TabIndex = 1;
            this.Pbx_Minimizar.TabStop = false;
            this.Pbx_Minimizar.Click += new System.EventHandler(this.Pbx_Minimizar_Click);
            // 
            // Pbx_Cerrar
            // 
            this.Pbx_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Cerrar.Image")));
            this.Pbx_Cerrar.Location = new System.Drawing.Point(440, 6);
            this.Pbx_Cerrar.Name = "Pbx_Cerrar";
            this.Pbx_Cerrar.Size = new System.Drawing.Size(28, 28);
            this.Pbx_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Cerrar.TabIndex = 0;
            this.Pbx_Cerrar.TabStop = false;
            this.Pbx_Cerrar.Click += new System.EventHandler(this.Pbx_Cerrar_Click);
            // 
            // Btn_IniciarViaje
            // 
            this.Btn_IniciarViaje.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_IniciarViaje.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_IniciarViaje.BorderRadius = 40;
            this.Btn_IniciarViaje.BorderSize = 0;
            this.Btn_IniciarViaje.FlatAppearance.BorderSize = 0;
            this.Btn_IniciarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_IniciarViaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IniciarViaje.ForeColor = System.Drawing.Color.White;
            this.Btn_IniciarViaje.Location = new System.Drawing.Point(12, 67);
            this.Btn_IniciarViaje.Name = "Btn_IniciarViaje";
            this.Btn_IniciarViaje.Size = new System.Drawing.Size(445, 48);
            this.Btn_IniciarViaje.TabIndex = 16;
            this.Btn_IniciarViaje.Text = "&Iniciar Viaje";
            this.Btn_IniciarViaje.UseVisualStyleBackColor = false;
            // 
            // Btn_IngresarParada
            // 
            this.Btn_IngresarParada.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_IngresarParada.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_IngresarParada.BorderRadius = 40;
            this.Btn_IngresarParada.BorderSize = 0;
            this.Btn_IngresarParada.FlatAppearance.BorderSize = 0;
            this.Btn_IngresarParada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_IngresarParada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IngresarParada.ForeColor = System.Drawing.Color.White;
            this.Btn_IngresarParada.Location = new System.Drawing.Point(12, 141);
            this.Btn_IngresarParada.Name = "Btn_IngresarParada";
            this.Btn_IngresarParada.Size = new System.Drawing.Size(445, 48);
            this.Btn_IngresarParada.TabIndex = 17;
            this.Btn_IngresarParada.Text = "&Ingresar Parada";
            this.Btn_IngresarParada.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_FinViaje);
            this.groupBox1.Controls.Add(this.Tbx_Minutos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbx_Hora);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 167);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finalizar Parada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Finalización (HH:mm):";
            // 
            // Tbx_Hora
            // 
            this.Tbx_Hora.Location = new System.Drawing.Point(266, 49);
            this.Tbx_Hora.Name = "Tbx_Hora";
            this.Tbx_Hora.Size = new System.Drawing.Size(49, 27);
            this.Tbx_Hora.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // Tbx_Minutos
            // 
            this.Tbx_Minutos.Location = new System.Drawing.Point(341, 49);
            this.Tbx_Minutos.Name = "Tbx_Minutos";
            this.Tbx_Minutos.Size = new System.Drawing.Size(49, 27);
            this.Tbx_Minutos.TabIndex = 3;
            // 
            // Btn_FinViaje
            // 
            this.Btn_FinViaje.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_FinViaje.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_FinViaje.BorderRadius = 40;
            this.Btn_FinViaje.BorderSize = 0;
            this.Btn_FinViaje.FlatAppearance.BorderSize = 0;
            this.Btn_FinViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FinViaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FinViaje.ForeColor = System.Drawing.Color.White;
            this.Btn_FinViaje.Location = new System.Drawing.Point(185, 102);
            this.Btn_FinViaje.Name = "Btn_FinViaje";
            this.Btn_FinViaje.Size = new System.Drawing.Size(243, 48);
            this.Btn_FinViaje.TabIndex = 18;
            this.Btn_FinViaje.Text = "&Finalizar Viaje";
            this.Btn_FinViaje.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(474, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_IngresarParada);
            this.Controls.Add(this.Btn_IniciarViaje);
            this.Controls.Add(this.Pnl_BtnCerrar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Pnl_BtnCerrar.ResumeLayout(false);
            this.Pnl_BtnCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Cerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Pbx_Restaurar;
        private System.Windows.Forms.PictureBox Pbx_Maximizar;
        private System.Windows.Forms.PictureBox Pbx_Minimizar;
        private System.Windows.Forms.PictureBox Pbx_Cerrar;
        private BotónPastilla.Models.Class.BtnPastilla Btn_IniciarViaje;
        private BotónPastilla.Models.Class.BtnPastilla Btn_IngresarParada;
        private System.Windows.Forms.GroupBox groupBox1;
        private BotónPastilla.Models.Class.BtnPastilla Btn_FinViaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Tbx_Minutos;
        public System.Windows.Forms.TextBox Tbx_Hora;
    }
}

