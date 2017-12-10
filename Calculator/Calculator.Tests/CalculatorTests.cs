using System;
using NUnit.Framework;
using static Calculator.Calculator;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        #region Addition
        [TestCase("3+5",ExpectedResult = 8.0)]
        [TestCase("3,0+5,0", ExpectedResult = 8)]
        [TestCase("3+6", ExpectedResult = 9)]
        [TestCase("3,0+6,0", ExpectedResult = 9.0)]
        [TestCase("256789    +  567890", ExpectedResult = 824679)]
        //для данных ситуаций, программа не подходит

        //[TestCase("1.7E+3", ExpectedResult = 8)] 
        //1.7E не тот формат

        //[TestCase("3,0 + (-5,0)", ExpectedResult = -2)]
        //-5,0 не парсится из-за "-"

        public double AdditionTest(string expression)
        {
            double result = Calculate(expression);
            return result;
        }
        #endregion

        #region Multiplication
        [TestCase("3*5", ExpectedResult = 15.0)]
        [TestCase("3,0*5,0", ExpectedResult = 15)]
        [TestCase("3*6", ExpectedResult = 18)]
        [TestCase("3,0*6,0", ExpectedResult = 18.0)]
        [TestCase("256789    *  567890", ExpectedResult = 145827905210)]
        public double MultiplicationTest(string expression)
        {
            double result = Calculate(expression);
            return result;
        }
        #endregion

        #region Division
        [TestCase("6/3", ExpectedResult = 2.0)]
        [TestCase("3,0/5,0", ExpectedResult = 0.6)]
        [TestCase("3/6", ExpectedResult = 0.5)]
        [TestCase("3,0/6,0", ExpectedResult = 0.5)]
        [TestCase("17/23", ExpectedResult = 0.739)]
        [TestCase("567    /  251", ExpectedResult = 2.259)]
        //[TestCase("20/0", ExpectedException = typeof(ArgumentException))]
        public double DivisionTest(string expression)
        {

            double result = Calculate(expression);
            return Math.Round(result,3);
        }

        #endregion

        #region Subtraction
        [TestCase("3-5", ExpectedResult = -2.0)]
        [TestCase("3,0-5,0", ExpectedResult = -2)]
        [TestCase("3-6", ExpectedResult = -3)]
        [TestCase("3,0-6,0", ExpectedResult = -3.0)]
        [TestCase("256789    -  567890", ExpectedResult = -311101)]
        public double SubtractionTest(string expression)
        {
            double result = Calculate(expression);
            return result;
        }
        #endregion
    }
}