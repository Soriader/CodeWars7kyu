namespace CodeWars7kyu;

public class ArrayOfTwinsTask
{
    public static bool Twins(int[] arr)
    {
        var boxForResult = new Dictionary<int, int>();

        foreach (var box in arr)
        {
            if (boxForResult.ContainsKey(box))
            {
                boxForResult[box]++;
            }
            else
            {
                boxForResult.Add(box, 1);
            }
        }

        if (boxForResult.Values.All(value => value == 2))
        {
            return true;
        }
        
        return false;
    }
}
//https://www.codewars.com/kata/58fdc60ed94f25a863000092/train/csharp