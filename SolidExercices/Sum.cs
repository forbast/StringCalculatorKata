using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Sum : IOperations
    {
        public bool CanMakeOperation(String operation)
        {
            return operation.Contains("+");
        }

        public decimal MakeOperation(String operation)
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
                    Console.WriteLine("Caracteres entrés non pris en charge 1");
                    return 0;
                }
            }
            return total;
        }
    }
}
