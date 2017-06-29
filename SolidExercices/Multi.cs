using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Multi : IOperations
    {
        public bool CanMakeOperation(String operation)
        {
            return operation.Contains("*");
        }

        public decimal MakeOperation(String operation)
        {
            decimal total = 1;
            String[] listNumber = operation.Split('*');
            foreach (var oneNumber in listNumber)
            {
                try
                {
                    total = total * Convert.ToDecimal(oneNumber);
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
