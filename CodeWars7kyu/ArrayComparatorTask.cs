namespace CodeWars7kyu;

public class ArrayComparatorTask
{
    public static int MatchArrays(int[] v, int[] r)
    {
        int result = 0;
        
        foreach (int element in v)
        {
            if (r.Contains(element))
            {
                result++;
            }
        }
        return result;
    }
}
//https://www.codewars.com/kata/561046a9f629a8aac000001d/train/csharp