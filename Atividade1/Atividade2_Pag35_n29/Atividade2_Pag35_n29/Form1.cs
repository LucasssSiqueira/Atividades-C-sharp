using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2_Pag35_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string nome, classe,codigo;
            int numero_hora, salario_hora, valor_total;

            nome = txt_nome.Text;
            classe = cbx__classe.Text;
            numero_hora = int.Parse(txt_horas.Text);
            codigo = txt_codigo.Text;
          



            switch (classe)
            {
                case "A":
                    salario_hora = 8;
                    valor_total = salario_hora * numero_hora * 21;
                    MessageBox.Show("O valor total do salário: " + valor_total.ToString("C"));
                    break;

                case "B":
                    salario_hora = 12;
                    valor_total = salario_hora * numero_hora * 21;
                    MessageBox.Show("O valor total do salário: " + valor_total.ToString("C"));
                    break;

                case "C":
                    salario_hora = 17;
                    valor_total = salario_hora * numero_hora * 21;
                    MessageBox.Show("O valor total do salário: " + valor_total.ToString("C"));
                    break;









            }








        }
    }
}
