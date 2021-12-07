namespace NumericExtensions
{
    public static class IntExtensions
    {
        public static bool IsDivisibleBy(this int d1, int d2)
        {
            var remainder = d1 % d2;

            return remainder == 0;
        }
    }
}
