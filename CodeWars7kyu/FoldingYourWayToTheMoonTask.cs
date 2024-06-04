using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FoldingYourWayToTheMoonTask
    {
        public static int? FoldTo(double distance)
        {
            if (distance < 0) return null;
            int iterator = 0;
            double flexure = 0.0001;

            while (flexure != distance) 
            {
                if (flexure >= distance) break;
                iterator++;
                flexure *= 2;
            }

            return iterator;
        }
    }
}
//https://www.codewars.com/kata/58f0ba42e89aa6158400000e/train/csharp