using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_09_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            
                ltx_imprimir.Items.Clear();
                double pares = 0, impares = 0, aleatorio = 0;
                Random random_class = new Random();
                while (true)
                {
                    aleatorio = random_class.Next(0, 1501);
                    if (aleatorio % 2 == 0)
                    {
                        pares += aleatorio;
                    ltx_imprimir.Items.Add(aleatorio + " - Par");
                    }
                    else
                    {
                        impares += aleatorio;
                    ltx_imprimir.Items.Add(aleatorio + " - Impar");
                    }
                    if (aleatorio > 1000)
                    {
                        break;
                    }
                }
            ltx_imprimir.Items.Add("A soma dos pares foi: " + pares + "\nA soma dos impares foi: " + impares);
            }
        }


    }
    

