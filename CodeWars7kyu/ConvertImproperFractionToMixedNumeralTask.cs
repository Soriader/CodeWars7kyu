namespace CodeWars7kyu;

public class ConvertImproperFractionToMixedNumeralTask
{
    public string ConvertToMixedNumeral(string frac)
    {
        var numbers = frac.Split('/');
        var numerator = int.Parse(numbers[0]);
        var denominator = int.Parse(numbers[1]);
    
        if (Math.Abs(numerator) < denominator)
        {
            return frac; 
        }
    
        int wholeNumber = numerator / denominator;
        int remainder = numerator % denominator;
    
        if (remainder == 0)
        {
            return wholeNumber.ToString();
        }
    
        if (Math.Sign(remainder) != Math.Sign(wholeNumber) && wholeNumber != 0)
        {
            remainder = Math.Abs(remainder);
            if (wholeNumber > 0)
            {
                wholeNumber--;
                remainder = denominator - remainder;
            }
            else
            {
                wholeNumber++;
                remainder = denominator - remainder;
            }
        }
    
        return $"{wholeNumber} {Math.Abs(remainder)}/{denominator}";
    }
}
//https://www.codewars.com/kata/574e4175ff5b0a554a00000b/train/csharp