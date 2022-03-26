using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe5_pag73_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int[] vetor = new int[100];
        int indice = 0;
        double cont_zeros = 0;
        Random x = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            
            for ( indice = 0; indice < 100; indice++)
            {
                vetor[indice] = x.Next(-100 , 100);
                ltx_imprimir.Items.Add(vetor[indice]);

                if (vetor[indice] == 0)
                {
                    ltx_imprimir.Items.Add("Posição dos números iguais a zero "+indice);
                }

                

            }


        }
    }
}
