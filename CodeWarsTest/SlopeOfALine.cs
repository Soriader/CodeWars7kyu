using CodeWars7kyu;

namespace CodeWarsTest;

public class SlopeOfALine
{
    [Test]
    public void SlopeOfALineTest()
    {
        Assert.AreEqual(1, SlopeOfALineTask.GetSlope(new Point(1, 1), new Point(2, 2)));
        Assert.AreEqual(-1, SlopeOfALineTask.GetSlope(new Point(11, 1), new Point(1, 11)));
        Assert.AreEqual(null, SlopeOfALineTask.GetSlope(new Point(1, 1), new Point(1, 1)));
    }
}