using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Calculator
    {
        public double FirstOperand { get; set; }
        public double SecondOperand { get; set; }
        public double Result { get; set; }
        public bool IsExistFirstOperand { get; set; }
        public Dictionary<string, IOperation2Operands> Operations1 { get; set; }
        public Dictionary<string, IOperation1Operand> Operations2 { get; set; }

        public Calculator(Dictionary<string, IOperation2Operands> operations1, Dictionary<string, IOperation1Operand> operations2)
        {
            Operations1 = operations1;
            Operations2 = operations2;
            IsExistFirstOperand = false;
        }

    }
}