﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(8, 4) == 2);
        }

        [Test]
        public void DivisionByZero_MustReturnException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(8, 0));
        }
    }
}
