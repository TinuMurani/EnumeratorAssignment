using System;
using System.Collections.Generic;

namespace EnumeratorConsoleApp
{
    public static class IntegerEnumerator
    {
        public static IEnumerable<int> GenerateAllIntegers(int lastValue = int.MaxValue)
        {
            if (lastValue < 0)
            {
                throw new IndexOutOfRangeException("The upper bound of the list is lower than 0");
            }

            if (lastValue > int.MaxValue)
            {
                throw new IndexOutOfRangeException("The upper bound of the list is higher than the maximum value for Int32");
            }

            for (int i = 0; i <= lastValue; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> GenerateAllOddIntegers(IEnumerable<int> input)
        {
            foreach (var item in input)
            {
                if (item % 2 is 1)
                {
                    yield return item;
                }
            }
        }
    }
}
