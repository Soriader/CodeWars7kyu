using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class UnluckyDaysTask
    {
        public static int UnluckyDays(int year)
        {
            int count = 0;

            for (int month = 1; month <= 12; month++)
            {
                DateTime date = new DateTime(year, month, 13);

                if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
