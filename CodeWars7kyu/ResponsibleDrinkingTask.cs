using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ResponsibleDrinkingTask
    {
        public string Hydrate(string drinkString)
        {
            var check = drinkString.ToCharArray();
            int howManyGlassOfWater = 0;

            for (int i = 0; i < check.Length; i++)
            {
                if (char.IsNumber(check[i]))
                {
                    howManyGlassOfWater += check[i] - '0';
                }
            }
            if (howManyGlassOfWater == 1) return "1 glass of water";

            return $"{howManyGlassOfWater} glasses of water";
        }
    }
}
//https://www.codewars.com/kata/5aee86c5783bb432cd000018/train/csharp