namespace CodeWars7kyu;

public class PrintCountAndNumbersTask
{
    public static string CountMe(string data)
    {
        if (data.Any(ch => !char.IsDigit(ch)) || data == "")
        {
            return ""; 
        }
        string result = "";
        char boxForNumber = data[0];
        int iterator = 1;
        for (int i = 1; i < data.Length; i++)
        {
            if (boxForNumber == data[i])
            {
                iterator++;
            }
            else
            {
                result += $"{iterator}{boxForNumber}";
                boxForNumber = data[i];
                iterator = 1;
            }
        }

        result += $"{iterator}{boxForNumber}";

        return result;
    }
}
//https://www.codewars.com/kata/559af787b4b8eac78b000022/train/csharp