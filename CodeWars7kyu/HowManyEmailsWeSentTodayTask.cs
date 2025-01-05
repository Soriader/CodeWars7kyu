using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class HowManyEmailsWeSentTodayTask
    {
        public static string CountEmails(int sent, int limit = 1000)
        {
            if(limit >= 0)
            {
                limit = 1000;
            }

            if(sent > limit)
            {
                return "Daily limit is reached";
            }

            if(sent == 0)
            {
                return "No e-mails sent";
            }

            int result = (sent * 100) / limit;


            return $"{result}%";

        }

    }
}
//https://www.codewars.com/kata/58a369fa5b3daf464200006c/train/csharp