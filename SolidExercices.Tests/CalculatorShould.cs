﻿using System.Collections.Generic;
using System.Linq.Expressions;
using NFluent;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            //var operations = new List<IOperations> { new Sum(), new Sub(), new Div(), new Multi() };
            var calculatorTrainer = new CalculatorTrainer();
            calculatorTrainer.Run();

            // Addition
           /* var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);

            result = calculator.Calculate("1+4+6");
            Check.That(result).IsEqualTo(11m);

            result = calculator.Calculate("9");
            Check.That(result).IsEqualTo(9m);

            result = calculator.Calculate("213+ezzrz");
            Check.That(result).IsEqualTo(0m);

            

            //Soustraction
            result = calculator.Calculate("4-1");
            Check.That(result).IsEqualTo(3m);

            result = calculator.Calculate("6-3");
            Check.That(result).IsEqualTo(3m);

            result = calculator.Calculate("12-3");
            Check.That(result).IsEqualTo(9m);

            result = calculator.Calculate("9");
            Check.That(result).IsEqualTo(9m);

            result = calculator.Calculate("213-ezzrz");
            Check.That(result).IsEqualTo(0m);




             //Division
            result = calculator.Calculate("4/1");
            Check.That(result).IsEqualTo(4m);

            result = calculator.Calculate("6/3");
            Check.That(result).IsEqualTo(2m);

            result = calculator.Calculate("12/3");
            Check.That(result).IsEqualTo(4m);

            result = calculator.Calculate("9");
            Check.That(result).IsEqualTo(9m);

            result = calculator.Calculate("213/ezzrz");
            Check.That(result).IsEqualTo(0m);




            //Division
            result = calculator.Calculate("4*1");
            Check.That(result).IsEqualTo(4m);

            result = calculator.Calculate("6*3");
            Check.That(result).IsEqualTo(18m);

            result = calculator.Calculate("12*3");
            Check.That(result).IsEqualTo(36m);

            result = calculator.Calculate("9");
            Check.That(result).IsEqualTo(9m);

            result = calculator.Calculate("213*ezzrz");
            Check.That(result).IsEqualTo(0m);




            // Autre
            result = calculator.Calculate("zzrz");
            Check.That(result).IsEqualTo(0m);*/


        


        }
    }
}
