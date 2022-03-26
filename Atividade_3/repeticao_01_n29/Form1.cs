using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_01_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int cont = 1, num = 0, maior = 0, menor = 100;

            do
            {
                num = x.Next(100);
                if (num > maior)
                {
                    maior = num;
                } else if(num < menor)
                {
                    menor = num;
                }
                ltx_imprimir.Items.Add(num);
                cont++;
            } while (cont <= 10);

            ltx_imprimir.Items.Add("O maior número é: " + maior);
            ltx_imprimir.Items.Add("O menor número é: " + menor);
        }
    }
}
