using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace CodeWars7kyu
{
    public class FindCountofMostFrequentItemInAnArrayTask
    {
        public static int MostFrequentItemCount(int[] collection)
        {
            if (collection == null || collection.Length == 0)
            {
                return 0;
            }

            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            foreach (int number in collection)
            {
                if (frequencyDict.ContainsKey(number))
                {
                    frequencyDict[number]++;
                }
                else
                {
                    frequencyDict[number] = 1;
                }
            }

            int maxCount = frequencyDict.Values.Max();

            return maxCount;

        }
    }
}
//https://www.codewars.com/kata/56582133c932d8239900002e/train/csharp