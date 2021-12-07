namespace NumericExtensions
{
    public static class ShortExtensions
    {
        /// <summary>
        /// Determine if <paramref name="s1"/> is divisible by <paramref name="s2"/>
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool IsDivisibleBy(this short s1, short s2)
        {
            var remainder = s1 % s2;

            return remainder == 0;
        }
    }
}
