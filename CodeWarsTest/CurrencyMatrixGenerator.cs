namespace CodeWarsTest;

using CodeWars7kyu;

public class CurrencyMatrixGenerator
{
    [Test]
    public void CurrencyMatrixGeneratorTest()
    {
        var expected = string.Join(",", new string[] { "EURGBP", "EURAUD", "EURNZD", "EURUSD", "EURCAD", "EURCHF", "EURJPY" });
        Assert.That(string.Join(",", CurrencyMatrixGeneratorTask.GenerateCurrencyMatrix("EUR")), Is.EqualTo(expected));
      
        expected = string.Join(",", new string[] { "EURGBP", "GBPAUD", "GBPNZD", "GBPUSD", "GBPCAD", "GBPCHF", "GBPJPY" });
        Assert.That(string.Join(",", CurrencyMatrixGeneratorTask.GenerateCurrencyMatrix("GBP")), Is.EqualTo(expected));
      
        expected = string.Join(",", new string[] { "EURCHF", "GBPCHF", "AUDCHF", "NZDCHF", "USDCHF", "CADCHF", "CHFJPY" });
        Assert.That(string.Join(",", CurrencyMatrixGeneratorTask.GenerateCurrencyMatrix("CHF")), Is.EqualTo(expected));      
    }
}