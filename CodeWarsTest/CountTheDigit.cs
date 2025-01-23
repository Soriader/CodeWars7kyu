using CodeWars7kyu;

namespace CodeWarsTest;

public class CountTheDigit
{
    [Test]
    public static void CountTheDigitTest()
    {
        Assert.AreEqual(4700, CountTheDigitTask.NbDig(5750, 0));
        Assert.AreEqual(9481, CountTheDigitTask.NbDig(11011, 2));
        Assert.AreEqual(7733, CountTheDigitTask.NbDig(12224, 8));
    }
}