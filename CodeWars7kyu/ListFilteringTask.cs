using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ListFilteringTask
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.Where(x => x is int).Select(x => (int)x);
        }
    }
}
//https://www.codewars.com/kata/53dbd5315a3c69eed20002dd/train/csharp