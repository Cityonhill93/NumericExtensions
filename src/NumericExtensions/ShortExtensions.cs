namespace NumericExtensions
{
    public static class ShortExtensions
    {
        public static bool IsDivisibleBy(this short d1, short d2)
        {
            var remainder = d1 % d2;

            return remainder == 0;
        }
    }
}
