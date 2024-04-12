using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TheCouponCodeTask
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            DateTime current = DateTime.Parse(currentDate);
            DateTime expiration = DateTime.Parse(expirationDate);

            bool correctCoupon = enteredCode == correctCode;
            bool notExpired = current <= expiration;

            return correctCoupon && notExpired;


        }
    }
}
//https://www.codewars.com/kata/539de388a540db7fec000642/train/csharp