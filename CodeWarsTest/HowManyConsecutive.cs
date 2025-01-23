using CodeWars7kyu;

namespace CodeWarsTest;

public class HowManyConsecutive
{
    [Test]
    public void HowManyConsecutiveTest()
    {
        Assert.AreEqual(2, HowManyConsecutiveTask.Consecutive(new int[] { 4, 8, 6 }));
        Assert.AreEqual(0, HowManyConsecutiveTask.Consecutive(new int[] { 1, 2, 3, 4 }));
        Assert.AreEqual(0, HowManyConsecutiveTask.Consecutive(new int[] { }));
        Assert.AreEqual(0, HowManyConsecutiveTask.Consecutive(new int[] { 1 }));
    }
}