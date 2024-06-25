using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CatAndMouseTask
    {
        public static string CatMouse(string x)
        {
            var check = x.ToCharArray();
            int iterator = 0;

            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] == '.')
                {
                    iterator++;
                }
            }

            if(iterator > 3)
            {
                return "Escaped!";
            }

            return "Caught!";
        }
    }
}
//https://www.codewars.com/kata/57ee24e17b45eff6d6000164/train/csharp