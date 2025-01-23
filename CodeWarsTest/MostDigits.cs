using CodeWars7kyu;

namespace CodeWarsTest;

public class MostDigits
{
    [Test]
    public void MostDigitsTest()
    {
        Assert.AreEqual(100, MostDigitsTask.FindLongest(new int[] { 1, 10, 100 }));
        Assert.AreEqual(9000, MostDigitsTask.FindLongest(new int[] { 9000, 8, 800 }));
        Assert.AreEqual(900, MostDigitsTask.FindLongest(new int[] { 8, 900, 500 }));
    }
}