namespace NumericExtensions
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Determine if <paramref name="d1"/> is divisible by <paramref name="d2"/>
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool IsDivisibleBy(this decimal d1, decimal d2)
        {
            var remainder = d1 % d2;

            return remainder == 0;
        }
    }
}
