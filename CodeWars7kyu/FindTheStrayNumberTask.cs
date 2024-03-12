using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FindTheStrayNumberTask
    {
        public static int Stray(int[] numbers)
        {
            var strayNumberGroup = numbers.GroupBy(x => x).Single(group => group.Count() == 1);
            return strayNumberGroup.Key;

        }
    }
}
//https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp