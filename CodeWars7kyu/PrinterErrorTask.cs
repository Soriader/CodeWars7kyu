using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PrinterErrorTask
    {
        public static string PrinterError(string s)
        {
            var total = 0;
            var errors = 0;

            foreach (var c in s.ToArray())
            {
                total += 1;

                if (c > 'm')
                {
                    errors += 1;
                }
            }

            return $"{errors}/{total}";

            //https://www.codewars.com/kata/56541980fa08ab47a0000040/train/csharp
        }
    }
}
