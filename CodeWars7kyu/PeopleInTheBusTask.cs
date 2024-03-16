using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PeopleInTheBusTask
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int remainingPassengers = 0;

            foreach (int[] stop in peopleListInOut)
            {
                remainingPassengers += stop[0];
                remainingPassengers -= stop[1]; 


                if (remainingPassengers < 0)
                {
                    remainingPassengers = 0;
                }
            }

            return remainingPassengers;
        }
    }
}
//https://www.codewars.com/kata/5648b12ce68d9daa6b000099/train/csharp