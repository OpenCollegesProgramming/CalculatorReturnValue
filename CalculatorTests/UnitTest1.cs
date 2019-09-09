using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.BusinessLogic;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WrittenValueTestAdd()
        {
            //Set values to test
            string testNumber1 = "one";
            string testNumber2 = "two";

            string result = CalculatorOperations.CalculateAnswer("Add", testNumber1, testNumber2);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WrittenValueTestSubtract()
        {
            //Set values to test
            string testNumber1 = "one";
            string testNumber2 = "two";

            string result = CalculatorOperations.CalculateAnswer("Subtract", testNumber1, testNumber2);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WrittenValueTestMultiply()
        {
            //Set values to test
            string testNumber1 = "one";
            string testNumber2 = "two";

            string result = CalculatorOperations.CalculateAnswer("Multiply", testNumber1, testNumber2);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WrittenValueTestDivide()
        {
            //Set values to test
            string testNumber1 = "one";
            string testNumber2 = "two";

            string result = CalculatorOperations.CalculateAnswer("Divide", testNumber1, testNumber2);
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WrittenValueTestModulus()
        {
            //Set values to test
            string testNumber1 = "one";
            string testNumber2 = "two";

            string result = CalculatorOperations.CalculateAnswer("Modulus", testNumber1, testNumber2);
        }

        [TestMethod]
        public void AdditionTest()
        {
            //Set values to test
            string testNumber1 = "10";
            string testNumber2 = "4";

            string actualResult = CalculatorOperations.CalculateAnswer("Add", testNumber1, testNumber2);
            string expectedResult = "14";
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void SubtractionTest() //requirement 2.1 / 2.2
        {
            //Set values to test
            string testNumber1 = "10";
            string testNumber2 = "4";

            string actualResult = CalculatorOperations.CalculateAnswer("Subtract", testNumber1, testNumber2);
            string expectedResult = "6";
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void MultiplyTest() //requirement 2.1 / 2.2
        {
            //Set values to test
            string testNumber1 = "10";
            string testNumber2 = "4";

            string actualResult = CalculatorOperations.CalculateAnswer("Multiply", testNumber1, testNumber2);
            string expectedResult = "40";
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void DivideTest() //requirement 2.1 / 2.2
        {
            //Set values to test
            string testNumber1 = "10";
            string testNumber2 = "4";

            string actualResult = CalculatorOperations.CalculateAnswer("Divide", testNumber1, testNumber2);
            string expectedResult = "2.5";
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void ModulusTest() //requirement 2.1 / 2.2
        {
            //Set values to test
            string testNumber1 = "10";
            string testNumber2 = "4";

            string actualResult = CalculatorOperations.CalculateAnswer("Modulus", testNumber1, testNumber2);
            string expectedResult = "2";
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
