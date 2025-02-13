namespace CodeWars7kyu;

public class BoxlinesTask
{
    public static ulong F(ushort x, ushort y, ushort z)
    {
        return x * (y + 1UL) * (z + 1UL) +
               y * (z + 1UL) * (x + 1UL) +
               z * (x + 1UL) * (y + 1UL);
    }
}
//https://www.codewars.com/kata/6129095b201d6b000e5a33f0/train/csharp