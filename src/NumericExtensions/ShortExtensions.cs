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
            var decimal1 = Convert.ToDecimal(s1);
            var decimal2 = Convert.ToDecimal(s1);

            return decimal1.IsDivisibleBy(decimal2);
        }
    }
}
