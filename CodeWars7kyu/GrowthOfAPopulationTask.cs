using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class GrowthOfAPopulationTask
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int currentPopulation = p0;
            int years = 0;

            while (currentPopulation < p)
            {
                currentPopulation += (int)(currentPopulation * percent / 100) + aug;
                years++;
            }

            return years;
        }
    }
}
//https://www.codewars.com/kata/563b662a59afc2b5120000c6/train/csharp