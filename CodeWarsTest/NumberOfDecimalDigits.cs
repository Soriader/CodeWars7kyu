using CodeWars7kyu;

namespace CodeWarsTest;

public class NumberOfDecimalDigits
{
    [Test]
    public void NumberOfDecimalDigitsTest()
    {
        Assert.AreEqual(1, NumberOfDecimalDigitsTask.Digits(5ul));
        Assert.AreEqual(5, NumberOfDecimalDigitsTask.Digits(12345ul));
        Assert.AreEqual(10, NumberOfDecimalDigitsTask.Digits(9876543210ul));
    }
}