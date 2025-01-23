using CodeWars7kyu;

namespace CodeWarsTest;

public class LargestPairSumInArray
{
    [Test]
    public void LargestPairSumInArrayTest()
    {
        Assert.AreEqual(-16, LargestPairSumInArrayTask.LargestPairSum(new int[] { -8, -8, -16, -18, -19 }));
        Assert.AreEqual(0, LargestPairSumInArrayTask.LargestPairSum(new int[] { -100, -29, -24, -19, 19 }));
        Assert.AreEqual(10, LargestPairSumInArrayTask.LargestPairSum(new int[] { 1, 2, 3, 4, 6, -1, 2 }));
        Assert.AreEqual(42, LargestPairSumInArrayTask.LargestPairSum(new int[] { 10, 14, 2, 23, 19 }));
    }
}