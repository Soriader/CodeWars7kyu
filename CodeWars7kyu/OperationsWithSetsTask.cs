using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class OperationsWithSetsTask
    {
        public static int[] Process2Arrays(int[] arr1, int[] arr2)
        {
            return new int[] { Both(arr1, arr2), OnlyOne(arr1, arr2), RemaningInArr1(arr1, arr2), RemaningInArr1(arr2, arr1) };
        }

        private static int Both(int[] arr1, int[] arr2)
        {
            int result = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++) 
                {
                    if (arr1[i] == arr2[j])
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private static int OnlyOne(int[] arr1, int[] arr2)
        {
            int result = 0;
            bool orginal = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        orginal = true;
                    }
                }

                if (!orginal)
                {
                    result++;
                }

                orginal = false;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        orginal = true;
                    }
                }

                if (!orginal)
                {
                    result++;
                }

                orginal = false;
            }

            return result;
        }

        private static int RemaningInArr1(int[] arr1, int[] arr2)
        {
            int result = 0;
            bool orginal = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        orginal = true;
                    }
                }

                if (!orginal)
                {
                    result++;
                }

                orginal = false;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5609fd5b44e602b2ff00003a/train/csharp