namespace CodeWars7kyu;

public class HighestPowerOfTwoTask
{
    public static long Solution(long n)
    {
        int iterator = 0;
        var boxForDividing = n;

        while (boxForDividing > 0)
        {
            if (boxForDividing % 2 != 0)
            {
                break;
            }
            
            boxForDividing = boxForDividing / 2;
            iterator++; 
        }
        
        return (long)Math.Pow(2, iterator);
    }
}
//https://www.codewars.com/kata/58dabca7ce77a12dbd00000f/train/csharp