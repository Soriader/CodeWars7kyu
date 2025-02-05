namespace CodeWars7kyu;

public class FastCookingPancakesTask
{
    public static int CookPancakes(int n, int m) 
    {
        if (n <= m)
        {
            return 2;
        }
        
        return (2 * n - 1) / m + 1;
        
    }
}
//https://www.codewars.com/kata/58552bdb68b034a1a80001fb/train/csharp