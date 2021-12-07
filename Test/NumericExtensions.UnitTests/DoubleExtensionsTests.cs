using Xunit;

namespace NumericExtensions
{
    public class DoubleExtensionsTests
    {
        [Theory]
        //A number should be divisible by itself
        [InlineData(1, 1)]
        //An even number is divisible by 2
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        [InlineData(10, 2)]
        //Multiples of 3 should be divisible by 3
        [InlineData(3, 3)]
        [InlineData(6, 3)]
        [InlineData(9, 3)]
        [InlineData(12, 3)]
        [InlineData(24, 3)]
        //Multiples of 10 should be divisible by 10

        [InlineData(10, 10)]
        [InlineData(100, 10)]
        [InlineData(1000, 10)]
        [InlineData(10000, 10)]
        [InlineData(100000, 10)]
        public void IsDivisibleBy_DivisibleNumbers_True(decimal d1, decimal d2)
        {
            var isDivisible = d1.IsDivisibleBy(d2);

            Assert.True(isDivisible);
        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(4, 5)]
        [InlineData(100, 75)]
        public void IsDivisibleBy_NonDivisibleNumbers_False(decimal d1, decimal d2)
        {
            var isDivisible = d1.IsDivisibleBy(d2);

            Assert.False(isDivisible);
        }
    }
}
