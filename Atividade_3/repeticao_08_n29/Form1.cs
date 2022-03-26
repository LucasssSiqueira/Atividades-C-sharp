using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_08_n29
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

            int num = 0, cont = 1, media = 0, maior = 0, menor = 0, soma = 0;

            for (cont =1; cont<=15; cont++)
            {
                num = x.Next(20);
                soma += num;
                ltx_imprimir.Items.Add(cont + " - " + num);

                if (num > maior)
                {
                    maior = num;
                }

                if(num < menor)
                {
                    menor = num;
                }
            }
            
            media = soma / 20;
            ltx_imprimir.Items.Add("A média é: "+ media);
            ltx_imprimir.Items.Add("O maior número é: "+ maior);
            ltx_imprimir.Items.Add("O menor número é: "+ menor);


        }
    }
}
