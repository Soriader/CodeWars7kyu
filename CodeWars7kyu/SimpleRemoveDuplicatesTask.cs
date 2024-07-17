using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SimpleRemoveDuplicatesTask
    {
        public static int[] solve(int[] arr)
        {
            Dictionary<int, bool> seen = new Dictionary<int, bool>();
            List<int> result = new List<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (!seen.ContainsKey(arr[i]))
                {
                    result.Add(arr[i]);
                    seen[arr[i]] = true;
                }
            }

            result.Reverse();

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/5ba38ba180824a86850000f7/train/csharp