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
            decimal sum = 0;
            String[] listNumber = operation.Split('+');
            foreach (var oneNumber in listNumber)
            {
                try
                {
                    sum += Convert.ToDecimal(oneNumber);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Caracteres entrés non pris en charge");
                    return 0;
                }
            }
            return sum;
        }
    }


}