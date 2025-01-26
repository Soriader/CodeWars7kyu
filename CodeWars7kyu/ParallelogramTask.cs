
namespace CodeWars7kyu;

public class ParallelogramTask
{
    public static string Pattern(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Negative number");
        }
        
        var spaceLengthOnLeft = n - 1;
        int spaceLengthOnRight = 0;
        int iterator = 0;
        string row = "";
        int number = 1;
        string result = "";
        
        while (iterator < n)
        {
            row += number.ToString();
            iterator++;
            number++;

            if (number == 10 && iterator != n)
            {
                number = 0;
                row += number.ToString();
                iterator++;
                number++;
            }
        }

        iterator = 0;

        while (iterator < n)
        {
            result += string.Concat(Enumerable.Repeat(" ", spaceLengthOnLeft)) 
                      + row 
                      + string.Concat(Enumerable.Repeat(" ", spaceLengthOnRight)) 
                      + "\n";
            spaceLengthOnLeft--;
            spaceLengthOnRight++;
            iterator++;
        }
        
        return result.TrimEnd('\n');
    }
}
//https://www.codewars.com/kata/5581a7651185fe13190000ee/train/csharp