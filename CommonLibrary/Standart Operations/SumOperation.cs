namespace CommonLibrary
{
    public class SumOperation : IOperation2Operands
    {
        private const string _sign = "+";
        public string Sign => _sign;
        private static SumOperation _sumOperation;
        private SumOperation()
        {

        }
        public static SumOperation CreateOrGetInstance()
        {
            if (_sumOperation == null)
                _sumOperation = new SumOperation();
            return _sumOperation;
        }
        public double Operate(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
