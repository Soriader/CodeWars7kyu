using CodeWars7kyu;

namespace CodeWarsTest;

public class CountTheDivisorsOfANumber
{
    [Test]
    public void CountTheDivisorsOfANumberTest()
    {
        Assert.AreEqual(1, CountTheDivisorsOfANumberTask.Divisors(1));
        Assert.AreEqual(4, CountTheDivisorsOfANumberTask.Divisors(10));
        Assert.AreEqual(2, CountTheDivisorsOfANumberTask.Divisors(11));
        Assert.AreEqual(8, CountTheDivisorsOfANumberTask.Divisors(54));
    }
}