using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MaximumLengthDifferenceTask
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1 == null || a2 == null || a1.Length == 0 || a2.Length == 0)
            {
                return -1;
            }

            int maxA1 = int.MinValue;
            int minA1 = int.MaxValue;
            int maxA2 = int.MinValue;
            int minA2 = int.MaxValue;

            foreach (string str in a1)
            {
                int len = str.Length;
                if (len > maxA1) maxA1 = len;
                if (len < minA1) minA1 = len;
            }

            foreach (string str in a2)
            {
                int len = str.Length;
                if (len > maxA2) maxA2 = len;
                if (len < minA2) minA2 = len;
            }

            int diff1 = Math.Abs(maxA1 - minA2);
            int diff2 = Math.Abs(minA1 - maxA2);

            return Math.Max(diff1, diff2);

        }
    }
}
