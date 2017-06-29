using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();


            // Addition
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);

            result = calculator.Calculate("1+4+6");
            Check.That(result).IsEqualTo(11m);

            result = calculator.Calculate("9");
            Check.That(result).IsEqualTo(9m);

            result = calculator.Calculate("213+ezzrz");
            Check.That(result).IsEqualTo(0m);

            result = calculator.Calculate("zzrz");
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

            result = calculator.Calculate("zzrz");
            Check.That(result).IsEqualTo(0m);


        }
    }
}
