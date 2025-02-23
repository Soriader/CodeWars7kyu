namespace CodeWars7kyu;

public class SortTheBytesTask
{
    public static uint SortBytes(uint number)
    {
        byte[] bytes = BitConverter.GetBytes(number).Reverse().ToArray();

        Array.Sort(bytes);
        Array.Reverse(bytes);

        return BitConverter.ToUInt32(bytes.Reverse().ToArray(), 0);
    }
}
//https://www.codewars.com/kata/6076d4edc7bf5d0041b31dcf/train/csharp