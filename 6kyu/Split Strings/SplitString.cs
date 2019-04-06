using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6kyu.Split_Strings
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            str = str.Length % 2 == 0 ? str : str + "_";

            return Enumerable.Range(0, str.Length)
                                .Where(x => x % 2 == 0)
                                .Select(x => str.Substring(x, 2))
                                .ToArray();
        }
    }
}
