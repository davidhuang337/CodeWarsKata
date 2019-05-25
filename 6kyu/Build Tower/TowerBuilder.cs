using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6kyu.Split_Strings
{
    public class TowerBuilder
    {
        public static string[] Build(int nFloors)
        {
            var result = Enumerable.Range(0, nFloors)
                .Select(floor => new string(' ',nFloors-floor-1) + new string('*',2*floor+1) + new string(' ', nFloors-floor-1) )
                .ToArray();
            return result;
        }
    }
}
