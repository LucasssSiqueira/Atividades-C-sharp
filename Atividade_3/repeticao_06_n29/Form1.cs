using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_06_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int a = 0, b = 1, c = 0, valor_usuario;
                    string sequencia = "A sequencia de fibonacci é: " + b;
                    valor_usuario = int.Parse(txt_n.Text);
                    for (int contador = 0; c < valor_usuario; c++)
                    {
                        c = a + b;
                        sequencia += ", " + c;
                        a = b;
                        b = c;
                    }
                    ltx_imprimir.Items.Add(sequencia);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Insira novamente o número!");
                }
                finally
                {
                    txt_n.Clear();
                }
            }
        }
    }
}
    

