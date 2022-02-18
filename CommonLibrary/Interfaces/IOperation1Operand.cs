namespace CommonLibrary
{
    public interface IOperation1Operand
    {
        string Sign { get; }
        double Operate(double num);
    }
}
