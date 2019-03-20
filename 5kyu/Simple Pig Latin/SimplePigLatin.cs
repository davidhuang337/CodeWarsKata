using System;
using System.Linq;

namespace _5kyu
{
    class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            return string.Join(" ",str.Split(" ").Select(word => $"{word.Substring(1)}{word[0]}ay"));
        }
    }
}