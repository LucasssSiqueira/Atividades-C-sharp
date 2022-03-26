using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_02_n29
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
            int num = 0, cont = 1, soma = 0;

            do
            {
                num = x.Next(101);
                soma += num;
                ltx_imprimir.Items.Add(cont + " - " + num);
                cont++;
            } while (cont <= 100);

            ltx_imprimir.Items.Add("A soma dos números é: " + soma);



        }
    }
}
