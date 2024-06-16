using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class LastSurvivorTask
    {
        public static string LastSurvivor(string letters, int[] coords)
        {
            List<char> letterList = new List<char>(letters);

            foreach (int index in coords)
            {
                letterList.RemoveAt(index);
            }

            return letterList[0].ToString();

        }
    }
}
//https://www.codewars.com/kata/609eee71109f860006c377d1/train/csharp