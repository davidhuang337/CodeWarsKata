using System.Linq;

namespace _6kyu.Split_Strings
{
    public class TowerBuilder
    {
        public static string[] Build(int nFloors)
        {
            return Enumerable.Range(0, nFloors)
                .Select(floor => new string(' ',nFloors-floor-1) + new string('*',2 * floor + 1) + new string(' ', nFloors-floor-1) )
                .ToArray();
        }
    }
}
