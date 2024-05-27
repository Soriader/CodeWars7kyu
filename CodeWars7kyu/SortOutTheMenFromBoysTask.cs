using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SortOutTheMenFromBoysTask
    {
        public static int[] MenFromBoys(int[] a)
        {
            List<int> men = new List<int>();
            List<int> boys = new List<int>();

            foreach (int number in a)
            {
                if (number % 2 == 0)
                {
                    if (!men.Contains(number)) 
                    {
                        men.Add(number);
                    }
                }
                else
                {
                    if (!boys.Contains(number)) 
                    {
                        boys.Add(number);
                    }
                }
            }

            men.Sort(); 
            boys.Sort((x, y) => y.CompareTo(x)); 

            men.AddRange(boys);

            return men.ToArray();
        }
    }
}
//https://www.codewars.com/kata/5af15a37de4c7f223e00012d/train/csharp