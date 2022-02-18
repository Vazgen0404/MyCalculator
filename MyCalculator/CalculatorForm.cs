using System;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            tbText.Text += bt.Text;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            number1 = 0;
            number2 = 0;
            operation = "";
            result = "";
            isValid = false;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length > 0)
                tbText.Text = tbText.Text.Remove(tbText.Text.Length - 1);
        }

        private void btOperation_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length > 0)
            {
                Button bt = (Button)sender;
                if (operation == "")
                {
                    number1 = Convert.ToDouble(tbText.Text);
                    isValid = true;
                }
                else
                {
                    switch (operation)
                    {
                        case "+":
                            number1 += Convert.ToDouble(tbText.Text);
                            break;
                        case "-":
                            number1 -= Convert.ToDouble(tbText.Text);
                            break;
                        case "x":
                            number1 *= Convert.ToDouble(tbText.Text);
                            break;
                        case "÷":
                            try
                            {
                                number1 /= Convert.ToDouble(tbText.Text);
                            }
                            catch (Exception)
                            {
                                tbText.Text = "Cannot divide by zero";
                            }
                            break;
                    }
                }
                operation = bt.Text;
                tbText.Clear();
            }
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            if (isValid)
            {
                if (tbText.Text.Length > 0)
                {
                    number2 = Convert.ToDouble(tbText.Text);
                    tbText.Clear();
                    isValid = false;
                    switch (operation)
                    {
                        case "+":
                            result = (number1 + number2).ToString();
                            break;
                        case "-":
                            result = (number1 - number2).ToString();
                            break;
                        case "x":
                            result = (number1 * number2).ToString();
                            break;
                        case "÷":
                            if (number2 != 0)
                            {
                                result = (number1 / number2).ToString();
                            }
                            else result = "Cannot divide by zero";
                            break;
                        default:
                            break;
                    }
                    tbText.Text = result;
                }
                else
                {
                    tbText.Text = number1.ToString();
                }
                operation = "";
            }
        }

        private void btPoint_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length > 0 && (!tbText.Text.Contains(".")))
            {
                tbText.Text += ".";
            }
        }

        private void btRoot_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length > 0)
            {
                tbText.Text = Math.Sqrt(Convert.ToDouble(tbText.Text)).ToString();
            }
        }

        private void btSign_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Length > 0)
            {
                if (tbText.Text[0] == '-')
                {
                    tbText.Text = tbText.Text.Remove(0, 1);
                }
                else tbText.Text = tbText.Text.Insert(0, "-");
            }
        }

        
    }
}
