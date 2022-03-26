using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe6_pag73_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] vetor = new int[31];
        int i = 0;
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
       
            //para fazer um vetor declarar em sequencia
            for ( i = 0; i < 30; i++)
            {
                vetor[i] = i + 1;
                ltx_imprimir.Items.Add(vetor[i]);
            }
             
        }

    }
}
