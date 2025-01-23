using CodeWars7kyu;

namespace CodeWarsTest;

public class LCM
{
    [Test]
    public void LCMTest()
    {
        Assert.AreEqual(840, LCMTask.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 18 }, new int[] { 4, 5 }, new int[] { 12, 60 } }));
        Assert.AreEqual(1092, LCMTask.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 }, new int[] { 13, 91 } }));
        Assert.AreEqual(0, LCMTask.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 7 }, new int[] { 4, 5 }, new int[] { 19, 60 } }));
        Assert.AreEqual(1890, LCMTask.SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 20, 50 }, new int[] { 10, 10 }, new int[] { 50, 20 } }));
        Assert.AreEqual(0, LCMTask.SumDifferencesBetweenProductsAndLCMs(new int[][] { }));
    }
}