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
            
            double calculopis = calculo.CalculoPIS(valor1, pis);
            double calculoicms = calculo.CalculoPIS(valor1, icms);
            double calculoconfins = calculo.CalculoPIS(valor1, confins);

            if(comboBox1.Text == "LT" || comboBox1.Text == "KL")
            {
                double valor_produto = (calculo.Total(valor1, calculopis, calculoicms, calculoconfins, lucro1) + (calculo.Total(valor1, calculopis, calculoicms, calculoconfins, lucro1) * 0.05));
                Valor_Produto.Text = valor_produto.ToString("C2");
            }
            else
            {
                double valor_produto = (calculo.Total(valor1, calculopis, calculoicms, calculoconfins, lucro1));
                Valor_Produto.Text = valor_produto.ToString("C2");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
