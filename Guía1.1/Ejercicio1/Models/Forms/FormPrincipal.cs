using Ejercicio1.Models.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Pbx_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region //// Funcionalidades de los Botónes ////

        private void Pbx_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Pbx_Maximizar.Visible = false;
            Pbx_Restaurar.Visible = true;
        }

        private void Pbx_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            Pbx_Maximizar.Visible = true;
            Pbx_Restaurar.Visible = false;
        }

        private void Pbx_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            FormResultado vResultado = new FormResultado();

            if (vResultado.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
