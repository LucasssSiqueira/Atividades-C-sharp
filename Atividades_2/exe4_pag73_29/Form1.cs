using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe4_pag73_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] vetor = new int[200];
        int indice = 0, maior = int.MinValue, menor = int.MaxValue, posicao_menor = 0, cont_negativos = 0;
        double soma = 0, media = 0, cont_zeros = 0, porc_zeros = 0;
        Random x = new Random();
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            for (indice = 0; indice < 200; indice++)
            {
                vetor[indice] = x.Next(-100, 500);
                soma += vetor[indice];
                if(vetor[indice] > maior)
                {
                    maior = vetor[indice];
                }

                if (vetor[indice] < menor)
                {
                    menor = vetor[indice];
                    posicao_menor = indice;
                }

                if(vetor[indice] == 0)
                {
                    cont_zeros++;
                }

                if (vetor[indice] < 0)
                {
                    cont_negativos++;
                }
            }

            media = soma / 200;
            porc_zeros = cont_zeros / 200 * 100;

            ltx_imprimir.Items.Add("Soma: " + soma);
            ltx_imprimir.Items.Add("Média: " + media.ToString("0.00"));
            ltx_imprimir.Items.Add("Maior número: " + maior);
            ltx_imprimir.Items.Add("Menor número: " + menor);
            ltx_imprimir.Items.Add("Posição do Menor número: " + posicao_menor);
            ltx_imprimir.Items.Add("Quantidade de números 0: " + cont_zeros);
            ltx_imprimir.Items.Add("Porcentagtem dos números 0: " + porc_zeros.ToString("0.00") + "%");
            ltx_imprimir.Items.Add("Quantidade de números negativos: " + cont_negativos);
            ltx_imprimir.Items.Add("Posição dos números armazenados entre 100 e 200: " );
            for (indice = 0; indice < 200; indice++)
            {
                if(vetor[indice]> 100 && vetor[indice] < 200)
                {
                    ltx_imprimir.Items.Add(indice);
                }
            }
        }
    }
}
