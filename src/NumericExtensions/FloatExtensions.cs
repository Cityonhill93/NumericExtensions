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
            var remainder = f1 % f2;

            return remainder == 0;
        }
    }
}
