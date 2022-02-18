using CommonLibrary;
using System;

namespace RootOperation
{
    class RootOperation : IOperation1Operand
    {
        private const string _sign = "√";
        public string Sign => _sign;
        public double Operate(double num)
        {
            return Math.Sqrt(num);
        }
    }
}
