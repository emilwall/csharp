using System;
using System.Collections.Generic;

namespace accumulate
{
    public static class Operations
    {
        public static IEnumerable<int> Accumulate(
            this IEnumerable<int> numbers,
            Func<int, int> operation
        ) => null; // Not implemented

        public static IEnumerable<string> Accumulate(
            this IEnumerable<int> numbers,
            Func<int, string> operation
        ) => null; // Not implemented

        public static IEnumerable<string> Accumulate(
            this IEnumerable<string> strings,
            Func<string, string> operation
        ) => null; // Not implemented
    }
}
