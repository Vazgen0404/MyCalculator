using System;

namespace CommonLibrary
{
    class DivideOperation : IOperation2Operands
    {
        private const string _sign = "÷";
        public string Sign => _sign;
        private static DivideOperation _divideOperation;
        private DivideOperation()
        {

        }
        public static DivideOperation CreateOrGetInstance()
        {
            if (_divideOperation == null)
                _divideOperation = new DivideOperation();
            return _divideOperation;
        }
        public double Operate(double num1, double num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Can not divide by 0");

            return num1 / num2;
        }
    }
}
