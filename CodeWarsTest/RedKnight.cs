using CodeWars7kyu;

namespace CodeWarsTest;

public class RedKnight
{
    [Test]
    public void RedKnightTests()
    {
        Assert.AreEqual(("White", 16), RedKnightTask.RedKnight(0, 8));
        Assert.AreEqual(("Black", 14), RedKnightTask.RedKnight(0, 7));
        Assert.AreEqual(("Black", 12), RedKnightTask.RedKnight(1, 6));
        Assert.AreEqual(("White", 10), RedKnightTask.RedKnight(1, 5));
    }
}