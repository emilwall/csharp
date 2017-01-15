using System;
using System.Collections.Generic;

namespace nucleotide_count
{
    public class DNA
    {
        public DNA(string strand)
        {
        }

        public Dictionary<char, int> NucleotideCounts => null; // Not implemented

        public int Count(char nucleotide) => 0; // Not implemented
    }

    public class InvalidNucleotideException : Exception { }
}
