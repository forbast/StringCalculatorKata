using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SolidExercices
{
    public class Calculator
    {
        private readonly List<IOperations> _operations;
        public Calculator(List<IOperations> operations)
        {
            _operations = operations;
        }

        public decimal Calculate(string operation)
        {
            decimal total = 0;



            foreach (var uneOperation in _operations)
            {
                if (uneOperation.CanMakeOperation(operation))
                {
                    return uneOperation.MakeOperation(operation);
                }
            }

            try
            {
                total = Convert.ToDecimal(operation);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Caracteres entrés non pris en charge");
                return 0;
            }

            return total;
        }
    }


}