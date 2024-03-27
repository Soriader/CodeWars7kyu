using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars7kyu
{
    public class RemoveAnchorFromURLTask
    {
        public static string RemoveUrlAnchor(string url)
        {
            string result = string.Empty;
            int index = url.IndexOf('#');

            if (index != -1)
            {
                result = url.Substring(0, index);
                return result;

            }

            return url;
        }
    }
}
//https://www.codewars.com/kata/51f2b4448cadf20ed0000386/train/csharp