using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class RedKnightTask
    {
        public static (string color, long position) RedKnight(int knight, long pawn)
        {
            long knightFinalPosition = 2 * pawn;

            string color = (knight + pawn) % 2 == 0 ? "White" : "Black";

            return (color, knightFinalPosition);
        }
    }
}
//https://www.codewars.com/kata/5fc4349ddb878a0017838d0f/train/csharp