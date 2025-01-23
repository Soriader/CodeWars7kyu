using CodeWars7kyu;

namespace CodeWarsTest;

public class ConvertingIntegerToCurrencyFormat
{
    [Test]
    public static void ConvertingIntegerToCurrencyFormatTest()
    {
        Assert.AreEqual("5,678,545", ConvertingIntegerToCurrencyFormatTask.ToCurrency(5678545));
        Assert.AreEqual("100,000", ConvertingIntegerToCurrencyFormatTask.ToCurrency(100000));
    }
}