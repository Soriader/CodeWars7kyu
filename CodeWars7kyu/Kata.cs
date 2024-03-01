using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public static class Kata
    {
        public static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            return string.Join(" ", words);

            //https://www.codewars.com/kata/5259b20d6021e9e14c0010d4/train/csharp
        }
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
        public static string MakeComplement(string dna)
        {
            char[] newDna = dna.ToCharArray();

            for (int i = 0; i < newDna.Length; i++)
            {
                switch (newDna[i])
                {
                    case 'A':
                        {
                            newDna[i] = 'T';
                            break;
                        }
                    case 'T':
                        {
                            newDna[i] = 'A';
                            break;
                        }
                    case 'G':
                        {
                            newDna[i] = 'C';
                            break;
                        }
                    case 'C':
                        {
                            newDna[i] = 'G';
                            break;
                        }
                }
            }

            string complement = new string(newDna);
            return complement;


            //https://www.codewars.com/kata/554e4a2f232cdd87d9000038/train/csharp
        }
    }
}
