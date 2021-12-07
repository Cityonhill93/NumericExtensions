namespace NumericExtensions
{
    public static class FloatExtensions
    {
        public static bool IsDivisibleBy(this float d1, float d2)
        {
            var remainder = d1 % d2;

            return remainder == 0;
        }
    }
}
