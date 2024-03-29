using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CheckTheExamTask
    {
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int score = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2[i] == "")
                {
                    continue;
                }

                if (arr1[i] == arr2[i])
                {
                    score += 4;
                }
                else
                {
                    score -= 1; 
                }

            }

            if(score < 0)
            {
                return 0;
            }

            return score;

        }
    }
}
//https://www.codewars.com/kata/5a3dd29055519e23ec000074/train/csharp