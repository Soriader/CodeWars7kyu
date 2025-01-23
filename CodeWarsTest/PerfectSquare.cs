using CodeWars7kyu;

namespace CodeWarsTest;

public class PerfectSquare
{
    [Test]
    public static void PerfectSquareTest()
    {
        Assert.AreEqual(-1, PerfectSquareTask.FindNextSquare(155));
        Assert.AreEqual(144, PerfectSquareTask.FindNextSquare(121));
        Assert.AreEqual(676, PerfectSquareTask.FindNextSquare(625));
        Assert.AreEqual(320356, PerfectSquareTask.FindNextSquare(319225));
    }
}