using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class OrderedCountOfCharactersTask
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {

            return input.GroupBy(c => c)
            .OrderBy(g => input.IndexOf(g.Key))
            .Select(g => Tuple.Create(g.Key, g.Count()))
            .ToList();


        }
    }
}
//https://www.codewars.com/kata/57a6633153ba33189e000074/train/csharp