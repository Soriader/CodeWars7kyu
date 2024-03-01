using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public static class Kata
    {
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
