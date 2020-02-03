using System.Collections.Generic;

namespace Sequences
{
    public class Numbers
    {
        public static IEnumerable<int> GetOddDigitsLessThan (int lim)
        {
            int result = 1;
            while (result < lim)
            {
                yield return result;
                result += 2;
            }
        }
    }
}
