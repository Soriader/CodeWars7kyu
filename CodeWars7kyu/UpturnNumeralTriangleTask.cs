namespace CodeWars7kyu;

public class UpturnNumeralTriangleTask
{
    public static string UpturnNumeralTriangle(int n)
    {
        int number = 1;
        int iterator = n;
        int space = 1;
        string result = "";

        while (iterator != 0)
        {
            result += string.Concat(Enumerable.Repeat(" ", space)) 
                + string.Concat(Enumerable.Repeat(number + " ", iterator)).TrimEnd(' ')
                + "\n";
            iterator--;
            number++;
            space++;

            if (number == 10)
            {
                number = 0;
            }
            
            
        }

        return result.TrimEnd('\n');
    }
}
//https://www.codewars.com/kata/564f3d49a06556d27c000077/train/csharp