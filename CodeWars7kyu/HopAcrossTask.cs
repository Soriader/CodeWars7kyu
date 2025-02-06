namespace CodeWars7kyu;

public class HopAcrossTask
{
    public static int HopAcross(List<int> lst)
    {
        if (lst.Count == 1)
        {
            return 2;
        }

        var leftSide = lst.ToList(); 
        leftSide.Reverse();

        return HopHop(lst) + HopHop(leftSide);
    }

    private static int HopHop(List<int> river)
    {
        int jumps = 0;
        int position = 0;

        while (position < river.Count)
        {
            jumps++;
            position += river[position];
        }

        return jumps;
    }
}
//https://www.codewars.com/kata/5a60d519400f93fc450032e5/train/csharp