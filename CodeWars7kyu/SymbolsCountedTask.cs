namespace CodeWars7kyu;

public class SymbolsCountedTask
{
    public static string Transform(string s)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (var x in s)
        {
            if (counts.ContainsKey(x))
            {
                counts[x]++;
            }
            else
            {
                counts.Add(x, 1);
            }
        }
        
        string result = "";
        string isUsed = "";

        foreach (var x in s)
        {
            if (counts[x] >= 2 && !isUsed.Contains(x))
            {
                result += $"{x}{counts[x]}";
                isUsed += x;
            }
            else if (!isUsed.Contains(x))
            {
                result += x;
                isUsed += x;
            }
        }
        
        return result;
    }
}
//https://www.codewars.com/kata/59ddeeb2fc3c49186f00009c/train/csharp