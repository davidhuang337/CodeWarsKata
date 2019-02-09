using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _6kyu
{
    public class Revrot
    {
        public static string RevRot(string str, int size)
        {
            var result = String.Empty;

            if (size == 0 || string.IsNullOrEmpty(str) || str.Length < size)           
                return result;
            
            for (int startIdx = 0; startIdx + size < str.Length; startIdx += size)
            {
                var chunk = str.Substring(startIdx, size);

                if (IsNeedRevers(chunk))
                {
                    result += Revers(chunk);
                }
                else
                {
                    result += Rotate(chunk);
                }
            }
            
            return result;
        }

        private static bool IsNeedRevers(string chunk)
        {
            var charArray = chunk.ToCharArray();
            var i = 0;
            foreach (var digit in charArray)
            {
                i += Convert.ToInt32(digit);
            }
            return i % 2 == 0;
        }

        private static string Rotate(string chunk)
        {
            return chunk.Substring(1, chunk.Length - 1) + chunk.Substring(0, 1);

        }

        private static string Revers(string chunk)
        {
            var charArray = chunk.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
