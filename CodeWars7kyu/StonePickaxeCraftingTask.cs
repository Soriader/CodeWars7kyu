using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class StonePickaxeCraftingTask
    {
        public static int StonePick(string[] arr)
        {
            int sticks = 0;
            int cobblestones = 0;

            foreach (var item in arr) 
            {
                if(item == "Sticks")
                {
                    sticks++;
                }

                if (item == "Cobblestone")
                {
                    cobblestones++;
                }

                if(item == "Wood")
                {
                    sticks += 4;
                }
            }

            return Math.Min(sticks / 2, cobblestones / 3);
        }

    }
}
//https://www.codewars.com/kata/65c0161a2380ae78052e5731/train/csharp