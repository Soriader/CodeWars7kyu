using CodeWars7kyu;

namespace CodeWarsTest;

public class HighestAndLowest
{
    [Test]
    public void HighestAndLowestTest()
    {
        Assert.AreEqual("42 -9", HighestAndLowestTask.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        Assert.AreEqual("3 1", HighestAndLowestTask.HighAndLow("1 2 3"));

    }
}