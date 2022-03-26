using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade1_Pagina35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string codigo, plano1, plano2, plano3, plano4;
            double valor_veiculo, valorTotal, valorJuros, valorParcela;

            codigo = cbx_codigo.Text;
            valor_veiculo = double.Parse(txt_valor.Text);
            plano1 = "A";
            plano2 = "B";
            plano3 = "C";
            plano4 = "D";
            valorJuros = 0;
            valorParcela = 0;
            valorTotal = valor_veiculo + valorJuros;

            switch (codigo)
            {
                case "Plano A":
                    codigo = plano1;
                    valorJuros = 0.70;
                    valorTotal = (valor_veiculo * valorJuros + valor_veiculo) * 24;
                    MessageBox.Show("Valor dos Juros: " + (valor_veiculo * valorJuros).ToString("C") + "/ "
                            + "Valor Total: " + valorTotal.ToString("C") + "/ "
                            + "Valor Parcelas: " + valor_veiculo / 24).ToString("C");
                    break;

                case "Plano B":
                    codigo = plano2;
                    valorJuros = 0.45;
                    valorTotal = (valor_veiculo * valorJuros + valor_veiculo) * 36;
                    MessageBox.Show("Valor dos Juros: " + (valor_veiculo * valorJuros).ToString("C") + "/ "
                             + "Valor Total: " + valorTotal.ToString("C") + "/ "
                             + "Valor Parcelas: " + valor_veiculo / 36).ToString("C");
                    break;

                case "Plano C":
                    codigo = plano3;
                    valorJuros = 0.25;
                    valorTotal = (valor_veiculo * valorJuros + valor_veiculo)* 48;
                    MessageBox.Show("Valor dos Juros: " + (valor_veiculo * valorJuros).ToString("C") + "/ "
                              + "Valor Total: " + valorTotal.ToString("C") + "/ "
                              + "Valor Parcelas: " + valor_veiculo / 48).ToString("C");
                    break;

                case "Plano D":
                    codigo = plano4;
                    valorJuros = 0.10;
                    valorTotal = (valor_veiculo * valorJuros + valor_veiculo) * 60;

                    MessageBox.Show("Valor dos Juros: " + (valor_veiculo * valorJuros - valorJuros).ToString("C") + "/ "
                               + "Valor Total: " + valorTotal.ToString("C") + "/ "
                               + "Valor Parcelas: " + valor_veiculo / 60).ToString("C");
                    break;
            }
        }
    }
}
