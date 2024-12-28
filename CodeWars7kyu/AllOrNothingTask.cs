using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AllOrNothingTask
    {
        public static bool PossiblyPerfect(string[] key, string[] ans)
        {
            bool isCorrect = true;
            bool isNotCorrect = true;

            for (int i = 0; i < key.Length; i++) 
            {
                if (key[i] != ans[i] && key[i] != "_")
                {
                    isCorrect = false;
                }

                if(key[i] == ans[i] && key[i] != "_")
                {
                    isNotCorrect = false;
                }
            }

            if (isCorrect || isNotCorrect)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//https://www.codewars.com/kata/65112af7056ad6004b5672f8/train/csharp