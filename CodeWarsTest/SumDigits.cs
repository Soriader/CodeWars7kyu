using CodeWars7kyu;

namespace CodeWarsTest;

public class SumDigits
{
    [Test]
    public void SumDigitsTest()
    {
        Assert.AreEqual(1, SumDigitsTask.SumDigits(10));
        Assert.AreEqual(18, SumDigitsTask.SumDigits(99));
        Assert.AreEqual(5, SumDigitsTask.SumDigits(-32));

    }
}