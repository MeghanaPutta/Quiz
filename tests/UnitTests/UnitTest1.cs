using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void square_WorksWithproductofanumber()
        {
        var expected = 4;
        var num = 2;
        var actual = square(num);
        Assert.Equal(expected,actual);
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(-3)]
        [InlineData(-4)]
        [InlineData(-5)]
        public void Isnegative_WorksWithanumber(int n)
        {
        Assert.True(Isnegative(n));
        }
        int square(int num)
            {
            return num*num;
        }           
        bool Isnegative(int n)
        {
            return n < 0;
        }

    }
}
