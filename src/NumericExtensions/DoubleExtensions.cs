namespace NumericExtensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Determine if <paramref name="d1"/> is divisible by <paramref name="d2"/>
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static bool IsDivisibleBy(this double d1, double d2)
        {
            var decimal1 = Convert.ToDecimal(d1);
            var decimal2 = Convert.ToDecimal(d2);

            return decimal1.IsDivisibleBy(decimal2);
        }
    }
}
