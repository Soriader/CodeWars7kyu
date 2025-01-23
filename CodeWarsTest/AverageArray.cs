using CodeWars7kyu;

namespace CodeWarsTest;

public class AverageArray
{
    [Test]
    public void AverageArrayTest()
    {
        Assert.AreEqual(new double[] { 3, 4, 5, 6 }, AverageArrayTask.AvgArray(new double[][] { new double[] { 1, 2, 3, 4 }, new double[] { 5, 6, 7, 8 } }));
        Assert.AreEqual(new double[] { 22.5, 11, 38.75, 38.25, 19.5 }, AverageArrayTask.AvgArray(new double[][] { new double[] { 2, 3, 9, 10, 7 }, new double[] { 12, 6, 89, 45, 3 }, new double[] { 9, 12, 56, 10, 34 }, new double[] { 67, 23, 1, 88, 34 } }));
    }
}