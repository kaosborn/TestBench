using System.Collections.Generic;

namespace Sequences
{
    public class Numbers
    {
        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            int index = 0;
            while (index < 10)
                yield return index++;
        }
    }
}
