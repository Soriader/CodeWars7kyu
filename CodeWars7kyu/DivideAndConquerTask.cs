using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DivideAndConquerTask
    {
        public static int DivCon(Object[] objArray)
        {

            List<int> digitsList = new List<int>();
            List<int> stringsList = new List<int>();

            foreach (object obj in objArray)
            {
                if (obj is int)
                {
                    digitsList.Add((int)obj);
                }
                else if (obj is string && int.TryParse((string)obj, out int parsedInt))
                {
                    stringsList.Add(parsedInt);
                }
            }

            int sumOfDigits = digitsList.Sum();
            int sumOfStrings = stringsList.Sum();

            return sumOfDigits - sumOfStrings;
        }
    }
}
//https://www.codewars.com/kata/57eaec5608fed543d6000021/train/csharp