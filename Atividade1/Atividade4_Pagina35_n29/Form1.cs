using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4_Pagina35_n29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string matricula;
            double horas, horas_extras, valor_hora = 0, sal_bruto = 0, adicional = 0, inss = 0, sal_liquido = 0;
            matricula = txt_matricula.Text;
            horas = double.Parse(txt_hTrab.Text);
            horas_extras = double.Parse(txt_hExtra.Text);
            matricula = matricula.Substring(0, 1);

            switch (matricula)
            {
                case "1":
                    valor_hora = 8;
                    break;

                case "2":
                    valor_hora = 10;
                    break;

                case "3":
                    valor_hora = 12;
                    break;

                case "4":
                    valor_hora = 15;
                    break;

                case "5":
                    valor_hora = 20;
                    break;
             }
            sal_bruto = horas* valor_hora;
            adicional = horas_extras * valor_hora * 1.50;
            inss = sal_bruto * 0.11;
            sal_liquido = sal_bruto + adicional - inss;

            lbl_salBruto.Text = "Valor do sálario bruto: " + sal_bruto.ToString("C");
            lbl_hExtra.Text = "Valor do adicional de horas extras: " + adicional.ToString("C");
            lbl_inss.Text = "O desconto do INSS: " + inss.ToString("C");
            lbl_salLiq.Text = "O valor do sálario líquido é: " + sal_liquido.ToString("C");

        }
    }
}
