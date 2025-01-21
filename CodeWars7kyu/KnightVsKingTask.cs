using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class KnightVsKingTask
    {
        public static string KnightVsKing(object[] knightPosition, object[] kingPosition)
        {
            var x = (int)knightPosition[0] - (int)kingPosition[0];
            var y = ((string)knightPosition[1])[0] - ((string)kingPosition[1])[0];
            var d = (x * x) + (y * y);

            if (d < 3)
            { 
                return "King"; 
            }
            else if (d == 5) 
            { 
                return "Knight"; 
            }
            return "None";
        }

    }
}
//https://www.codewars.com/kata/564e1d90c41a8423230000bc/train/csharp