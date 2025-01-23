using CodeWars7kyu;

namespace CodeWarsTest;

public class IsSquare
{
    [Test]
    public static void IsSquareTest()
    {
        Assert.AreEqual(false, IsSquareTask.IsSquare(-1), "negative numbers aren't square numbers");
        Assert.AreEqual(false, IsSquareTask.IsSquare(3), "3 isn't a square number");
        Assert.AreEqual(true, IsSquareTask.IsSquare(4), "4 is a square number");
        Assert.AreEqual(true, IsSquareTask.IsSquare(25), "25 is a square number");
        Assert.AreEqual(false, IsSquareTask.IsSquare(26), "26 isn't a square number");
    }
}