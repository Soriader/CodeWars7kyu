using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SortedYesOrNoTask
    {
        public static string IsSortedAndHow(int[] array)
        {

            bool ascending = true;
            bool descending = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    ascending = false;
                }

                if (array[i] < array[i + 1])
                {
                    descending = false;
                }
            }

            if (ascending)
            {
                return "yes, ascending";
            }
            else if (descending)
            {
                return "yes, descending";
            }
            else
            {
                return "no";
            }
        }
    }
}
//https://www.codewars.com/kata/580a4734d6df748060000045/train/csharp