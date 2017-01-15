using System;
using System.Collections.Generic;

namespace strain
{
    public static class Strain
    {
        public static IEnumerable<int> Keep(
            this IEnumerable<int> collection,
            Func<int, bool> predicate
        ) => null; // Not implemented

        public static IEnumerable<string> Keep(
            this IEnumerable<string> collection,
            Func<string, bool> predicate
        ) => null; // Not implemented

        public static int[][] Keep(
            this int[][] collection,
            Func<int[], bool> predicate
        ) => null; // Not implemented

        public static IEnumerable<int> Discard(
            this IEnumerable<int> collection,
            Func<int, bool> predicate
        ) => null; // Not implemented

        public static IEnumerable<string> Discard(
            this IEnumerable<string> collection,
            Func<string, bool> predicate
        ) => null; // Not implemented

        public static int[][] Discard(
            this int[][] collection,
            Func<int[], bool> predicate
        ) => null; // Not implemented
    }
}
