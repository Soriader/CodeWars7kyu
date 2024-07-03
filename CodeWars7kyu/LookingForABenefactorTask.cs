using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class LookingForABenefactorTask
    {
        public static long NewAvg(double[] arr, double navg)
        {
            double currentSum = arr.Sum();

            int n = arr.Length;

            double requiredDonation = navg * (n + 1) - currentSum;

            if (requiredDonation <= 0)
            {
                throw new ArgumentException("The required donation should be greater than zero.");
            }

            return (long)Math.Ceiling(requiredDonation);
        }
    }
}
