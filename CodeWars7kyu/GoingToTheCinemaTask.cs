using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWars7kyu
{
    public class GoingToTheCinemaTask
    {
        public static int Movie(int card, int ticket, double perc)
        {
            int result = 0;
            double totalB = card;
            double currentTicketPrice = ticket;

            while (Math.Ceiling(totalB) >= ticket * result)
            {
                result++;
                currentTicketPrice *= perc;
                totalB += currentTicketPrice;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/562f91ff6a8b77dfe900006e/train/csharp