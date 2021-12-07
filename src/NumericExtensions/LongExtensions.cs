namespace NumericExtensions
{
    public static class LongExtensions
    {
        public static bool IsDivisibleBy(this long d1, long d2)
        {
            var remainder = d1 % d2;

            return remainder == 0;
        }
    }
}
