namespace CommonLibrary
{
    public interface IOperation2Operands
    {
        string Sign { get; }
        double Operate(double num1, double num2);
    }
}
