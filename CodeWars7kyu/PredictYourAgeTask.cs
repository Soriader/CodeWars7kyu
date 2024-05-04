using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PredictYourAgeTask
    {
        public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
        {
            List<int> list = new List<int> { age1, age2, age3, age4, age5, age6, age7,  age8 };

            for (int i = 0; i < 8; i++)
            {
                list[i] = list[i] * list[i];
            }

            int result = list.Aggregate((x, y) => x + y);

            double nextStep = Math.Sqrt(result);

            return (int)(nextStep / 2);
        }

    }
}
//https://www.codewars.com/kata/5aff237c578a14752d0035ae/train/csharp