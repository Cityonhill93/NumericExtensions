namespace NumericExtensions
{
    public static class DecimalExtensions
    {
        public static bool IsDivisibleBy(this decimal d1, decimal d2)
        {
            var remainder = d1 % d2;

            return remainder == 0;
        }
    }
}
