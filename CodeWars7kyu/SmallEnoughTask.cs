using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SmallEnoughTask
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            foreach (int i in a)
            {
                if(i > limit)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
//https://www.codewars.com/kata/57cc981a58da9e302a000214/train/csharp