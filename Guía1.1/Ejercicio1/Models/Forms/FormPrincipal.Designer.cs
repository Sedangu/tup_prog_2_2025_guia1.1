namespace Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbx_Marca = new System.Windows.Forms.TextBox();
            this.NuUpD_Modelo = new System.Windows.Forms.NumericUpDown();
            this.NuUpD_AnoCalcular = new System.Windows.Forms.NumericUpDown();
            this.Tbx_ValorFab = new System.Windows.Forms.TextBox();
            this.Tbx_TasaDep = new System.Windows.Forms.TextBox();
            this.Tbx_VidaUtil = new System.Windows.Forms.TextBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Pnl_BtnCerrar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Pbx_Restaurar = new System.Windows.Forms.PictureBox();
            this.Pbx_Maximizar = new System.Windows.Forms.PictureBox();
            this.Pbx_Minimizar = new System.Windows.Forms.PictureBox();
            this.Pbx_Cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NuUpD_Modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuUpD_AnoCalcular)).BeginInit();
            this.Pnl_BtnCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modelo (Año):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Año a Calcular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor de Fabricación $:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tasa de depreciación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Vida Útil(años):";
            // 
            // Tbx_Marca
            // 
            this.Tbx_Marca.ForeColor = System.Drawing.Color.Blue;
            this.Tbx_Marca.Location = new System.Drawing.Point(222, 66);
            this.Tbx_Marca.Name = "Tbx_Marca";
            this.Tbx_Marca.Size = new System.Drawing.Size(100, 27);
            this.Tbx_Marca.TabIndex = 1;
            // 
            // NuUpD_Modelo
            // 
            this.NuUpD_Modelo.ForeColor = System.Drawing.Color.Blue;
            this.NuUpD_Modelo.Location = new System.Drawing.Point(222, 120);
            this.NuUpD_Modelo.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.NuUpD_Modelo.Name = "NuUpD_Modelo";
            this.NuUpD_Modelo.Size = new System.Drawing.Size(120, 27);
            this.NuUpD_Modelo.TabIndex = 2;
            // 
            // NuUpD_AnoCalcular
            // 
            this.NuUpD_AnoCalcular.ForeColor = System.Drawing.Color.Blue;
            this.NuUpD_AnoCalcular.Location = new System.Drawing.Point(222, 176);
            this.NuUpD_AnoCalcular.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.NuUpD_AnoCalcular.Name = "NuUpD_AnoCalcular";
            this.NuUpD_AnoCalcular.Size = new System.Drawing.Size(120, 27);
            this.NuUpD_AnoCalcular.TabIndex = 3;
            // 
            // Tbx_ValorFab
            // 
            this.Tbx_ValorFab.ForeColor = System.Drawing.Color.Blue;
            this.Tbx_ValorFab.Location = new System.Drawing.Point(222, 236);
            this.Tbx_ValorFab.Name = "Tbx_ValorFab";
            this.Tbx_ValorFab.Size = new System.Drawing.Size(100, 27);
            this.Tbx_ValorFab.TabIndex = 4;
            // 
            // Tbx_TasaDep
            // 
            this.Tbx_TasaDep.ForeColor = System.Drawing.Color.Blue;
            this.Tbx_TasaDep.Location = new System.Drawing.Point(573, 66);
            this.Tbx_TasaDep.Name = "Tbx_TasaDep";
            this.Tbx_TasaDep.Size = new System.Drawing.Size(100, 27);
            this.Tbx_TasaDep.TabIndex = 5;
            // 
            // Tbx_VidaUtil
            // 
            this.Tbx_VidaUtil.ForeColor = System.Drawing.Color.Blue;
            this.Tbx_VidaUtil.Location = new System.Drawing.Point(573, 119);
            this.Tbx_VidaUtil.Name = "Tbx_VidaUtil";
            this.Tbx_VidaUtil.Size = new System.Drawing.Size(100, 27);
            this.Tbx_VidaUtil.TabIndex = 6;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Calcular.Location = new System.Drawing.Point(24, 298);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(160, 53);
            this.Btn_Calcular.TabIndex = 7;
            this.Btn_Calcular.Text = "Calcular Costo";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Location = new System.Drawing.Point(513, 298);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(160, 53);
            this.Btn_Cerrar.TabIndex = 8;
            this.Btn_Cerrar.Text = "&Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
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
            this.Pnl_BtnCerrar.Size = new System.Drawing.Size(700, 40);
            this.Pnl_BtnCerrar.TabIndex = 14;
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
            this.label7.Size = new System.Drawing.Size(182, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tasación de Motos";
            // 
            // Pbx_Restaurar
            // 
            this.Pbx_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Restaurar.Image")));
            this.Pbx_Restaurar.Location = new System.Drawing.Point(631, 6);
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
            this.Pbx_Maximizar.Location = new System.Drawing.Point(632, 6);
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
            this.Pbx_Minimizar.Location = new System.Drawing.Point(597, 6);
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
            this.Pbx_Cerrar.Location = new System.Drawing.Point(666, 6);
            this.Pbx_Cerrar.Name = "Pbx_Cerrar";
            this.Pbx_Cerrar.Size = new System.Drawing.Size(28, 28);
            this.Pbx_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Cerrar.TabIndex = 0;
            this.Pbx_Cerrar.TabStop = false;
            this.Pbx_Cerrar.Click += new System.EventHandler(this.Pbx_Cerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 362);
            this.Controls.Add(this.Pnl_BtnCerrar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Tbx_VidaUtil);
            this.Controls.Add(this.Tbx_TasaDep);
            this.Controls.Add(this.Tbx_ValorFab);
            this.Controls.Add(this.NuUpD_AnoCalcular);
            this.Controls.Add(this.NuUpD_Modelo);
            this.Controls.Add(this.Tbx_Marca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasación de Motos";
            ((System.ComponentModel.ISupportInitialize)(this.NuUpD_Modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuUpD_AnoCalcular)).EndInit();
            this.Pnl_BtnCerrar.ResumeLayout(false);
            this.Pnl_BtnCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tbx_Marca;
        private System.Windows.Forms.NumericUpDown NuUpD_Modelo;
        private System.Windows.Forms.NumericUpDown NuUpD_AnoCalcular;
        private System.Windows.Forms.TextBox Tbx_ValorFab;
        private System.Windows.Forms.TextBox Tbx_TasaDep;
        private System.Windows.Forms.TextBox Tbx_VidaUtil;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Panel Pnl_BtnCerrar;
        private System.Windows.Forms.PictureBox Pbx_Maximizar;
        private System.Windows.Forms.PictureBox Pbx_Minimizar;
        private System.Windows.Forms.PictureBox Pbx_Cerrar;
        private System.Windows.Forms.PictureBox Pbx_Restaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}

