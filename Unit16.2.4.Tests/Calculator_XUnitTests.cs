using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Unit16._2._Tests
{
    public class Calculator_XUnitTests
    {
        [Fact]
        public void Substraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.Equal(20, calculator.Subtraction(30, 10));
            // or
            Assert.True(calculator.Subtraction(300, 10) == 290);
        }

        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(200, 10) == 20);
        }

        [Fact]
        public void DivisionByZero_MustReturnException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
