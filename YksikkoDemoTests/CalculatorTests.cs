using Microsoft.VisualStudio.TestTools.UnitTesting;
using YksikkoDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkoDemo.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // AAA-periaate
            // Arrange -> alustus
            Calculator engels = new Calculator();
            int num1 = 5;
            int num2 = 8;
            int expected = 13;

            // Act -> toimi
            int actual = engels.Add(num1, num2);

            // Assert -> tarkista
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTestZero()
        {
            Calculator engels = new Calculator();
            int num1 = 0;
            int num2 = 0;
            int expected = 0;

            int actual = engels.Add(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator engels = new Calculator();
            int num1 = 10;
            int num2 = 5;
            int expected = 50;

            int actual = engels.Multiply(num1, num2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SubtractionTest()
        {
            Calculator engels = new Calculator();
            int num1 = 10;
            int num2 = 5;
            int expected = 5;

            int actual = engels.Subtract(num1, num2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DivisionTest()
        {
            Calculator engels = new Calculator();
            int num1 = 12;
            int num2 = 3;
            int expected = 4;

            int actual = engels.Divide(num1, num2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void DivisionTestFraction()
        {
            Calculator engels = new Calculator();
            int num1 = 22;
            int num2 = 5;
            int expected = 4;

            int actual = engels.Divide(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        // Testataan tuleeko poikkeus!
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException), "Divided by zero")]
        public void DivisionTestZero()
        {
            Calculator engels = new Calculator();
            int num1 = 12;
            int num2 = 0;
            int expected = 1;

            int actual = engels.Divide(num1, num2);

            Assert.AreEqual(expected, actual);
        }
    }
}