namespace CommonLibrary
{
    class MultiplyOperation : IOperation2Operands
    {
        private const string _sign = "x";
        public string Sign => _sign;
        private static MultiplyOperation _multiplyOperation;
        private MultiplyOperation()
        {

        }
        public static MultiplyOperation CreateOrGetInstance()
        {
            if (_multiplyOperation == null)
                _multiplyOperation = new MultiplyOperation();
            return _multiplyOperation;
        }
        public double Operate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}