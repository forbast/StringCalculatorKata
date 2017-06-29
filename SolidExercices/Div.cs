using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public class Sub : IOperations
    {
        public bool CanMakeOperation(String operation)
        {
            return operation.Contains("/");
        }

        public decimal MakeOperation(String operation)
        {
            decimal total;
            String[] listNumber = operation.Split('/');
            try
            {
                total = Convert.ToDecimal(listNumber[0]);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Caracteres entrés non pris en charge");
                return 0;
            }

            foreach (var oneNumber in listNumber.Skip(1).ToArray())
            {
                try
                {
                    total = total / Convert.ToDecimal(oneNumber);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Caracteres entrés non pris en charge");
                    return 0;
                }
                catch (System.DivideByZeroException)
                {
                    Console.WriteLine("La division par  est impossible");
                    return 0;
                }
            }
            return total;
        }
    }
}
