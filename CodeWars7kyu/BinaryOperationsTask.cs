namespace CodeWars7kyu;

public class BinaryOperationsTask
{
    public static int FlipBit(int value, int bitIndex)
    {
        int mask = 1 << (bitIndex - 1);

        return value ^ mask;
    }
}
//https://www.codewars.com/kata/560e80734267381a270000a2/train/csharp