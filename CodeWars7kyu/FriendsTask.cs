using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FriendsTask
    {
        public static int Friends(int n)
        {
            if(n < 3)
            {
                return 0;
            }

            double iterator = 1;
            double value = 0;

            while (value < n) 
            {
                value = Math.Pow(2, iterator);

                if(value >= n)
                {
                    break;
                }

                iterator++;
            }

            return (int)iterator - 1;
        }
    }
}
//https://www.codewars.com/kata/5ad29cd95e8240dd85000b54/train/csharp