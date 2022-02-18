using System;
using System.Windows.Forms;
using CommonLibrary;

namespace MyCalculator
{
    public partial class CalculatorForm : Form
    {
        private Calculator Calculator { get; set; }
        private IOperation2Operands Operation2Operands { get; set; }
        private IOperation1Operand Operation1Operand { get; set; }

        public CalculatorForm()
        {
            InitializeComponent();
            Calculator = new CalculatorCreator().CreateCalculator();
        }

        private void btNumber_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            tbText.Text += bt.Text;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            Operation2Operands = null;
            Calculator.FirstOperand = 0;
            Calculator.SecondOperand = 0;
            Calculator.Result = 0;
            Calculator.IsExistFirstOperand = false;
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
                if (Operation2Operands == null)
                {
                    Calculator.FirstOperand = Convert.ToDouble(tbText.Text);
                    Calculator.IsExistFirstOperand = true;
                }
                else
                {
                    Calculator.SecondOperand = Convert.ToDouble(tbText.Text);
                    Calculator.FirstOperand = Operation2Operands.Operate(Calculator.FirstOperand, Calculator.SecondOperand);
                }

                Operation2Operands = Calculator.Operations1[bt.Text];
                tbText.Clear() ;
            }
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            if (Calculator.IsExistFirstOperand)
            {
                if (tbText.Text.Length > 0)
                {
                    Calculator.SecondOperand = Convert.ToDouble(tbText.Text);
                    tbText.Clear();
                    Calculator.IsExistFirstOperand = false;
                    Calculator.Result = Operation2Operands.Operate(Calculator.FirstOperand, Calculator.SecondOperand);
                    tbText.Text = Calculator.Result.ToString();
                }
                else
                {
                    tbText.Text = Calculator.FirstOperand.ToString();
                }
                Operation2Operands = null;
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
                Button bt = (Button)sender;
                Operation1Operand = Calculator.Operations2[bt.Text];
                tbText.Text = Operation1Operand.Operate(Convert.ToDouble(tbText.Text)).ToString();
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
