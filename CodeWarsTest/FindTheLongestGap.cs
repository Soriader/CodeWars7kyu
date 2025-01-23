using CodeWars7kyu;

namespace CodeWarsTest;

public class FindTheLongestGap
{
    [Test]
    public static void FindTheLongestGapTest()
    {
        Assert.AreEqual(2, FindTheLongestGapTask.Gap(9));
        Assert.AreEqual(4, FindTheLongestGapTask.Gap(529));
        Assert.AreEqual(1, FindTheLongestGapTask.Gap(20));
        Assert.AreEqual(0, FindTheLongestGapTask.Gap(15));
    }
}