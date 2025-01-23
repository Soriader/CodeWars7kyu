using CodeWars7kyu;

namespace CodeWarsTest;

public class ClosestToZero
{
    [Test]
    public void ClosestToZeroTest()
    {
        Assert.AreEqual(1, ClosestToZeroTask.Closest(new int[] { 10, 3, 9, 1 }));
        Assert.AreEqual(-1, ClosestToZeroTask.Closest(new int[] { 2, 4, -1, -3 }));
        Assert.AreEqual(0, ClosestToZeroTask.Closest(new int[] { 13, 0, -6 }));
        Assert.AreEqual(null, ClosestToZeroTask.Closest(new int[] { 5, 1, -1, 2, -10 }));

    }
}