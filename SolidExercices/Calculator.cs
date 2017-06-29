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
                sum += Convert.ToDecimal(oneNumber);
                Console.WriteLine(sum);
            }
            return sum;
        }
    }


}