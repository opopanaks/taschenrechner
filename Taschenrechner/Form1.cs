namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";

        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";

        }
        private void plusSymb_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void minusSymb_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void multSymb_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void divSymb_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void modSymb_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "%";
        }
        private void equalsSymb_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = operation(txtDisplay.Text);
        }

        public string operation(string text)
        {

            string symbol = null;

            if (text.Contains("*"))
            {
                symbol = "*";
            }
            else if (text.Contains("+"))
            {
                symbol = "+";
            }
            else if (text.Contains("-"))
            {
                symbol = "-";
            }
            else if (text.Contains("/"))
            {
                symbol = "/";
            }
            else if (text.Contains("%"))
            {
                symbol = "%";
            }

            if (!string.IsNullOrEmpty(symbol))
            {
                int index = txtDisplay.Text.IndexOf(symbol);


                decimal.TryParse(txtDisplay.Text.Substring(0, index), out decimal first);
                decimal.TryParse(txtDisplay.Text.Substring(index + 1), out decimal second);

               
                decimal result;
                switch (symbol)
                {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = first - second;
                        break;
                    case "*":
                        result = first * second;
                        break;
                    case "/":
                        if (second != 0)
                            result = first / second;
                        else
                            return "ERROR";
                        break;
                    case "%":
                        result = first % second;
                        break;
                    default:
                        return "ERROR";
                        break;
                }

                return result.ToString();
            }

            else { return ""; }
           

        }
        private void clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text ="";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1) { txtDisplay.Text = txtDisplay.Text.Substring(0,txtDisplay.Text.Length - 1); }
            else txtDisplay.Text = "";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
