using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_03_n29
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
            int num = 0, soma = 0, cont = 1,number;
            number = int.Parse(txt_number.Text);

            do
            {
                num = x.Next(0, 100);
                if(num % 2 != 0) {
                    soma += num;
                }
                
                ltx_imprimir.Items.Add(cont + " - " + num);
                cont++;
            } while (cont <= number);

            ltx_imprimir.Items.Add("A soma dos números impares é: " + soma);
        }
    }
}
