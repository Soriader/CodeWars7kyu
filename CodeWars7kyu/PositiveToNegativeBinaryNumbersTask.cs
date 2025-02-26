namespace CodeWars7kyu;

public class PositiveToNegativeBinaryNumbersTask
{
    public static int[] Positive2Negative(int[] binaryArray)
    {
        var invertedArray = new int[binaryArray.Length];
        
        for (int i = 0; i < binaryArray.Length; i++)
        {
            invertedArray[i] = binaryArray[i] == 0 ? 1 : 0;
        }

        int carry = 1;
        var resultArray = new int[binaryArray.Length];
        for (int i = binaryArray.Length - 1; i >= 0; i--)
        {
            int sum = invertedArray[i] + carry;
            if (sum == 2)
            {
                resultArray[i] = 0;
                carry = 1;
            }
            else
            {
                resultArray[i] = sum;
                carry = 0;
            }
        }

        return resultArray;
    }
}
//https://www.codewars.com/kata/5becace7063291bebf0001d5/train/csharp