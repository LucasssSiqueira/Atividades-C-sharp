using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe9_pag73_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] vetor = new int[200];
        int indice = 0;
        double maior = 0, media = 0, menor = 0, soma = 0;
        Random x = new Random();
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            for (indice = 0; indice < 100; indice++)
            {
                vetor[indice] = x.Next(1,100);
                soma += vetor[indice];
                ltx_imprimir.Items.Add(vetor[indice]);
                if (vetor[indice] > maior)
                {
                    maior = vetor[indice];
                }

                if (vetor[indice] < menor)
                {
                    menor = vetor[indice];
                }

                media = soma / 100;
            
            }
            ltx_imprimir.Items.Add("A média dos números é: " + media);
            ltx_imprimir.Items.Add("O menor número é: " + menor);
            ltx_imprimir.Items.Add("O maior número é: " + maior);

        }
    }
}
