namespace NumericExtensions
{
    public static class DoubleExtensions
    {
        public static bool IsDivisibleBy(this double d1, double d2)
        {
            var remainder = d1 % d2;

            return remainder == 0;
        }
    }
}
