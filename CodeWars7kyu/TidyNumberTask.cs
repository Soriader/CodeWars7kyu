using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TidyNumberTask
    {
        public static bool TidyNumber(int n)
        {
            char[] check = n.ToString().ToCharArray();
            int result = 0;

            for (int i = 0; i < check.Length - 1; i++)
            {
                if (check[i] > check[i + 1])
                {
                    return false;
                }
            }

            return true;

        }
    }
}
//https://www.codewars.com/kata/5a87449ab1710171300000fd/train/csharp