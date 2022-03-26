using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe3_pag73_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] num = new int[50];
        int indice = 0, maior = 0;
        Random x = new Random();


        private void btn_calcular_Click(object sender, EventArgs e)
        {
            for(indice = 0; indice < 50; indice++)
            {
                num[indice] = x.Next(50);
                ltx_imprimir.Items.Add(num[indice]);
                if (num[indice] > maior)
                {
                    maior = num[indice];
                }

            }

            ltx_imprimir.Items.Add("O maior número é: " + maior);
        }
    }
}
