namespace CodeWars7kyu;

public class RemoveTheNoiseFromTheStringTask
{
    public static string RemoveNoise(string equation)
    {
        var exceptions = "%$&/#·@|º\\ª";
        return new string(equation.Where(c => !exceptions.Contains(c) || c == ' ').ToArray());
    }
}
//https://www.codewars.com/kata/5681cf0be812b41721000034/train/csharp