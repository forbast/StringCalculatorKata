using System;
using System.Collections.Generic;
using SolidExercices;

namespace SolidExercices
{
    public class CalculatorTrainer
    {
        static readonly Operations InstOperations = new Operations();
        private readonly string[] _operations = InstOperations._operations;
        public void Run()
        {
            var operations = new List<IOperations> { new Sum(), new Sub(), new Div(), new Multi() };
            var calculator = new Calculator(operations);


            foreach (var operation in _operations)
            {
                try
                {
                    var result = calculator.Calculate(operation);
                    System.Console.WriteLine(operation + " = " + result);
                }
                catch (ArgumentException e)
                {
                    System.Console.WriteLine("ERROR: " + e.Message);
                }
            }
            System.Console.ReadKey();
        }
    }
}
