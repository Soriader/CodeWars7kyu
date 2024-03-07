using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DescendingOrderTask
    {
        public static int DescendingOrder(int num)
        {
            var numbers = num.ToString();

            string sortedNumberString = string.Join("", numbers.Select(x => x.ToString()).OrderByDescending(x => x));

            int sortedNumber = int.Parse(sortedNumberString);

            return sortedNumber;
        }
    }
}
//https://www.codewars.com/kata/5467e4d82edf8bbf40000155/train/csharp
