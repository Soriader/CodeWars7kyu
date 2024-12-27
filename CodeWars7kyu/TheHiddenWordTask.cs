using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TheHiddenWordTask
    {
        private Dictionary<char, char> HiddenCode = new Dictionary<char, char>
{
    { '6', 'a' },
    { '1', 'b' },
    { '7', 'd' },
    { '4', 'e' },
    { '3', 'i' },
    { '2', 'l' },
    { '9', 'm' },
    { '8', 'n' },
    { '0', 'o' },
    { '5', 't' }
};
        public string Hidden(int num)
        {
            var check = num.ToString().ToCharArray();
            var result = "";

            foreach (char c in check)
            {
                if (HiddenCode.ContainsKey(c))
                {
                    result += HiddenCode[c];
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5906a218dfeb0dbb52000005/train/csharp