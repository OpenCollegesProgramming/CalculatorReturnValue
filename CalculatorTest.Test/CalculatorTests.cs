using NUnit.Framework;
using CalculatorUtility.Lib;

namespace CalculatorTest.Test
{
    public class Tests
    {
        private CalculatorUtility.Lib.Calculator calculator;
        [SetUp]
        public void Setup()
        {          
            CalculatorUtility.Lib.Calculator calculator = new CalculatorUtility.Lib.Calculator();
            this.calculator = calculator;
        }

        [Test]
        public void Calculator_Addition()
        {
            var expected = "4";
            var actual = calculator.calculateAnswer("2", "2", "Add");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_Subtract()
        {
            var expected = "0";
            var actual = calculator.calculateAnswer("2", "2", "Subtract");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_Multiply()
        {
            var expected = "12";
            var actual = calculator.calculateAnswer("3", "4", "Multiply");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_Divide()
        {
            var expected = "2";
            var actual = calculator.calculateAnswer("8", "4", "Divide");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_Modulus()
        {
            var expected = "2";
            var actual = calculator.calculateAnswer("8", "6", "Modulus");
            Assert.AreEqual(expected, actual);
        }
    }
}