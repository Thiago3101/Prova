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
            if(unidade.Text == "")
            {
                MessageBox.Show("Nenhuma unidade foi selecionada");
            }
            else
            {
                Produto calculo = new Produto();
                calculo.id = codigo.Text;
                calculo.unidade = unidade.Text;
                calculo.descricao = descricao.Text;
                calculo.valor = Convert.ToDouble(valor.Text);
                calculo.pis = Convert.ToDouble(PIS.Text);
                calculo.icms = Convert.ToDouble(ICMS.Text);
                calculo.confins = Convert.ToDouble(CONFINS.Text);
                calculo.lucro = Convert.ToDouble(lucro.Text);

                double calculopis = calculo.CalculoPIS(calculo.valor, calculo.pis);
                double calculoicms = calculo.CalculoPIS(calculo.valor, calculo.icms);
                double calculoconfins = calculo.CalculoPIS(calculo.valor, calculo.confins);

                if (unidade.Text == "LT" || unidade.Text == "KL")
                {
                    double valor_produto = (calculo.Total(calculo.valor, calculopis, calculoicms, calculoconfins, calculo.lucro) + (calculo.Total(calculo.valor, calculopis, calculoicms, calculoconfins, calculo.lucro) * 0.05));
                    Valor_Produto.Text = valor_produto.ToString("C2");

                    calculo.valorTotal = valor_produto;
                }
                else
                {
                    double valor_produto = (calculo.Total(calculo.valor, calculopis, calculoicms, calculoconfins, calculo.lucro));
                    Valor_Produto.Text = valor_produto.ToString("C2");

                    calculo.valorTotal = valor_produto;
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
