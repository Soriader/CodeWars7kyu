using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class JavaScriptArrayFilterTask
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            int[] result = numbers.Where(w => w % 2 == 0).ToArray();

            return result;
        }
    }
}
//https://www.codewars.com/kata/514a6336889283a3d2000001/train/csharp