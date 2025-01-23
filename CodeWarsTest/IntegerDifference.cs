using CodeWars7kyu;

namespace CodeWarsTest;

public class IntegerDifference
{
    [Test]
    public void IntegerDifferenceTest()
    {
        Assert.AreEqual(3, IntegerDifferenceTask.IntDiff(new int[] { 1, 1, 5, 6, 9, 16, 27 }, 4));
        Assert.AreEqual(4, IntegerDifferenceTask.IntDiff(new int[] { 1, 1, 3, 3 }, 2));
    }
}