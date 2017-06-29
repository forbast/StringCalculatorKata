using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Sum : IOperations
    {
        public bool CanSum(String operation)
        {
            return operation.Contains("+");
        }

        public decimal MakeSum(String operation)
        {
            decimal total = 0;
            String[] listNumber = operation.Split('+');
            foreach (var oneNumber in listNumber)
            {
                try
                {
                    total += Convert.ToDecimal(oneNumber);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Caracteres entrés non pris en charge");
                    return 0;
                }
            }
            return total;
        }
    }
}
