using CodeWars7kyu;

namespace CodeWarsTest;

public class NoOdditiesHere
{
    [Test]
    public void NoOdditiesHereTest()
    {
        Assert.AreEqual(new int[] { 2, 4 }, NoOdditiesHereTask.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
    }
}