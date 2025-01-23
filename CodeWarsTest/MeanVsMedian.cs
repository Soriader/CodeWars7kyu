using CodeWars7kyu;

namespace CodeWarsTest;

public class MeanVsMedian
{
    [Test]
    public void MeanVsMedianTest()
    {
        Assert.AreEqual("median", MeanVsMedianTask.MeanVsMedian(new int[] { 7, 14, -70 }));
        Assert.AreEqual("mean", MeanVsMedianTask.MeanVsMedian(new int[] { 1, 2, 37 }));
        Assert.AreEqual("same", MeanVsMedianTask.MeanVsMedian(new int[] { 1, 1, 1 }));


    }
}