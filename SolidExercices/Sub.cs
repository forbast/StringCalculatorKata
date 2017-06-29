using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Div : IOperations
    {
        public bool CanMakeOperation(String operation)
        {
            return operation.Contains("-");
        }

        public decimal MakeOperation(String operation)
        {
            decimal total = 0;
            String[] listNumber = operation.Split('-');
            try
            {
                total = Convert.ToDecimal(listNumber[0]);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Caracteres entrés non pris en charge 1-");
                return 0;
            }
            foreach (var oneNumber in listNumber.Skip(1).ToArray())
            {
                try
                {
                    total = total - Convert.ToDecimal(oneNumber);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Caracteres entrés non pris en charge 2-");
                    return 0;
                }
            }
            return total;
        }
    }
}
