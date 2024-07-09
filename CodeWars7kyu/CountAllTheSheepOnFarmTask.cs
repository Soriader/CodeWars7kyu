using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CountAllTheSheepOnFarmTask
    {
        public int lostSheep(int[] friday, int[] saturday, int total)
        {
            return total - (friday.Sum() + saturday.Sum());
        }
    }
}
//https://www.codewars.com/kata/58e0f0bf92d04ccf0a000010/train/csharp