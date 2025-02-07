namespace CodeWars7kyu;

public class RoundingTask
{
    public static int Rounding(int n, int m)
    {
        if (n % m == 0)
        {
            return n;
        }

        int closeLess = (n / m) * m;
        int closeMore = closeLess + m;

        if (n - closeLess == closeMore - n)
        {
            return n; 
        }
    
        return (n - closeLess > closeMore - n) ? closeMore : closeLess;
    }
}
//https://www.codewars.com/kata/58bccdf56f25ff6b6d00002f/train/csharp