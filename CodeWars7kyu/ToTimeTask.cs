using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ToTimeTask
    {
        public static string ToTime(int seconds)
        {
            int hour = 0;
            int minute = 0;

            TimeSpan time = TimeSpan.FromSeconds(seconds);
            hour = (int)time.TotalHours;
            minute = (int)(time.TotalMinutes - hour*60);


            return $"{hour} hour(s) and {minute} minute(s)";
        }
    }
}
//https://www.codewars.com/kata/5865cff66b5699883f0001aa/train/csharp
