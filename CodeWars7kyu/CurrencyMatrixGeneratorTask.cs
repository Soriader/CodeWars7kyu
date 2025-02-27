namespace CodeWars7kyu;

public class CurrencyMatrixGeneratorTask
{
    public static string[] GenerateCurrencyMatrix(string currency)
    {
        Dictionary<string, int> currencyForex = new Dictionary<string, int>
        {
            { "EUR", 1 },
            { "GBP", 2 },
            { "AUD", 3 },
            { "NZD", 4 },
            { "USD", 5 },
            { "CAD", 6 },
            { "CHF", 7 },
            { "JPY", 8 }
        };

        var valueOfCurrency = currencyForex[currency];

        var result = new List<string>();
        
        foreach (var currencyPair in currencyForex)
        {
            if (currencyPair.Key == currency)
            {
                continue;
            }
            if (currencyPair.Value > valueOfCurrency) 
            {
                result.Add($"{currency}{currencyPair.Key}");
            }
            else
            {
                result.Add($"{currencyPair.Key}{currency}");
            }
        }
        
        return result.ToArray();
    }
}
//https://www.codewars.com/kata/57bec3bc5640aa5f3f00003e/train/csharp