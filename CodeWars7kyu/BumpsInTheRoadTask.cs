using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class BumpsInTheRoadTask
    {
        public static string Bump(string input)
        {
            int iterator = 0;

            var checkTheRoad = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (checkTheRoad[i] == 'n')
                {
                    iterator++;
                }
            }

            if(iterator <= 15)
            {
                return "Woohoo!";
            }

            return "Car Dead";
        }
    }
}
//https://www.codewars.com/kata/57ed30dde7728215300005fa/train/csharp