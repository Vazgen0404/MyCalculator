using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CommonLibrary
{
    public class CalculatorCreator : ICalculatorCreator
    {
        private Dictionary<string, IOperation2Operands> _operations1 = new Dictionary<string, IOperation2Operands>();
        private Dictionary<string, IOperation1Operand> _operations2 = new Dictionary<string, IOperation1Operand>();

        public Calculator CreateCalculator()
        {
            _operations1.Add(SumOperation.CreateOrGetInstance().Sign, SumOperation.CreateOrGetInstance());
            _operations1.Add(SubtractOperation.CreateOrGetInstance().Sign, SubtractOperation.CreateOrGetInstance());
            _operations1.Add(MultiplyOperation.CreateOrGetInstance().Sign, MultiplyOperation.CreateOrGetInstance());
            _operations1.Add(DivideOperation.CreateOrGetInstance().Sign, DivideOperation.CreateOrGetInstance());

            GetOperations();

            return new Calculator(_operations1, _operations2);
        }

        public void GetOperations()
        {
            string path = @"C:\Plugins";
            foreach (string dll in Directory.GetFiles(path, "*.dll"))
            {
                var types = Assembly.LoadFile(dll).GetTypes().Where(t => t.IsClass && typeof(IOperation2Operands).IsAssignableFrom(t));
                foreach (var type in types)
                {
                    var instance = Activator.CreateInstance(type) as IOperation2Operands;
                    _operations1.Add(instance.Sign, instance);
                }

                types = Assembly.LoadFile(dll).GetTypes().Where(t => t.IsClass && typeof(IOperation1Operand).IsAssignableFrom(t));
                foreach (var type in types)
                {
                    var instance = Activator.CreateInstance(type) as IOperation1Operand;
                    _operations2.Add(instance.Sign, instance);
                }
            }
        }
    }
}
