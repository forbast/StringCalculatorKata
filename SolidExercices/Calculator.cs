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

            if (sum.CanSum(operation))
            {
                return sum.MakeSum(operation);
            }

            else if (operation.Contains("-"))
            {
                String[] listNumber = operation.Split('-');
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
                        total = total - Convert.ToDecimal(oneNumber);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Caracteres entrés non pris en charge");
                        return 0;
                    }
                }
            }
            else if (operation.Contains("/"))
            {
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
                }
            }
            else if (operation.Contains("*"))
            {
                total = 1;
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