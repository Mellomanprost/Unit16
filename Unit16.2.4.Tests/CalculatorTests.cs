using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Unit16._2._Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Substraction_ShouldReturnCorrectValue()
        {
            var calculator = new Calculator();
            //calculator.Subtraction(7, 2);

            //Assert.AreEqual(5, calculator.Subtraction(7, 2));
            Assert.That(calculator.Subtraction(7, 2) == 5);
        }
    }
}
