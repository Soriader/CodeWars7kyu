using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ZeroBalancedArrayTask
    {
        public static bool IsZeroBalanced(List<int> xs)
        {
            if(xs.Sum() != 0)
            {
                return false;
            }

            if (xs.Count == 0)
            {
                return false;

            }

            List<int> positiveNumber = new List<int>();
            List<int> negativeeNumber = new List<int>();

            foreach (int x in xs) 
            {
                if(x > 0)
                {
                    positiveNumber.Add(x);
                }
                else if(x < 0)
                {
                    negativeeNumber.Add(x);
                }
            }

            foreach (int x in negativeeNumber) 
            {
                if (!positiveNumber.Contains(Math.Abs(x)))
                {
                    return false;
                }
            }

            return true;

        }
    }
}
//https://www.codewars.com/kata/59c6fa6972851e8959000067/train/csharp