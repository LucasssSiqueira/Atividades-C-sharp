using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_05_n29
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
            int cont = 1, num = 0, cont5 = 0;
            
            
            
            while (num != -1)
            {
                num = x.Next(-1, 101);
                ltx_imprimir.Items.Add(cont + " - " + num);
                cont++;

                if(num == -1)
                {
                    break;
                }

                if( num == 5)
                {
                    cont5++;
                }
            }
        }
    }
}
