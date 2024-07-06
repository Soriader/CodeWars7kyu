using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ByThreeOrNotTask
    {
        public static bool DivisibleByThree(string n)
        {
            var check = n.ToCharArray();
            int result = 0;

            foreach (char c in check)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }

            if(result % 3 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/59f7fc109f0e86d705000043/train/csharp