using CodeWars7kyu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWars7kyu
{
    public class RemoveAllTheMarkedElementsOfAListTask
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            List<int> result = new List<int>();

            foreach (int num in integerList)
            {
                if (!valuesList.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/563089b9b7be03472d00002b/train/csharp