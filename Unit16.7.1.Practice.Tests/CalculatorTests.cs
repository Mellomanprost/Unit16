using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Unit16._7._1.Practice.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(140, calculator.Additional(60, 80));
        }

        [Test]
        public void Substraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(23, 7) == 16);
        }

        [Test]
        public void Multiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Multiplication(6, 8) == 48);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.AreEqual(4, calculator.Division(32, 8));
        }
    }
}
