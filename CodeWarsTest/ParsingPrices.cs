using CodeWars7kyu;

namespace CodeWarsTest;

public class ParsingPrices
{
    [Test]
    public void ParsingPricesTest()
    {
        Assert.AreEqual(null, ParsingPricesTask.ToCents(""));
        Assert.AreEqual(null, ParsingPricesTask.ToCents("1"));
        Assert.AreEqual(null, ParsingPricesTask.ToCents("1.23"));
        Assert.AreEqual(null, ParsingPricesTask.ToCents("$1"));
        Assert.AreEqual(123, ParsingPricesTask.ToCents("$1.23"));
        Assert.AreEqual(9999, ParsingPricesTask.ToCents("$99.99"));
        Assert.AreEqual(1234567890, ParsingPricesTask.ToCents("$12345678.90"));
        Assert.AreEqual(969, ParsingPricesTask.ToCents("$9.69"));
        Assert.AreEqual(970, ParsingPricesTask.ToCents("$9.70"));
        Assert.AreEqual(971, ParsingPricesTask.ToCents("$9.71"));
        Assert.AreEqual(69, ParsingPricesTask.ToCents("$0.69"));
        Assert.AreEqual(null, ParsingPricesTask.ToCents("$9.69$4.3.7"));
        Assert.AreEqual(null, ParsingPricesTask.ToCents("$9.692"));
    }
}