using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TemplateLib.Tests.Unit
{
    public class CalcTests
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 0, 2)]
        public void TestAdd(int v1, int v2, int expected)
        {
            var calc = new Calc();
            var actual = calc.Add(v1, v2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 0, 0)]
        public void TestMultiply(int v1, int v2, int expected)
        {
            var calc = new Calc();
            var actual = calc.Multiply(v1, v2);
            Assert.Equal(expected, actual);
        }
    }
}
