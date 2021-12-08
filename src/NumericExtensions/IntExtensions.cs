namespace NumericExtensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Determine if <paramref name="i1"/> is divisible by <paramref name="i2"/>
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public static bool IsDivisibleBy(this int i1, int i2)
        {
            var decimal1 = Convert.ToDecimal(i1);
            var decimal2 = Convert.ToDecimal(i2);

            return decimal1.IsDivisibleBy(decimal2);
        }
    }
}
