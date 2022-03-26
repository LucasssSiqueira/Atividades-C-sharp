using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5_pag64_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double s = 0, numerador = 1, denominador = 2;

            for (denominador = 2; denominador <= 50; denominador++)

            if (denominador % 2 == 0)
            {
                s += (numerador / denominador);
                ltx_imprimir.Items.Add("+" + numerador + " / " + denominador);
            }
            else
            {
                s -= (numerador / denominador);
                ltx_imprimir.Items.Add("-" + numerador + " / " + denominador);
            }

            ltx_imprimir.Items.Add("O valor da soma é: " + s.ToString("0.000"));
        }
    }
}
