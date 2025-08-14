using Ejercicio1.Models.Class;
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
            string marca = Tbx_Marca.Text;
            int modelo = Convert.ToInt32(NuUpD_Modelo.Value);
            int añoACalcular = Convert.ToInt32(NuUpD_AnoCalcular.Value);
            double valorFabrica = Convert.ToDouble(Tbx_ValorFab.Text);
            int vidaUtil = Convert.ToInt32(Tbx_VidaUtil.Text);
            double tasaDepreciacion = Convert.ToDouble(Tbx_TasaDep.Text);

            Moto moto = new Moto(marca, modelo, valorFabrica);

            FormResultado vResultado = new FormResultado();

            vResultado.Lbx_Resultado.Items.Add(moto.VerDescripcion());

            double valorLineal = moto.DepreciacionLineal(añoACalcular, vidaUtil);
            vResultado.Lbx_Resultado.Items.Add($"Depreciación lineal: ${valorLineal,10:f2}");

            double valorAnual = moto.DepreciacionAnual(añoACalcular, tasaDepreciacion);
            vResultado.Lbx_Resultado.Items.Add($"Depreciación anual: ${valorAnual,10:f2}");

            vResultado.ShowDialog();
            
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
