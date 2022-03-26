using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3_Pagina35_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnn_calcular_Click(object sender, EventArgs e)
        {
            string codigo;
            int qtd_comprada, preco_produto, preco_total;

            codigo = cbx_codigo.Text;
            qtd_comprada = int.Parse(txt_qtd.Text);
            preco_produto = 0;
            preco_total = preco_produto * qtd_comprada;

            switch (codigo)
            {
                case "AUTO":
                    preco_produto = 325;
                    preco_total = preco_produto * qtd_comprada;
                    MessageBox.Show("Preço total: " + preco_total.ToString("C"));
                    break;

                case "MOTO":
                    preco_produto = 102;
                    preco_total = preco_produto * qtd_comprada;
                    MessageBox.Show("Preço total: " + preco_total.ToString("C"));
                    break;

                case "BIKE":
                    preco_produto = 76;
                    preco_total = preco_produto * qtd_comprada;
                    MessageBox.Show("Preço total: " + preco_total.ToString("C"));
                    break;

                case "KLWE":
                    preco_produto = 176;
                    preco_total = preco_produto * qtd_comprada;
                    MessageBox.Show("Preço total: " + preco_total.ToString("C"));
                    break;

                case "WPDD":
                    preco_produto = 456;
                    preco_total = preco_produto * qtd_comprada;
                    MessageBox.Show("Preço total: " + preco_total.ToString("C"));
                    break;

                default:
                        MessageBox.Show("Código inválido");
                    break;



            }













        }
        }
}
