using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe11_pag73_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int[] temperatura = new int[121];
            int indice = 0, maior = int.MinValue, menor = int.MaxValue;
            double media = 0, soma = 0;
            Random aleatorio = new Random();

            for (indice = 0; indice < 121; indice++)
            {
                temperatura[indice] = aleatorio.Next(-5, 45);

                if(temperatura[indice] > maior)
                {
                    maior = temperatura[indice];
                }

                if (temperatura[indice] < menor)
                {
                    menor = temperatura[indice];
                }
                 soma += temperatura[indice];

                for (indice = 0; indice < 121; indice++)
                {
                    ltx_imprimi.Items.Add(temperatura[indice]);

                }
               

                ltx_imprimi.Items.Add("A maior temperatura é: " + maior);
                ltx_imprimi.Items.Add("A menor temperatura é: " + menor);
                ltx_imprimi.Items.Add("A média das temperaturas é: " + media);
                ltx_imprimi.Items.Add("Dias em que a temperatura esteve abaixo da média: " );
                for (indice = 0; indice < 121; indice++)
                {
                    if (temperatura[indice] < media)
                    {
                        ltx_imprimi.Items.Add(indice);
                    }
                }

                media = soma / 121;

            }



        }
    }
}
