using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAyres
{
    public partial class FrmCalculadora : Form
    {
        double conta = 0, tipo = 0;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double botao = 1;
            Resultado_Text.Text += botao.ToString();
        }

        private void buttonsoma_Click(object sender, EventArgs e)
        {
            buttonsoma.Enabled = false;
            buttonmenos.Enabled = false;
            buttonvezes.Enabled = false;
            buttondivisão.Enabled = false;
            conta = Convert.ToDouble(Resultado_Text.Text);
            Resultado_Text.Text = "";
            tipo = 1;
        }

        private void buttonenter_Click(object sender, EventArgs e)
        {
            buttonvezes.Enabled = true;
            buttonmenos.Enabled = true;
            buttonsoma.Enabled = true;
            buttondivisão.Enabled = true;
            double resultado = 0;
            if(Resultado_Text.Text == "")
            {
                MessageBox.Show("digite o segundo número");
                buttonsoma.Enabled = false;
                buttonmenos.Enabled = false;
                buttonvezes.Enabled = false;
                buttondivisão.Enabled = false;
                return;

            }

            if (tipo == 1)
            {
                resultado = conta + Convert.ToDouble(Resultado_Text.Text);
                Resultado_Text.Text = resultado.ToString();
            }
            if (tipo == 2)
            {
                resultado = conta - Convert.ToDouble(Resultado_Text.Text);
                Resultado_Text.Text = resultado.ToString();
            }
            if (tipo == 3)
            {
                resultado = conta * Convert.ToDouble(Resultado_Text.Text);
                Resultado_Text.Text = resultado.ToString();
            }
            if (tipo == 4)
            {
                resultado = conta / Convert.ToDouble(Resultado_Text.Text);
                Resultado_Text.Text = resultado.ToString();
            }
            conta = Convert.ToDouble(Resultado_Text.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Resultado_Text.Text = "";
            conta = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double botao = 2;
            Resultado_Text.Text += botao.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double botao = 3;
            Resultado_Text.Text += botao.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double botao = 4;
            Resultado_Text.Text += botao.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double botao = 5;
            Resultado_Text.Text += botao.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double botao = 6;
            Resultado_Text.Text += botao.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double botao = 7;
            Resultado_Text.Text += botao.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double botao = 8;
            Resultado_Text.Text += botao.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double botao = 9;
            Resultado_Text.Text += botao.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            double botao = 0;
            Resultado_Text.Text += botao.ToString();
        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            buttonmenos.Enabled = false;
            buttonsoma.Enabled = false;
            buttonvezes.Enabled = false;
            buttondivisão.Enabled = false;
            conta = Convert.ToDouble(Resultado_Text.Text);
            Resultado_Text.Text = "";
            tipo = 2;
        }

        private void buttonvezes_Click(object sender, EventArgs e)
        {
            buttonvezes.Enabled = false;
            buttonmenos.Enabled = false;
            buttonsoma.Enabled = false;
            buttondivisão.Enabled = false;
            conta = Convert.ToDouble(Resultado_Text.Text);
            Resultado_Text.Text = "";
            tipo = 3;
        }

        private void buttondivisão_Click(object sender, EventArgs e)
        {
            buttondivisão.Enabled = false;
            buttonmenos.Enabled = false;
            buttonvezes.Enabled = false;
            buttonsoma.Enabled = false;
            conta = Convert.ToDouble(Resultado_Text.Text);
            Resultado_Text.Text = "";
            tipo = 4;
        }
    }
}
