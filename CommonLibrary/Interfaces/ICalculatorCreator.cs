namespace CommonLibrary
{
    public interface ICalculatorCreator
    {
        void GetOperations();
        Calculator CreateCalculator();
    }
}
