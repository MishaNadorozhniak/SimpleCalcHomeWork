using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalc;

namespace SimpleCalc
{

	[TestFixture]
	public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void TestSetup()
        {
         calc = new Calculator();
            calc.Number1 = 10;
            calc.Number2 = 15;
        }
        
        [Test]
        public void TestMethodAdd()
        {

            var result = calc.Add();

            Assert.AreEqual(result, 25);
        }

        [Test]
        public void TestMethodSub()
        {
            var result = calc.Subtract();

            Assert.AreEqual(result, -5);
        }

        [Test]
        public void TestMethodMul()
        {
            var result = calc.Multiply();

            Assert.AreEqual(result, 150);
        }

        [Test]
        public void TestMethodDiv()
        {
            var result = calc.Divide();

            Assert.AreEqual(result, (double)10/15);
        }

        [Test]
        public void ShouldReturnZeroWhenDivideByZero()
        {
            calc.Number2 = 0;

            var result = calc.Divide();

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ShouldReturnZeroWhenMultiplyByZero()
        {
            calc.Number2 = 0;

            var result = calc.Multiply();

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ShouldReturnZeroWhenAddZeros()
        {
            calc.Number1 = 0;
            calc.Number2 = 0;

            var result = calc.Add();

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void TestMethodAddWithDouble()
        {
            calc.Number1 = 4.5;
            calc.Number2 = 3.555;

            var result = calc.Add();

            Assert.AreEqual(result, 8.055);
        }

        [Test]
        public void TestMethodSubWithDouble()
        {
            calc.Number1 = 4.5;
            calc.Number2 = 3.555;

            var result = calc.Subtract();

            Assert.AreEqual(result, 0.94);
        }
    }
}
