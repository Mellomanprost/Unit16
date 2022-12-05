using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calculator = new Calculator();
            calculator.Multiplication(2, 4);

            Assert.AreEqual(8, calculator.Multiplication(2, 4));
        }

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
    }
}
