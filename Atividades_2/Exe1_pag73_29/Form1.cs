using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1_pag73_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] num = new int[5];
        int indice = 0;
        Random ale = new Random();
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            for (indice = 0; indice < 5; indice++)
            {
                num[indice] = ale.Next(100);
                ltx_imprimir.Items.Add(num[indice]);
            }

            ltx_imprimir.Items.Clear();
        }
    }
}
