namespace NumericExtensions
{
    public static class LongExtensions
    {
        /// <summary>
        /// Determine if <paramref name="l1"/> is divisible by <paramref name="l2"/>
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static bool IsDivisibleBy(this long l1, long l2)
        {
            var remainder = l1 % l2;

            return remainder == 0;
        }
    }
}
