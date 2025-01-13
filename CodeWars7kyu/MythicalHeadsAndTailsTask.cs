using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MythicalHeadsAndTailsTask
    {
        public static int[] Beasts(int heads, int tails)
        {
            int y = (heads - 2 * tails) / 3;

            if ((heads - 2 * tails) % 3 != 0 || y < 0)
            {
                return null; 
            }

            int x = tails - y;

            if (x < 0)
            {
                return null; 
            }

            return new int[] { x, y };
        }
    }
}
//https://www.codewars.com/kata/5751aa92f2dac7695d000fb0/train/csharp