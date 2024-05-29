using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class HelpSuzukiCountHisVegetablesTask
    {
        public static List<Tuple<int, string>> CountVegetables(string s)
        {

            var validVegetables = new HashSet<string>
            {
            "cabbage", "carrot", "celery", "cucumber", "mushroom",
            "onion", "pepper", "potato", "tofu", "turnip"
            };

            var vegetableCounts = s.Split(' ')
                .Where(word => validVegetables.Contains(word))
                .GroupBy(word => word)
                .Select(group => new Tuple<int, string>(group.Count(), group.Key))
                .OrderByDescending(tuple => tuple.Item1)
                .ThenByDescending(tuple => tuple.Item2)
                .ToList();

            return vegetableCounts;

        }
    }
}
//https://www.codewars.com/kata/56ff1667cc08cacf4b00171b/train/csharp
