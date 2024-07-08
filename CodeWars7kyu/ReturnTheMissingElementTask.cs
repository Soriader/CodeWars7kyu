using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ReturnTheMissingElementTask
    {
        public static int GetMissingElement(int[] superImportantArray)
        {
            int totalSum = 45;

            int arraySum = superImportantArray.Sum();

            return totalSum - arraySum;
        }
    }
}
//https://www.codewars.com/kata/5299413901337c637e000004/train/csharp