using System.Globalization;

namespace CalculadoraDigital
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
                textResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para a soma.");
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") { 
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para a subtração.");
            }
        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") { 
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para a multiplicação.");
            }
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "") { 
            valor1 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            textResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
            }else
            {
                MessageBox.Show("Informe um valor para a divisão.");
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
    }
}