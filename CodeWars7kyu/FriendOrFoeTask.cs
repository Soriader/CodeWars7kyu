using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FriendOrFoeTask
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friendsList = new List<string>();

            foreach (string name in names)
            {
                if (name.Length <= 4)
                {

                    friendsList.Add(name);
                }
            }

            return friendsList.ToArray();
            //https://www.codewars.com/kata/55b42574ff091733d900002f/train/csharp
        }
    }
}
