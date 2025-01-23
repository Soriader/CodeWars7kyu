using CodeWars7kyu;

namespace CodeWarsTest;

public class MaximumGap
{
    [Test]
    public void MaximumGapTest()
    {
        Assert.AreEqual(4, MaximumGapTask.MaxGap(new int[] { 13, 10, 2, 9, 5 }));
        Assert.AreEqual(8, MaximumGapTask.MaxGap(new int[] { 13, 3, 5 }));
        Assert.AreEqual(168, MaximumGapTask.MaxGap(new int[] { 24, 299, 131, 14, 26, 25 }));
        Assert.AreEqual(767, MaximumGapTask.MaxGap(new int[] { -7, -42, -809, -14, -12 }));
        Assert.AreEqual(0, MaximumGapTask.MaxGap(new int[] { 1, 1, 1 }));
        Assert.AreEqual(576, MaximumGapTask.MaxGap(new int[] { -54, 37, 0, 64, -15, 640, 0 }));

    }
}