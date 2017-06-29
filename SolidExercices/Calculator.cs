using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SolidExercices
{
    public class Calculator
    {
        public decimal Calculate(string operation)
        {
            decimal total = 0;

            IOperations sum = new Sum();
            IOperations div = new Div();
            IOperations multi = new Multi();
            IOperations sub = new Sub();

            if (sum.CanMakeOperation(operation))
            {
                return sum.MakeOperation(operation);
            }
            else if (div.CanMakeOperation(operation))
            {
                return div.MakeOperation(operation);
            }
            else if (multi.CanMakeOperation(operation))
            {
                return multi.MakeOperation(operation);
            }
            else if (sub.CanMakeOperation(operation))
            {
                return sub.MakeOperation(operation);
            }
            else
            {
                try
                {
                    total = Convert.ToDecimal(operation);
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