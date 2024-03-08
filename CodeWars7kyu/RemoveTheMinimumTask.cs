using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class RemoveTheMinimumTask
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return new List<int>();
            }

            int min = numbers.Min(); 

            List<int> result = new List<int>(numbers); 

            result.Remove(min);

            return result;

        }
    }
}
//https://www.codewars.com/kata/563cf89eb4747c5fb100001b/train/csharp