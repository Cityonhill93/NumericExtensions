namespace NumericExtensions
{
    public static class FloatExtensions
    {
        /// <summary>
        /// Determine if <paramref name="f1"/> is divisible by <paramref name="f2"/>
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static bool IsDivisibleBy(this float f1, float f2)
        {
            var decimal1 = Convert.ToDecimal(f1);
            var decimal2 = Convert.ToDecimal(f2);

            return decimal1.IsDivisibleBy(decimal2);
        }
    }
}
