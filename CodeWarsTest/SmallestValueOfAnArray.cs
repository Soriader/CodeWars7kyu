using CodeWars7kyu;

namespace CodeWarsTest;

public class SmallestValueOfAnArray
{
    [Test]
    public void SmallestValueOfAnArrayTest()
    {
        Assert.AreEqual(1, SmallestValueOfAnArrayTask.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "value"));
        Assert.AreEqual(4, SmallestValueOfAnArrayTask.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "index"));
    }
}