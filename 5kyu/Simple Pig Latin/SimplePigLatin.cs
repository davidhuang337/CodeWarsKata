using System;
using System.Linq;

namespace _5kyu
{
    class SimplePigLatin
    {

        public static string PigIt(string str)
        {
            var words = str.Split(" ");
            string result = "";
            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(result))
                {
                    result += " ";
                }
                result += $"{word.Substring(1, word.Length-1)}{word.Substring(0,1)}ay";
            }

            return result;
        }

    }
}