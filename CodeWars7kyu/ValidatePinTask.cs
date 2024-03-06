using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ValidatePinTask
    {
        public static bool ValidatePin(string pin)
        {
            int numberOfPin;

            if (pin.Length == 4 || pin.Length == 6)
            {
                foreach (char c in pin)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }

                return int.TryParse(pin, out numberOfPin) && numberOfPin >= 0;

            }

            return false;
        }
    }
}
//https://www.codewars.com/kata/55f8a9c06c018a0d6e000132/train/csharp