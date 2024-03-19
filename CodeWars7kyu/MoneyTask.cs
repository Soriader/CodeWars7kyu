using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MoneyTask
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;

            if(principal >= desiredPrincipal) 
            { 
                return years;
            }

            while (principal < desiredPrincipal)
            {
                double interestEarned = principal * interest;
                double taxToPay = interestEarned * tax;
                principal += interestEarned - taxToPay;
                years++;
            }

            return years;
        }
    }
}
//https://www.codewars.com/kata/563f037412e5ada593000114/train/csharp
