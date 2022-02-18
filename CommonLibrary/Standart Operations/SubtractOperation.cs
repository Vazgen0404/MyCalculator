namespace CommonLibrary
{
    class SubtractOperation : IOperation2Operands
    {
        private const string _sign = "-";
        public string Sign => _sign;
        private static SubtractOperation _subtractOperation;
        private SubtractOperation()
        {

        }
        public static SubtractOperation CreateOrGetInstance()
        {
            if (_subtractOperation == null)
                _subtractOperation = new SubtractOperation();
            return _subtractOperation;
        }
        public double Operate(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}