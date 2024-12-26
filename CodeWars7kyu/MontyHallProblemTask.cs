using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MontyHallProblemTask
    {
        public static int MontyHall(int correctDoor, int[] participants)
        {
            int result = participants.Count(x => x == correctDoor);

            return 100 - (int)Math.Round(100.0 * result / participants.Length);
        }
    }
}
//https://www.codewars.com/kata/54f9cba3c417224c63000872/train/csharp
