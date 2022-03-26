using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_10_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int valor_usuario = int.Parse(txt_valor.Text);
                double pares = 0, impares = 0;
                string sequencia_pares = "Sequencia de pares: ", sequencia_impares = "Sequencia de impares: ";
                for (int c = 1; c <= valor_usuario; c++)
                {
                    if (c % 2 == 0)
                    {
                        sequencia_pares += c + " ";
                    }
                    else
                    {
                        sequencia_impares += c + " ";
                    }
                }
              ltx_imprimir.Items.Add(sequencia_pares + "\n" + sequencia_impares);
            }
           
            finally
            {

            }
        }
    }
    }

