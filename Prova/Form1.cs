using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
                
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(valor.Text);
            double pis = Convert.ToDouble(PIS.Text);
            double icms = Convert.ToDouble(ICMS.Text);
            double confins = Convert.ToDouble(CONFINS.Text);
            double lucro1 = Convert.ToDouble(lucro.Text);


            Produto calculo = new Produto();
            calculo.id = codigo.Text;
            calculo.unidade = unidade.Text;
            calculo.descricao = descricao.Text;
            calculo.valor = Convert.ToDouble(valor.Text);
            calculo.pis = Convert.ToDouble(PIS.Text);
            calculo.icms = Convert.ToDouble(ICMS.Text);
            calculo.confins = Convert.ToDouble(CONFINS.Text);
            calculo.lucro = Convert.ToDouble(lucro.Text);

            double calculopis = calculo.CalculoPIS(valor1, pis);
            double calculoicms = calculo.CalculoPIS(valor1, icms);
            double calculoconfins = calculo.CalculoPIS(valor1, confins);

            if(unidade.Text == "LT" || unidade.Text == "KL")
            {
                double valor_produto = (calculo.Total(valor1, calculopis, calculoicms, calculoconfins, lucro1) + (calculo.Total(valor1, calculopis, calculoicms, calculoconfins, lucro1) * 0.05));
                Valor_Produto.Text = valor_produto.ToString("C2");

                calculo.valorTotal = valor_produto;
            }
            else
            {
                double valor_produto = (calculo.Total(valor1, calculopis, calculoicms, calculoconfins, lucro1));
                Valor_Produto.Text = valor_produto.ToString("C2");

                calculo.valorTotal = valor_produto;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
